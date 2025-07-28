using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoIntegrador.Entidades;

namespace ProyectoIntegrador.Datos
{
    internal class NoSocios
    {

        // Método que valida si existe el no socio (según el idNoSocio)
        // Retorna TRUE si el no socio existe, FALSE si no existe
        public bool ExisteNoSocio(int idNoSocio)
        {
            bool existe = false;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {

                // Consulta SQL para ver si existe el idSocio
                // devuelve un único valor entero: la cantidad de filas que coinciden con el ID.
                string query = "SELECT COUNT(*) FROM noSocio WHERE idNoSocio = " + idNoSocio;

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                // Se  ejecuta la consulta Y obtiene el valor entero devuelto por COUNT(*)
                sqlCon.Open();
                int resultado = Convert.ToInt32(comando.ExecuteScalar());

                // Si resultado es mayor a 0 => el no socio existe
                existe = resultado > 0;
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
            return existe;
        }



        // Devuelve el nombre y apellido del no socio
        public string ObtenerNombreNoSocio(int idNoSocio)
        {
            string nombre = "";
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();
                string query = "SELECT CONCAT(c.Nombre, ' ', c.Apellido) AS nombreCompleto " +
                               "FROM noSocio ns JOIN cliente c ON ns.Doc = c.Doc " +
                               "WHERE ns.idNoSocio = " + idNoSocio;

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
        

    }
}
