using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Datos;

namespace ProyectoIntegrador
{
    public partial class frmCarnetSocio : Form
    {

        /* ---  ATRIBUTOS  --- */
        // Variables para traer LOS DATOS del formulario 
        public int numero_c;
        public string? socio_c;
        public DateTime fechaInscripcion_c;
        public DateTime fechaVencimiento_c;


        /* ---  MÉTODOS  --- */
        // Constructor
        public frmCarnetSocio()
        {
            InitializeComponent();
        }


        //Evento de carga del formulario
        private void frmFactura_Load(object sender, EventArgs e)
        {
            // Se asigna el valor a los datos mostrados por las etiquetas del diseño
            lblSocio.Text = socio_c;                                               // nombre completo del socio
            lblNroSocio.Text = Convert.ToString(numero_c);                         // id del socio
            lblFechaInscripcion.Text = fechaInscripcion_c.ToShortDateString();    // fecha inscripcion del socio
            lblFechaVencimiento.Text = fechaVencimiento_c.ToShortDateString();    // fecha vencimiento 

        }


        // Se vuelve al formulario de Pago de Cuota Mensual
        private void btnVolver_Click(object sender, EventArgs e)
        {
            VolverAlFrmPagoOriginal();
        }



        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // se oculta el botón de impresión
            btnImprimir.Visible = false;

            try
            {
                // Se crean los objetos para la impresion 
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirFactura);
                pd.Print(); // se intenta imprimir


                // Si el proceso de impresión es exitoso
                // se muestra aviso de éxito y se regresa al formulario principal 
                this.Activate();
                this.TopMost = true; // asegurarse que msj no quede minimizado luego de la impresión
                MessageBox.Show(this, "Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TopMost = false;
                VolverAlFrmPagoOriginal();

            }
            catch (Exception ex)
            {
                // Si hay un error en el proceso de immpresión
                // se muestra mensaje de error
                MessageBox.Show("Error al imprimir: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Siempre se visualiza nuevamente el objeto
                btnImprimir.Visible = true;
            }

        }


        /* -------------------------------------------------------
        * Conjunto de sentencias necesarias parA el objeto Print
        * ------------------------------------------------------- */
        private void ImprimirFactura(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }



        // Método para volver al formulario de pago ORIGINAL
        private void VolverAlFrmPagoOriginal()
        {
            // se busca el formulario pagar cuota abierto
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmPagarCuota)
                {
                    // se muestra el frm pagar cuota ya abierto
                    // (con datos cargados y su comprobante de pago)
                    frm.Show();
                    break;
                }
            }
            this.Hide(); // se oculta el formulario actual 
        }



    }
}
