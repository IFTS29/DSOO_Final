using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoIntegrador.Datos;

namespace ProyectoIntegrador
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }

        private void frmConexion_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblServidor; // foco inicial en el label
        }

        private void txtServidor_Enter(object sender, EventArgs e)
        {
            if (txtServidor.Text == "Ej. localhost")
            {
                txtServidor.Text = "";
                txtServidor.ForeColor = Color.Black;
            }
        }

        private void txtServidor_Leave(object sender, EventArgs e)
        {
            if (txtServidor.Text == "")
            {
                txtServidor.Text = "Ej. localhost";
                txtServidor.ForeColor = SystemColors.ControlDark;
            }
        }

        private void txtPuerto_Enter(object sender, EventArgs e)
        {
            if (txtPuerto.Text == "Ej. 3306")
            {
                txtPuerto.Text = "";
                txtPuerto.ForeColor = Color.Black;
            }
        }

        private void txtPuerto_Leave(object sender, EventArgs e)
        {
            if (txtPuerto.Text == "")
            {
                txtPuerto.Text = "Ej. 3306";
                txtPuerto.ForeColor = SystemColors.ControlDark;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ej. root")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ej. root";
                txtUsuario.ForeColor = SystemColors.ControlDark;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Ej. ******")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Ej. ******";
                txtClave.ForeColor = SystemColors.ControlDark;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosConexion())
            {
                MessageBox.Show("Debe completar todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Asignamos los datos desde los cuadros de texto
                Conexion.getInstancia().SetDatosConexion(
                    txtServidor.Text.Trim(),
                    txtPuerto.Text.Trim(),
                    txtUsuario.Text.Trim(),
                    txtClave.Text.Trim()
                );

                // Intentamos establecer la conexión
                var con = Conexion.getInstancia().CrearConexion();
                con.Open(); // si se puede abrir está todo OK, sino pueda lanzar excepción
                con.Close();

                MessageBox.Show("Conexión exitosa", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrimos el formulario de login
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide(); // ocultamos este formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos incorrectos.",
                        "ERROR DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidarDatosConexion()
        {
            return !(txtServidor.Text.Trim() == "" || txtServidor.Text == "Ej. localhost" ||
                     txtPuerto.Text.Trim() == "" || txtPuerto.Text == "Ej. 3306" ||
                     txtUsuario.Text.Trim() == "" || txtUsuario.Text == "Ej. root" ||
                     txtClave.Text.Trim() == "" || txtClave.Text == "Ej. ******");
        }
    }
}

