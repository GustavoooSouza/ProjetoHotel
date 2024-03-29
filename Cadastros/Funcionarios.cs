using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel.Cadastros
{
    public partial class formularioFuncionarios : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;
        //VARIAVEL PARA SALVAR O CPF NA HORA DE EDITAR E PODER REALIZAR A VERIFICAO SEM ERROS
        string cpfAntigo;

        public formularioFuncionarios()
        {
            InitializeComponent();
        }

        private void formatarDg()
        {
            //Mudar nome das tabelas no grid
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Endereço";
            grid.Columns[4].HeaderText = "Telefone";
            grid.Columns[5].HeaderText = "Cargo";
            grid.Columns[6].HeaderText = "DATA";

            //DEIXAR COLUNA SEM APARECER NO GRID
            grid.Columns[0].Visible = false;
        }

        //METODO PARA LISTAR NA GRID OS DADOS
        private void Listar()
        {
            con.abrirCon();
            sql = "SELECT * FROM funcionarios ORDER BY nome ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.fecharCon();

            formatarDg();
        }

        private void buscarNome()
        {
            con.abrirCon();
            sql = "SELECT * FROM funcionarios WHERE nome LIKE @nome ORDER BY nome ASC";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtBuscarNome.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.fecharCon();

            formatarDg();
        }

        private void buscarCpf()
        {
            con.abrirCon();
            sql = "SELECT * FROM funcionarios WHERE cpf = @cpf ORDER BY cpf ASC";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("cpf", txtBuscarCpf.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.fecharCon();

            formatarDg();
        }

        private void carregarComboBox()
        {
            con.abrirCon();
            sql = "SELECT * FROM cargos ORDER BY cargo ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbCargo.DataSource = dt;
            //CODIGO PARA MOSTRAR OS CARGOS DENTRO DA COMBOBOX
            cbCargo.DisplayMember = "cargo";
            con.fecharCon();
        }

        private void habilitarCampos() 
        { 
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            cbCargo.Enabled = true;
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            cbCargo.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void formularioFuncionarios_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true;
            carregarComboBox();
            Listar();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = true;
            txtBuscarCpf.Visible = false;

            txtBuscarNome.Text = "";
            txtBuscarCpf.Text = "";
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = false;
            txtBuscarCpf.Visible = true;

            txtBuscarNome.Text = "";
            txtBuscarCpf.Text = "";
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            if(cbCargo.Text == "")
            {
                MessageBox.Show("Cadestre antes um cargo!");
                Close();
            }

            habilitarCampos();
            botaoSalvar.Enabled = true;
            botaoNovo.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "") 
            {
                MessageBox.Show("Preencha o campo Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtCpf.Text.ToString().Trim() == "   .   .   -")
            {
                MessageBox.Show("Preencha o campo CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Text = "";
                txtCpf.Focus();
                return;
            }

            //CODIGO BOTAO SALVAR
            con.abrirCon();
            sql = "INSERT INTO funcionarios (nome, cpf, endereco, telefone, cargo, data) VALUES (@nome, @cpf, @endereco, @telefone, @cargo, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);

            //VERIFICAR SE CPF EXISTE
            MySqlCommand cmdVerificar;
            string sqlVerificar;
            sqlVerificar = "SELECT * FROM funcionarios WHERE cpf = @cpf";
            cmdVerificar = new MySqlCommand(sqlVerificar, con.con);
            cmdVerificar.Parameters.AddWithValue("@cpf", txtCpf.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Este CPF já existe!", "CPF já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Text = "";
                txtCpf.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            con.fecharCon();


            MessageBox.Show("Novo funcionario cadastrado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtCpf.Text.ToString().Trim() == "   .   .   -")
            {
                MessageBox.Show("Preencha o campo CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Text = "";
                txtCpf.Focus();
                return;
            }

            //CODIGO BOTAO EDITAR
            con.abrirCon();
            sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, endereco = @endereco, telefone = @telefone, cargo = @cargo WHERE id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@id", id);

            //VERIFICAR SE CPF EXISTE
            if (txtCpf.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                string sqlVerificar;
                sqlVerificar = "SELECT * FROM funcionarios WHERE cpf = @cpf";
                cmdVerificar = new MySqlCommand(sqlVerificar, con.con);
                cmdVerificar.Parameters.AddWithValue("@cpf", txtCpf.Text);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Este CPF já existe!", "CPF já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCpf.Text = "";
                    txtCpf.Focus();
                    return;
                }
            }           

            cmd.ExecuteNonQuery();
            con.fecharCon();

            MessageBox.Show("Registro editado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?!", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CODIGO BOTAO EXCLUIR
                con.abrirCon();
                sql = "DELETE FROM funcionarios WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.fecharCon();

                MessageBox.Show("Registro excluido com sucesso!", "Dados Excluidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoNovo.Enabled = true;
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;
                limparCampos();
                desabilitarCampos();
                Listar();
            }
            else
            {

            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;
            botaoNovo.Enabled = false;
            botaoSalvar.Enabled = false;
            //PRECISA HABILITAR OS CAMPOS PARA EDIÇÂO
            habilitarCampos();

            //CODIGO PARA PEGAR O ID DA CELULA QUE DESEJAMOS EDITAR
            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtCpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[4].Value.ToString();
            cbCargo.Text = grid.CurrentRow.Cells[5].Value.ToString();

            //CODIGO PARA PASSAR OS DADOS ARMAZENADOS PARA A VARIAVEL cpfAntigo
            cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            buscarNome();
        }

        private void txtBuscarCpf_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarNome.Text == "   .   .   -")
            {
                Listar();
            } else {
                buscarCpf();
            }
        }
    }
}
