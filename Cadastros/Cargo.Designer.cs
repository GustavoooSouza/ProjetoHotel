namespace ProjetoHotel.Cadastros
{
    partial class formularioCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioCargo));
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.botaoExcluir.Location = new System.Drawing.Point(395, 215);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(65, 65);
            this.botaoExcluir.TabIndex = 76;
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
            this.botaoEditar.Location = new System.Drawing.Point(285, 215);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(65, 65);
            this.botaoEditar.TabIndex = 75;
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
            this.botaoSalvar.Location = new System.Drawing.Point(172, 215);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(65, 65);
            this.botaoSalvar.TabIndex = 74;
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
            this.botaoNovo.Location = new System.Drawing.Point(59, 215);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(65, 65);
            this.botaoNovo.TabIndex = 73;
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.Location = new System.Drawing.Point(13, 50);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(500, 150);
            this.grid.TabIndex = 72;
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(57, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Cargo :";
            // 
            // formularioCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formularioCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros de Cargos";
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
    }
}