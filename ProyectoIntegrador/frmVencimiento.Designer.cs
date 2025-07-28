namespace ProyectoIntegrador
{
    partial class frmVencimiento
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
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.dtgvVencimiento = new System.Windows.Forms.DataGridView();
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActual = new System.Windows.Forms.Label();
            this.lblDiaActual = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.picLogoVencimientos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVencimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVencimiento.Location = new System.Drawing.Point(261, 97);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(229, 25);
            this.lblVencimiento.TabIndex = 0;
            this.lblVencimiento.Text = "VENCIMIENTOS DEL DÍA";
            // 
            // dtgvVencimiento
            // 
            this.dtgvVencimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVencimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocio,
            this.Nombre,
            this.Apellido,
            this.TDoc,
            this.Doc,
            this.estadoPago});
            this.dtgvVencimiento.Location = new System.Drawing.Point(45, 188);
            this.dtgvVencimiento.Name = "dtgvVencimiento";
            this.dtgvVencimiento.Size = new System.Drawing.Size(663, 233);
            this.dtgvVencimiento.TabIndex = 1;
            // 
            // idSocio
            // 
            this.idSocio.HeaderText = "Nro. Socio";
            this.idSocio.Name = "idSocio";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // TDoc
            // 
            this.TDoc.HeaderText = "Tipo doc.";
            this.TDoc.Name = "TDoc";
            // 
            // Doc
            // 
            this.Doc.HeaderText = "Nro doc.";
            this.Doc.Name = "Doc";
            // 
            // estadoPago
            // 
            this.estadoPago.HeaderText = "Estado del pago";
            this.estadoPago.Name = "estadoPago";
            this.estadoPago.Width = 120;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.ForeColor = System.Drawing.Color.Black;
            this.lblActual.Location = new System.Drawing.Point(303, 134);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(56, 21);
            this.lblActual.TabIndex = 2;
            this.lblActual.Text = "Fecha:";
            // 
            // lblDiaActual
            // 
            this.lblDiaActual.AutoSize = true;
            this.lblDiaActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaActual.ForeColor = System.Drawing.Color.Black;
            this.lblDiaActual.Location = new System.Drawing.Point(357, 135);
            this.lblDiaActual.Name = "lblDiaActual";
            this.lblDiaActual.Size = new System.Drawing.Size(79, 21);
            this.lblDiaActual.TabIndex = 3;
            this.lblDiaActual.Text = "día actual";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(45, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 32);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // picLogoVencimientos
            // 
            this.picLogoVencimientos.Image = global::ProyectoIntegrador.Properties.Resources.imgSport;
            this.picLogoVencimientos.Location = new System.Drawing.Point(619, 23);
            this.picLogoVencimientos.Name = "picLogoVencimientos";
            this.picLogoVencimientos.Size = new System.Drawing.Size(119, 41);
            this.picLogoVencimientos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoVencimientos.TabIndex = 25;
            this.picLogoVencimientos.TabStop = false;
            // 
            // frmVencimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 454);
            this.Controls.Add(this.picLogoVencimientos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDiaActual);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.dtgvVencimiento);
            this.Controls.Add(this.lblVencimiento);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "frmVencimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO DE VENCIMIENTOS";
            this.Load += new System.EventHandler(this.frmVencimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoVencimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.DataGridView dtgvVencimiento;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblDiaActual;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPago;
        private System.Windows.Forms.PictureBox picLogoVencimientos;
    }
}