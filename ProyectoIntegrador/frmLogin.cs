using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Entidades;
using ProyectoIntegrador.Auxiliares;


namespace ProyectoIntegrador
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTituloLogin; 
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Se crea la tabla que recibe los datos desde el formulario
            // (recibe el resultado del procedimiento almacenado)
            DataTable tablaLogin = new DataTable();

            // Variable que contiene todas las caracteristica de la clase
            // Instancia de la clase Usuarios para acceder al método Log_Usu
            Datos.Usuarios dato = new Datos.Usuarios();
            
            // Llamada al procedimiento almacenado en la base de datos, pasando el usuario y la contraseña
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);


            // Verificación si el usuario existe
            if (tablaLogin.Rows.Count > 0)
            {
                // Si la consulta devuelve 1 fila, significa que el usuario existe
                // informamos con un mensaje al usuario
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Se guarda la información del usuario
                Sesion.Usuario = txtUsuario.Text;
                Sesion.Rol = tablaLogin.Rows[0][0].ToString();

                // YA SE ESTABLECIÓ LA CONEXION:
                // Se  isntancia un objeto de la clase formulario principal
                frmPrincipal Principal = new frmPrincipal();
                // se llama al formulario principal
                Principal.Show();
                // se oculta el formulario de login
                this.Hide();  


            }
            else
            {
                // Si el resultado devuelve 0 filas: significa que el usuario o la contraseña son incorrectos
                MessageBox.Show("Usuario y/o password incorrecto", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            Application.Exit(); // cierra las ventanas de la aplicación
        }

    }
}
