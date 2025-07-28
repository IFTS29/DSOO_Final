using ProyectoIntegrador.Entidades;
using ProyectoIntegrador;
using ProyectoIntegrador.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace ProyectoIntegrador
{
    public partial class frmInscripcion : Form
    {

        
        // Constructor
        public frmInscripcion()
        {
            InitializeComponent();
        }


        // Método para retornar al formulario PRINCIPAL original
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // se busca el formulario principal abierto
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmPrincipal)
                {
                    // se muestra el frm princial ya abierto
                    // (con datos de usuarios cargados)
                    frm.Show();  
                    break; // se sale del foreach porque ya se encontró frm
                }
            }
            this.Hide(); // se oculta el formulario actual (Inscripcion)
        }


        // Método para salir de la aplicación
        private void btnSalirInscrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Evento de carga del formulario
        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            dtpFechaNac.MaxDate = DateTime.Today;
        }



        // Método para registrar al nuevo Cliente
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN DE DATOS INGRESADOS

            // Todos los campos deben ser completados
            if (txtNombre.Text == "" || txtApellido.Text == "" || cboTipo.Text == "" || 
                txtDocumento.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" ||
                txtEmail.Text == "" || cboApto.Text == "" || cboTipoCliente.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            // El Apto médico es obligatorio
            else if (cboApto.Text != "Presentado")
            {
                MessageBox.Show("El Apto Médico es obligatorio!",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cboApto.Focus(); // se enfoca en el campo Apto Médico
            }
            
            // El documento solo admite caracteres numéricos
            else if (!int.TryParse(txtDocumento.Text, out _) || txtDocumento.Text.Length < 6)
            {
                MessageBox.Show("El documento solo permite caracteres numéricos. " +
                    "\n y debe tener entre 6 y 10 caracteres",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDocumento.Focus(); // se enfoca en el campo Documento
            }

            // El Teléfono solo admite caracteres numéricos
            else if (!long.TryParse(txtTelefono.Text, out _) || txtTelefono.Text.Length < 6 || txtTelefono.Text.Length > 16)
            {
                MessageBox.Show("El número de teléfono solo permite caracteres numéricos." +
                    "\n y debe tener entre 6 y 16 caracteres",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTelefono.Focus(); // se enfoca en el campo Teléfono
            }

            // Si las validaciones son correctas se procede con la carga de datos
            else
            {
                string respuesta;
                E_Cliente cli = new E_Cliente();
                cli.Nombre = txtNombre.Text;
                cli.Apellido = txtApellido.Text;
                cli.Doc = Convert.ToInt32(txtDocumento.Text);
                cli.TDoc = cboTipo.Text;
                cli.FechaNac = dtpFechaNac.Value;
                cli.Direccion = txtDireccion.Text;
                cli.Telefono = txtTelefono.Text;
                cli.Email = txtEmail.Text;
                cli.AptoMedico = (cboApto.Text == "Presentado");

                // se crea una instancia de la clase Clientes
                // para poder usar el metodo Nuevo_Cliente de la clase
                Clientes clienteDatos = new Clientes();
                string tipo = cboTipoCliente.Text; // "Socio" o "No Socio"
                respuesta = clienteDatos.Nuevo_Cliente(cli, tipo);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == -1)
                    {
                        MessageBox.Show("El cliente ya existe!", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDocumento.Focus(); // se enfoca en el campo Doc
                    }
                    else
                    {
                        MessageBox.Show("¡Registro exitoso! \n " + cboTipoCliente.Text + " nro " + respuesta, "AVISO DEL SISTEMA",
                                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }



        /* Limpiar los objetos para facilitar un nuevo ingreso  */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.SelectedIndex = -1;
            cboApto.SelectedIndex = -1;
            cboTipoCliente.SelectedIndex = -1;
            dtpFechaNac.Value = DateTime.Today;
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombre.Focus();
        }

        
    }
}
