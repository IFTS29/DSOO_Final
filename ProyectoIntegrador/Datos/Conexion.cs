using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Referencia a MySQL (se agrega como libreria)

namespace ProyectoIntegrador.Datos
{
    public class Conexion // la clase debe ser pública
    {

        // Declaración de variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null; // Se usará para el patrón Singleton


        // Constructor privado para evitar la creación de instancias fuera de la clase
        private Conexion()
        {

            // variables usadas para la repetición de líneas de código
            bool correcto = false;
            int mensaje;


            // se crean las variables para recibir los datos desde el teclado
            // (se antepone la letra T para indicar que viene del teclado)
            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";


            // CICLO WHILE para volver a repetir el ingreso de datos
            // la variable 'correcto' se inicializa para ingresar al ciclo
            while (correcto != true)
            {
                // Recolección de datos
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("ingrese clave", "DATOS DE INSTALACIÓN MySQL");


                // Confirmación visual
                // Se controla que los datos ingresados para acceder a MySQL sean correctos
                mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " + T_servidor + 
                                                " PUERTO= " + T_puerto + 
                                                " USUARIO: " + T_usuario + 
                                                " CLAVE: " + T_clave, 
                                                "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje != 6) // Si NO acepta los datos
                {
                    MessageBox.Show("Ingrese nuevamente los datos.");
                    continue; // Vuelve al inicio del while sin intentar conectar
                }

                // Si aceptó los datos, se intenta conectar
                try
                {
                    // Tu código para crear la conexión, por ejemplo:
                    string cadena = "server=" + T_servidor + ";port=" + T_puerto + ";user=" + T_usuario + ";password=" + T_clave;
                    MySqlConnection conexion = new MySqlConnection(cadena);
                    conexion.Open();

                    // Si se conecta correctamente
                    correcto = true;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Datos de conexión a MySQL incorrectos. Intente nuevamente.",
                                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correcto = false;
                }

            }

            // reemplazamos los datos concretos que teniamos por las variables
            this.baseDatos = "ProyectoGym";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; //"3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave; // "";
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

        // Método estático para evaluar la instancia de la conexión
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
