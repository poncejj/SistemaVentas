namespace SistemaVentas
{
    partial class frmProducto
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
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.btnFotoSiguienteProducto = new System.Windows.Forms.Button();
            this.btnFotoAnteriorProducto = new System.Windows.Forms.Button();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.btnAgregarFotoProducto = new System.Windows.Forms.Button();
            this.btnEliminarFotoProducto = new System.Windows.Forms.Button();
            this.panelSeleccion = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLista = new System.Windows.Forms.CheckedListBox();
            this.btnCancelarPanel = new System.Windows.Forms.Button();
            this.btnGuardarPanel = new System.Windows.Forms.Button();
            this.gbSeleccionarProducto = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.cbMarcaProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.lblTamanoProducto = new System.Windows.Forms.Label();
            this.lblColorProducto = new System.Windows.Forms.Label();
            this.cbTamanoProducto = new System.Windows.Forms.ComboBox();
            this.cbColorProducto = new System.Windows.Forms.ComboBox();
            this.lblDescripionProducto = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.cbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.lbBuscarlProducto = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lbProducto = new System.Windows.Forms.ListBox();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.SeleccionImagenes = new System.Windows.Forms.OpenFileDialog();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtProductoSeleccion = new System.Windows.Forms.TextBox();
            this.gbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            this.panelSeleccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSeleccionarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProducto)).BeginInit();
            this.gbListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbImagen
            // 
            this.gbImagen.BackColor = System.Drawing.Color.Transparent;
            this.gbImagen.Controls.Add(this.btnFotoSiguienteProducto);
            this.gbImagen.Controls.Add(this.btnFotoAnteriorProducto);
            this.gbImagen.Controls.Add(this.pbImagenProducto);
            this.gbImagen.Controls.Add(this.btnAgregarFotoProducto);
            this.gbImagen.Controls.Add(this.btnEliminarFotoProducto);
            this.gbImagen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbImagen.Location = new System.Drawing.Point(671, 24);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(246, 311);
            this.gbImagen.TabIndex = 35;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "Imagen";
            // 
            // btnFotoSiguienteProducto
            // 
            this.btnFotoSiguienteProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFotoSiguienteProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFotoSiguienteProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFotoSiguienteProducto.Location = new System.Drawing.Point(76, 272);
            this.btnFotoSiguienteProducto.Name = "btnFotoSiguienteProducto";
            this.btnFotoSiguienteProducto.Size = new System.Drawing.Size(45, 29);
            this.btnFotoSiguienteProducto.TabIndex = 16;
            this.btnFotoSiguienteProducto.Text = ">";
            this.btnFotoSiguienteProducto.UseVisualStyleBackColor = false;
            this.btnFotoSiguienteProducto.Click += new System.EventHandler(this.btnFotoSiguienteProducto_Click);
            // 
            // btnFotoAnteriorProducto
            // 
            this.btnFotoAnteriorProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFotoAnteriorProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFotoAnteriorProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFotoAnteriorProducto.Location = new System.Drawing.Point(25, 272);
            this.btnFotoAnteriorProducto.Name = "btnFotoAnteriorProducto";
            this.btnFotoAnteriorProducto.Size = new System.Drawing.Size(45, 29);
            this.btnFotoAnteriorProducto.TabIndex = 15;
            this.btnFotoAnteriorProducto.Text = "<";
            this.btnFotoAnteriorProducto.UseVisualStyleBackColor = false;
            this.btnFotoAnteriorProducto.Click += new System.EventHandler(this.btnFotoAnteriorProducto_Click);
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImagenProducto.InitialImage = null;
            this.pbImagenProducto.Location = new System.Drawing.Point(13, 29);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(218, 239);
            this.pbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenProducto.TabIndex = 28;
            this.pbImagenProducto.TabStop = false;
            // 
            // btnAgregarFotoProducto
            // 
            this.btnAgregarFotoProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarFotoProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarFotoProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarFotoProducto.Location = new System.Drawing.Point(127, 272);
            this.btnAgregarFotoProducto.Name = "btnAgregarFotoProducto";
            this.btnAgregarFotoProducto.Size = new System.Drawing.Size(45, 29);
            this.btnAgregarFotoProducto.TabIndex = 17;
            this.btnAgregarFotoProducto.Text = "+";
            this.btnAgregarFotoProducto.UseVisualStyleBackColor = false;
            this.btnAgregarFotoProducto.Click += new System.EventHandler(this.btnAgregarFotoProducto_Click);
            // 
            // btnEliminarFotoProducto
            // 
            this.btnEliminarFotoProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarFotoProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarFotoProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFotoProducto.Location = new System.Drawing.Point(179, 272);
            this.btnEliminarFotoProducto.Name = "btnEliminarFotoProducto";
            this.btnEliminarFotoProducto.Size = new System.Drawing.Size(45, 29);
            this.btnEliminarFotoProducto.TabIndex = 18;
            this.btnEliminarFotoProducto.Text = "-";
            this.btnEliminarFotoProducto.UseVisualStyleBackColor = false;
            this.btnEliminarFotoProducto.Click += new System.EventHandler(this.btnEliminarFotoProducto_Click);
            // 
            // panelSeleccion
            // 
            this.panelSeleccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSeleccion.Controls.Add(this.groupBox1);
            this.panelSeleccion.Controls.Add(this.btnCancelarPanel);
            this.panelSeleccion.Controls.Add(this.btnGuardarPanel);
            this.panelSeleccion.Location = new System.Drawing.Point(138, 0);
            this.panelSeleccion.Name = "panelSeleccion";
            this.panelSeleccion.Size = new System.Drawing.Size(193, 222);
            this.panelSeleccion.TabIndex = 50;
            this.panelSeleccion.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLista);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 172);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // chkLista
            // 
            this.chkLista.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.chkLista.FormattingEnabled = true;
            this.chkLista.Location = new System.Drawing.Point(4, 27);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(175, 144);
            this.chkLista.TabIndex = 47;
            // 
            // btnCancelarPanel
            // 
            this.btnCancelarPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelarPanel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelarPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPanel.Location = new System.Drawing.Point(5, 185);
            this.btnCancelarPanel.Name = "btnCancelarPanel";
            this.btnCancelarPanel.Size = new System.Drawing.Size(85, 29);
            this.btnCancelarPanel.TabIndex = 46;
            this.btnCancelarPanel.Text = "Cancelar";
            this.btnCancelarPanel.UseVisualStyleBackColor = false;
            this.btnCancelarPanel.Click += new System.EventHandler(this.btnCancelarPanel_Click);
            // 
            // btnGuardarPanel
            // 
            this.btnGuardarPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarPanel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardarPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPanel.Location = new System.Drawing.Point(96, 185);
            this.btnGuardarPanel.Name = "btnGuardarPanel";
            this.btnGuardarPanel.Size = new System.Drawing.Size(85, 29);
            this.btnGuardarPanel.TabIndex = 44;
            this.btnGuardarPanel.Text = "Guardar";
            this.btnGuardarPanel.UseVisualStyleBackColor = false;
            this.btnGuardarPanel.Click += new System.EventHandler(this.btnGuardarPanel_Click);
            // 
            // gbSeleccionarProducto
            // 
            this.gbSeleccionarProducto.BackColor = System.Drawing.Color.Transparent;
            this.gbSeleccionarProducto.Controls.Add(this.panelSeleccion);
            this.gbSeleccionarProducto.Controls.Add(this.txtDescripcion);
            this.gbSeleccionarProducto.Controls.Add(this.cantidadProducto);
            this.gbSeleccionarProducto.Controls.Add(this.lblCantidadProducto);
            this.gbSeleccionarProducto.Controls.Add(this.txtPrecio);
            this.gbSeleccionarProducto.Controls.Add(this.label2);
            this.gbSeleccionarProducto.Controls.Add(this.txtNombreProducto);
            this.gbSeleccionarProducto.Controls.Add(this.cbMarcaProducto);
            this.gbSeleccionarProducto.Controls.Add(this.label1);
            this.gbSeleccionarProducto.Controls.Add(this.lblMarcaProducto);
            this.gbSeleccionarProducto.Controls.Add(this.lblTamanoProducto);
            this.gbSeleccionarProducto.Controls.Add(this.lblColorProducto);
            this.gbSeleccionarProducto.Controls.Add(this.cbTamanoProducto);
            this.gbSeleccionarProducto.Controls.Add(this.cbColorProducto);
            this.gbSeleccionarProducto.Controls.Add(this.lblDescripionProducto);
            this.gbSeleccionarProducto.Controls.Add(this.lblCategoriaProducto);
            this.gbSeleccionarProducto.Controls.Add(this.cbCategoriaProducto);
            this.gbSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbSeleccionarProducto.Location = new System.Drawing.Point(264, 67);
            this.gbSeleccionarProducto.Name = "gbSeleccionarProducto";
            this.gbSeleccionarProducto.Size = new System.Drawing.Size(401, 268);
            this.gbSeleccionarProducto.TabIndex = 34;
            this.gbSeleccionarProducto.TabStop = false;
            this.gbSeleccionarProducto.Text = "Produto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(132, 85);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(250, 26);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cantidadProducto.Location = new System.Drawing.Point(350, 223);
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Size = new System.Drawing.Size(45, 33);
            this.cantidadProducto.TabIndex = 9;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblCantidadProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCantidadProducto.Location = new System.Drawing.Point(245, 222);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(86, 26);
            this.lblCantidadProducto.TabIndex = 48;
            this.lblCantidadProducto.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtPrecio.Location = new System.Drawing.Point(132, 225);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(107, 26);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_number);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Precio";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtNombreProducto.Location = new System.Drawing.Point(132, 17);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(250, 26);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // cbMarcaProducto
            // 
            this.cbMarcaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarcaProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcaProducto.FormattingEnabled = true;
            this.cbMarcaProducto.Location = new System.Drawing.Point(132, 189);
            this.cbMarcaProducto.Name = "cbMarcaProducto";
            this.cbMarcaProducto.Size = new System.Drawing.Size(166, 30);
            this.cbMarcaProducto.TabIndex = 7;
            this.cbMarcaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Producto";
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblMarcaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMarcaProducto.Location = new System.Drawing.Point(6, 193);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(63, 26);
            this.lblMarcaProducto.TabIndex = 31;
            this.lblMarcaProducto.Text = "Marca";
            // 
            // lblTamanoProducto
            // 
            this.lblTamanoProducto.AutoSize = true;
            this.lblTamanoProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblTamanoProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblTamanoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTamanoProducto.Location = new System.Drawing.Point(5, 158);
            this.lblTamanoProducto.Name = "lblTamanoProducto";
            this.lblTamanoProducto.Size = new System.Drawing.Size(79, 26);
            this.lblTamanoProducto.TabIndex = 30;
            this.lblTamanoProducto.Text = "Tamaño";
            this.lblTamanoProducto.DoubleClick += new System.EventHandler(this.lblTamanoProducto_DoubleClick);
            // 
            // lblColorProducto
            // 
            this.lblColorProducto.AutoSize = true;
            this.lblColorProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblColorProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblColorProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblColorProducto.Location = new System.Drawing.Point(6, 124);
            this.lblColorProducto.Name = "lblColorProducto";
            this.lblColorProducto.Size = new System.Drawing.Size(56, 26);
            this.lblColorProducto.TabIndex = 29;
            this.lblColorProducto.Text = "Color";
            this.lblColorProducto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblColorProducto_MouseDoubleClick);
            // 
            // cbTamanoProducto
            // 
            this.cbTamanoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTamanoProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanoProducto.FormattingEnabled = true;
            this.cbTamanoProducto.Location = new System.Drawing.Point(132, 153);
            this.cbTamanoProducto.Name = "cbTamanoProducto";
            this.cbTamanoProducto.Size = new System.Drawing.Size(166, 30);
            this.cbTamanoProducto.TabIndex = 6;
            this.cbTamanoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // cbColorProducto
            // 
            this.cbColorProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbColorProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColorProducto.FormattingEnabled = true;
            this.cbColorProducto.Location = new System.Drawing.Point(132, 117);
            this.cbColorProducto.Name = "cbColorProducto";
            this.cbColorProducto.Size = new System.Drawing.Size(166, 30);
            this.cbColorProducto.TabIndex = 5;
            this.cbColorProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // lblDescripionProducto
            // 
            this.lblDescripionProducto.AutoSize = true;
            this.lblDescripionProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripionProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblDescripionProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDescripionProducto.Location = new System.Drawing.Point(5, 90);
            this.lblDescripionProducto.Name = "lblDescripionProducto";
            this.lblDescripionProducto.Size = new System.Drawing.Size(109, 26);
            this.lblDescripionProducto.TabIndex = 25;
            this.lblDescripionProducto.Text = "Descripción";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblCategoriaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCategoriaProducto.Location = new System.Drawing.Point(5, 56);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(89, 26);
            this.lblCategoriaProducto.TabIndex = 23;
            this.lblCategoriaProducto.Text = "Categoria";
            // 
            // cbCategoriaProducto
            // 
            this.cbCategoriaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoriaProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaProducto.FormattingEnabled = true;
            this.cbCategoriaProducto.Location = new System.Drawing.Point(132, 49);
            this.cbCategoriaProducto.Name = "cbCategoriaProducto";
            this.cbCategoriaProducto.Size = new System.Drawing.Size(247, 30);
            this.cbCategoriaProducto.TabIndex = 3;
            this.cbCategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaProducto_SelectedIndexChanged);
            this.cbCategoriaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(642, 341);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(85, 29);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Location = new System.Drawing.Point(733, 341);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(85, 29);
            this.btnModificarProducto.TabIndex = 12;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Location = new System.Drawing.Point(824, 341);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(86, 29);
            this.btnGuardarProducto.TabIndex = 13;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // lbBuscarlProducto
            // 
            this.lbBuscarlProducto.AutoSize = true;
            this.lbBuscarlProducto.BackColor = System.Drawing.Color.Transparent;
            this.lbBuscarlProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lbBuscarlProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbBuscarlProducto.Location = new System.Drawing.Point(269, 35);
            this.lbBuscarlProducto.Name = "lbBuscarlProducto";
            this.lbBuscarlProducto.Size = new System.Drawing.Size(87, 26);
            this.lbBuscarlProducto.TabIndex = 41;
            this.lbBuscarlProducto.Text = "Producto";
            // 
            // gbListado
            // 
            this.gbListado.BackColor = System.Drawing.Color.Transparent;
            this.gbListado.Controls.Add(this.lbProducto);
            this.gbListado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbListado.Location = new System.Drawing.Point(12, 24);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(246, 313);
            this.gbListado.TabIndex = 36;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // lbProducto
            // 
            this.lbProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lbProducto.FormattingEnabled = true;
            this.lbProducto.ItemHeight = 26;
            this.lbProducto.Location = new System.Drawing.Point(7, 23);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(233, 264);
            this.lbProducto.TabIndex = 21;
            this.lbProducto.SelectedIndexChanged += new System.EventHandler(this.lbProducto_SelectedIndexChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbActivo.Checked = true;
            this.rbActivo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.rbActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbActivo.Location = new System.Drawing.Point(12, 343);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(85, 30);
            this.rbActivo.TabIndex = 19;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = false;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbInactivo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.rbInactivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbInactivo.Location = new System.Drawing.Point(103, 343);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(97, 30);
            this.rbInactivo.TabIndex = 20;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = false;
            // 
            // SeleccionImagenes
            // 
            this.SeleccionImagenes.FileName = "fdSeleccionImagenes";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(551, 341);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 29);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtProductoSeleccion
            // 
            this.txtProductoSeleccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductoSeleccion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtProductoSeleccion.Location = new System.Drawing.Point(396, 35);
            this.txtProductoSeleccion.Name = "txtProductoSeleccion";
            this.txtProductoSeleccion.Size = new System.Drawing.Size(247, 26);
            this.txtProductoSeleccion.TabIndex = 1;
            this.txtProductoSeleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoSeleccion_KeyPress);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 380);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.rbInactivo);
            this.Controls.Add(this.rbActivo);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.txtProductoSeleccion);
            this.Controls.Add(this.lbBuscarlProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.gbImagen);
            this.Controls.Add(this.gbSeleccionarProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProducto_FormClosed);
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.gbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            this.panelSeleccion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbSeleccionarProducto.ResumeLayout(false);
            this.gbSeleccionarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProducto)).EndInit();
            this.gbListado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbImagen;
        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Button btnAgregarFotoProducto;
        private System.Windows.Forms.Button btnEliminarFotoProducto;
        private System.Windows.Forms.GroupBox gbSeleccionarProducto;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.Label lblTamanoProducto;
        private System.Windows.Forms.Label lblColorProducto;
        private System.Windows.Forms.Label lblDescripionProducto;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.ComboBox cbCategoriaProducto;
        private System.Windows.Forms.Button btnFotoSiguienteProducto;
        private System.Windows.Forms.Button btnFotoAnteriorProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Label lbBuscarlProducto;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ComboBox cbMarcaProducto;
        private System.Windows.Forms.ListBox lbProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.NumericUpDown cantidadProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTamanoProducto;
        private System.Windows.Forms.ComboBox cbColorProducto;
        private System.Windows.Forms.OpenFileDialog SeleccionImagenes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panelSeleccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkLista;
        private System.Windows.Forms.Button btnCancelarPanel;
        private System.Windows.Forms.Button btnGuardarPanel;
        private System.Windows.Forms.TextBox txtProductoSeleccion;
        private System.Windows.Forms.TextBox txtDescripcion;

    }
}