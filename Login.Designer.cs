namespace LavaCar
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PbLogin = new System.Windows.Forms.PictureBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLogin
            // 
            this.PbLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbLogin.BackgroundImage")));
            this.PbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbLogin.Location = new System.Drawing.Point(191, 71);
            this.PbLogin.Name = "PbLogin";
            this.PbLogin.Size = new System.Drawing.Size(242, 256);
            this.PbLogin.TabIndex = 0;
            this.PbLogin.TabStop = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(71, 380);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(71, 457);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(81, 17);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Contraseña";
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInicio.Location = new System.Drawing.Point(191, 512);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(257, 47);
            this.BtnInicio.TabIndex = 3;
            this.BtnInicio.Text = "Iniciar Sesión";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(161, 374);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(309, 23);
            this.TxtUser.TabIndex = 4;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(161, 457);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(309, 23);
            this.TxtPass.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(638, 586);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.PbLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLogin;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPass;
    }
}