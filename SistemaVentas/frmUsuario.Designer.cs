namespace SistemaVentas
{
    partial class frmUsuario
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
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.cbRolUsuario = new System.Windows.Forms.ComboBox();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtIdentificacionUsuario = new System.Windows.Forms.TextBox();
            this.lblIdentificacionUsuario = new System.Windows.Forms.Label();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.gbCredenciales = new System.Windows.Forms.GroupBox();
            this.txtContrasena2Usuario = new System.Windows.Forms.TextBox();
            this.txtContrasena1Usuario = new System.Windows.Forms.TextBox();
            this.lblContrasenaUsuario = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblUsuarioBusqueda = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbBusquedaUsuario = new System.Windows.Forms.ComboBox();
            this.gbUsuario.SuspendLayout();
            this.gbCredenciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsuario
            // 
            this.gbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gbUsuario.Controls.Add(this.lblRolUsuario);
            this.gbUsuario.Controls.Add(this.cbRolUsuario);
            this.gbUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.gbUsuario.Controls.Add(this.lblTelefonoUsuario);
            this.gbUsuario.Controls.Add(this.txtApellidoUsuario);
            this.gbUsuario.Controls.Add(this.lblApellidoUsuario);
            this.gbUsuario.Controls.Add(this.txtNombreUsuario);
            this.gbUsuario.Controls.Add(this.lblNombreUsuario);
            this.gbUsuario.Controls.Add(this.txtIdentificacionUsuario);
            this.gbUsuario.Controls.Add(this.lblIdentificacionUsuario);
            this.gbUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbUsuario.Location = new System.Drawing.Point(12, 78);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(406, 251);
            this.gbUsuario.TabIndex = 6;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblRolUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRolUsuario.Location = new System.Drawing.Point(15, 164);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(40, 26);
            this.lblRolUsuario.TabIndex = 35;
            this.lblRolUsuario.Text = "Rol";
            // 
            // cbRolUsuario
            // 
            this.cbRolUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRolUsuario.FormattingEnabled = true;
            this.cbRolUsuario.Location = new System.Drawing.Point(140, 163);
            this.cbRolUsuario.Name = "cbRolUsuario";
            this.cbRolUsuario.Size = new System.Drawing.Size(251, 34);
            this.cbRolUsuario.TabIndex = 11;
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(140, 131);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(147, 26);
            this.txtTelefonoUsuario.TabIndex = 10;
            this.txtTelefonoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_num);
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblTelefonoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(15, 131);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(84, 26);
            this.lblTelefonoUsuario.TabIndex = 32;
            this.lblTelefonoUsuario.Text = "Telefono";
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoUsuario.Location = new System.Drawing.Point(140, 99);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(251, 26);
            this.txtApellidoUsuario.TabIndex = 9;
            this.txtApellidoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblApellidoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblApellidoUsuario.Location = new System.Drawing.Point(15, 101);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(83, 26);
            this.lblApellidoUsuario.TabIndex = 30;
            this.lblApellidoUsuario.Text = "Apellido";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Location = new System.Drawing.Point(140, 67);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(251, 26);
            this.txtNombreUsuario.TabIndex = 8;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(15, 67);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(82, 26);
            this.lblNombreUsuario.TabIndex = 28;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // txtIdentificacionUsuario
            // 
            this.txtIdentificacionUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacionUsuario.Location = new System.Drawing.Point(140, 35);
            this.txtIdentificacionUsuario.Name = "txtIdentificacionUsuario";
            this.txtIdentificacionUsuario.Size = new System.Drawing.Size(170, 26);
            this.txtIdentificacionUsuario.TabIndex = 7;
            this.txtIdentificacionUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // lblIdentificacionUsuario
            // 
            this.lblIdentificacionUsuario.AutoSize = true;
            this.lblIdentificacionUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentificacionUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblIdentificacionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblIdentificacionUsuario.Location = new System.Drawing.Point(15, 35);
            this.lblIdentificacionUsuario.Name = "lblIdentificacionUsuario";
            this.lblIdentificacionUsuario.Size = new System.Drawing.Size(123, 26);
            this.lblIdentificacionUsuario.TabIndex = 22;
            this.lblIdentificacionUsuario.Text = "Identificacion";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Location = new System.Drawing.Point(605, 335);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 29);
            this.btnGuardarUsuario.TabIndex = 17;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(515, 335);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(84, 29);
            this.btnModificarUsuario.TabIndex = 16;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(434, 335);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 29);
            this.btnEliminarUsuario.TabIndex = 15;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // gbCredenciales
            // 
            this.gbCredenciales.BackColor = System.Drawing.Color.Transparent;
            this.gbCredenciales.Controls.Add(this.txtContrasena2Usuario);
            this.gbCredenciales.Controls.Add(this.txtContrasena1Usuario);
            this.gbCredenciales.Controls.Add(this.lblContrasenaUsuario);
            this.gbCredenciales.Controls.Add(this.txtLoginUsuario);
            this.gbCredenciales.Controls.Add(this.lblLoginUsuario);
            this.gbCredenciales.Controls.Add(this.button4);
            this.gbCredenciales.Controls.Add(this.button8);
            this.gbCredenciales.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbCredenciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbCredenciales.Location = new System.Drawing.Point(424, 78);
            this.gbCredenciales.Name = "gbCredenciales";
            this.gbCredenciales.Size = new System.Drawing.Size(256, 251);
            this.gbCredenciales.TabIndex = 36;
            this.gbCredenciales.TabStop = false;
            this.gbCredenciales.Text = "Credenciales";
            // 
            // txtContrasena2Usuario
            // 
            this.txtContrasena2Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena2Usuario.Location = new System.Drawing.Point(10, 150);
            this.txtContrasena2Usuario.MaxLength = 20;
            this.txtContrasena2Usuario.Name = "txtContrasena2Usuario";
            this.txtContrasena2Usuario.Size = new System.Drawing.Size(170, 26);
            this.txtContrasena2Usuario.TabIndex = 14;
            this.txtContrasena2Usuario.UseSystemPasswordChar = true;
            this.txtContrasena2Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum_login);
            // 
            // txtContrasena1Usuario
            // 
            this.txtContrasena1Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena1Usuario.Location = new System.Drawing.Point(10, 118);
            this.txtContrasena1Usuario.MaxLength = 20;
            this.txtContrasena1Usuario.Name = "txtContrasena1Usuario";
            this.txtContrasena1Usuario.Size = new System.Drawing.Size(170, 26);
            this.txtContrasena1Usuario.TabIndex = 13;
            this.txtContrasena1Usuario.UseSystemPasswordChar = true;
            this.txtContrasena1Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum_login);
            // 
            // lblContrasenaUsuario
            // 
            this.lblContrasenaUsuario.AutoSize = true;
            this.lblContrasenaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenaUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblContrasenaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblContrasenaUsuario.Location = new System.Drawing.Point(6, 91);
            this.lblContrasenaUsuario.Name = "lblContrasenaUsuario";
            this.lblContrasenaUsuario.Size = new System.Drawing.Size(112, 26);
            this.lblContrasenaUsuario.TabIndex = 24;
            this.lblContrasenaUsuario.Text = "Constraseña";
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUsuario.Location = new System.Drawing.Point(6, 62);
            this.txtLoginUsuario.MaxLength = 8;
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(170, 26);
            this.txtLoginUsuario.TabIndex = 12;
            this.txtLoginUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum_login);
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblLoginUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLoginUsuario.Location = new System.Drawing.Point(6, 35);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(60, 26);
            this.lblLoginUsuario.TabIndex = 22;
            this.lblLoginUsuario.Text = "Login";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(297, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 29);
            this.button4.TabIndex = 21;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(344, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 29);
            this.button8.TabIndex = 2;
            this.button8.Text = "Buscar";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // lblUsuarioBusqueda
            // 
            this.lblUsuarioBusqueda.AutoSize = true;
            this.lblUsuarioBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioBusqueda.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblUsuarioBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUsuarioBusqueda.Location = new System.Drawing.Point(27, 22);
            this.lblUsuarioBusqueda.Name = "lblUsuarioBusqueda";
            this.lblUsuarioBusqueda.Size = new System.Drawing.Size(77, 26);
            this.lblUsuarioBusqueda.TabIndex = 40;
            this.lblUsuarioBusqueda.Text = "Usuario";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(353, 335);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 29);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cbBusquedaUsuario
            // 
            this.cbBusquedaUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBusquedaUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBusquedaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBusquedaUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cbBusquedaUsuario.FormattingEnabled = true;
            this.cbBusquedaUsuario.Location = new System.Drawing.Point(129, 19);
            this.cbBusquedaUsuario.Name = "cbBusquedaUsuario";
            this.cbBusquedaUsuario.Size = new System.Drawing.Size(309, 34);
            this.cbBusquedaUsuario.TabIndex = 42;
            this.cbBusquedaUsuario.SelectedIndexChanged += new System.EventHandler(this.cbBusquedaUsuario_SelectedIndexChanged);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 376);
            this.Controls.Add(this.cbBusquedaUsuario);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblUsuarioBusqueda);
            this.Controls.Add(this.gbCredenciales);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.gbUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de Usuarios";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbCredenciales.ResumeLayout(false);
            this.gbCredenciales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.ComboBox cbRolUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.Label lblTelefonoUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.Label lblApellidoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.TextBox txtIdentificacionUsuario;
        private System.Windows.Forms.Label lblIdentificacionUsuario;
        private System.Windows.Forms.GroupBox gbCredenciales;
        private System.Windows.Forms.TextBox txtContrasena2Usuario;
        private System.Windows.Forms.TextBox txtContrasena1Usuario;
        private System.Windows.Forms.Label lblContrasenaUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblUsuarioBusqueda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbBusquedaUsuario;
    }
}