using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaCar.Logica
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasennia { get; set; }
        public string Correo { get; set; }

        public Usuario()
        {
                
        }

        public bool Agregar() 
        {

            bool R = false;

            string conn = "Server=localhost;Database=lavacar;User ID=root;Password=root;";
            MySqlConnection SqlCon = new MySqlConnection(conn);

            try
            {
                SqlCon.Open();
                string sql_tarea = "Insert into Usuario (NombreUsuario, Contrasennia, Correo) VALUES (@NombreUsuario, @Contrasennia, @Correo)";

                MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                COMANDO.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
                COMANDO.Parameters.AddWithValue("@Contrasennia", this.Contrasennia);
                COMANDO.Parameters.AddWithValue("@Correo", this.Correo);
                COMANDO.ExecuteNonQuery();
            }
            finally
            {
                SqlCon.Close();
            }

            return R;
        }

        public bool Editar() 
        {
            bool R = false;
            string conn = "Server=localhost;Database=lavacar;User ID=root;Password=root;";
            MySqlConnection SqlCon = new MySqlConnection(conn);

            try
            {
                SqlCon.Open();
                string sql_tarea = "UPDATE Usuario SET NombreUsuario = @NombreUsuario, Contrasennia = @Contrasennia, Correo = @Correo WHERE IdUsuario = @IdUsuario";

                MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                COMANDO.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                COMANDO.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
                COMANDO.Parameters.AddWithValue("@Contrasennia", this.Contrasennia);
                COMANDO.Parameters.AddWithValue("@Correo", this.Correo);
                COMANDO.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            string conn = "Server=localhost;Database=lavacar;User ID=root;Password=root;";
            MySqlConnection SqlCon = new MySqlConnection(conn);

            try
            {

                SqlCon.Open();
                string sql_tarea = "DELETE From Usuario WHERE IdUsuario = @IdUsuario";

                MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                COMANDO.Parameters.AddWithValue("@IdUsuario", this.IdUsuario);
                COMANDO.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return R;
        }

        public DataTable Consultar(string busqueda = "")
        {
            DataTable DT = new DataTable();

            DT.Columns.Add("IdUsuario", typeof(int));
            DT.Columns.Add("NombreUsuario", typeof(string));
            DT.Columns.Add("Contrasennia", typeof(string));
            DT.Columns.Add("Correo", typeof(string));


            string conn = "Server=localhost;Database=lavacar;User ID=root;Password=root;";

            MySqlConnection SqlCon = new MySqlConnection(conn);
            try
            {
                SqlCon.Open();
                if (busqueda == "")
                {
                    string sql_tarea = "SELECT IdUsuario, NombreUsuario, Contrasennia, Correo from lavacar.usuario";
                    MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(COMANDO))
                    {
                        adapter.Fill(DT);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }


            return DT;
        }


        public bool ValidarLogin(string u, string p)
        {
            bool R = false;

            string conn = "Server=localhost;Database=lavacar;User ID=root;Password=root;";
            MySqlConnection SqlCon = new MySqlConnection(conn);

            try
            {
                SqlCon.Open();
                string sql_tarea = "SELECT IdUsuario, NombreUsuario, Contrasennia, Correo from lavacar.usuario WHERE NombreUsuario = @NombreUsuario AND Contrasennia = @Contrasennia";

                MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                COMANDO.Parameters.AddWithValue("@NombreUsuario", u);
                COMANDO.Parameters.AddWithValue("@Contrasennia", p);

                using (MySqlDataReader reader = COMANDO.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ObjetosGlobales.MiUsuarioGlobal = new Usuario
                        {
                            IdUsuario = reader.GetInt32("IdUsuario"),
                            NombreUsuario = reader.GetString("NombreUsuario"),
                            Contrasennia = reader.GetString("Contrasennia")

                        };

                        Console.WriteLine(reader.GetInt32("IdUsuario"));
                    }
                }

                if (ObjetosGlobales.MiUsuarioGlobal.IdUsuario != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return R;
        }
    }
}
