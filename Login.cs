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

namespace ProjetoHotel
{
    public partial class formularioLogin : Form
    {
        Conexao con = new Conexao();

        public formularioLogin()
        {
            InitializeComponent();
            painelLogin.Visible = false;
        }

        private void formularioLogin_Load(object sender, EventArgs e)
        {
            painelLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
            painelLogin.Visible = true;
            botaoLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);
            botaoLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            chamarLogin();
        }

        private void formularioLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                chamarLogin();
            }
        }

        private void chamarLogin ()
        {
            if (txtUsuario.Text.ToString().Trim() == "" && txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha os campos para realizar LOGIN!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                return;
            }

            if (txtUsuario.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo de LOGIN!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }

            if (txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo da SENHA!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }

            //AQUI VAI O CODIGO PARA O LOGIN!
            //VERIFICAR SE USUARIO JÁ EXISTE
            con.abrirCon();
            MySqlCommand cmdVerificar;
            MySqlDataReader reader;
            string sqlVerificar;
            sqlVerificar = "SELECT * FROM usuarios WHERE usuario = @usuario and senha = @senha";
            cmdVerificar = new MySqlCommand(sqlVerificar, con.con);
            cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmdVerificar.Parameters.AddWithValue("@senha", txtSenha.Text);
            //CODIGO PARA PASSAR OS DADOS DA CONSULTA A CIMA PARA O READER
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                //EXTRAINDO INFORMACOES DO READER
                while (reader.Read())
                {
                    Program.nomeUsuario = Convert.ToString(reader["nome"]);
                    Program.cargoUsuario = Convert.ToString(reader["cargo"]);
                }
                MessageBox.Show("Bem-vindo!!!" + Program.nomeUsuario, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formularioMenu menu = new formularioMenu();
                this.Hide();
                menu.Show();
            } else {
                MessageBox.Show("Usuario ou Senha incorretos!!!", "Erro ao fazer Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                txtSenha.Text = "";
            }
            con.fecharCon();
        }

        private void formularioLogin_Resize(object sender, EventArgs e)
        {
            painelLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
