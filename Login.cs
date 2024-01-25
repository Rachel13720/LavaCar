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

namespace LavaCar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(TxtUser.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtPass.Text.Trim()))
                {
                    string u = TxtUser.Text.Trim();
                    string p = TxtPass.Text.Trim();

                    Usuario MiUsuario = new Usuario();

                    if (MiUsuario.ValidarLogin(u,p))
                    {
                        ObjetosGlobales.MiFormPrincipal.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña son incorrectos", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
