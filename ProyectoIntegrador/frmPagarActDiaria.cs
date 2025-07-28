using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Entidades;



namespace ProyectoIntegrador
{
    public partial class frmPagarActDiaria : Form
    {
        // -----------------------------
        // VARIABLES Y CONSTRUCTOR
        // -----------------------------

        // Instancia del formulario de comprobante (factura)
        public frmFacturaDiaria doc = new frmFacturaDiaria();

        // Objetos DAO para acceder a las tablas correspondientes desde la base de datos
        private CuotasDiarias cuotasDAO = new CuotasDiarias();
        private NoSocios noSociosDAO = new NoSocios();
        private Actividades actividadesDAO = new Actividades();

        // Constructor del formulario
        public frmPagarActDiaria()
        {
            InitializeComponent();
        }



        // -----------------------------------------
        // EVENTO DE CARGA Y CONFIGURACIÓN INICIAL
        // -----------------------------------------

        // Evento que se dispara al cargarse el formulario
        private void frmPagarCuota_Load(object sender, EventArgs e)
        {
            // se inicializa el combo de cant de cuotas en 1
            cboCantCuotas.SelectedIndex = 0;

            List<E_Actividad> listaActividades = actividadesDAO.ListarActividades();
            cboActividades.DataSource = listaActividades;
            cboActividades.DisplayMember = "nombreActividad";
            cboActividades.ValueMember = "idActividad";
            cboActividades.SelectedIndex = -1;
        }




        // --------------------------------
        // EVENTOS DE CONTROLES DE ENTRADA
        // --------------------------------

