namespace SistemaVentas
{
    partial class frmVenta
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.btnDevolverProducto = new System.Windows.Forms.Button();
            this.dgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubtotalVenta = new System.Windows.Forms.TextBox();
            this.cbBusquedaClienteVenta = new System.Windows.Forms.ComboBox();
            this.rbPorClienteFecha = new System.Windows.Forms.RadioButton();
            this.rbPorFecha = new System.Windows.Forms.RadioButton();
            this.rbPorCliente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.lbVenta = new System.Windows.Forms.ListBox();
            this.gbVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).BeginInit();
            this.gbListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCliente.Location = new System.Drawing.Point(25, 34);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(90, 32);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // calendario
            // 
            this.calendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.calendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendario.Location = new System.Drawing.Point(160, 78);
            this.calendario.Margin = new System.Windows.Forms.Padding(4);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(532, 40);
            this.calendario.TabIndex = 3;
            this.calendario.ValueChanged += new System.EventHandler(this.calendario_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha";
            // 
            // gbVenta
            // 
            this.gbVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbVenta.BackColor = System.Drawing.Color.Transparent;
            this.gbVenta.Controls.Add(this.btnDevolverProducto);
            this.gbVenta.Controls.Add(this.dgDetalleVenta);
            this.gbVenta.Controls.Add(this.btnModificar);
            this.gbVenta.Controls.Add(this.btnGuardar);
            this.gbVenta.Controls.Add(this.label5);
            this.gbVenta.Controls.Add(this.cbEstado);
            this.gbVenta.Controls.Add(this.label3);
            this.gbVenta.Controls.Add(this.txtSubtotalVenta);
            this.gbVenta.Controls.Add(this.cbBusquedaClienteVenta);
            this.gbVenta.Controls.Add(this.rbPorClienteFecha);
            this.gbVenta.Controls.Add(this.rbPorFecha);
            this.gbVenta.Controls.Add(this.rbPorCliente);
            this.gbVenta.Controls.Add(this.label2);
            this.gbVenta.Controls.Add(this.label1);
            this.gbVenta.Controls.Add(this.calendario);
            this.gbVenta.Controls.Add(this.lblCliente);
            this.gbVenta.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbVenta.Location = new System.Drawing.Point(16, 15);
            this.gbVenta.Margin = new System.Windows.Forms.Padding(4);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Padding = new System.Windows.Forms.Padding(4);
            this.gbVenta.Size = new System.Drawing.Size(961, 701);
            this.gbVenta.TabIndex = 5;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Venta";
            // 
            // btnDevolverProducto
            // 
            this.btnDevolverProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolverProducto.AutoSize = true;
            this.btnDevolverProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnDevolverProducto.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.btnDevolverProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevolverProducto.FlatAppearance.BorderSize = 0;
            this.btnDevolverProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverProducto.Image = global::SistemaVentas.Properties.Resources.uncheck;
            this.btnDevolverProducto.Location = new System.Drawing.Point(921, 184);
            this.btnDevolverProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolverProducto.Name = "btnDevolverProducto";
            this.btnDevolverProducto.Size = new System.Drawing.Size(32, 30);
            this.btnDevolverProducto.TabIndex = 60;
            this.btnDevolverProducto.UseMnemonic = false;
            this.btnDevolverProducto.UseVisualStyleBackColor = false;
            this.btnDevolverProducto.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dgDetalleVenta
            // 
            this.dgDetalleVenta.AllowUserToAddRows = false;
            this.dgDetalleVenta.AllowUserToDeleteRows = false;
            this.dgDetalleVenta.AllowUserToResizeColumns = false;
            this.dgDetalleVenta.AllowUserToResizeRows = false;
            this.dgDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgDetalleVenta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgDetalleVenta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Color,
            this.Tamano,
            this.Cantidad,
            this.Precio,
            this.Total,
            this.Observacion});
            this.dgDetalleVenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgDetalleVenta.GridColor = System.Drawing.Color.White;
            this.dgDetalleVenta.Location = new System.Drawing.Point(32, 222);
            this.dgDetalleVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetalleVenta.MultiSelect = false;
            this.dgDetalleVenta.Name = "dgDetalleVenta";
            this.dgDetalleVenta.ReadOnly = true;
            this.dgDetalleVenta.RowHeadersVisible = false;
            this.dgDetalleVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalleVenta.ShowCellToolTips = false;
            this.dgDetalleVenta.ShowEditingIcon = false;
            this.dgDetalleVenta.ShowRowErrors = false;
            this.dgDetalleVenta.Size = new System.Drawing.Size(921, 431);
            this.dgDetalleVenta.TabIndex = 62;
            this.dgDetalleVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleVenta_CellEndEdit);
            this.dgDetalleVenta.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleVenta_CellEnter);
            this.dgDetalleVenta.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgDetallePaquete_EditingControlShowing);
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Producto.Width = 118;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Color.Width = 79;
            // 
            // Tamano
            // 
            this.Tamano.DataPropertyName = "Tamano";
            this.Tamano.HeaderText = "Tamano";
            this.Tamano.Name = "Tamano";
            this.Tamano.ReadOnly = true;
            this.Tamano.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tamano.Width = 104;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 118;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 87;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 74;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Observacion.Width = 151;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(-4, 661);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 36);
            this.btnModificar.TabIndex = 61;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(117, 661);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 36);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(-158, 665);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 32);
            this.label5.TabIndex = 56;
            this.label5.Text = "$";
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstado.Enabled = false;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "VIGENTE",
            "ANULADO",
            "ENTREGADO"});
            this.cbEstado.Location = new System.Drawing.Point(160, 172);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(532, 40);
            this.cbEstado.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(700, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total";
            // 
            // txtSubtotalVenta
            // 
            this.txtSubtotalVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotalVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotalVenta.Enabled = false;
            this.txtSubtotalVenta.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtSubtotalVenta.Location = new System.Drawing.Point(776, 83);
            this.txtSubtotalVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotalVenta.Name = "txtSubtotalVenta";
            this.txtSubtotalVenta.Size = new System.Drawing.Size(108, 33);
            this.txtSubtotalVenta.TabIndex = 42;
            // 
            // cbBusquedaClienteVenta
            // 
            this.cbBusquedaClienteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBusquedaClienteVenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBusquedaClienteVenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBusquedaClienteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBusquedaClienteVenta.FormattingEnabled = true;
            this.cbBusquedaClienteVenta.Location = new System.Drawing.Point(160, 31);
            this.cbBusquedaClienteVenta.Margin = new System.Windows.Forms.Padding(4);
            this.cbBusquedaClienteVenta.Name = "cbBusquedaClienteVenta";
            this.cbBusquedaClienteVenta.Size = new System.Drawing.Size(759, 40);
            this.cbBusquedaClienteVenta.TabIndex = 26;
            this.cbBusquedaClienteVenta.SelectedIndexChanged += new System.EventHandler(this.cbBusquedaClienteVenta_SelectedIndexChanged);
            this.cbBusquedaClienteVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // rbPorClienteFecha
            // 
            this.rbPorClienteFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPorClienteFecha.AutoSize = true;
            this.rbPorClienteFecha.Location = new System.Drawing.Point(456, 128);
            this.rbPorClienteFecha.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorClienteFecha.Name = "rbPorClienteFecha";
            this.rbPorClienteFecha.Size = new System.Drawing.Size(153, 36);
            this.rbPorClienteFecha.TabIndex = 25;
            this.rbPorClienteFecha.Text = "Por Ambos";
            this.rbPorClienteFecha.UseVisualStyleBackColor = true;
            this.rbPorClienteFecha.CheckedChanged += new System.EventHandler(this.rbPorClienteFecha_CheckedChanged);
            // 
            // rbPorFecha
            // 
            this.rbPorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPorFecha.AutoSize = true;
            this.rbPorFecha.Location = new System.Drawing.Point(299, 128);
            this.rbPorFecha.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorFecha.Name = "rbPorFecha";
            this.rbPorFecha.Size = new System.Drawing.Size(141, 36);
            this.rbPorFecha.TabIndex = 24;
            this.rbPorFecha.Text = "Por Fecha";
            this.rbPorFecha.UseVisualStyleBackColor = true;
            this.rbPorFecha.CheckedChanged += new System.EventHandler(this.rbPorFecha_CheckedChanged);
            // 
            // rbPorCliente
            // 
            this.rbPorCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPorCliente.AutoSize = true;
            this.rbPorCliente.Checked = true;
            this.rbPorCliente.Location = new System.Drawing.Point(129, 128);
            this.rbPorCliente.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorCliente.Name = "rbPorCliente";
            this.rbPorCliente.Size = new System.Drawing.Size(154, 36);
            this.rbPorCliente.TabIndex = 23;
            this.rbPorCliente.TabStop = true;
            this.rbPorCliente.Text = "Por Cliente";
            this.rbPorCliente.UseVisualStyleBackColor = true;
            this.rbPorCliente.CheckedChanged += new System.EventHandler(this.rbPorCliente_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado";
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbListado.BackColor = System.Drawing.Color.Transparent;
            this.gbListado.Controls.Add(this.btnEntregar);
            this.gbListado.Controls.Add(this.btnAnular);
            this.gbListado.Controls.Add(this.lbVenta);
            this.gbListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbListado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbListado.Location = new System.Drawing.Point(985, 15);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(4);
            this.gbListado.Size = new System.Drawing.Size(320, 697);
            this.gbListado.TabIndex = 38;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // btnEntregar
            // 
            this.btnEntregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregar.Location = new System.Drawing.Point(73, 651);
            this.btnEntregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(113, 36);
            this.btnEntregar.TabIndex = 59;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.UseVisualStyleBackColor = false;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(194, 651);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(113, 36);
            this.btnAnular.TabIndex = 58;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // lbVenta
            // 
            this.lbVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbVenta.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lbVenta.FormattingEnabled = true;
            this.lbVenta.ItemHeight = 32;
            this.lbVenta.Location = new System.Drawing.Point(8, 38);
            this.lbVenta.Margin = new System.Windows.Forms.Padding(4);
            this.lbVenta.Name = "lbVenta";
            this.lbVenta.Size = new System.Drawing.Size(300, 576);
            this.lbVenta.TabIndex = 0;
            this.lbVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbVenta_MouseClick);
            this.lbVenta.SelectedIndexChanged += new System.EventHandler(this.lbVenta_SelectedIndexChanged);
            this.lbVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbVenta_Key);
            this.lbVenta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbVenta_Key);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 731);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbVenta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).EndInit();
            this.gbListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPorClienteFecha;
        private System.Windows.Forms.RadioButton rbPorFecha;
        private System.Windows.Forms.RadioButton rbPorCliente;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lbVenta;
        private System.Windows.Forms.ComboBox cbBusquedaClienteVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubtotalVenta;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.Button btnDevolverProducto;
        private System.Windows.Forms.Button btnEntregar;
    }
}