namespace SistemaVentas
{
    partial class frmSeleccionProductos
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
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lbProducto = new System.Windows.Forms.ListBox();
            this.txtProductoSeleccion = new System.Windows.Forms.TextBox();
            this.lbBuscarlProducto = new System.Windows.Forms.Label();
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.btnFotoSiguienteProducto = new System.Windows.Forms.Button();
            this.btnFotoAnteriorProducto = new System.Windows.Forms.Button();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.gbSeleccionarProducto = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTamanoProducto = new System.Windows.Forms.Label();
            this.lblColorProducto = new System.Windows.Forms.Label();
            this.cbTamanoProducto = new System.Windows.Forms.ComboBox();
            this.cbColorProducto = new System.Windows.Forms.ComboBox();
            this.lblDescripionProducto = new System.Windows.Forms.Label();
            this.cbMarcaProducto = new System.Windows.Forms.ComboBox();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.cbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.gbListado.SuspendLayout();
            this.gbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            this.gbSeleccionarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbInactivo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.rbInactivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbInactivo.Location = new System.Drawing.Point(101, 190);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(97, 30);
            this.rbInactivo.TabIndex = 49;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = false;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbActivo.Checked = true;
            this.rbActivo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.rbActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbActivo.Location = new System.Drawing.Point(10, 191);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(85, 30);
            this.rbActivo.TabIndex = 48;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = false;
            // 
            // gbListado
            // 
            this.gbListado.BackColor = System.Drawing.Color.Transparent;
            this.gbListado.Controls.Add(this.lbProducto);
            this.gbListado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbListado.Location = new System.Drawing.Point(15, 95);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(246, 267);
            this.gbListado.TabIndex = 52;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // lbProducto
            // 
            this.lbProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lbProducto.FormattingEnabled = true;
            this.lbProducto.ItemHeight = 26;
            this.lbProducto.Location = new System.Drawing.Point(9, 28);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(233, 238);
            this.lbProducto.TabIndex = 21;
            this.lbProducto.SelectedIndexChanged += new System.EventHandler(this.lbProducto_SelectedIndexChanged);
            // 
            // txtProductoSeleccion
            // 
            this.txtProductoSeleccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductoSeleccion.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoSeleccion.Location = new System.Drawing.Point(112, 24);
            this.txtProductoSeleccion.Name = "txtProductoSeleccion";
            this.txtProductoSeleccion.Size = new System.Drawing.Size(537, 29);
            this.txtProductoSeleccion.TabIndex = 42;
            this.txtProductoSeleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoSeleccion_KeyPress);
            // 
            // lbBuscarlProducto
            // 
            this.lbBuscarlProducto.AutoSize = true;
            this.lbBuscarlProducto.BackColor = System.Drawing.Color.Transparent;
            this.lbBuscarlProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lbBuscarlProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbBuscarlProducto.Location = new System.Drawing.Point(19, 24);
            this.lbBuscarlProducto.Name = "lbBuscarlProducto";
            this.lbBuscarlProducto.Size = new System.Drawing.Size(87, 26);
            this.lbBuscarlProducto.TabIndex = 53;
            this.lbBuscarlProducto.Text = "Producto";
            // 
            // gbImagen
            // 
            this.gbImagen.BackColor = System.Drawing.Color.Transparent;
            this.gbImagen.Controls.Add(this.btnFotoSiguienteProducto);
            this.gbImagen.Controls.Add(this.btnFotoAnteriorProducto);
            this.gbImagen.Controls.Add(this.pbImagenProducto);
            this.gbImagen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbImagen.Location = new System.Drawing.Point(674, 16);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(246, 310);
            this.gbImagen.TabIndex = 51;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "Imagen";
            // 
            // btnFotoSiguienteProducto
            // 
            this.btnFotoSiguienteProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFotoSiguienteProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFotoSiguienteProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFotoSiguienteProducto.Location = new System.Drawing.Point(131, 271);
            this.btnFotoSiguienteProducto.Name = "btnFotoSiguienteProducto";
            this.btnFotoSiguienteProducto.Size = new System.Drawing.Size(45, 29);
            this.btnFotoSiguienteProducto.TabIndex = 16;
            this.btnFotoSiguienteProducto.Text = ">";
            this.btnFotoSiguienteProducto.UseVisualStyleBackColor = false;
            // 
            // btnFotoAnteriorProducto
            // 
            this.btnFotoAnteriorProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFotoAnteriorProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFotoAnteriorProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFotoAnteriorProducto.Location = new System.Drawing.Point(80, 271);
            this.btnFotoAnteriorProducto.Name = "btnFotoAnteriorProducto";
            this.btnFotoAnteriorProducto.Size = new System.Drawing.Size(45, 29);
            this.btnFotoAnteriorProducto.TabIndex = 15;
            this.btnFotoAnteriorProducto.Text = "<";
            this.btnFotoAnteriorProducto.UseVisualStyleBackColor = false;
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
            // gbSeleccionarProducto
            // 
            this.gbSeleccionarProducto.BackColor = System.Drawing.Color.Transparent;
            this.gbSeleccionarProducto.Controls.Add(this.rbInactivo);
            this.gbSeleccionarProducto.Controls.Add(this.txtDescripcion);
            this.gbSeleccionarProducto.Controls.Add(this.rbActivo);
            this.gbSeleccionarProducto.Controls.Add(this.cantidadProducto);
            this.gbSeleccionarProducto.Controls.Add(this.lblCantidadProducto);
            this.gbSeleccionarProducto.Controls.Add(this.txtPrecio);
            this.gbSeleccionarProducto.Controls.Add(this.label2);
            this.gbSeleccionarProducto.Controls.Add(this.txtNombreProducto);
            this.gbSeleccionarProducto.Controls.Add(this.label1);
            this.gbSeleccionarProducto.Controls.Add(this.lblTamanoProducto);
            this.gbSeleccionarProducto.Controls.Add(this.lblColorProducto);
            this.gbSeleccionarProducto.Controls.Add(this.cbTamanoProducto);
            this.gbSeleccionarProducto.Controls.Add(this.cbColorProducto);
            this.gbSeleccionarProducto.Controls.Add(this.lblDescripionProducto);
            this.gbSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbSeleccionarProducto.Location = new System.Drawing.Point(267, 106);
            this.gbSeleccionarProducto.Name = "gbSeleccionarProducto";
            this.gbSeleccionarProducto.Size = new System.Drawing.Size(401, 255);
            this.gbSeleccionarProducto.TabIndex = 50;
            this.gbSeleccionarProducto.TabStop = false;
            this.gbSeleccionarProducto.Text = "Datos";
            this.gbSeleccionarProducto.Enter += new System.EventHandler(this.gbSeleccionarProducto_Enter);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(132, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(250, 26);
            this.txtDescripcion.TabIndex = 4;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cantidadProducto.Location = new System.Drawing.Point(350, 156);
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
            this.lblCantidadProducto.Location = new System.Drawing.Point(245, 155);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(86, 26);
            this.lblCantidadProducto.TabIndex = 48;
            this.lblCantidadProducto.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtPrecio.Location = new System.Drawing.Point(132, 158);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(107, 26);
            this.txtPrecio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Precio";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtNombreProducto.Location = new System.Drawing.Point(132, 22);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(250, 26);
            this.txtNombreProducto.TabIndex = 2;
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
            // lblTamanoProducto
            // 
            this.lblTamanoProducto.AutoSize = true;
            this.lblTamanoProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblTamanoProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblTamanoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTamanoProducto.Location = new System.Drawing.Point(5, 127);
            this.lblTamanoProducto.Name = "lblTamanoProducto";
            this.lblTamanoProducto.Size = new System.Drawing.Size(79, 26);
            this.lblTamanoProducto.TabIndex = 30;
            this.lblTamanoProducto.Text = "Tamaño";
            // 
            // lblColorProducto
            // 
            this.lblColorProducto.AutoSize = true;
            this.lblColorProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblColorProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblColorProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblColorProducto.Location = new System.Drawing.Point(6, 93);
            this.lblColorProducto.Name = "lblColorProducto";
            this.lblColorProducto.Size = new System.Drawing.Size(56, 26);
            this.lblColorProducto.TabIndex = 29;
            this.lblColorProducto.Text = "Color";
            // 
            // cbTamanoProducto
            // 
            this.cbTamanoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTamanoProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanoProducto.FormattingEnabled = true;
            this.cbTamanoProducto.Location = new System.Drawing.Point(132, 122);
            this.cbTamanoProducto.Name = "cbTamanoProducto";
            this.cbTamanoProducto.Size = new System.Drawing.Size(250, 30);
            this.cbTamanoProducto.TabIndex = 6;
            // 
            // cbColorProducto
            // 
            this.cbColorProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbColorProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColorProducto.FormattingEnabled = true;
            this.cbColorProducto.Location = new System.Drawing.Point(132, 86);
            this.cbColorProducto.Name = "cbColorProducto";
            this.cbColorProducto.Size = new System.Drawing.Size(250, 30);
            this.cbColorProducto.TabIndex = 5;
            // 
            // lblDescripionProducto
            // 
            this.lblDescripionProducto.AutoSize = true;
            this.lblDescripionProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripionProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblDescripionProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDescripionProducto.Location = new System.Drawing.Point(5, 59);
            this.lblDescripionProducto.Name = "lblDescripionProducto";
            this.lblDescripionProducto.Size = new System.Drawing.Size(109, 26);
            this.lblDescripionProducto.TabIndex = 25;
            this.lblDescripionProducto.Text = "Descripción";
            // 
            // cbMarcaProducto
            // 
            this.cbMarcaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarcaProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcaProducto.FormattingEnabled = true;
            this.cbMarcaProducto.Location = new System.Drawing.Point(428, 59);
            this.cbMarcaProducto.Name = "cbMarcaProducto";
            this.cbMarcaProducto.Size = new System.Drawing.Size(221, 30);
            this.cbMarcaProducto.TabIndex = 7;
            this.cbMarcaProducto.SelectedIndexChanged += new System.EventHandler(this.cbMarcaProducto_SelectedIndexChanged);
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblMarcaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMarcaProducto.Location = new System.Drawing.Point(359, 59);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(63, 26);
            this.lblMarcaProducto.TabIndex = 31;
            this.lblMarcaProducto.Text = "Marca";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaProducto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblCategoriaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCategoriaProducto.Location = new System.Drawing.Point(17, 59);
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
            this.cbCategoriaProducto.Location = new System.Drawing.Point(110, 59);
            this.cbCategoriaProducto.Name = "cbCategoriaProducto";
            this.cbCategoriaProducto.Size = new System.Drawing.Size(241, 30);
            this.cbCategoriaProducto.TabIndex = 3;
            this.cbCategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaProducto_SelectedIndexChanged);
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSeleccionarProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(738, 333);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(112, 29);
            this.btnSeleccionarProducto.TabIndex = 47;
            this.btnSeleccionarProducto.Text = "Seleccionar";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = false;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // frmSeleccionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 380);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.txtProductoSeleccion);
            this.Controls.Add(this.lbBuscarlProducto);
            this.Controls.Add(this.gbImagen);
            this.Controls.Add(this.cbMarcaProducto);
            this.Controls.Add(this.lblMarcaProducto);
            this.Controls.Add(this.gbSeleccionarProducto);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.lblCategoriaProducto);
            this.Controls.Add(this.cbCategoriaProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeleccionProductos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion Productos";
            this.Load += new System.EventHandler(this.frmSeleccionProductos_Load);
            this.gbListado.ResumeLayout(false);
            this.gbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            this.gbSeleccionarProducto.ResumeLayout(false);
            this.gbSeleccionarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lbProducto;
        private System.Windows.Forms.TextBox txtProductoSeleccion;
        private System.Windows.Forms.Label lbBuscarlProducto;
        private System.Windows.Forms.GroupBox gbImagen;
        private System.Windows.Forms.Button btnFotoSiguienteProducto;
        private System.Windows.Forms.Button btnFotoAnteriorProducto;
        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.GroupBox gbSeleccionarProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown cantidadProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTamanoProducto;
        private System.Windows.Forms.Label lblColorProducto;
        private System.Windows.Forms.ComboBox cbTamanoProducto;
        private System.Windows.Forms.ComboBox cbColorProducto;
        private System.Windows.Forms.Label lblDescripionProducto;
        private System.Windows.Forms.ComboBox cbMarcaProducto;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.ComboBox cbCategoriaProducto;
        private System.Windows.Forms.Button btnSeleccionarProducto;
    }
}