namespace SistemaVentas
{
    partial class frmCliente
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cbReferencia = new System.Windows.Forms.ComboBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtDomicilioCliente = new System.Windows.Forms.TextBox();
            this.txtTelefono2Cliente = new System.Windows.Forms.TextBox();
            this.txtTelefono1Cliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.btnHistorialCliente = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbBusquedaCliente = new System.Windows.Forms.ComboBox();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.txtSaldo);
            this.gbCliente.Controls.Add(this.lblSaldo);
            this.gbCliente.Controls.Add(this.cbReferencia);
            this.gbCliente.Controls.Add(this.lblReferencia);
            this.gbCliente.Controls.Add(this.lblIdentificacion);
            this.gbCliente.Controls.Add(this.txtIdentificacionCliente);
            this.gbCliente.Controls.Add(this.lblEmail);
            this.gbCliente.Controls.Add(this.lblDomicilio);
            this.gbCliente.Controls.Add(this.lblTelefono2);
            this.gbCliente.Controls.Add(this.lblTelefono1);
            this.gbCliente.Controls.Add(this.txtEmailCliente);
            this.gbCliente.Controls.Add(this.txtDomicilioCliente);
            this.gbCliente.Controls.Add(this.txtTelefono2Cliente);
            this.gbCliente.Controls.Add(this.txtTelefono1Cliente);
            this.gbCliente.Controls.Add(this.txtApellidoCliente);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.lblApellido);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbCliente.Location = new System.Drawing.Point(12, 65);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(668, 264);
            this.gbCliente.TabIndex = 24;
            this.gbCliente.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(536, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 26);
            this.label4.TabIndex = 60;
            this.label4.Text = "$";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldo.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.txtSaldo.Location = new System.Drawing.Point(564, 22);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(69, 26);
            this.txtSaldo.TabIndex = 25;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSaldo.Location = new System.Drawing.Point(398, 22);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(144, 26);
            this.lblSaldo.TabIndex = 24;
            this.lblSaldo.Text = "Saldo Pendiente";
            this.lblSaldo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbReferencia
            // 
            this.cbReferencia.BackColor = System.Drawing.SystemColors.Window;
            this.cbReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReferencia.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReferencia.FormattingEnabled = true;
            this.cbReferencia.Location = new System.Drawing.Point(149, 150);
            this.cbReferencia.Name = "cbReferencia";
            this.cbReferencia.Size = new System.Drawing.Size(307, 34);
            this.cbReferencia.TabIndex = 7;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.BackColor = System.Drawing.Color.Transparent;
            this.lblReferencia.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblReferencia.Location = new System.Drawing.Point(20, 153);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(98, 26);
            this.lblReferencia.TabIndex = 21;
            this.lblReferencia.Text = "Referencia";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentificacion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblIdentificacion.Location = new System.Drawing.Point(20, 22);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(123, 26);
            this.lblIdentificacion.TabIndex = 17;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // txtIdentificacionCliente
            // 
            this.txtIdentificacionCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacionCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacionCliente.Location = new System.Drawing.Point(149, 22);
            this.txtIdentificacionCliente.MaxLength = 13;
            this.txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            this.txtIdentificacionCliente.Size = new System.Drawing.Size(154, 26);
            this.txtIdentificacionCliente.TabIndex = 2;
            this.txtIdentificacionCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_number);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(20, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 26);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDomicilio.Location = new System.Drawing.Point(20, 190);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(92, 26);
            this.lblDomicilio.TabIndex = 22;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblTelefono2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTelefono2.Location = new System.Drawing.Point(341, 123);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(99, 26);
            this.lblTelefono2.TabIndex = 22;
            this.lblTelefono2.Text = "Telefono 2";
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblTelefono1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTelefono1.Location = new System.Drawing.Point(20, 118);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(99, 26);
            this.lblTelefono1.TabIndex = 20;
            this.lblTelefono1.Text = "Telefono 1";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailCliente.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.txtEmailCliente.Location = new System.Drawing.Point(149, 222);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(484, 26);
            this.txtEmailCliente.TabIndex = 9;
            this.txtEmailCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum_email);
            // 
            // txtDomicilioCliente
            // 
            this.txtDomicilioCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilioCliente.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.txtDomicilioCliente.Location = new System.Drawing.Point(149, 190);
            this.txtDomicilioCliente.Name = "txtDomicilioCliente";
            this.txtDomicilioCliente.Size = new System.Drawing.Size(484, 26);
            this.txtDomicilioCliente.TabIndex = 8;
            this.txtDomicilioCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // txtTelefono2Cliente
            // 
            this.txtTelefono2Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono2Cliente.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.txtTelefono2Cliente.Location = new System.Drawing.Point(451, 118);
            this.txtTelefono2Cliente.Name = "txtTelefono2Cliente";
            this.txtTelefono2Cliente.Size = new System.Drawing.Size(182, 26);
            this.txtTelefono2Cliente.TabIndex = 6;
            this.txtTelefono2Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_number);
            // 
            // txtTelefono1Cliente
            // 
            this.txtTelefono1Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono1Cliente.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.txtTelefono1Cliente.Location = new System.Drawing.Point(149, 118);
            this.txtTelefono1Cliente.Name = "txtTelefono1Cliente";
            this.txtTelefono1Cliente.Size = new System.Drawing.Size(186, 26);
            this.txtTelefono1Cliente.TabIndex = 5;
            this.txtTelefono1Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_number);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoCliente.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.txtApellidoCliente.Location = new System.Drawing.Point(149, 86);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(484, 26);
            this.txtApellidoCliente.TabIndex = 4;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(149, 54);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(484, 26);
            this.txtNombreCliente.TabIndex = 3;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblApellido.Location = new System.Drawing.Point(20, 86);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(83, 26);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNombre.Location = new System.Drawing.Point(20, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 26);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(476, 9);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarCliente.TabIndex = 15;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCliente.Location = new System.Drawing.Point(45, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(69, 26);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Cliente";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(412, 335);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(85, 29);
            this.btnEliminarCliente.TabIndex = 11;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(503, 335);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(85, 29);
            this.btnModificarCliente.TabIndex = 12;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Location = new System.Drawing.Point(594, 335);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(86, 29);
            this.btnGuardarCliente.TabIndex = 13;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // btnHistorialCliente
            // 
            this.btnHistorialCliente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnHistorialCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHistorialCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialCliente.Location = new System.Drawing.Point(28, 335);
            this.btnHistorialCliente.Name = "btnHistorialCliente";
            this.btnHistorialCliente.Size = new System.Drawing.Size(85, 29);
            this.btnHistorialCliente.TabIndex = 14;
            this.btnHistorialCliente.Text = "Historial";
            this.btnHistorialCliente.UseVisualStyleBackColor = false;
            this.btnHistorialCliente.Click += new System.EventHandler(this.btnHistorialCliente_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(321, 335);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 29);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cbBusquedaCliente
            // 
            this.cbBusquedaCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBusquedaCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBusquedaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBusquedaCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cbBusquedaCliente.FormattingEnabled = true;
            this.cbBusquedaCliente.Location = new System.Drawing.Point(161, 6);
            this.cbBusquedaCliente.MaxDropDownItems = 10;
            this.cbBusquedaCliente.MaxLength = 100;
            this.cbBusquedaCliente.Name = "cbBusquedaCliente";
            this.cbBusquedaCliente.Size = new System.Drawing.Size(309, 34);
            this.cbBusquedaCliente.TabIndex = 1;
            this.cbBusquedaCliente.SelectedIndexChanged += new System.EventHandler(this.cbBusquedaCliente_SelectedIndexChanged);
            this.cbBusquedaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 376);
            this.Controls.Add(this.cbBusquedaCliente);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnHistorialCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.gbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.Label lblTelefono1;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtDomicilioCliente;
        private System.Windows.Forms.TextBox txtTelefono2Cliente;
        private System.Windows.Forms.TextBox txtTelefono1Cliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtIdentificacionCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.ComboBox cbReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Button btnHistorialCliente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbBusquedaCliente;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label4;
    }
}