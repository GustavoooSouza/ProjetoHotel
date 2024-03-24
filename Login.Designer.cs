namespace ProjetoHotel
{
    partial class formularioLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioLogin));
            this.painelLogin = new System.Windows.Forms.Panel();
            this.botaoLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.painelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelLogin
            // 
            this.painelLogin.BackColor = System.Drawing.Color.Transparent;
            this.painelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelLogin.BackgroundImage")));
            this.painelLogin.Controls.Add(this.botaoLogin);
            this.painelLogin.Controls.Add(this.txtSenha);
            this.painelLogin.Controls.Add(this.txtUsuario);
            this.painelLogin.Location = new System.Drawing.Point(296, 176);
            this.painelLogin.Name = "painelLogin";
            this.painelLogin.Size = new System.Drawing.Size(332, 340);
            this.painelLogin.TabIndex = 0;
            // 
            // botaoLogin
            // 
            this.botaoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLogin.FlatAppearance.BorderSize = 0;
            this.botaoLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.botaoLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botaoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLogin.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.botaoLogin.Location = new System.Drawing.Point(15, 255);
            this.botaoLogin.Name = "botaoLogin";
            this.botaoLogin.Size = new System.Drawing.Size(302, 43);
            this.botaoLogin.TabIndex = 2;
            this.botaoLogin.Text = "ENTRAR";
            this.botaoLogin.UseVisualStyleBackColor = true;
            this.botaoLogin.Click += new System.EventHandler(this.botaoLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(63, 212);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(238, 16);
            this.txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(63, 154);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(238, 16);
            this.txtUsuario.TabIndex = 0;
            // 
            // formularioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 669);
            this.Controls.Add(this.painelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formularioLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formularioLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formularioLogin_KeyDown);
            this.Resize += new System.EventHandler(this.formularioLogin_Resize);
            this.painelLogin.ResumeLayout(false);
            this.painelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button botaoLogin;
    }
}

