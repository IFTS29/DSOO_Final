using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Referencia a MySQL (se agrega como libreria)
using System.Data;  // Necesario para trabajar con DataTable

namespace ProyectoIntegrador.Datos
{
    internal class Usuarios
    {
        // Método que retorna una tabla con la información
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // Variable de tipo DataReader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // Usamos la clase Conexion para crear la conexión
                sqlCon = Conexion.getInstancia().CrearConexion();

                // El comando es un elemento que almacena el nombre del procedimiento almacenado y la referencia a la conexión
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Definimos los parámetros que recibe el procedure almacenado
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                // Abrimos la conexión
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // Ejecutamos el procedimiento y almacenamos el resultado
                tabla.Load(resultado); // Cargamos el resultado en el DataTable

                return tabla; // Retornamos la tabla con los datos
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                // Cerramos la conexión
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

    }
}
