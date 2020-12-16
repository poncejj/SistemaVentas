namespace SistemaVentas
{
    partial class frmVariablesSistema
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbCredenciales = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoombreBase = new System.Windows.Forms.TextBox();
            this.txtPasswordBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioBase = new System.Windows.Forms.TextBox();
            this.lblContrasenaUsuario = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.gbCredenciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(329, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbCredenciales
            // 
            this.gbCredenciales.BackColor = System.Drawing.Color.Transparent;
            this.gbCredenciales.Controls.Add(this.btnGuardar);
            this.gbCredenciales.Controls.Add(this.label2);
            this.gbCredenciales.Controls.Add(this.txtNoombreBase);
            this.gbCredenciales.Controls.Add(this.txtPasswordBase);
            this.gbCredenciales.Controls.Add(this.label1);
            this.gbCredenciales.Controls.Add(this.txtUsuarioBase);
            this.gbCredenciales.Controls.Add(this.lblContrasenaUsuario);
            this.gbCredenciales.Controls.Add(this.txtServidor);
            this.gbCredenciales.Controls.Add(this.lblLoginUsuario);
            this.gbCredenciales.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbCredenciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbCredenciales.Location = new System.Drawing.Point(12, 19);
            this.gbCredenciales.Name = "gbCredenciales";
            this.gbCredenciales.Size = new System.Drawing.Size(418, 205);
            this.gbCredenciales.TabIndex = 40;
            this.gbCredenciales.TabStop = false;
            this.gbCredenciales.Text = "Credenciales";
            this.gbCredenciales.Enter += new System.EventHandler(this.gbCredenciales_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre Base";
            // 
            // txtNoombreBase
            // 
            this.txtNoombreBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoombreBase.Location = new System.Drawing.Point(138, 64);
            this.txtNoombreBase.Name = "txtNoombreBase";
            this.txtNoombreBase.Size = new System.Drawing.Size(266, 26);
            this.txtNoombreBase.TabIndex = 2;
            this.txtNoombreBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // txtPasswordBase
            // 
            this.txtPasswordBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordBase.Location = new System.Drawing.Point(138, 128);
            this.txtPasswordBase.Name = "txtPasswordBase";
            this.txtPasswordBase.Size = new System.Drawing.Size(175, 26);
            this.txtPasswordBase.TabIndex = 4;
            this.txtPasswordBase.UseSystemPasswordChar = true;
            this.txtPasswordBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Contraseña";
            // 
            // txtUsuarioBase
            // 
            this.txtUsuarioBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioBase.Location = new System.Drawing.Point(138, 96);
            this.txtUsuarioBase.Name = "txtUsuarioBase";
            this.txtUsuarioBase.Size = new System.Drawing.Size(266, 26);
            this.txtUsuarioBase.TabIndex = 3;
            this.txtUsuarioBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // lblContrasenaUsuario
            // 
            this.lblContrasenaUsuario.AutoSize = true;
            this.lblContrasenaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenaUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblContrasenaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblContrasenaUsuario.Location = new System.Drawing.Point(6, 96);
            this.lblContrasenaUsuario.Name = "lblContrasenaUsuario";
            this.lblContrasenaUsuario.Size = new System.Drawing.Size(77, 26);
            this.lblContrasenaUsuario.TabIndex = 24;
            this.lblContrasenaUsuario.Text = "Usuario";
            // 
            // txtServidor
            // 
            this.txtServidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServidor.Location = new System.Drawing.Point(138, 32);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(266, 26);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress_alfanum);
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblLoginUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLoginUsuario.Location = new System.Drawing.Point(6, 32);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(82, 26);
            this.lblLoginUsuario.TabIndex = 22;
            this.lblLoginUsuario.Text = "Servidor";
            // 
            // frmVariablesSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.ClientSize = new System.Drawing.Size(442, 236);
            this.Controls.Add(this.gbCredenciales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVariablesSistema";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVariablesSistema";
            this.Load += new System.EventHandler(this.frmVariablesSistema_Load);
            this.gbCredenciales.ResumeLayout(false);
            this.gbCredenciales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbCredenciales;
        private System.Windows.Forms.TextBox txtUsuarioBase;
        private System.Windows.Forms.Label lblContrasenaUsuario;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoombreBase;
        private System.Windows.Forms.TextBox txtPasswordBase;
        private System.Windows.Forms.Label label1;
    }
}