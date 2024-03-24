namespace ProjetoHotel.Produtos
{
    partial class formularioProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioProdutos));
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.botaoImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoExcluir.Enabled = false;
            this.botaoExcluir.FlatAppearance.BorderSize = 0;
            this.botaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoExcluir.Image = ((System.Drawing.Image)(resources.GetObject("botaoExcluir.Image")));
            this.botaoExcluir.Location = new System.Drawing.Point(475, 362);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(65, 65);
            this.botaoExcluir.TabIndex = 88;
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditar.Enabled = false;
            this.botaoEditar.FlatAppearance.BorderSize = 0;
            this.botaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditar.Image = ((System.Drawing.Image)(resources.GetObject("botaoEditar.Image")));
            this.botaoEditar.Location = new System.Drawing.Point(365, 362);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(65, 65);
            this.botaoEditar.TabIndex = 87;
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSalvar.Enabled = false;
            this.botaoSalvar.FlatAppearance.BorderSize = 0;
            this.botaoSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.Location = new System.Drawing.Point(252, 362);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(65, 65);
            this.botaoSalvar.TabIndex = 86;
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoNovo
            // 
            this.botaoNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoNovo.FlatAppearance.BorderSize = 0;
            this.botaoNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoNovo.Image = ((System.Drawing.Image)(resources.GetObject("botaoNovo.Image")));
            this.botaoNovo.Location = new System.Drawing.Point(139, 362);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(65, 65);
            this.botaoNovo.TabIndex = 85;
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.Location = new System.Drawing.Point(36, 190);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(636, 150);
            this.grid.TabIndex = 81;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Enabled = false;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(265, 129);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(100, 21);
            this.cbFornecedor.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Fornecedor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Estoque :";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(436, 129);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Valor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Descrição :";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(82, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nome :";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(436, 30);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarNome.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Buscar :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(265, 85);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(271, 20);
            this.txtDescricao.TabIndex = 89;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(82, 129);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtEstoque.TabIndex = 90;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(552, 30);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(120, 120);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 91;
            this.img.TabStop = false;
            // 
            // botaoImagen
            // 
            this.botaoImagen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botaoImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoImagen.Enabled = false;
            this.botaoImagen.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.botaoImagen.FlatAppearance.BorderSize = 0;
            this.botaoImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoImagen.Location = new System.Drawing.Point(576, 156);
            this.botaoImagen.Name = "botaoImagen";
            this.botaoImagen.Size = new System.Drawing.Size(75, 23);
            this.botaoImagen.TabIndex = 92;
            this.botaoImagen.Text = "Carregar";
            this.botaoImagen.UseVisualStyleBackColor = false;
            this.botaoImagen.Click += new System.EventHandler(this.botaoImagen_Click);
            // 
            // formularioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.botaoImagen);
            this.Controls.Add(this.img);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formularioProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Produtos";
            this.Load += new System.EventHandler(this.formularioProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button botaoImagen;
    }
}