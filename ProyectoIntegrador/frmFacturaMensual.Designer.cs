namespace ProyectoIntegrador
{
    partial class frmFacturaMensual
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblFechaInsc = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.pnlEncabez = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFPago = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblFInsc = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblClub = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pnlEncabez.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(543, 534);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 44);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(39, 46);
            this.lblSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(172, 17);
            this.lblSocio.TabIndex = 1;
            this.lblSocio.Text = "NOMBRE APELLIDO SOCIO";
            // 
            // lblFechaInsc
            // 
            this.lblFechaInsc.AutoSize = true;
            this.lblFechaInsc.Location = new System.Drawing.Point(198, 125);
            this.lblFechaInsc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInsc.Name = "lblFechaInsc";
            this.lblFechaInsc.Size = new System.Drawing.Size(103, 15);
            this.lblFechaInsc.TabIndex = 2;
            this.lblFechaInsc.Text = "Fecha inscripcion";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(490, 210);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 15);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "VALOR";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(198, 210);
            this.lblFormaPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(91, 15);
            this.lblFormaPago.TabIndex = 4;
            this.lblFormaPago.Text = "Forma de pago";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.Location = new System.Drawing.Point(199, 15);
            this.lblFechaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(80, 17);
            this.lblFechaActual.TabIndex = 5;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // pnlEncabez
            // 
            this.pnlEncabez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlEncabez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabez.Controls.Add(this.lblEncabezado);
            this.pnlEncabez.Location = new System.Drawing.Point(49, 81);
            this.pnlEncabez.Name = "pnlEncabez";
            this.pnlEncabez.Size = new System.Drawing.Size(604, 49);
            this.pnlEncabez.TabIndex = 7;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(185, 9);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(233, 25);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "COMPROBANTE de PAGO";
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.pnlDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDerecho.Controls.Add(this.lblDatos);
            this.pnlDerecho.Controls.Add(this.lblFechaActual);
            this.pnlDerecho.Location = new System.Drawing.Point(351, 130);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(302, 84);
            this.pnlDerecho.TabIndex = 9;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(19, 52);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(269, 17);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "DATOS GENERALES DEL PAGO DE LA CUOTA ";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.lblNroSocio);
            this.pnlDatos.Controls.Add(this.lblMonto);
            this.pnlDatos.Controls.Add(this.lblFPago);
            this.pnlDatos.Controls.Add(this.lblFechaPago);
            this.pnlDatos.Controls.Add(this.lblMetodoPago);
            this.pnlDatos.Controls.Add(this.lblNro);
            this.pnlDatos.Controls.Add(this.lblFInsc);
            this.pnlDatos.Controls.Add(this.lblSocio);
            this.pnlDatos.Controls.Add(this.lblFechaInsc);
            this.pnlDatos.Controls.Add(this.lblValor);
            this.pnlDatos.Controls.Add(this.lblFormaPago);
            this.pnlDatos.Location = new System.Drawing.Point(49, 214);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(604, 300);
            this.pnlDatos.TabIndex = 10;
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Location = new System.Drawing.Point(198, 87);
            this.lblNroSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(101, 15);
            this.lblNroSocio.TabIndex = 10;
            this.lblNroSocio.Text = "Numero de socio";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(401, 210);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(58, 15);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "Monto: $ ";
            // 
            // lblFPago
            // 
            this.lblFPago.AutoSize = true;
            this.lblFPago.Location = new System.Drawing.Point(39, 166);
            this.lblFPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFPago.Name = "lblFPago";
            this.lblFPago.Size = new System.Drawing.Size(92, 15);
            this.lblFPago.TabIndex = 8;
            this.lblFPago.Text = "Fecha de pago:";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(198, 167);
            this.lblFechaPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(84, 15);
            this.lblFechaPago.TabIndex = 7;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(39, 210);
            this.lblMetodoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(98, 15);
            this.lblMetodoPago.TabIndex = 5;
            this.lblMetodoPago.Text = "Forma de Pago: ";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(39, 87);
            this.lblNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(106, 15);
            this.lblNro.TabIndex = 4;
            this.lblNro.Text = "Número de Socio:";
            // 
            // lblFInsc
            // 
            this.lblFInsc.AutoSize = true;
            this.lblFInsc.Location = new System.Drawing.Point(39, 125);
            this.lblFInsc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFInsc.Name = "lblFInsc";
            this.lblFInsc.Size = new System.Drawing.Size(126, 15);
            this.lblFInsc.TabIndex = 3;
            this.lblFInsc.Text = "Fecha de inscripción: ";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(29, 23);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 32);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(14, 31);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(135, 21);
            this.lblClub.TabIndex = 0;
            this.lblClub.Text = "CLUB DEPORTIVO";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ProyectoIntegrador.Properties.Resources.imgSport;
            this.picLogo.Location = new System.Drawing.Point(155, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(133, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.pnlIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIzquierdo.Controls.Add(this.picLogo);
            this.pnlIzquierdo.Controls.Add(this.lblClub);
            this.pnlIzquierdo.Location = new System.Drawing.Point(49, 130);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(302, 84);
            this.pnlIzquierdo.TabIndex = 8;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 602);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlEncabez);
            this.Controls.Add(this.btnImprimir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPROBANTE  DE  PAGO";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.pnlEncabez.ResumeLayout(false);
            this.pnlEncabez.PerformLayout();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblFechaInsc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Panel pnlEncabez;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblFInsc;
        private System.Windows.Forms.Label lblFPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlIzquierdo;
    }
}