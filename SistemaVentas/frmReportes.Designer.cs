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
            this.gbReporteClientesPagoPendiente = new System.Windows.Forms.GroupBox();
            this.cbReferencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBusquedaCliente = new System.Windows.Forms.ComboBox();
            this.btnNoIncluirProducto = new System.Windows.Forms.Button();
            this.dgReporte = new System.Windows.Forms.DataGridView();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.cbTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnGenerarReporte2 = new System.Windows.Forms.Button();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde2 = new System.Windows.Forms.Label();
            this.lblHasta2 = new System.Windows.Forms.Label();
            this.gbReporteClientesPagoPendiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReporteClientesPagoPendiente
            // 
            this.gbReporteClientesPagoPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReporteClientesPagoPendiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbReporteClientesPagoPendiente.BackColor = System.Drawing.Color.Transparent;
            this.gbReporteClientesPagoPendiente.Controls.Add(this.cbReferencia);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.label1);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.cbBusquedaCliente);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.btnNoIncluirProducto);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.dgReporte);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.lblTipoReporte);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.cbTipoReporte);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.lblCliente);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.btnGenerarReporte2);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.fechaHasta);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.fechaDesde);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.lblDesde2);
            this.gbReporteClientesPagoPendiente.Controls.Add(this.lblHasta2);
            this.gbReporteClientesPagoPendiente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbReporteClientesPagoPendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbReporteClientesPagoPendiente.Location = new System.Drawing.Point(13, 13);
            this.gbReporteClientesPagoPendiente.Margin = new System.Windows.Forms.Padding(4);
            this.gbReporteClientesPagoPendiente.Name = "gbReporteClientesPagoPendiente";
            this.gbReporteClientesPagoPendiente.Padding = new System.Windows.Forms.Padding(4);
            this.gbReporteClientesPagoPendiente.Size = new System.Drawing.Size(1233, 705);
            this.gbReporteClientesPagoPendiente.TabIndex = 23;
            this.gbReporteClientesPagoPendiente.TabStop = false;
            this.gbReporteClientesPagoPendiente.Text = "Reportes";
            // 
            // cbReferencia
            // 
            this.cbReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReferencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbReferencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReferencia.FormattingEnabled = true;
            this.cbReferencia.Location = new System.Drawing.Point(148, 163);
            this.cbReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.cbReferencia.Name = "cbReferencia";
            this.cbReferencia.Size = new System.Drawing.Size(1075, 40);
            this.cbReferencia.TabIndex = 63;
            this.cbReferencia.SelectedIndexChanged += new System.EventHandler(this.cbClienteBusqueda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Referencia: ";
            // 
            // cbBusquedaCliente
            // 
            this.cbBusquedaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBusquedaCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBusquedaCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBusquedaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBusquedaCliente.FormattingEnabled = true;
            this.cbBusquedaCliente.Location = new System.Drawing.Point(14, 114);
            this.cbBusquedaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbBusquedaCliente.Name = "cbBusquedaCliente";
            this.cbBusquedaCliente.Size = new System.Drawing.Size(436, 40);
            this.cbBusquedaCliente.TabIndex = 61;
            this.cbBusquedaCliente.SelectedIndexChanged += new System.EventHandler(this.cbClienteBusqueda_SelectedIndexChanged);
            // 
            // btnNoIncluirProducto
            // 
            this.btnNoIncluirProducto.AutoSize = true;
            this.btnNoIncluirProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnNoIncluirProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoIncluirProducto.FlatAppearance.BorderSize = 0;
            this.btnNoIncluirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoIncluirProducto.Image = global::SistemaVentas.Properties.Resources.buscar;
            this.btnNoIncluirProducto.Location = new System.Drawing.Point(567, 41);
            this.btnNoIncluirProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoIncluirProducto.Name = "btnNoIncluirProducto";
            this.btnNoIncluirProducto.Size = new System.Drawing.Size(37, 37);
            this.btnNoIncluirProducto.TabIndex = 60;
            this.btnNoIncluirProducto.UseMnemonic = false;
            this.btnNoIncluirProducto.UseVisualStyleBackColor = false;
            // 
            // dgReporte
            // 
            this.dgReporte.AllowUserToAddRows = false;
            this.dgReporte.AllowUserToDeleteRows = false;
            this.dgReporte.AllowUserToOrderColumns = true;
            this.dgReporte.AllowUserToResizeColumns = false;
            this.dgReporte.AllowUserToResizeRows = false;
            this.dgReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgReporte.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgReporte.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgReporte.GridColor = System.Drawing.Color.White;
            this.dgReporte.Location = new System.Drawing.Point(8, 211);
            this.dgReporte.Margin = new System.Windows.Forms.Padding(4);
            this.dgReporte.MultiSelect = false;
            this.dgReporte.Name = "dgReporte";
            this.dgReporte.RowHeadersVisible = false;
            this.dgReporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReporte.ShowCellToolTips = false;
            this.dgReporte.ShowEditingIcon = false;
            this.dgReporte.ShowRowErrors = false;
            this.dgReporte.Size = new System.Drawing.Size(1215, 486);
            this.dgReporte.TabIndex = 42;
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTipoReporte.Location = new System.Drawing.Point(514, 81);
            this.lblTipoReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(156, 29);
            this.lblTipoReporte.TabIndex = 26;
            this.lblTipoReporte.Text = "Tipo Reporte";
            // 
            // cbTipoReporte
            // 
            this.cbTipoReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoReporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoReporte.FormattingEnabled = true;
            this.cbTipoReporte.Items.AddRange(new object[] {
            "Reporte de Pagos pendientes",
            "Reporte de Pagos recibidos",
            "Reporte de Productos entregados",
            "Reporte de Ventas realizadas"});
            this.cbTipoReporte.Location = new System.Drawing.Point(519, 114);
            this.cbTipoReporte.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoReporte.Name = "cbTipoReporte";
            this.cbTipoReporte.Size = new System.Drawing.Size(700, 40);
            this.cbTipoReporte.TabIndex = 25;
            this.cbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cbTipoReporte_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCliente.Location = new System.Drawing.Point(8, 81);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(89, 29);
            this.lblCliente.TabIndex = 24;
            this.lblCliente.Text = "Cliente";
            // 
            // btnGenerarReporte2
            // 
            this.btnGenerarReporte2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarReporte2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarReporte2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerarReporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte2.Location = new System.Drawing.Point(1108, 43);
            this.btnGenerarReporte2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarReporte2.Name = "btnGenerarReporte2";
            this.btnGenerarReporte2.Size = new System.Drawing.Size(115, 36);
            this.btnGenerarReporte2.TabIndex = 17;
            this.btnGenerarReporte2.Text = "Generar";
            this.btnGenerarReporte2.UseVisualStyleBackColor = false;
            this.btnGenerarReporte2.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // fechaHasta
            // 
            this.fechaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHasta.Location = new System.Drawing.Point(382, 38);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(177, 40);
            this.fechaHasta.TabIndex = 22;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesde.Location = new System.Drawing.Point(100, 35);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(192, 40);
            this.fechaDesde.TabIndex = 21;
            // 
            // lblDesde2
            // 
            this.lblDesde2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesde2.AutoSize = true;
            this.lblDesde2.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDesde2.Location = new System.Drawing.Point(8, 43);
            this.lblDesde2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde2.Name = "lblDesde2";
            this.lblDesde2.Size = new System.Drawing.Size(84, 29);
            this.lblDesde2.TabIndex = 18;
            this.lblDesde2.Text = "Desde";
            // 
            // lblHasta2
            // 
            this.lblHasta2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHasta2.AutoSize = true;
            this.lblHasta2.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHasta2.Location = new System.Drawing.Point(300, 41);
            this.lblHasta2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta2.Name = "lblHasta2";
            this.lblHasta2.Size = new System.Drawing.Size(74, 29);
            this.lblHasta2.TabIndex = 19;
            this.lblHasta2.Text = "Hasta";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 731);
            this.Controls.Add(this.gbReporteClientesPagoPendiente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmReportes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.gbReporteClientesPagoPendiente.ResumeLayout(false);
            this.gbReporteClientesPagoPendiente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbReporteClientesPagoPendiente;
        private System.Windows.Forms.Button btnGenerarReporte2;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Label lblDesde2;
        private System.Windows.Forms.Label lblHasta2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.DataGridView dgReporte;
        private System.Windows.Forms.Button btnNoIncluirProducto;
        private System.Windows.Forms.ComboBox cbBusquedaCliente;
        private System.Windows.Forms.ComboBox cbTipoReporte;
        private System.Windows.Forms.ComboBox cbReferencia;
        private System.Windows.Forms.Label label1;
    }
}