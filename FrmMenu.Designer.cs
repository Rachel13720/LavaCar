namespace LavaCar
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.PBFondo = new System.Windows.Forms.PictureBox();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnClient = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PBFondo)).BeginInit();
            this.LblTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBFondo
            // 
            this.PBFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBFondo.BackgroundImage")));
            this.PBFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBFondo.Location = new System.Drawing.Point(27, 25);
            this.PBFondo.Name = "PBFondo";
            this.PBFondo.Size = new System.Drawing.Size(350, 381);
            this.PBFondo.TabIndex = 0;
            this.PBFondo.TabStop = false;
            // 
            // BtnUser
            // 
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.Location = new System.Drawing.Point(510, 91);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(376, 49);
            this.BtnUser.TabIndex = 1;
            this.BtnUser.Text = "Formulario Usuarios";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnClient
            // 
            this.BtnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClient.Location = new System.Drawing.Point(510, 209);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(376, 49);
            this.BtnClient.TabIndex = 2;
            this.BtnClient.Text = "Formulario Clientes";
            this.BtnClient.UseVisualStyleBackColor = true;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(510, 338);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(376, 49);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Cerrar Sesión";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(4, 9);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(0, 13);
            this.LblUsuario.TabIndex = 5;
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.LblTitulo.Location = new System.Drawing.Point(0, 428);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(948, 22);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "Bienvenido";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel2.Text = "U";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.PBFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBFondo)).EndInit();
            this.LblTitulo.ResumeLayout(false);
            this.LblTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBFondo;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.StatusStrip LblTitulo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}