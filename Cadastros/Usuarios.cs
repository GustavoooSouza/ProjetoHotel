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
    public partial class formularioUsuarios : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        //METODO PARA MUDAR NOMES A SEREM EXIBIDOS DENTRO DA GRID
        private void formatarDg()
        {
            //Mudar nome das tabelas no grid
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Cargo";
            grid.Columns[3].HeaderText = "Usuario";
            grid.Columns[4].HeaderText = "Senha";
            grid.Columns[5].HeaderText = "DATA";

            //DEIXAR COLUNA SEM APARECER NO GRID
            grid.Columns[0].Visible = false;
        }

        //METODO PARA LISTAR NA GRID OS DADOS
        private void Listar()
        {
            con.abrirCon();
            sql = "SELECT * FROM usuarios ORDER BY nome ASC";
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
            sql = "SELECT * FROM usuarios WHERE nome LIKE @nome ORDER BY nome ASC";
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
            cbCargo.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            cbCargo.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        public formularioUsuarios()
        {
            InitializeComponent();
        }

        private void formularioUsuarios_Load(object sender, EventArgs e)
        {
            carregarComboBox();
            Listar();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            if (cbCargo.Text == "")
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

            //CODIGO BOTAO SALVAR
            con.abrirCon();
            sql = "INSERT INTO usuarios (nome, usuario, senha, cargo, data) VALUES (@nome, @usuario, @senha, @cargo, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);

            //VERIFICAR SE USUARIO EXISTE
            con.abrirCon();
            sql = "SELECT * FROM usuarios WHERE usuario = @usuario";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.fecharCon();

            cmd.ExecuteNonQuery();
            con.fecharCon();


            MessageBox.Show("Novo usuario cadastrado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }
    }
}
