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
    public partial class formularioFornecedores : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public formularioFornecedores()
        {
            InitializeComponent();
        }

        private void formatarDg()
        {
            //Mudar nome das tabelas no grid
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Telefone";
            grid.Columns[3].HeaderText = "Endereço";

            //DEIXAR COLUNA SEM APARECER NO GRID
            grid.Columns[0].Visible = false;
        }

        //METODO PARA LISTAR NA GRID OS DADOS
        private void Listar()
        {
            con.abrirCon();
            sql = "SELECT * FROM fornecedores ORDER BY nome ASC";
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
            sql = "SELECT * FROM fornecedores WHERE nome LIKE @nome ORDER BY nome ASC";
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

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtEndereco.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void formularioFornecedores_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            botaoSalvar.Enabled = true;
            botaoNovo.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            //TRIM = COMANDO PARA CONTAR ESPACOS COMO VAZIO
            if(txtNome.Text.ToString().Trim() == "") 
            {
                MessageBox.Show("Preencha o campo Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            con.abrirCon();
            sql = "INSERT INTO fornecedores (nome, telefone, endereco) VALUES (@nome, @telefone, @endereco)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);


            cmd.ExecuteNonQuery();
            con.fecharCon();

            MessageBox.Show("Novo fornecedor cadastrado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
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
            txtTelefone.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = grid.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            buscarNome();
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.ToString().Trim() == "") 
            {
                MessageBox.Show("Preencha o campo Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            con.abrirCon();
            sql = "UPDATE fornecedores SET nome = @nome, telefone = @telefone, endereco = @endereco WHERE id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@id", id);

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
                sql = "DELETE FROM fornecedores WHERE id = @id";
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
    }
}
