using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador.Datos
{
    internal class Socios
    {

        // Método que valida si existe el socio 
        // Recibe como parámetro el idSocio
        // Retorna TRUE si el socio existe, FALSE si no existe
        public bool ExisteSocio(int idSocio)
        {
            bool existe = false;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Consulta SQL para ver si existe el idSocio
                // devuelve un único valor entero: la cantidad de filas que coinciden con el ID. 
                string query = "SELECT COUNT(*) FROM socio WHERE idSocio = " + idSocio;

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                // Se  ejecuta la consulta Y obtiene el valor entero devuelto por COUNT(*)
                sqlCon.Open();
                int resultado = Convert.ToInt32(comando.ExecuteScalar());

                // Si resultado es mayor a 0 => el socio existe
                existe = resultado > 0;

            }
            catch (Exception)
            {
                throw; // Se propaga la excepción para manejarla en niveles superiores
            }
            finally
            {
                // Se cierra la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return existe;
        }



        // Método que el nombre y apellido del socio
        public string ObtenerNombreSocio(int idSocio)
        {
            string nombre = "";
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();

                // Consulta SQL para obtener el nombre completo del socio
                string query = "SELECT CONCAT(c.Nombre, ' ', c.Apellido) AS nombreCompleto " +
                               "FROM socio s JOIN cliente c ON s.Doc = c.Doc " +
                               "WHERE s.idSocio = " + idSocio;

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    nombre = reader.GetString("nombreCompleto");
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // Se cierra la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return nombre;
        }


        // Método que devuelve la fecha de inscripción del socio
        public DateTime ObtenerFechaInscripcion(int idSocio)
        {
            DateTime fechaInsc = DateTime.MinValue;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();

                string query = "SELECT fechaInscripcion FROM socio WHERE idSocio = " + idSocio;

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    fechaInsc = reader.GetDateTime("fechaInscripcion");
                }

                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return fechaInsc;
        }


        
        // Método que setea el carnet de socio como entregado (true)
        public void EntregarCarnet(int idSocio)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // Consulta SQL para actualizar el campo CarnetEntregado a true
                string query = "UPDATE socio SET CarnetEntregado = true WHERE idSocio = " + idSocio;

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw; // Se propaga la excepción para manejarla externamente
            }
            finally
            {
                // Se cierra la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }




    }
}