        // Si se selecciona método de pago TARJETA,
        // se habilita el combo de cuotas y se reinicia a 1
        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked)
            {
                cboCantCuotas.Enabled = true;
                cboCantCuotas.SelectedIndex = 0; 
            }
        }


        // Si se selecciona método de pago EFECTIVO
        // se deshabilita el combo de cuotas y se reinicia a 1
        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (optEfectivo.Checked)
            {
                cboCantCuotas.Enabled = false;
                cboCantCuotas.SelectedIndex = 0; 
            }
        }


        // Evento que se dispara al modificar el campo Nro Socio
        private void txtNro_TextChanged(object sender, EventArgs e)
        {
            // si se hizo click en botón Buscar
            // y la interfaz muestra un estado distinto al inicial
            // (Ej. botón de pagar activo)
            if (btnPagar.Enabled)
            {
                // se la reinicia a su estado inicial por defecto.
                cboActividades.SelectedIndex = -1;
                btnPagar.Enabled = false;
                lblDatos.Text = "NO HAY DATOS DE PAGO";
                lblDatos.Top = (grpDatos.Height - lblDatos.Height) / 2;
                grpFormaPago.Enabled = false;
                optEfectivo.Checked = false;
                optTarjeta.Checked = false;
                cboCantCuotas.SelectedIndex = 0;
                btnComprobante.Enabled = false;

            }
        }

        // Evento que se dispara al modificar el campo Actividad
        private void cboActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si se hizo click en botón Buscar
            // y la interfaz muestra un estado distinto al inicial
            // (Ej. botón de pagar activo)
            if (btnPagar.Enabled)
            {
                
                
                btnPagar.Enabled = false;
                lblDatos.Text = "NO HAY DATOS DE PAGO";
                lblDatos.Top = (grpDatos.Height - lblDatos.Height) / 2;
                grpFormaPago.Enabled = false;
                optEfectivo.Checked = false;
                optTarjeta.Checked = false;
                cboCantCuotas.SelectedIndex = 0;
                btnComprobante.Enabled = false;
            }
        }


        // -------------------------------------
        // BOTONES PRINCIPALES (BUSCAR Y PAGAR)
        // -------------------------------------

        // Botón para buscar y mostrar datos del socio y su cuota
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // VALIDACION: campo Nro de socio está vacío
            if (string.IsNullOrWhiteSpace(txtNro.Text))
            {
                MessageBox.Show("Debe ingresar un Nro de Cliente no socio .", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDACIÓN: campo Nro de socio es numérico
            if (!int.TryParse(txtNro.Text, out int idNoSocio))
            {
                MessageBox.Show("El Nro Cliente debe ser numérico", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDACIÓN: existencia del no socio
            if (!noSociosDAO.ExisteNoSocio(idNoSocio))
            {
                MessageBox.Show("Número de Cliente no socio inexistente.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // VALIDACIÓN: actividad seleccionada
            if (cboActividades.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una actividad.");
                return;
            }


            // se obtiene la actividad seleccionada por el usuario
            E_Actividad actividad = (E_Actividad)cboActividades.SelectedItem;

            // se visualizan los datos del no socio y la actividad elegida
            lblDatos.Text =
                noSociosDAO.ObtenerNombreNoSocio(idNoSocio).ToUpper() + "\n\n" +
                "ACTIVIDAD: " + actividad.nombreActividad + "\n\n" +
                "HORARIO: " + actividad.horaActividad + "\n\n" +
                "MONTO: $" + actividad.costoActividad.ToString("N2");

            // se centra el texto
            lblDatos.Top = (grpDatos.Height - lblDatos.Height) / 2;

            // Se habilitan los controles de pago
            grpFormaPago.Enabled = true;
            btnPagar.Enabled = true;


        }



        // Botón para ejecutar el pago de la actividad diaria
        private void btnPagar_Click(object sender, EventArgs e)
        {
            int idNoSocio = int.Parse(txtNro.Text);
            // El botón pagar solo se habilita si el ID es válido


            // VALIDACIÓN: método de pago debe estar seleccionado
            if (!optEfectivo.Checked && !optTarjeta.Checked)
            {
                MessageBox.Show("Debe ingresar un método de pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grpFormaPago.Focus();
                return;
            }

            // Se establece el método de pago y la cantidad de cuotas
            string formaPago = optEfectivo.Checked ? "Efectivo" : "TarjetaCredito";
            int cantCuotas = optTarjeta.Checked ? Convert.ToInt32(cboCantCuotas.SelectedItem) : 1;


            // Se obtiene nuevamente la actividad elegida por el cliente
            E_Actividad actividad = (E_Actividad)cboActividades.SelectedItem;
            int idActividad = actividad.idActividad;

            // VALIDACIÓN: el no socio no debe haber pagado esta misma actividad del día de hoy.
            if (cuotasDAO.PagoYaRegistradoHoy(idNoSocio, idActividad))
            {
                MessageBox.Show("Este cliente ya ha pagado esta actividad de hoy.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se ejecuta el pago de la actividad mediante DAO
            cuotasDAO.RegistrarPago(idNoSocio, actividad.idActividad, formaPago, actividad.costoActividad, cantCuotas);

            // Se actualiza el comprobante con los datos del pago
            doc.numero_f = idNoSocio;
            doc.noSocio_f = noSociosDAO.ObtenerNombreNoSocio(idNoSocio);
            doc.actividad_f = actividad.nombreActividad;
            doc.monto_f = actividad.costoActividad;
            doc.forma_f = formaPago;

            // Se muestra el mensaje de éxito
            MessageBox.Show("¡Pago exitoso! \n  Ya está disponible su comprobante de pago", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnComprobante.Enabled = true;
        }




        // -----------------------
        // BOTONES DE NAVEGACIÓN
        // -----------------------


        // Botón para ver el comprobante de pago
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();  // se muestra el formulario de comprobante
            this.Close(); // se cierra el actual
        }


        // Botón para volver al formulario principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // se busca si el formulario principal ya está abierto
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmPrincipal)
                {
                    frm.Show();// se muestra el fomulario principal original
                    break; 
                }
            }
            this.Hide(); // se oculta el formulario actual
        }


    }
}
