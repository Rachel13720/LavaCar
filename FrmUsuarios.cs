using LavaCar.Logica;
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
    public partial class FrmUsuarios : Form
    {

        Usuario usuarioGlobal = new Usuario();

        public FrmUsuarios()
        {
            InitializeComponent();
        }


        private void Listado(string busqueda = "")
        {
            DataTable DT = new DataTable();
            Usuario MiUsuario = new Usuario();
            DT = MiUsuario.Consultar(busqueda);
            DgvUsuarios.DataSource = DT;
            Console.WriteLine(DT.Rows.Count);

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Listado();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Herramientas.ValidarEmail(TxtCorreo.Text.Trim()) == true)
            {
                try
                {
                    Usuario MiUsuario = new Usuario();
                    MiUsuario.NombreUsuario = TxtUsuario.Text.Trim();
                    MiUsuario.Contrasennia = TxtPassword.Text.Trim();
                    MiUsuario.Correo = TxtCorreo.Text.Trim();

                    MiUsuario.Agregar();
                    Listado();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Correo electrónico incorrecto", " ", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
           
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Herramientas.ValidarEmail(TxtCorreo.Text.Trim()) == true)
            {
                try
                {
                    usuarioGlobal.NombreUsuario = TxtUsuario.Text.Trim();
                    usuarioGlobal.Contrasennia = TxtPassword.Text.Trim();
                    usuarioGlobal.Correo = TxtCorreo.Text.Trim();

                    usuarioGlobal.Editar();
                    Listado();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (DgvUsuarios.SelectedRows.Count == 1)
                {

                    DataGridViewRow MiFila = DgvUsuarios.SelectedRows[0];

                    TxtUsuario.Text = Convert.ToString(MiFila.Cells["NombreUsuario"].Value);
                    TxtPassword.Text = Convert.ToString(MiFila.Cells["Contrasennia"].Value);
                    TxtCorreo.Text = Convert.ToString(MiFila.Cells["Correo"].Value);

                    usuarioGlobal.IdUsuario = Convert.ToInt32(MiFila.Cells["IdUsuario"].Value);

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
                usuarioGlobal.Eliminar();
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

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTextoM(pE);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e);
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, false, true);
        }
    }
}
