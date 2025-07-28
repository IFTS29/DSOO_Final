using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Entidades;



namespace ProyectoIntegrador
{
    public partial class frmPagarCuota : Form
    {
        // -----------------------------
        // VARIABLES Y CONSTRUCTOR
        // -----------------------------

        // Instancia del formulario de comprobante (factura)
        public frmFacturaMensual doc = new frmFacturaMensual();
        public frmCarnetSocio carnet = new frmCarnetSocio();

        // Objetos DAO para acceder a las cuotas y socios desde la base de datos
        private CuotasMensuales cuotasDAO = new CuotasMensuales();
        private Socios sociosDAO = new Socios();

        // Constructor del formulario
        public frmPagarCuota()
        {
            InitializeComponent();
        }



        // -----------------------------------------
        // EVENTO DE CARGA Y CONFIGURACIÓN INICIAL
        // -----------------------------------------

        // Evento que se dispara al cargarse el formulario
        private void frmPagarCuota_Load(object sender, EventArgs e)
        {
            // inicializa el combo de cant de cuotas en 1
            cboCantCuotas.SelectedIndex = 0; 
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
            // Si la interfaz muestra un estado distinto al inicial
            // (Ej. botón de pagar activo)
            if (btnPagar.Enabled)
            {
                // se la reinicia a su estado inicial por defecto.
                btnPagar.Enabled = false;
                lblDatos.Text = "NO HAY DATOS DE PAGO";
                lblDatos.Top = (grpDatos.Height - lblDatos.Height) / 2;
                grpFormaPago.Enabled = false;
                optEfectivo.Checked = false;
                optTarjeta.Checked = false;
                cboCantCuotas.SelectedIndex = 0;
                btnComprobante.Enabled = false;
                btnCarnet.Enabled = false;

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
                MessageBox.Show("Debe ingresar un número de socio.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDACIÓN: campo Nro de socio es numérico
            if (!int.TryParse(txtNro.Text, out int idSocio))
            {
                MessageBox.Show("El número de socio debe ser un valor numérico", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDACIÓN: existencia del socio
            if (!sociosDAO.ExisteSocio(idSocio)) // LLAMA AL MÉTODO DE LA CLASE SOCIOS
            {
                MessageBox.Show("Número de Socio inexistente.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Se actualiza la información visual
            ActualizarLabelDatos(idSocio);

            // Se habilitan los controles de pago
            grpFormaPago.Enabled = true; 
             btnPagar.Enabled = true;
                
        }



        // Botón para ejecutar el pago de la cuota mensual
        private void btnPagar_Click(object sender, EventArgs e)
        {
         
            int idSocio = int.Parse(txtNro.Text);
            // El botón pagar solo se habilita si el ID es válido

            // Se obtiene nuevamente la cuota con vencimiento igual o anterior al día actual
            E_CuotaMensual cuota = cuotasDAO.ObtenerCuotaVencida(idSocio);

            // VALIDACIÓN: la cuota debe estar vencida y sin pagar
            if (cuota == null || cuota.fechaPago != null)
            {
                MessageBox.Show("El socio no tiene cuotas vencidas pendientes de pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // VALIDACIÓN: método de pago debe estar seleccionado
            if (!optEfectivo.Checked && !optTarjeta.Checked)
            {
                MessageBox.Show("Debe ingresar un método de pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grpFormaPago.Focus();
                return;
            }

            // Se establece el método de pago y la cantidad de cuotas
            int cantCuotas = 1;
            string formaPago = "";
            if (optEfectivo.Checked)
            {
                formaPago = "Efectivo";
            }
            else
            {
                formaPago = "TarjetaCredito";
                cantCuotas = Convert.ToInt32(cboCantCuotas.SelectedItem);
            }

            // Se ejecuta el pago y se retorna la nueva fecha de vencimiento
            DateTime nuevaFechaVencimiento = cuotasDAO.PagarCuota(cuota, formaPago, cantCuotas);

            // Se actualizan los datos del comprobante
            doc.numero_f = idSocio;
            doc.socio_f = sociosDAO.ObtenerNombreSocio(idSocio).ToUpper();
            doc.fechaInscripcion_f = DateTime.Now; 
            doc.monto_f = Convert.ToSingle(cuota.montoCuota);
            doc.forma_f = formaPago;

            // Se actualizan los datos del carnet
            carnet.numero_c = idSocio;
            carnet.socio_c = sociosDAO.ObtenerNombreSocio(idSocio).ToUpper();
            carnet.fechaInscripcion_c = sociosDAO.ObtenerFechaInscripcion(idSocio);
            carnet.fechaVencimiento_c = nuevaFechaVencimiento;

            // Se actualiza el carnet de socio como entregado/true
            // (inicialmente al registrarse el socio se setea como false por default)
            sociosDAO.EntregarCarnet(idSocio);

            // Se muestra el mensaje de éxito
            MessageBox.Show("¡Pago exitoso! \nYa está disponible su Comprobante de Pago \ny su Carnet de Socio", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Se actualiza la información visual
            ActualizarLabelDatos(idSocio);

            // Se habilitan botones para ver comprobante y carnet
            btnComprobante.Enabled = true;
            btnCarnet.Enabled = true;
        }




        // -----------------------
        // BOTONES DE NAVEGACIÓN
        // -----------------------

        // BOTÓN para ver el comprobante de pago
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();  // se muestra el formulario de comprobante
            this.Hide(); // se oculta el actual
        }


        // BOTÓN para ver el carnet del socio
        private void btnCarnet_Click(object sender, EventArgs e)
        {
            carnet.Show();  // se muestra el formulario de comprobante
            this.Hide(); // se oculta el actual
        }


        // BOTÓN para volver al formulario principal
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





        // -----------------------------------
        // MÉTODO PRIVADO PARA ACTUALIZAR DATOS
        // -----------------------------------

        private void ActualizarLabelDatos(int idSocio)
        {
            // Se obtiene la cuota vencida (vencimiento hoy o anterior, esté o no pagada)
            E_CuotaMensual cuota = cuotasDAO.ObtenerCuotaVencida(idSocio);

            // Si existe una cuota que cumple
            if (cuota != null)
            {
                // variables locales para mostrar en pantalla
                string estado = (cuota.fechaPago == null) ? "PENDIENTE" : "PAGADO";
                string fechaVencimiento = cuota.fechaVencimiento.ToString("dd/MM/yyyy");

                // Se visualizan los datos en la etiqueta
                lblDatos.Text =
                    sociosDAO.ObtenerNombreSocio(idSocio).ToUpper() + "\n\n" +
                    "VENCIMIENTO CUOTA: " + fechaVencimiento + "\n\n" +
                    "ESTADO: " + estado + "\n\n" +
                    "MONTO: $" + cuota.montoCuota.ToString("N2");

                // Se centra el texto verticalmente en el grupo
                lblDatos.Top = (grpDatos.Height - lblDatos.Height) / 2;
            }
        }



    }
}
