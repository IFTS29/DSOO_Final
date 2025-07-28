namespace ProyectoIntegrador
{
    partial class frmPagarCuota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloPago = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.grpFormaPago = new System.Windows.Forms.GroupBox();
            this.grpCantCuotas = new System.Windows.Forms.GroupBox();
            this.cboCantCuotas = new System.Windows.Forms.ComboBox();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCarnet = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpFormaPago.SuspendLayout();
            this.grpCantCuotas.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(48, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 32);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTituloPago
            // 
            this.lblTituloPago.AutoSize = true;
            this.lblTituloPago.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloPago.Location = new System.Drawing.Point(246, 63);
            this.lblTituloPago.Name = "lblTituloPago";
            this.lblTituloPago.Size = new System.Drawing.Size(256, 25);
            this.lblTituloPago.TabIndex = 1;
            this.lblTituloPago.Text = "PAGO DE CUOTA MENSUAL";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(122, 141);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(152, 20);
            this.lblNro.TabIndex = 2;
            this.lblNro.Text = "Ingrese Nro de Socio";
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(329, 138);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(111, 23);
            this.txtNro.TabIndex = 3;
            this.txtNro.TextChanged += new System.EventHandler(this.txtNro_TextChanged);
            // 
            // grpFormaPago
            // 
            this.grpFormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.grpFormaPago.Controls.Add(this.picLogo);
            this.grpFormaPago.Controls.Add(this.grpCantCuotas);
            this.grpFormaPago.Controls.Add(this.optTarjeta);
            this.grpFormaPago.Controls.Add(this.optEfectivo);
            this.grpFormaPago.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormaPago.Location = new System.Drawing.Point(112, 196);
            this.grpFormaPago.Name = "grpFormaPago";
            this.grpFormaPago.Size = new System.Drawing.Size(162, 253);
            this.grpFormaPago.TabIndex = 4;
            this.grpFormaPago.TabStop = false;
            this.grpFormaPago.Text = "Forma de Pago";
            // 
            // grpCantCuotas
            // 
            this.grpCantCuotas.Controls.Add(this.cboCantCuotas);
            this.grpCantCuotas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCantCuotas.Location = new System.Drawing.Point(6, 122);
            this.grpCantCuotas.Name = "grpCantCuotas";
            this.grpCantCuotas.Size = new System.Drawing.Size(140, 109);
            this.grpCantCuotas.TabIndex = 2;
            this.grpCantCuotas.TabStop = false;
            this.grpCantCuotas.Text = "Cantidad cuotas:";
            // 
            // cboCantCuotas
            // 
            this.cboCantCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCantCuotas.Enabled = false;
            this.cboCantCuotas.FormattingEnabled = true;
            this.cboCantCuotas.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCantCuotas.Location = new System.Drawing.Point(5, 35);
            this.cboCantCuotas.Name = "cboCantCuotas";
            this.cboCantCuotas.Size = new System.Drawing.Size(121, 28);
            this.cboCantCuotas.TabIndex = 0;
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTarjeta.Location = new System.Drawing.Point(12, 64);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(71, 24);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optEfectivo.Location = new System.Drawing.Point(11, 33);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(80, 24);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPagar.Enabled = false;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(450, 329);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(143, 52);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnComprobante.Enabled = false;
            this.btnComprobante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.Location = new System.Drawing.Point(450, 397);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(143, 52);
            this.btnComprobante.TabIndex = 6;
            this.btnComprobante.Text = "Comprobante";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(475, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 36);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblDatos);
            this.grpDatos.Location = new System.Drawing.Point(329, 175);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(264, 137);
            this.grpDatos.TabIndex = 8;
            this.grpDatos.TabStop = false;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(59, 63);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(140, 15);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "NO HAY DATOS DE PAGO";
            // 
            // btnCarnet
            // 
            this.btnCarnet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCarnet.Enabled = false;
            this.btnCarnet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarnet.Location = new System.Drawing.Point(301, 397);
            this.btnCarnet.Name = "btnCarnet";
            this.btnCarnet.Size = new System.Drawing.Size(143, 52);
            this.btnCarnet.TabIndex = 9;
            this.btnCarnet.Text = "Carnet";
            this.btnCarnet.UseVisualStyleBackColor = false;
            this.btnCarnet.Click += new System.EventHandler(this.btnCarnet_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ProyectoIntegrador.Properties.Resources.imgSport;
            this.picLogo.Location = new System.Drawing.Point(29, 208);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(89, 35);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 25;
            this.picLogo.TabStop = false;
            // 
            // frmPagarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 474);
            this.Controls.Add(this.btnCarnet);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.grpFormaPago);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.lblTituloPago);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPagarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGAR CUOTA";
            this.Load += new System.EventHandler(this.frmPagarCuota_Load);
            this.grpFormaPago.ResumeLayout(false);
            this.grpFormaPago.PerformLayout();
            this.grpCantCuotas.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTituloPago;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.GroupBox grpFormaPago;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.GroupBox grpCantCuotas;
        private System.Windows.Forms.ComboBox cboCantCuotas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCarnet;
    }
}