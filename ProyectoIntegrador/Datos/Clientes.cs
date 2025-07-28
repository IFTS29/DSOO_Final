using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.Entidades;
using MySql.Data.MySqlClient;


namespace ProyectoIntegrador.Datos
{
    internal class Clientes
    {
        // Parametro E_Cliente: contiene datos comunes, definidos en la clase padre
        // Parametro tipoCliente: para que el procedimiento determine a qué clase hija derivar la insercción del resto de los datos
        // el procedimiento inserta 1° en el cliente base y luego en la clase hija correspondiente según el tipo.
        public string Nuevo_Cliente(E_Cliente cli, string tipoCliente)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros que vienen desde E_Cliente
                comando.Parameters.Add("Docu", MySqlDbType.Int32).Value = cli.Doc;
                comando.Parameters.Add("TipoDoc", MySqlDbType.VarChar).Value = cli.TDoc;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = cli.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = cli.Apellido;
                comando.Parameters.Add("Nac", MySqlDbType.Date).Value = cli.FechaNac;
                comando.Parameters.Add("Direc", MySqlDbType.VarChar).Value = cli.Direccion;
                comando.Parameters.Add("Telef", MySqlDbType.VarChar).Value = cli.Telefono;
                comando.Parameters.Add("Em", MySqlDbType.VarChar).Value = cli.Email;
                comando.Parameters.Add("Apt", MySqlDbType.Bit).Value = cli.AptoMedico;
                comando.Parameters.Add("TipoCliente", MySqlDbType.VarChar).Value = tipoCliente;

                // Parámetro de salida
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}

