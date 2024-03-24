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
        public formularioProdutos()
        {
            InitializeComponent();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtEstoque.Enabled = true;
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

            if (txtValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            //CODIGO BOTAO SALVAR

            MessageBox.Show("Novo produto cadastrado com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            botaoNovo.Enabled = true;
            botaoSalvar.Enabled = false;
            limparCampos();
            LimparFoto();
            desabilitarCampos();
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
    }
}
