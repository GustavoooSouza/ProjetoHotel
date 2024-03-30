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

namespace ProjetoHotel.Produtos
{
    public partial class formularioProdutos : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public formularioProdutos()
        {
            InitializeComponent();
        }

        private void formatarDg()
        {
            //Mudar nome das tabelas no grid
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Descrição";
            grid.Columns[3].HeaderText = "Estoque";
            grid.Columns[4].HeaderText = "Fornecedor";
            grid.Columns[5].HeaderText = "Valor Venda";
            grid.Columns[6].HeaderText = "Valor Compra";
            grid.Columns[7].HeaderText = "DATA";
            grid.Columns[8].HeaderText = "Imagem";
            grid.Columns[9].HeaderText = "ID Fornecedor";

            //DEIXAR COLUNA SEM APARECER NO GRID
            grid.Columns[0].Visible = false;
            grid.Columns[8].Visible = false;
            grid.Columns[9].Visible = false;
        }

        //METODO PARA LISTAR NA GRID OS DADOS
        private void Listar()
        {
            con.abrirCon();
            sql = "SELECT p.id, p.nome, p.descricao, p.estoque, f.nome, p.valorVenda, p.valorCompra, p.data, p.imagem, p.fornecedor FROM produtos as p INNER JOIN fornecedores as f ON p.fornecedor = f.id ORDER BY p.nome ASC";
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
            sql = "SELECT * FROM produtos WHERE nome LIKE @nome ORDER BY nome ASC";
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

        private void carregarComboBox()
        {
            con.abrirCon();
            sql = "SELECT * FROM fornecedores ORDER BY nome ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbFornecedor.DataSource = dt;
            cbFornecedor.ValueMember = "id";
            //CODIGO PARA MOSTRAR OS CARGOS DENTRO DA COMBOBOX
            cbFornecedor.DisplayMember = "nome";
            con.fecharCon();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            //txtEstoque.Enabled = true;
            cbFornecedor.Enabled = true;
            txtValor.Enabled = true;
            botaoImagen.Enabled = true;
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtEstoque.Enabled = false;
            cbFornecedor.Enabled = false;
            txtValor.Enabled = false;
            botaoImagen.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtEstoque.Text = "";
            txtValor.Text = "";
            LimparFoto();
        }

        private void LimparFoto()
        {
            img.Image = Properties.Resources.sem_foto;
        }

        private void formularioProdutos_Load(object sender, EventArgs e)
        {
            LimparFoto();
            carregarComboBox();
            Listar();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            if (cbFornecedor.Text == "")
            {
                MessageBox.Show("Cadestre antes um fornecedor!");
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

            if (txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            //CODIGO BOTAO SALVAR
            con.abrirCon();
            sql = "INSERT INTO produtos (nome, descricao, fornecedor, valorVenda, data) VALUES (@nome, @descricao, @fornecedor, @valorVenda, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@fornecedor", cbFornecedor.SelectedValue);
            cmd.Parameters.AddWithValue("@valorVenda", txtValor.Text);
            
            cmd.ExecuteNonQuery();
            con.fecharCon();

            MessageBox.Show("Novo produto cadastrado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoSalvar.Enabled = false;
            limparCampos();
            LimparFoto();
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

            if (txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            //CODIGO BOTAO EDITAR

            MessageBox.Show("Registro editado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
            limparCampos();
            LimparFoto();
            desabilitarCampos();
            Listar();
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?!", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CODIGO BOTAO EXCLUIR

                MessageBox.Show("Registro excluido com sucesso!", "Dados Excluidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoNovo.Enabled = true;
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;

                Listar();
            }
            else
            {

            }
        }

        private void botaoImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Arquivos de Imagens (*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                img.ImageLocation = foto;
            }
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            buscarNome();
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
            txtDescricao.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtValor.Text = grid.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
