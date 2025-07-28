namespace ProyectoIntegrador
{
    partial class frmPrincipal
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
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnPagarActividad = new System.Windows.Forms.Button();
            this.btnPagarCuotaMensual = new System.Windows.Forms.Button();
            this.btnListados = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(26, 24);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(61, 17);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "USUARIO";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(310, 56);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(171, 25);
            this.lblTituloPrincipal.TabIndex = 1;
            this.lblTituloPrincipal.Text = "MENÚ PRINCIPAL";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(679, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInscribir.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.Location = new System.Drawing.Point(29, 141);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(244, 79);
            this.btnInscribir.TabIndex = 3;
            this.btnInscribir.Text = "Registrar  Cliente";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnPagarActividad
            // 
            this.btnPagarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.btnPagarActividad.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarActividad.Location = new System.Drawing.Point(504, 141);
            this.btnPagarActividad.Name = "btnPagarActividad";
            this.btnPagarActividad.Size = new System.Drawing.Size(244, 79);
            this.btnPagarActividad.TabIndex = 5;
            this.btnPagarActividad.Text = "Pagar Actividad Diaria";
            this.btnPagarActividad.UseVisualStyleBackColor = false;
            this.btnPagarActividad.Click += new System.EventHandler(this.btnPagarActividad_Click);
            // 
            // btnPagarCuotaMensual
            // 
            this.btnPagarCuotaMensual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.btnPagarCuotaMensual.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarCuotaMensual.Location = new System.Drawing.Point(29, 247);
            this.btnPagarCuotaMensual.Name = "btnPagarCuotaMensual";
            this.btnPagarCuotaMensual.Size = new System.Drawing.Size(244, 79);
            this.btnPagarCuotaMensual.TabIndex = 6;
            this.btnPagarCuotaMensual.Text = "Pagar Cuota Mensual";
            this.btnPagarCuotaMensual.UseVisualStyleBackColor = false;
            this.btnPagarCuotaMensual.Click += new System.EventHandler(this.btnPagarCuotaMensual_Click);
            // 
            // btnListados
            // 
            this.btnListados.BackColor = System.Drawing.Color.PeachPuff;
            this.btnListados.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListados.Location = new System.Drawing.Point(504, 247);
            this.btnListados.Name = "btnListados";
            this.btnListados.Size = new System.Drawing.Size(244, 79);
            this.btnListados.TabIndex = 7;
            this.btnListados.Text = "Generar listado \r\nde Vencimientos";
            this.btnListados.UseVisualStyleBackColor = false;
            this.btnListados.Click += new System.EventHandler(this.btnListados_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ProyectoIntegrador.Properties.Resources.imgSport;
            this.picLogo.Location = new System.Drawing.Point(15, 46);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(117, 47);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.imgFondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(774, 366);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnListados);
            this.Controls.Add(this.btnPagarCuotaMensual);
            this.Controls.Add(this.btnPagarActividad);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Controls.Add(this.lblIngreso);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLUB DEPORTIVO  -  MENÚ PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnPagarActividad;
        private System.Windows.Forms.Button btnPagarCuotaMensual;
        private System.Windows.Forms.Button btnListados;
        private System.Windows.Forms.PictureBox picLogo;
    }
}