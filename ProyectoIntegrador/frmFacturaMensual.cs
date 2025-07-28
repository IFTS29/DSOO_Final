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



namespace ProyectoIntegrador
{
    public partial class frmFacturaMensual : Form
    {
        
        /* ---  ATRIBUTOS  --- */
        // Variables para traer LOS DATOS del formulario 
        public int numero_f; 
        public string? socio_f;
        public DateTime fechaInscripcion_f;
        public string? forma_f;
        public float monto_f;
      


        /* ---  MÉTODOS  --- */

        // Constructor
        public frmFacturaMensual()
        {
            InitializeComponent();
        }



        // Evento de carga del formulario
        private void frmFactura_Load(object sender, EventArgs e)
        {
            // Se asigna el valor a los datos mostrados por las etiquetas del diseño
            lblSocio.Text = socio_f;                                      // nombre completo del socio
            lblNroSocio.Text = Convert.ToString(numero_f);                // id del socio
            lblFechaInsc.Text = fechaInscripcion_f.ToShortDateString();   // fecha isncripcion del socio
            lblFechaActual.Text = DateTime.Now.ToShortDateString();       // fecha de actual 
            lblFechaPago.Text = DateTime.Now.ToShortDateString();         // fecha de pago
            lblFormaPago.Text = forma_f;                                  // forma de pago
            lblValor.Text = Convert.ToString(monto_f);                    // valor del monto a pagar   
        }


        // Se vuelve al formulario de Pago de Cuota original
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
                // se muestra aviso de éxito y se regresa al formulario de pago original 
                this.Activate();
                this.TopMost = true; // asegurarse que msj no quede minimizado luego de la impresión
                MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VolverAlFrmPagoOriginal();
                this.TopMost = false;

            }
            catch (Exception ex)
            {
                // Si hay un error en el proceso de immpresión
                // se muestra mensaje de error
                MessageBox.Show(this, "Error al imprimir: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // (con datos del socio y su cuota cargados)
                    frm.Show();
                    break;
                }
            }
            this.Hide(); // se oculta el formulario actual 
        }



    }
}
