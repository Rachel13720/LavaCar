using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LavaCar.Logica
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Carro { get; set; }
        public int Telefono { get; set; }
        public string Servicio { get; set; }
        public float Precio { get; set; }
        public DateTime Fecha { get; set; }

        public Cliente()
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
                string sql_tarea = "Insert into Clientes (Nombre, Carro, Telefono, Servicio, Precio, Fecha) VALUES (@Nombre, @Carro, @Telefono, @Servicio, @Precio, @Fecha)";

                MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                COMANDO.Parameters.AddWithValue("@Nombre",this.Nombre);
                COMANDO.Parameters.AddWithValue("@Carro", this.Carro);
                COMANDO.Parameters.AddWithValue("@Telefono", this.Telefono);
                COMANDO.Parameters.AddWithValue("@Servicio", this.Servicio);
                COMANDO.Parameters.AddWithValue("@Precio", this.Precio);
                COMANDO.Parameters.AddWithValue("@Fecha", this.Fecha);
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
                string sql_tarea = "UPDATE Clientes SET Nombre = @Nombre, Carro = @Carro, Telefono = @Telefono, Servicio = @Servicio, Precio = @Precio, Fecha = @Fecha WHERE IdCliente = @IdCliente";
                
                MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                COMANDO.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                COMANDO.Parameters.AddWithValue("@Nombre", this.Nombre);
                COMANDO.Parameters.AddWithValue("@Carro", this.Carro);
                COMANDO.Parameters.AddWithValue("@Telefono", this.Telefono);
                COMANDO.Parameters.AddWithValue("@Servicio", this.Servicio);
                COMANDO.Parameters.AddWithValue("@Precio", this.Precio);
                COMANDO.Parameters.AddWithValue("@Fecha", this.Fecha);
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
                string sql_tarea = "DELETE From Clientes WHERE IdCliente = @IdCliente";

                MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                COMANDO.Parameters.AddWithValue("@IdCliente", this.IdCliente);
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
            DT.Columns.Add("IdCliente", typeof(int));
            DT.Columns.Add("Nombre", typeof(string));
            DT.Columns.Add("Carro", typeof(string));
            DT.Columns.Add("Telefono", typeof(int));
            DT.Columns.Add("Servicio", typeof(string));
            DT.Columns.Add("Precio", typeof(float));
            DT.Columns.Add("Fecha", typeof(DateTime));


            string conn = "Server=localhost;Database=lavacar;User ID=root;Password=root;";

            MySqlConnection SqlCon = new MySqlConnection(conn);
            try
            {
                SqlCon.Open();
                if (busqueda == "")
                {
                    string sql_tarea = "SELECT IdCliente, Nombre, Carro, Telefono, Servicio, Precio, Fecha from lavacar.clientes";
                    MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(COMANDO))
                    {
                        adapter.Fill(DT);
                    }
                }
                else
                {
                    //agregar otra consulta con un datetimepicker
                    string sql_tarea = "SELECT IdCliente, Nombre, Carro, Telefono, Servicio, Precio, Fecha from lavacar.clientes WHERE Clientes.Fecha like @busqueda";
                    MySqlCommand COMANDO = new MySqlCommand(sql_tarea, SqlCon);
                    COMANDO.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
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

    }
}
