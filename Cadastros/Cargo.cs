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
    public partial class formularioCargo : Form
    {
        public formularioCargo()
        {
            InitializeComponent();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            botaoSalvar.Enabled = true;
            botaoNovo.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
            txtNome.Focus();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Cargo!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            MessageBox.Show("Cargo salvo com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoSalvar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
        }

        private void grid_Click(object sender, EventArgs e)
        {
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;
            botaoNovo.Enabled = false;
            botaoSalvar.Enabled = false;
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Cargo!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            //CODIGO BOTAO EDITAR

            MessageBox.Show("Registro editado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
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
            } 
            else
            {

            }
        }
    }
}
