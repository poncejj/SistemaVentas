namespace SistemaVentas
{
    partial class frmPanelPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPaquete = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnVariables = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(60, 20);
            this.fileMenu.Text = "&Archivo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(93, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSize = true;
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton1;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Image = global::SistemaVentas.Properties.Resources.user_group_icon;
            this.btnCliente.Location = new System.Drawing.Point(0, 27);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(134, 134);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.UseMnemonic = false;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPaquete
            // 
            this.btnPaquete.AutoSize = true;
            this.btnPaquete.BackColor = System.Drawing.Color.Transparent;
            this.btnPaquete.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton3;
            this.btnPaquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaquete.FlatAppearance.BorderSize = 0;
            this.btnPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaquete.Image = global::SistemaVentas.Properties.Resources.paquete;
            this.btnPaquete.Location = new System.Drawing.Point(0, 295);
            this.btnPaquete.Name = "btnPaquete";
            this.btnPaquete.Size = new System.Drawing.Size(134, 134);
            this.btnPaquete.TabIndex = 4;
            this.btnPaquete.UseMnemonic = false;
            this.btnPaquete.UseVisualStyleBackColor = false;
            this.btnPaquete.Click += new System.EventHandler(this.btnPaquete_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.AutoSize = true;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton4;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Image = global::SistemaVentas.Properties.Resources.venta__1_;
            this.btnVentas.Location = new System.Drawing.Point(0, 429);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(134, 134);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.UseMnemonic = false;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.AutoSize = true;
            this.btnProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton2;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Image = global::SistemaVentas.Properties.Resources.Cart_icon;
            this.btnProducto.Location = new System.Drawing.Point(0, 161);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(134, 134);
            this.btnProducto.TabIndex = 7;
            this.btnProducto.UseMnemonic = false;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnVariables
            // 
            this.btnVariables.AutoSize = true;
            this.btnVariables.BackColor = System.Drawing.Color.Transparent;
            this.btnVariables.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton7png;
            this.btnVariables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVariables.FlatAppearance.BorderSize = 0;
            this.btnVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariables.Image = global::SistemaVentas.Properties.Resources.config1;
            this.btnVariables.Location = new System.Drawing.Point(1227, 563);
            this.btnVariables.Name = "btnVariables";
            this.btnVariables.Size = new System.Drawing.Size(134, 134);
            this.btnVariables.TabIndex = 8;
            this.btnVariables.UseMnemonic = false;
            this.btnVariables.UseVisualStyleBackColor = false;
            this.btnVariables.Click += new System.EventHandler(this.btnVariables_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = true;
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton6;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Image = global::SistemaVentas.Properties.Resources.user;
            this.btnUsuarios.Location = new System.Drawing.Point(1227, 429);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(134, 134);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.UseMnemonic = false;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.AutoSize = true;
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton5;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Image = global::SistemaVentas.Properties.Resources.eventmgr;
            this.btnReportes.Location = new System.Drawing.Point(0, 563);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(134, 134);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.UseMnemonic = false;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton_8;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::SistemaVentas.Properties.Resources.logout;
            this.btnSalir.Location = new System.Drawing.Point(1228, 27);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 134);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseMnemonic = false;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.AutoSize = true;
            this.btnBackUp.BackColor = System.Drawing.Color.Transparent;
            this.btnBackUp.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_boton_9;
            this.btnBackUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackUp.FlatAppearance.BorderSize = 0;
            this.btnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUp.Image = global::SistemaVentas.Properties.Resources.backup;
            this.btnBackUp.Location = new System.Drawing.Point(1227, 295);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(134, 134);
            this.btnBackUp.TabIndex = 15;
            this.btnBackUp.UseMnemonic = false;
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // frmPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_modelo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 692);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnPaquete);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnVariables);
            this.Controls.Add(this.btnUsuarios);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPanelPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE VENTAS";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPanelPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPanelPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPaquete;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnVariables;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBackUp;

    }
}



