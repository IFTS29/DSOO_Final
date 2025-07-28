using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoIntegrador.Entidades;

namespace ProyectoIntegrador.Datos
{
    internal class CuotasDiarias
    {

        // Registra el pago en CuotaDiaria
        public void RegistrarPago(int idNoSocio, int idActividad, string formaPago, decimal monto, int cantCuotas)
        {
            
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();
                DateTime fecha = DateTime.Now;

                string query = "INSERT INTO CuotaDiaria (idNoSocio, idActividad, monto, medioPago, fechaPago, cantCuotas) " +
                       "VALUES (" + idNoSocio + ", " + idActividad + ", " +
                       monto.ToString("0.00").Replace(",", ".") + ", '" +
                       formaPago + "', '" + fecha.ToString("yyyy-MM-dd") + "', " +
                       cantCuotas + ")";

                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        
        }

        // Método que devuelve TRUE si el socio ya pagó una determinada actividad del día
        public bool PagoYaRegistradoHoy(int idNoSocio, int idActividad)
        {
            bool yaPagado = false;
            using var sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();

                // Se arma la consulta concatenando los valores (ya validados como enteros)
                string query = "SELECT COUNT(*) FROM CuotaDiaria " +
                               "WHERE idNoSocio = " + idNoSocio +
                               " AND idActividad = " + idActividad +
                               " AND fechaPago = CURDATE()";

                using var cmd = new MySqlCommand(query, sqlCon);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                yaPagado = resultado > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return yaPagado;
        }
    }
}
