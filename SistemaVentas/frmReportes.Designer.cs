namespace SistemaVentas
{
    partial class frmReportes
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
            this.gbReporteVentas = new System.Windows.Forms.GroupBox();
            this.btnGenerarReporte1 = new System.Windows.Forms.Button();
            this.calendarioHasta1 = new System.Windows.Forms.DateTimePicker();
            this.calendarioDesde1 = new System.Windows.Forms.DateTimePicker();
            this.lblDesde1 = new System.Windows.Forms.Label();
            this.lblHasta1 = new System.Windows.Forms.Label();
            this.gbReporteClientesPagoPendiente = new System.Windows.Forms.GroupBox();
            this.lblReferencia2 = new System.Windows.Forms.Label();
            this.cbReferencia2 = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte2 = new System.Windows.Forms.Button();
            this.calendarioHasta2 = new System.Windows.Forms.DateTimePicker();
            this.calendarioDesde2 = new System.Windows.Forms.DateTimePicker();
            this.lblDesde2 = new System.Windows.Forms.Label();
            this.lblHasta2 = new System.Windows.Forms.Label();
            this.gbPaquetesEntregado = new System.Windows.Forms.GroupBox();
            this.rbDevueltos = new System.Windows.Forms.RadioButton();
            this.rbEntregados = new System.Windows.Forms.RadioButton();
            this.lblReferencia3 = new System.Windows.Forms.Label();
            this.cbReferencia3 = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte3 = new System.Windows.Forms.Button();
            this.calendarioHasta3 = new System.Windows.Forms.DateTimePicker();
            this.calendarioDesde3 = new System.Windows.Forms.DateTimePicker();
            this.lblDesde3 = new System.Windows.Forms.Label();
            this.lblHasta3 = new System.Windows.Forms.Label();
            this.gbReporteVentas.SuspendLayout();
            this.gbReporteClientesPagoPendiente.SuspendLayout();
            this.gbPaquetesEntregado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReporteVentas
            // 
            this.gbReporteVentas.BackColor = System.Drawing.Color.Transparent;
            this.gbReporteVentas.Controls.Add(this.btnGenerarReporte1);
            this.gbReporteVentas.Controls.Add(this.calendarioHasta1);
            this.gbReporteVentas.Controls.Add(this.calendarioDesde1);
            this.gbReporteVentas.Controls.Add(this.lblDesde1);
            this.gbReporteVentas.Controls.Add(this.lblHasta1);
            this.gbReporteVentas.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbReporteVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbReporteVentas.Location = new System.Drawing.Point(12, 12);
            this.gbReporteVentas.Name = "gbReporteVentas";
            this.gbReporteVentas.Size = new System.Drawing.Size(668, 78);
            this.gbReporteVentas.TabIndex = 7;
            this.gbReporteVentas.TabStop = false;
            this.gbReporteVentas.Text = "Reporte Ventas";
            // 
            // btnGenerarReporte1
            // 
            this.btnGenerarReporte1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarReporte1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerarReporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte1.Location = new System.Drawing.Point(528, 27);
            this.btnGenerarReporte1.Name = "btnGenerarReporte1";
            this.btnGenerarReporte1.Size = new System.Drawing.Size(86, 29);
            this.btnGenerarReporte1.TabIndex = 17;
            this.btnGenerarReporte1.Text = "Generar";
            this.btnGenerarReporte1.UseVisualStyleBackColor = false;
            this.btnGenerarReporte1.Click += new System.EventHandler(this.btnGenerarReporte1_Click);
            // 
            // calendarioHasta1
            // 
            this.calendarioHasta1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarioHasta1.Location = new System.Drawing.Point(314, 26);
            this.calendarioHasta1.Name = "calendarioHasta1";
            this.calendarioHasta1.Size = new System.Drawing.Size(134, 33);
            this.calendarioHasta1.TabIndex = 22;
            // 
            // calendarioDesde1
            // 
            this.calendarioDesde1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarioDesde1.Location = new System.Drawing.Point(88, 26);
            this.calendarioDesde1.Name = "calendarioDesde1";
            this.calendarioDesde1.Size = new System.Drawing.Size(145, 33);
            this.calendarioDesde1.TabIndex = 21;
            // 
            // lblDesde1
            // 
            this.lblDesde1.AutoSize = true;
            this.lblDesde1.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDesde1.Location = new System.Drawing.Point(17, 32);
            this.lblDesde1.Name = "lblDesde1";
            this.lblDesde1.Size = new System.Drawing.Size(65, 24);
            this.lblDesde1.TabIndex = 18;
            this.lblDesde1.Text = "Desde";
            // 
            // lblHasta1
            // 
            this.lblHasta1.AutoSize = true;
            this.lblHasta1.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHasta1.Location = new System.Drawing.Point(251, 32);
            this.lblHasta1.Name = "lblHasta1";
            this.lblHasta1.Size = new System.Drawing.Size(57, 24);
            this.lblHasta1.TabIndex = 19;
            this.lblHasta1.Text = "Hasta";
            // 
            // gbReporteClientesPagoPendiente
            // 
            this.gbReporteClientesPagoPendiente.BackColor = System.Drawing.Color.Transparent;
            this.gbReporteClientesPagoPendiente.Controls.Add(this.lblReferencia2);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.cbReferencia2);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.btnGenerarReporte2);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.calendarioHasta2);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.calendarioDesde2);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.lblDesde2);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.lblHasta2);
            this.gbReporteClientesPagoPendiente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbReporteClientesPagoPendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbReporteClientesPagoPendiente.Location = new System.Drawing.Point(12, 96);
            this.gbReporteClientesPagoPendiente.Name = "gbReporteClientesPagoPendiente";
            this.gbReporteClientesPagoPendiente.Size = new System.Drawing.Size(668, 127);
            this.gbReporteClientesPagoPendiente.TabIndex = 23;
            this.gbReporteClientesPagoPendiente.TabStop = false;
            this.gbReporteClientesPagoPendiente.Text = "Reporte Clientes pago pendiente";
            // 
            // lblReferencia2
            // 
            this.lblReferencia2.AutoSize = true;
            this.lblReferencia2.BackColor = System.Drawing.Color.Transparent;
            this.lblReferencia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblReferencia2.Location = new System.Drawing.Point(17, 75);
            this.lblReferencia2.Name = "lblReferencia2";
            this.lblReferencia2.Size = new System.Drawing.Size(101, 24);
            this.lblReferencia2.TabIndex = 24;
            this.lblReferencia2.Text = "Referencia";
            // 
            // cbReferencia2
            // 
            this.cbReferencia2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReferencia2.FormattingEnabled = true;
            this.cbReferencia2.Location = new System.Drawing.Point(124, 71);
            this.cbReferencia2.Name = "cbReferencia2";
            this.cbReferencia2.Size = new System.Drawing.Size(251, 34);
            this.cbReferencia2.TabIndex = 23;
            this.cbReferencia2.SelectedIndexChanged += new System.EventHandler(this.cbReferenciaReporte2_SelectedIndexChanged);
            // 
            // btnGenerarReporte2
            // 
            this.btnGenerarReporte2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarReporte2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerarReporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte2.Location = new System.Drawing.Point(528, 27);
            this.btnGenerarReporte2.Name = "btnGenerarReporte2";
            this.btnGenerarReporte2.Size = new System.Drawing.Size(86, 29);
            this.btnGenerarReporte2.TabIndex = 17;
            this.btnGenerarReporte2.Text = "Generar";
            this.btnGenerarReporte2.UseVisualStyleBackColor = false;
            this.btnGenerarReporte2.Click += new System.EventHandler(this.btnGenerarReporte2_Click);
            // 
            // calendarioHasta2
            // 
            this.calendarioHasta2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarioHasta2.Location = new System.Drawing.Point(314, 27);
            this.calendarioHasta2.Name = "calendarioHasta2";
            this.calendarioHasta2.Size = new System.Drawing.Size(134, 33);
            this.calendarioHasta2.TabIndex = 22;
            this.calendarioHasta2.ValueChanged += new System.EventHandler(this.CalendarioFechaHasta2_ValueChanged);
            // 
            // calendarioDesde2
            // 
            this.calendarioDesde2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarioDesde2.Location = new System.Drawing.Point(88, 26);
            this.calendarioDesde2.Name = "calendarioDesde2";
            this.calendarioDesde2.Size = new System.Drawing.Size(145, 33);
            this.calendarioDesde2.TabIndex = 21;
            // 
            // lblDesde2
            // 
            this.lblDesde2.AutoSize = true;
            this.lblDesde2.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDesde2.Location = new System.Drawing.Point(17, 32);
            this.lblDesde2.Name = "lblDesde2";
            this.lblDesde2.Size = new System.Drawing.Size(65, 24);
            this.lblDesde2.TabIndex = 18;
            this.lblDesde2.Text = "Desde";
            // 
            // lblHasta2
            // 
            this.lblHasta2.AutoSize = true;
            this.lblHasta2.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHasta2.Location = new System.Drawing.Point(251, 32);
            this.lblHasta2.Name = "lblHasta2";
            this.lblHasta2.Size = new System.Drawing.Size(57, 24);
            this.lblHasta2.TabIndex = 19;
            this.lblHasta2.Text = "Hasta";
            // 
            // gbPaquetesEntregado
            // 
            this.gbPaquetesEntregado.BackColor = System.Drawing.Color.Transparent;
            this.gbPaquetesEntregado.Controls.Add(this.rbDevueltos);
            this.gbPaquetesEntregado.Controls.Add(this.rbEntregados);
            this.gbPaquetesEntregado.Controls.Add(this.lblReferencia3);
            this.gbPaquetesEntregado.Controls.Add(this.cbReferencia3);
            this.gbPaquetesEntregado.Controls.Add(this.btnGenerarReporte3);
            this.gbPaquetesEntregado.Controls.Add(this.calendarioHasta3);
            this.gbPaquetesEntregado.Controls.Add(this.calendarioDesde3);
            this.gbPaquetesEntregado.Controls.Add(this.lblDesde3);
            this.gbPaquetesEntregado.Controls.Add(this.lblHasta3);
            this.gbPaquetesEntregado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbPaquetesEntregado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbPaquetesEntregado.Location = new System.Drawing.Point(12, 229);
            this.gbPaquetesEntregado.Name = "gbPaquetesEntregado";
            this.gbPaquetesEntregado.Size = new System.Drawing.Size(668, 114);
            this.gbPaquetesEntregado.TabIndex = 25;
            this.gbPaquetesEntregado.TabStop = false;
            this.gbPaquetesEntregado.Text = "Reporte Paquetes por Entregar";
            // 
            // rbDevueltos
            // 
            this.rbDevueltos.AutoSize = true;
            this.rbDevueltos.Location = new System.Drawing.Point(519, 72);
            this.rbDevueltos.Name = "rbDevueltos";
            this.rbDevueltos.Size = new System.Drawing.Size(120, 30);
            this.rbDevueltos.TabIndex = 26;
            this.rbDevueltos.Text = "Pendientes";
            this.rbDevueltos.UseVisualStyleBackColor = true;
            // 
            // rbEntregados
            // 
            this.rbEntregados.AutoSize = true;
            this.rbEntregados.Checked = true;
            this.rbEntregados.Location = new System.Drawing.Point(390, 72);
            this.rbEntregados.Name = "rbEntregados";
            this.rbEntregados.Size = new System.Drawing.Size(123, 30);
            this.rbEntregados.TabIndex = 25;
            this.rbEntregados.TabStop = true;
            this.rbEntregados.Text = "Entregados";
            this.rbEntregados.UseVisualStyleBackColor = true;
            // 
            // lblReferencia3
            // 
            this.lblReferencia3.AutoSize = true;
            this.lblReferencia3.BackColor = System.Drawing.Color.Transparent;
            this.lblReferencia3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblReferencia3.Location = new System.Drawing.Point(17, 75);
            this.lblReferencia3.Name = "lblReferencia3";
            this.lblReferencia3.Size = new System.Drawing.Size(101, 24);
            this.lblReferencia3.TabIndex = 24;
            this.lblReferencia3.Text = "Referencia";
            // 
            // cbReferencia3
            // 
            this.cbReferencia3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReferencia3.FormattingEnabled = true;
            this.cbReferencia3.Location = new System.Drawing.Point(124, 71);
            this.cbReferencia3.Name = "cbReferencia3";
            this.cbReferencia3.Size = new System.Drawing.Size(251, 34);
            this.cbReferencia3.TabIndex = 23;
            // 
            // btnGenerarReporte3
            // 
            this.btnGenerarReporte3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarReporte3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerarReporte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte3.Location = new System.Drawing.Point(528, 27);
            this.btnGenerarReporte3.Name = "btnGenerarReporte3";
            this.btnGenerarReporte3.Size = new System.Drawing.Size(86, 29);
            this.btnGenerarReporte3.TabIndex = 17;
            this.btnGenerarReporte3.Text = "Generar";
            this.btnGenerarReporte3.UseVisualStyleBackColor = false;
            this.btnGenerarReporte3.Click += new System.EventHandler(this.btnGenerarReporte3_Click);
            // 
            // calendarioHasta3
            // 
            this.calendarioHasta3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarioHasta3.Location = new System.Drawing.Point(314, 26);
            this.calendarioHasta3.Name = "calendarioHasta3";
            this.calendarioHasta3.Size = new System.Drawing.Size(134, 33);
            this.calendarioHasta3.TabIndex = 22;
            // 
            // calendarioDesde3
            // 
            this.calendarioDesde3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarioDesde3.Location = new System.Drawing.Point(88, 26);
            this.calendarioDesde3.Name = "calendarioDesde3";
            this.calendarioDesde3.Size = new System.Drawing.Size(145, 33);
            this.calendarioDesde3.TabIndex = 21;
            // 
            // lblDesde3
            // 
            this.lblDesde3.AutoSize = true;
            this.lblDesde3.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDesde3.Location = new System.Drawing.Point(17, 32);
            this.lblDesde3.Name = "lblDesde3";
            this.lblDesde3.Size = new System.Drawing.Size(65, 24);
            this.lblDesde3.TabIndex = 18;
            this.lblDesde3.Text = "Desde";
            // 
            // lblHasta3
            // 
            this.lblHasta3.AutoSize = true;
            this.lblHasta3.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHasta3.Location = new System.Drawing.Point(251, 32);
            this.lblHasta3.Name = "lblHasta3";
            this.lblHasta3.Size = new System.Drawing.Size(57, 24);
            this.lblHasta3.TabIndex = 19;
            this.lblHasta3.Text = "Hasta";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 359);
            this.Controls.Add(this.gbPaquetesEntregado);
            this.Controls.Add(this.gbReporteClientesPagoPendiente);
            this.Controls.Add(this.gbReporteVentas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.gbReporteVentas.ResumeLayout(false);
            this.gbReporteVentas.PerformLayout();
            this.gbReporteClientesPagoPendiente.ResumeLayout(false);
            this.gbReporteClientesPagoPendiente.PerformLayout();
            this.gbPaquetesEntregado.ResumeLayout(false);
            this.gbPaquetesEntregado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReporteVentas;
        private System.Windows.Forms.Label lblDesde1;
        private System.Windows.Forms.Label lblHasta1;
        private System.Windows.Forms.DateTimePicker calendarioHasta1;
        private System.Windows.Forms.DateTimePicker calendarioDesde1;
        private System.Windows.Forms.Button btnGenerarReporte1;
        private System.Windows.Forms.GroupBox gbReporteClientesPagoPendiente;
        private System.Windows.Forms.Button btnGenerarReporte2;
        private System.Windows.Forms.DateTimePicker calendarioHasta2;
        private System.Windows.Forms.DateTimePicker calendarioDesde2;
        private System.Windows.Forms.Label lblDesde2;
        private System.Windows.Forms.Label lblHasta2;
        private System.Windows.Forms.Label lblReferencia2;
        private System.Windows.Forms.ComboBox cbReferencia2;
        private System.Windows.Forms.GroupBox gbPaquetesEntregado;
        private System.Windows.Forms.Label lblReferencia3;
        private System.Windows.Forms.ComboBox cbReferencia3;
        private System.Windows.Forms.Button btnGenerarReporte3;
        private System.Windows.Forms.DateTimePicker calendarioHasta3;
        private System.Windows.Forms.DateTimePicker calendarioDesde3;
        private System.Windows.Forms.Label lblDesde3;
        private System.Windows.Forms.Label lblHasta3;
        private System.Windows.Forms.RadioButton rbDevueltos;
        private System.Windows.Forms.RadioButton rbEntregados;
    }
}