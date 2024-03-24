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

            formularioMenu menu = new formularioMenu();
            this.Hide();
            menu.Show();
        }

        private void formularioLogin_Resize(object sender, EventArgs e)
        {
            painelLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
