using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace LavaCar.Logica
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion MiCnn = null;

        private Conexion()
        {
            this.Base = "lavacar";
            this.Servidor = "127.0.0.1";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Clave = "root";

        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "datasource=" + this.Servidor +
                                         "; port=" + this.Puerto +
                                         ";username=" + this.Usuario +
                                         ";password=" + this.Clave +
                                         ";Database=" + this.Base;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        
        }

        public static Conexion getInstancia()
        {
            if (MiCnn == null)
            {
                MiCnn = new Conexion();
            }

            return MiCnn;
        }
         

    }
}
