namespace ProjetoHotel.Cadastros
{
    partial class formularioUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioUsuarios));
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
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
            this.botaoExcluir.Location = new System.Drawing.Point(417, 296);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(65, 65);
            this.botaoExcluir.TabIndex = 88;
            this.botaoExcluir.UseVisualStyleBackColor = true;
            // 
            // botaoEditar
            // 
            this.botaoEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditar.Enabled = false;
            this.botaoEditar.FlatAppearance.BorderSize = 0;
            this.botaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditar.Image = ((System.Drawing.Image)(resources.GetObject("botaoEditar.Image")));
            this.botaoEditar.Location = new System.Drawing.Point(307, 296);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(65, 65);
            this.botaoEditar.TabIndex = 87;
            this.botaoEditar.UseVisualStyleBackColor = true;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSalvar.Enabled = false;
            this.botaoSalvar.FlatAppearance.BorderSize = 0;
            this.botaoSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.Location = new System.Drawing.Point(194, 296);
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
            this.botaoNovo.Location = new System.Drawing.Point(81, 296);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(65, 65);
            this.botaoNovo.TabIndex = 85;
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.Location = new System.Drawing.Point(35, 131);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(500, 150);
            this.grid.TabIndex = 81;
            // 
            // cbCargo
            // 
            this.cbCargo.Enabled = false;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(260, 26);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(100, 21);
            this.cbCargo.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Cargo :";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(81, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nome :";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(435, 81);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarNome.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Buscar :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(81, 81);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Usuario :";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(260, 81);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Senha :";
            // 
            // formularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 382);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formularioUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuarios";
            this.Load += new System.EventHandler(this.formularioUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
    }
}