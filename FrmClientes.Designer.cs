namespace LavaCar
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCarro = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblServicio = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCarro = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtServicio = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nombre,
            this.Carro,
            this.Telefono,
            this.Servicio,
            this.Precio,
            this.Fecha});
            this.DgvClientes.Location = new System.Drawing.Point(25, 298);
            this.DgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(968, 338);
            this.DgvClientes.TabIndex = 0;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "Codigo";
            this.IdCliente.Name = "IdCliente";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Carro
            // 
            this.Carro.DataPropertyName = "Carro";
            this.Carro.HeaderText = "Carro";
            this.Carro.Name = "Carro";
            this.Carro.Width = 130;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Servicio
            // 
            this.Servicio.DataPropertyName = "Servicio";
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.Width = 150;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 200;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(277, 47);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(605, 23);
            this.TxtBusqueda.TabIndex = 1;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(200, 50);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(52, 17);
            this.LblBuscar.TabIndex = 2;
            this.LblBuscar.Text = "Buscar";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAgregar.Location = new System.Drawing.Point(1082, 324);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(123, 45);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnEditar.Location = new System.Drawing.Point(1082, 400);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(123, 45);
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.LightBlue;
            this.BtnEliminar.Location = new System.Drawing.Point(1082, 480);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(123, 45);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(41, 113);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCarro
            // 
            this.LblCarro.AutoSize = true;
            this.LblCarro.Location = new System.Drawing.Point(41, 164);
            this.LblCarro.Name = "LblCarro";
            this.LblCarro.Size = new System.Drawing.Size(43, 17);
            this.LblCarro.TabIndex = 7;
            this.LblCarro.Text = "Carro";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(41, 216);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(64, 17);
            this.LblTelefono.TabIndex = 8;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblServicio
            // 
            this.LblServicio.AutoSize = true;
            this.LblServicio.Location = new System.Drawing.Point(502, 113);
            this.LblServicio.Name = "LblServicio";
            this.LblServicio.Size = new System.Drawing.Size(58, 17);
            this.LblServicio.TabIndex = 9;
            this.LblServicio.Text = "Servicio";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(502, 164);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(48, 17);
            this.LblPrecio.TabIndex = 10;
            this.LblPrecio.Text = "Precio";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(502, 216);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(47, 17);
            this.LblFecha.TabIndex = 11;
            this.LblFecha.Text = "Fecha";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(117, 107);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(329, 23);
            this.TxtNombre.TabIndex = 12;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtCarro
            // 
            this.TxtCarro.Location = new System.Drawing.Point(117, 158);
            this.TxtCarro.Name = "TxtCarro";
            this.TxtCarro.Size = new System.Drawing.Size(329, 23);
            this.TxtCarro.TabIndex = 13;
            this.TxtCarro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCarro_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(117, 213);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(329, 23);
            this.TxtTelefono.TabIndex = 14;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtServicio
            // 
            this.TxtServicio.Location = new System.Drawing.Point(576, 107);
            this.TxtServicio.Name = "TxtServicio";
            this.TxtServicio.Size = new System.Drawing.Size(329, 23);
            this.TxtServicio.TabIndex = 15;
            this.TxtServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtServicio_KeyPress);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(576, 164);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(329, 23);
            this.TxtPrecio.TabIndex = 16;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // DtFecha
            // 
            this.DtFecha.Location = new System.Drawing.Point(576, 213);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(329, 23);
            this.DtFecha.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1079, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 18;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnSalir.Location = new System.Drawing.Point(1082, 554);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(123, 47);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1217, 649);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtServicio);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCarro);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblServicio);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblCarro);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.DgvClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCarro;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblServicio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCarro;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtServicio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button BtnSalir;
    }
}

