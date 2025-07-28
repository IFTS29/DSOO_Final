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
    internal class Actividades
    {

        // Método que devuelve una lista de objetos de tipo E_Actividad
        public List<E_Actividad> ListarActividades()
        {
            List<E_Actividad> lista = new List<E_Actividad>();
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();

            try
            {
                sqlCon.Open();
                string query = "SELECT idActividad, nombreActividad, horaActividad, costoActividad FROM Actividad";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new E_Actividad
                    {
                        idActividad = reader.GetInt32("idActividad"),
                        nombreActividad = reader.GetString("nombreActividad"),
                        horaActividad = reader.GetTimeSpan("horaActividad"),
                        costoActividad = reader.GetDecimal("costoActividad")
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // se cierra la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return lista;
        }



        // Método que obtiene la información de una actividad seleccionada
        public E_Actividad ObtenerActividadPorId(int idActividad)
        {
            E_Actividad actividad = null;
            using var sqlCon = Conexion.getInstancia().CrearConexion();
            sqlCon.Open();

            string query = "SELECT nombreActividad, horaActividad, costoActividad FROM Actividad WHERE idActividad = @id";
            var cmd = new MySqlCommand(query, sqlCon);
            cmd.Parameters.AddWithValue("@id", idActividad);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                actividad = new E_Actividad
                {
                    idActividad = idActividad,
                    nombreActividad = reader.GetString("nombreActividad"),
                    horaActividad = reader.GetTimeSpan("horaActividad"),
                    costoActividad = reader.GetDecimal("costoActividad")
                };
            }
            return actividad;
        }
    }
}
