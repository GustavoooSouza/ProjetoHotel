namespace ProjetoHotel.Cadastros
{
    partial class formularioFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.txtBuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar :";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(435, 26);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarNome.TabIndex = 50;
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(81, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nome :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "CPF :";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(240, 93);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(435, 93);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Endereço :";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(81, 137);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Telefone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Cargo :";
            // 
            // cbCargo
            // 
            this.cbCargo.Enabled = false;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(240, 135);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(100, 21);
            this.cbCargo.TabIndex = 60;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.Location = new System.Drawing.Point(35, 198);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(500, 150);
            this.grid.TabIndex = 61;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // txtBuscarCpf
            // 
            this.txtBuscarCpf.Location = new System.Drawing.Point(435, 52);
            this.txtBuscarCpf.Mask = "000,000,000-00";
            this.txtBuscarCpf.Name = "txtBuscarCpf";
            this.txtBuscarCpf.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCpf.TabIndex = 62;
            this.txtBuscarCpf.Visible = false;
            this.txtBuscarCpf.TextChanged += new System.EventHandler(this.txtBuscarCpf_TextChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(319, 27);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 63;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Location = new System.Drawing.Point(373, 27);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(45, 17);
            this.rbCpf.TabIndex = 64;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = true;
            this.rbCpf.CheckedChanged += new System.EventHandler(this.rbCpf_CheckedChanged);
            // 
            // botaoNovo
            // 
            this.botaoNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoNovo.FlatAppearance.BorderSize = 0;
            this.botaoNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoNovo.Image = ((System.Drawing.Image)(resources.GetObject("botaoNovo.Image")));
            this.botaoNovo.Location = new System.Drawing.Point(81, 363);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(65, 65);
            this.botaoNovo.TabIndex = 65;
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSalvar.Enabled = false;
            this.botaoSalvar.FlatAppearance.BorderSize = 0;
            this.botaoSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.Location = new System.Drawing.Point(194, 363);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(65, 65);
            this.botaoSalvar.TabIndex = 66;
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditar.Enabled = false;
            this.botaoEditar.FlatAppearance.BorderSize = 0;
            this.botaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditar.Image = ((System.Drawing.Image)(resources.GetObject("botaoEditar.Image")));
            this.botaoEditar.Location = new System.Drawing.Point(307, 363);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(65, 65);
            this.botaoEditar.TabIndex = 67;
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoExcluir.Enabled = false;
            this.botaoExcluir.FlatAppearance.BorderSize = 0;
            this.botaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoExcluir.Image = ((System.Drawing.Image)(resources.GetObject("botaoExcluir.Image")));
            this.botaoExcluir.Location = new System.Drawing.Point(417, 363);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(65, 65);
            this.botaoExcluir.TabIndex = 68;
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // formularioFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.rbCpf);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.txtBuscarCpf);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formularioFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Funcionarios";
            this.Load += new System.EventHandler(this.formularioFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.MaskedTextBox txtBuscarCpf;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button botaoExcluir;
    }
}