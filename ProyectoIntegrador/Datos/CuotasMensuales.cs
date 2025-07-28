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
    internal class CuotasMensuales
    {


        // Método que obtiene la cuota con vencimiento igual o anterior al día actual
        // Recibe como parámetro el idSocio
        // Retorna el objeto E_CuotaMensual con sus datos, o null si no existe
        public E_CuotaMensual ObtenerCuotaVencida(int idSocio)
        {
            E_CuotaMensual cuota = null;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = "SELECT idCuota, montoCuota, fechaPago, fechaVencimiento " +
                                "FROM CuotaMensual " +
                                "WHERE idSocio = " + idSocio +
                                    " AND fechaVencimiento <= CURDATE() " +
                                    "AND idCuota = (SELECT MAX(idCuota) FROM CuotaMensual " +
                                            "WHERE idSocio = " + idSocio + 
                                            " AND fechaVencimiento <= CURDATE())";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    cuota = new E_CuotaMensual();
                    cuota.idCuota = reader.GetInt32("idCuota");
                    cuota.idSocio = idSocio;
                    cuota.montoCuota = reader.GetDecimal("montoCuota");
                    cuota.fechaPago = reader.IsDBNull(reader.GetOrdinal("fechaPago")) ? null : reader.GetDateTime("fechaPago");
                    cuota.fechaVencimiento = reader.GetDateTime("fechaVencimiento");
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
            return cuota;
        }



        // Método que registra el pago y genera la nueva cuota, devolviendo su fecha de vencimiento
        public DateTime PagarCuota(E_CuotaMensual cuota, string formaPago, int cantCuotas)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            DateTime proximoVencimiento = DateTime.MinValue;
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                DateTime fechaPago = DateTime.Now;

                // actualiza la cuota del socio
                string queryUpdate = "UPDATE CuotaMensual SET " +
                                     "fechaPago = '" + fechaPago.ToString("yyyy-MM-dd") + "', " +
                                     "medioPago = '" + formaPago + "', " +
                                     "cantCuotas = " + cantCuotas + " " +
                                     "WHERE idCuota = " + cuota.idCuota;

                MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, sqlCon);
                cmdUpdate.ExecuteNonQuery();

                // Nueva cuota: con fecha de vencimiento en un mes
                proximoVencimiento = fechaPago.AddMonths(1);
                string queryInsert = "INSERT INTO CuotaMensual (idSocio, fechaVencimiento) " +
                                     "VALUES (" + cuota.idSocio + ", '" + proximoVencimiento.ToString("yyyy-MM-dd") + "')";

                MySqlCommand cmdInsert = new MySqlCommand(queryInsert, sqlCon);
                cmdInsert.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return proximoVencimiento;
        }



    }
}
