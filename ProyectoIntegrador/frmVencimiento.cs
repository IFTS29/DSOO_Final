using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Datos;
using MySql.Data.MySqlClient;
using ProyectoIntegrador.Entidades;


namespace ProyectoIntegrador
{
    public partial class frmVencimiento : Form
    {

        private frmPrincipal principalOriginal;


        
        // Constructor
        public frmVencimiento()
        {
            InitializeComponent();
        }

        // Carga del formulario
        private void frmVencimiento_Load(object sender, EventArgs e)
        {
            lblDiaActual.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Fecha actual de vencimiento
            CargaGrilla(); //llamada al procedimiento
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
            this.Hide(); // se oculta el formulario actual (Vencimientos)
        }



        public void CargaGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                
                query = "select s.idSocio, c.Nombre,c.Apellido,c.TDoc,c.Doc,cm.fechaPago " +
                    "from socio s join cliente c on s.Doc = c.Doc " +
                    "join CuotaMensual cm on s.idSocio = cm.idSocio " +
                    "where cm.fechaVencimiento = curdate()";



                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvVencimiento.Rows.Add();
                        dtgvVencimiento.Rows[renglon].Cells[0].Value = reader.GetInt32(0);  // idSocio
                        dtgvVencimiento.Rows[renglon].Cells[1].Value = reader.GetString(1); // Nombre
                        dtgvVencimiento.Rows[renglon].Cells[2].Value = reader.GetString(2); // Apellido
                        dtgvVencimiento.Rows[renglon].Cells[3].Value = reader.GetString(3); // TDoc
                        dtgvVencimiento.Rows[renglon].Cells[4].Value = reader.GetInt32(4);  // Doc

                        // Estado del pago: PENDIENTE O PAGADO (según si fechaPago es null o no)
                        DateTime? fechaPago = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                        string estado = (fechaPago == null) ? "PENDIENTE" : "PAGADO";
                        dtgvVencimiento.Rows[renglon].Cells[5].Value = estado;

                        // Aplicar estilo según estado
                        DataGridViewCell celdaEstado = dtgvVencimiento.Rows[renglon].Cells[5];
                        celdaEstado.Style.ForeColor = (estado == "PAGADO") ? Color.Green : Color.Red;

                    }
                }
                else
                {
                    MessageBox.Show("NO HAY SOCIOS CON CUOTAS VENCIDAS \nEN EL DIA DE LA FECHA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar socios con cuotas vencidas: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }

        }
    }
}
