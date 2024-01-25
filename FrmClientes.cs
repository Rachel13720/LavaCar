using LavaCar.Logica;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace LavaCar
{
    public partial class FrmClientes : Form
    {

        Cliente clienteGlobal = new Cliente();

        public FrmClientes()
        {
            InitializeComponent();
        }


        private void Formato()
        {
            DgvClientes.Columns[0].HeaderText = "CODIGO";
            DgvClientes.Columns[1].HeaderText = "CLIENTE";
            DgvClientes.Columns[2].HeaderText = "CARRO";
            DgvClientes.Columns[3].HeaderText = "TELEFONO";
            DgvClientes.Columns[4].HeaderText = "SERVICIO";
            DgvClientes.Columns[5].HeaderText = "PRECIO";
            DgvClientes.Columns[6].HeaderText = "FECHA";
        }

        private void Listado(string busqueda = "")
        {
                DataTable DT = new DataTable();
                Cliente MiCliente = new Cliente();
                DT = MiCliente.Consultar(busqueda);
                DgvClientes.DataSource = DT;
                this.Formato();
                Console.WriteLine(DT.Rows.Count);
            
        }



        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.Listado(); 
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente MiCliente = new Cliente();
                MiCliente.Nombre = TxtNombre.Text.Trim();
                MiCliente.Carro = TxtCarro.Text.Trim(); 
                MiCliente.Telefono = Convert.ToInt32(TxtTelefono.Text.Trim());
                MiCliente.Servicio = TxtServicio.Text.Trim();
                MiCliente.Precio = Convert.ToInt32(TxtPrecio.Text.Trim());
                MiCliente.Fecha = DtFecha.Value.Date;

                MiCliente.Agregar();
                Listado();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                clienteGlobal.Nombre = TxtNombre.Text.Trim();
                clienteGlobal.Carro = TxtCarro.Text.Trim();
                clienteGlobal.Telefono = Convert.ToInt32(TxtTelefono.Text.Trim());
                clienteGlobal.Servicio = TxtServicio.Text.Trim();
                clienteGlobal.Precio = Convert.ToInt32(TxtPrecio.Text.Trim());
                clienteGlobal.Fecha = DtFecha.Value.Date;

                clienteGlobal.Editar();
                Listado();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvClientes.SelectedRows.Count == 1)
                {

                    DataGridViewRow MiFila = DgvClientes.SelectedRows[0];

                    TxtNombre.Text = Convert.ToString(MiFila.Cells["Nombre"].Value);
                    TxtCarro.Text = Convert.ToString(MiFila.Cells["Carro"].Value);
                    TxtTelefono.Text = Convert.ToString(MiFila.Cells["Telefono"].Value);
                    TxtServicio.Text = Convert.ToString(MiFila.Cells["Servicio"].Value);
                    TxtPrecio.Text = Convert.ToString(MiFila.Cells["Precio"].Value);
                    DtFecha.Text = Convert.ToString(MiFila.Cells["Fecha"].Value);

                    clienteGlobal.IdCliente = Convert.ToInt32(MiFila.Cells["IdCliente"].Value);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteGlobal.Eliminar();
                Listado();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            ObjetosGlobales.MiFormPrincipal.Show();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Listado(TxtBusqueda.Text.Trim());
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        private void TxtCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Herramientas.CaracteresTextoM(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        private void TxtServicio_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

    }
}
