namespace SistemaVentas
{
    partial class frmPaquete
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
            this.gbPaquete = new System.Windows.Forms.GroupBox();
            this.btnNoIncluirProducto = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIncluirProducto = new System.Windows.Forms.Button();
            this.cbBusquedaCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotalPaquete = new System.Windows.Forms.TextBox();
            this.rbPorClienteFecha = new System.Windows.Forms.RadioButton();
            this.cbEstadoPaquete = new System.Windows.Forms.ComboBox();
            this.rbPorFecha = new System.Windows.Forms.RadioButton();
            this.rbPorCliente = new System.Windows.Forms.RadioButton();
            this.dgDetallePaquete = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calendarioPaquete = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAgregarProductoPaquete = new System.Windows.Forms.Button();
            this.btnEliminarPaquete = new System.Windows.Forms.Button();
            this.btnModificarPaquete = new System.Windows.Forms.Button();
            this.btnGuardarPaquete = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lbPaquete = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.gbPaquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallePaquete)).BeginInit();
            this.gbListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPaquete
            // 
            this.gbPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaquete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbPaquete.BackColor = System.Drawing.Color.Transparent;
            this.gbPaquete.Controls.Add(this.btnNoIncluirProducto);
            this.gbPaquete.Controls.Add(this.btnVender);
            this.gbPaquete.Controls.Add(this.label5);
            this.gbPaquete.Controls.Add(this.btnIncluirProducto);
            this.gbPaquete.Controls.Add(this.cbBusquedaCliente);
            this.gbPaquete.Controls.Add(this.label2);
            this.gbPaquete.Controls.Add(this.txtSubtotalPaquete);
            this.gbPaquete.Controls.Add(this.rbPorClienteFecha);
            this.gbPaquete.Controls.Add(this.cbEstadoPaquete);
            this.gbPaquete.Controls.Add(this.rbPorFecha);
            this.gbPaquete.Controls.Add(this.rbPorCliente);
            this.gbPaquete.Controls.Add(this.dgDetallePaquete);
            this.gbPaquete.Controls.Add(this.label3);
            this.gbPaquete.Controls.Add(this.label4);
            this.gbPaquete.Controls.Add(this.calendarioPaquete);
            this.gbPaquete.Controls.Add(this.lblCliente);
            this.gbPaquete.Controls.Add(this.btnAgregarProductoPaquete);
            this.gbPaquete.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbPaquete.Location = new System.Drawing.Point(31, 27);
            this.gbPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.gbPaquete.Name = "gbPaquete";
            this.gbPaquete.Padding = new System.Windows.Forms.Padding(4);
            this.gbPaquete.Size = new System.Drawing.Size(902, 585);
            this.gbPaquete.TabIndex = 7;
            this.gbPaquete.TabStop = false;
            this.gbPaquete.Text = "Paquete";
            // 
            // btnNoIncluirProducto
            // 
            this.btnNoIncluirProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoIncluirProducto.AutoSize = true;
            this.btnNoIncluirProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnNoIncluirProducto.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.btnNoIncluirProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoIncluirProducto.FlatAppearance.BorderSize = 0;
            this.btnNoIncluirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoIncluirProducto.Image = global::SistemaVentas.Properties.Resources.uncheck;
            this.btnNoIncluirProducto.Location = new System.Drawing.Point(810, 174);
            this.btnNoIncluirProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoIncluirProducto.Name = "btnNoIncluirProducto";
            this.btnNoIncluirProducto.Size = new System.Drawing.Size(32, 30);
            this.btnNoIncluirProducto.TabIndex = 59;
            this.btnNoIncluirProducto.UseMnemonic = false;
            this.btnNoIncluirProducto.UseVisualStyleBackColor = false;
            this.btnNoIncluirProducto.Click += new System.EventHandler(this.btnNoIncluirProducto_Click);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(414, 168);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(113, 36);
            this.btnVender.TabIndex = 57;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(750, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 32);
            this.label5.TabIndex = 55;
            this.label5.Text = "$";
            // 
            // btnIncluirProducto
            // 
            this.btnIncluirProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluirProducto.AutoSize = true;
            this.btnIncluirProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluirProducto.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.btnIncluirProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluirProducto.FlatAppearance.BorderSize = 0;
            this.btnIncluirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirProducto.Image = global::SistemaVentas.Properties.Resources.check;
            this.btnIncluirProducto.Location = new System.Drawing.Point(770, 174);
            this.btnIncluirProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluirProducto.Name = "btnIncluirProducto";
            this.btnIncluirProducto.Size = new System.Drawing.Size(32, 30);
            this.btnIncluirProducto.TabIndex = 58;
            this.btnIncluirProducto.UseMnemonic = false;
            this.btnIncluirProducto.UseVisualStyleBackColor = false;
            this.btnIncluirProducto.Click += new System.EventHandler(this.btnIncluirProducto_Click);
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
            this.cbBusquedaCliente.Location = new System.Drawing.Point(152, 22);
            this.cbBusquedaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbBusquedaCliente.Name = "cbBusquedaCliente";
            this.cbBusquedaCliente.Size = new System.Drawing.Size(449, 35);
            this.cbBusquedaCliente.TabIndex = 53;
            this.cbBusquedaCliente.SelectedIndexChanged += new System.EventHandler(this.cbBusquedaCliente_SelectedIndexChanged);
            this.cbBusquedaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(668, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Total";
            // 
            // txtSubtotalPaquete
            // 
            this.txtSubtotalPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotalPaquete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotalPaquete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtSubtotalPaquete.Location = new System.Drawing.Point(782, 26);
            this.txtSubtotalPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotalPaquete.Name = "txtSubtotalPaquete";
            this.txtSubtotalPaquete.ReadOnly = true;
            this.txtSubtotalPaquete.Size = new System.Drawing.Size(87, 33);
            this.txtSubtotalPaquete.TabIndex = 38;
            // 
            // rbPorClienteFecha
            // 
            this.rbPorClienteFecha.AutoSize = true;
            this.rbPorClienteFecha.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.rbPorClienteFecha.Location = new System.Drawing.Point(479, 119);
            this.rbPorClienteFecha.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorClienteFecha.Name = "rbPorClienteFecha";
            this.rbPorClienteFecha.Size = new System.Drawing.Size(153, 36);
            this.rbPorClienteFecha.TabIndex = 52;
            this.rbPorClienteFecha.Text = "Por Ambos";
            this.rbPorClienteFecha.UseVisualStyleBackColor = true;
            this.rbPorClienteFecha.CheckedChanged += new System.EventHandler(this.rbPorClienteFecha_CheckedChanged);
            // 
            // cbEstadoPaquete
            // 
            this.cbEstadoPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoPaquete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstadoPaquete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstadoPaquete.Enabled = false;
            this.cbEstadoPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstadoPaquete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cbEstadoPaquete.FormattingEnabled = true;
            this.cbEstadoPaquete.Items.AddRange(new object[] {
            "VENDIDO",
            "SIN VENDER"});
            this.cbEstadoPaquete.Location = new System.Drawing.Point(152, 164);
            this.cbEstadoPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoPaquete.Name = "cbEstadoPaquete";
            this.cbEstadoPaquete.Size = new System.Drawing.Size(254, 40);
            this.cbEstadoPaquete.TabIndex = 54;
            this.cbEstadoPaquete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // rbPorFecha
            // 
            this.rbPorFecha.AutoSize = true;
            this.rbPorFecha.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.rbPorFecha.Location = new System.Drawing.Point(321, 119);
            this.rbPorFecha.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorFecha.Name = "rbPorFecha";
            this.rbPorFecha.Size = new System.Drawing.Size(141, 36);
            this.rbPorFecha.TabIndex = 51;
            this.rbPorFecha.Text = "Por Fecha";
            this.rbPorFecha.UseVisualStyleBackColor = true;
            this.rbPorFecha.CheckedChanged += new System.EventHandler(this.rbPorFecha_CheckedChanged);
            // 
            // rbPorCliente
            // 
            this.rbPorCliente.AutoSize = true;
            this.rbPorCliente.Checked = true;
            this.rbPorCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.rbPorCliente.Location = new System.Drawing.Point(152, 119);
            this.rbPorCliente.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorCliente.Name = "rbPorCliente";
            this.rbPorCliente.Size = new System.Drawing.Size(154, 36);
            this.rbPorCliente.TabIndex = 50;
            this.rbPorCliente.TabStop = true;
            this.rbPorCliente.Text = "Por Cliente";
            this.rbPorCliente.UseVisualStyleBackColor = true;
            this.rbPorCliente.CheckedChanged += new System.EventHandler(this.rbPorCliente_CheckedChanged);
            // 
            // dgDetallePaquete
            // 
            this.dgDetallePaquete.AllowUserToAddRows = false;
            this.dgDetallePaquete.AllowUserToDeleteRows = false;
            this.dgDetallePaquete.AllowUserToResizeColumns = false;
            this.dgDetallePaquete.AllowUserToResizeRows = false;
            this.dgDetallePaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetallePaquete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetallePaquete.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgDetallePaquete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetallePaquete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgDetallePaquete.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgDetallePaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallePaquete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Color,
            this.Tamano,
            this.Cantidad,
            this.Precio,
            this.Total,
            this.Estado});
            this.dgDetallePaquete.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgDetallePaquete.GridColor = System.Drawing.Color.White;
            this.dgDetallePaquete.Location = new System.Drawing.Point(24, 212);
            this.dgDetallePaquete.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetallePaquete.MultiSelect = false;
            this.dgDetallePaquete.Name = "dgDetallePaquete";
            this.dgDetallePaquete.RowHeadersVisible = false;
            this.dgDetallePaquete.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDetallePaquete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetallePaquete.ShowCellToolTips = false;
            this.dgDetallePaquete.ShowEditingIcon = false;
            this.dgDetallePaquete.ShowRowErrors = false;
            this.dgDetallePaquete.Size = new System.Drawing.Size(817, 366);
            this.dgDetallePaquete.TabIndex = 41;
            this.dgDetallePaquete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallePaquete_CellContentClick);
            this.dgDetallePaquete.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallePaquete_CellEndEdit);
            this.dgDetallePaquete.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallePaquete_CellEnter);
            this.dgDetallePaquete.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDetallePaquete_CellMouseClick);
            this.dgDetallePaquete.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetallePaquete_CellValueChanged);
            this.dgDetallePaquete.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgDetallePaquete_CurrentCellDirtyStateChanged);
            this.dgDetallePaquete.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgDetallePaquete_EditingControlShowing);
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tamano
            // 
            this.Tamano.DataPropertyName = "Tamano";
            this.Tamano.HeaderText = "Tamano";
            this.Tamano.Name = "Tamano";
            this.Tamano.ReadOnly = true;
            this.Tamano.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(19, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 49;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 32);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha";
            // 
            // calendarioPaquete
            // 
            this.calendarioPaquete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.calendarioPaquete.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarioPaquete.Location = new System.Drawing.Point(152, 71);
            this.calendarioPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.calendarioPaquete.Name = "calendarioPaquete";
            this.calendarioPaquete.Size = new System.Drawing.Size(184, 40);
            this.calendarioPaquete.TabIndex = 47;
            this.calendarioPaquete.ValueChanged += new System.EventHandler(this.calendarioPaquete_ValueChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCliente.Location = new System.Drawing.Point(17, 26);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(90, 32);
            this.lblCliente.TabIndex = 46;
            this.lblCliente.Text = "Cliente";
            // 
            // btnAgregarProductoPaquete
            // 
            this.btnAgregarProductoPaquete.AccessibleDescription = "Anterior paquete del cliente";
            this.btnAgregarProductoPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProductoPaquete.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProductoPaquete.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.btnAgregarProductoPaquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProductoPaquete.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductoPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductoPaquete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductoPaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregarProductoPaquete.Image = global::SistemaVentas.Properties.Resources.add;
            this.btnAgregarProductoPaquete.Location = new System.Drawing.Point(849, 212);
            this.btnAgregarProductoPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProductoPaquete.Name = "btnAgregarProductoPaquete";
            this.btnAgregarProductoPaquete.Size = new System.Drawing.Size(45, 36);
            this.btnAgregarProductoPaquete.TabIndex = 9;
            this.btnAgregarProductoPaquete.UseVisualStyleBackColor = false;
            this.btnAgregarProductoPaquete.Click += new System.EventHandler(this.btnAgregarProductoPaquete_Click);
            // 
            // btnEliminarPaquete
            // 
            this.btnEliminarPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPaquete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaquete.Location = new System.Drawing.Point(922, 682);
            this.btnEliminarPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPaquete.Name = "btnEliminarPaquete";
            this.btnEliminarPaquete.Size = new System.Drawing.Size(113, 36);
            this.btnEliminarPaquete.TabIndex = 12;
            this.btnEliminarPaquete.Text = "Eliminar";
            this.btnEliminarPaquete.UseVisualStyleBackColor = false;
            this.btnEliminarPaquete.Click += new System.EventHandler(this.btnEliminarPaquete_Click);
            // 
            // btnModificarPaquete
            // 
            this.btnModificarPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarPaquete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificarPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPaquete.Location = new System.Drawing.Point(1043, 682);
            this.btnModificarPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarPaquete.Name = "btnModificarPaquete";
            this.btnModificarPaquete.Size = new System.Drawing.Size(113, 36);
            this.btnModificarPaquete.TabIndex = 13;
            this.btnModificarPaquete.Text = "Modificar";
            this.btnModificarPaquete.UseVisualStyleBackColor = false;
            this.btnModificarPaquete.Click += new System.EventHandler(this.btnModificarPaquete_Click);
            // 
            // btnGuardarPaquete
            // 
            this.btnGuardarPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPaquete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardarPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPaquete.Location = new System.Drawing.Point(1164, 684);
            this.btnGuardarPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPaquete.Name = "btnGuardarPaquete";
            this.btnGuardarPaquete.Size = new System.Drawing.Size(115, 36);
            this.btnGuardarPaquete.TabIndex = 14;
            this.btnGuardarPaquete.Text = "Guardar";
            this.btnGuardarPaquete.UseVisualStyleBackColor = false;
            this.btnGuardarPaquete.Click += new System.EventHandler(this.btnGuardarPaquete_Click);
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbListado.BackColor = System.Drawing.Color.Transparent;
            this.gbListado.Controls.Add(this.lbPaquete);
            this.gbListado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbListado.Location = new System.Drawing.Point(941, 29);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(4);
            this.gbListado.Size = new System.Drawing.Size(328, 614);
            this.gbListado.TabIndex = 37;
            this.gbListado.TabStop = false;
            // 
            // lbPaquete
            // 
            this.lbPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPaquete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPaquete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lbPaquete.FormattingEnabled = true;
            this.lbPaquete.ItemHeight = 32;
            this.lbPaquete.Location = new System.Drawing.Point(8, 33);
            this.lbPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.lbPaquete.Name = "lbPaquete";
            this.lbPaquete.Size = new System.Drawing.Size(311, 544);
            this.lbPaquete.TabIndex = 0;
            this.lbPaquete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPaquete_MouseClick);
            this.lbPaquete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbPaquete_Key);
            this.lbPaquete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbPaquete_Key);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(801, 682);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 36);
            this.btnNuevo.TabIndex = 43;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtObservaciones.Location = new System.Drawing.Point(55, 646);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.MaxLength = 5000;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(738, 73);
            this.txtObservaciones.TabIndex = 60;
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblObservaciones.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblObservaciones.Location = new System.Drawing.Point(49, 611);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(173, 32);
            this.lblObservaciones.TabIndex = 60;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // frmPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1318, 731);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnEliminarPaquete);
            this.Controls.Add(this.btnModificarPaquete);
            this.Controls.Add(this.btnGuardarPaquete);
            this.Controls.Add(this.gbPaquete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmPaquete";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paquete";
            this.Load += new System.EventHandler(this.frmPaquete_Load);
            this.gbPaquete.ResumeLayout(false);
            this.gbPaquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallePaquete)).EndInit();
            this.gbListado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaquete;
        private System.Windows.Forms.Button btnEliminarPaquete;
        private System.Windows.Forms.Button btnModificarPaquete;
        private System.Windows.Forms.Button btnGuardarPaquete;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lbPaquete;
        private System.Windows.Forms.ComboBox cbEstadoPaquete;
        private System.Windows.Forms.ComboBox cbBusquedaCliente;
        private System.Windows.Forms.RadioButton rbPorClienteFecha;
        private System.Windows.Forms.RadioButton rbPorFecha;
        private System.Windows.Forms.RadioButton rbPorCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker calendarioPaquete;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgDetallePaquete;
        private System.Windows.Forms.Button btnAgregarProductoPaquete;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnIncluirProducto;
        private System.Windows.Forms.Button btnNoIncluirProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotalPaquete;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}