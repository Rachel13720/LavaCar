using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaCar
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            if (!Logica.ObjetosGlobales.MiFormUsuarios.Visible)
            {
                Logica.ObjetosGlobales.MiFormUsuarios = new FrmUsuarios();
                Logica.ObjetosGlobales.MiFormUsuarios.Show();
            }
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {

            if (!Logica.ObjetosGlobales.MiFormClientes.Visible)
            {
                Logica.ObjetosGlobales.MiFormClientes = new FrmClientes();
                Logica.ObjetosGlobales.MiFormClientes.Show();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Logica.ObjetosGlobales.MiUsuarioGlobal.NombreUsuario;
        }
    }
}
