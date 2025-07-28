using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Entidades;
using ProyectoIntegrador.Auxiliares;

namespace ProyectoIntegrador
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + Sesion.Usuario + " (" + Sesion.Rol + ")";
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            /* Se cierra completamente la aplicación */
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Show(); // se abre el formulario de registro del cliente
            this.Hide(); // se oculta el formulario principal
        }

        private void btnPagarActividad_Click(object sender, EventArgs e)
        {
            frmPagarActDiaria pagoActDiaria = new frmPagarActDiaria();
            pagoActDiaria.Show(); // se abre el formulario de pago de actividad diaria
            this.Hide(); // se oculta el formulario principal
        }

        private void btnPagarCuotaMensual_Click(object sender, EventArgs e)
        {
            frmPagarCuota pagoCuotaMensual = new frmPagarCuota();
            pagoCuotaMensual.Show(); // se abre el formulario de pago de cuota
            this.Hide(); // se oculta el formulario principal
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            frmVencimiento vencimiento = new frmVencimiento();
            vencimiento.Show(); // se abre el formulario de vencimientos del día
            this.Hide(); // se oculta el formulario principal
        }

        
    }
}
