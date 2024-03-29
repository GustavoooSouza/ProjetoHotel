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
    public partial class formularioMenu : Form
    {
        public formularioMenu()
        {
            InitializeComponent();
        }

        private void formularioMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formularioMenu_Load(object sender, EventArgs e)
        {
            painelTopo.BackColor = Color.FromArgb(230, 230, 230);
            painelRight.BackColor = Color.FromArgb(170, 170, 170);

            labelUsuario.Text = Program.nomeUsuario;
            labelCargo.Text = Program.cargoUsuario;

        }

        private void funToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.formularioFuncionarios formulario = new Cadastros.formularioFuncionarios();
            formulario.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.formularioCargo formularioCargo = new Cadastros.formularioCargo();
            formularioCargo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos.formularioProdutos formularioProdutos = new Produtos.formularioProdutos();
            formularioProdutos.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.formularioProdutos formularioProdutos = new Produtos.formularioProdutos();
            formularioProdutos.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.formularioUsuarios formularioUsuarios = new Cadastros.formularioUsuarios();
            formularioUsuarios.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.formularioFornecedores formularioFornecedores = new Cadastros.formularioFornecedores();
            formularioFornecedores.Show();
        }
    }
}
