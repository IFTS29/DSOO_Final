using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador.Datos
{
    public class Conexion // la clase debe ser pública
    {

        // Variables de conexión
        private string baseDatos = "ProyectoGym";
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null; // Se usará para el patrón Singleton


        // Constructor privado
        private Conexion() { }


        // Método para cargar los datos desde el formulario
        public void SetDatosConexion(string servidor, string puerto, string usuario, string clave)
        {
            this.servidor = servidor;
            this.puerto = puerto;
            this.usuario = usuario;
            this.clave = clave;
        }


        // Método para crear y obtener la conexión
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();

            // el bloque try permite controlar errores
            try
            {
                // Formamos la cadena de conexión usando las variables declaradas
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw; // Relanzamos el error
            }
            return cadena;
        }




        // Método estático para obtener la instancia de la clase conexión (singleton)
        public static Conexion getInstancia()
        {
            if (con == null) // Si la conexión no ha sido creada
            {
                con = new Conexion(); // Creamos una nueva instancia de la clase Conexion
            }
            return con;
        }

    }
}
