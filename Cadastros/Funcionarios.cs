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
        public formularioFuncionarios()
        {
            InitializeComponent();
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

            MessageBox.Show("Novo funcionario cadastrado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
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

            MessageBox.Show("Registro editado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
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
