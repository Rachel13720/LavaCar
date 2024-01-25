namespace LavaCar
{
    partial class FrmUsuarios
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
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasennia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NombreUsuario,
            this.Contrasennia,
            this.Correo});
            this.DgvUsuarios.Location = new System.Drawing.Point(65, 270);
            this.DgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(862, 397);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(991, 270);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(203, 60);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(991, 365);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(203, 60);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(991, 460);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(203, 60);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(991, 552);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(203, 60);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correo";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(216, 69);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(495, 23);
            this.TxtUsuario.TabIndex = 8;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(216, 130);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(495, 23);
            this.TxtPassword.TabIndex = 9;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(216, 192);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(495, 23);
            this.TxtCorreo.TabIndex = 10;
            this.TxtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreo_KeyPress);
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "CODIGO";
            this.IdUsuario.Name = "IdUsuario";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DataPropertyName = "NombreUsuario";
            this.NombreUsuario.HeaderText = "USUARIO";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Width = 200;
            // 
            // Contrasennia
            // 
            this.Contrasennia.DataPropertyName = "Contrasennia";
            this.Contrasennia.HeaderText = "PASSWORD";
            this.Contrasennia.Name = "Contrasennia";
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "CORREO ELECTRONICO";
            this.Correo.Name = "Correo";
            this.Correo.Width = 520;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1225, 718);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasennia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}