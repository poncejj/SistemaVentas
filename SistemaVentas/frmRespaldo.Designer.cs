namespace SistemaVentas
{
    partial class frmRespaldo
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
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.gbRespaldo = new System.Windows.Forms.GroupBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnGenerarRespaldo = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbRespaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarRuta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRuta.Location = new System.Drawing.Point(511, 27);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(32, 29);
            this.btnBuscarRuta.TabIndex = 18;
            this.btnBuscarRuta.Text = "...";
            this.btnBuscarRuta.UseVisualStyleBackColor = false;
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnBuscarRuta_Click);
            // 
            // gbRespaldo
            // 
            this.gbRespaldo.BackColor = System.Drawing.Color.Transparent;
            this.gbRespaldo.Controls.Add(this.txtRuta);
            this.gbRespaldo.Controls.Add(this.btnGenerarRespaldo);
            this.gbRespaldo.Controls.Add(this.btnBuscarRuta);
            this.gbRespaldo.Controls.Add(this.lblRuta);
            this.gbRespaldo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbRespaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbRespaldo.Location = new System.Drawing.Point(12, 7);
            this.gbRespaldo.Name = "gbRespaldo";
            this.gbRespaldo.Size = new System.Drawing.Size(668, 78);
            this.gbRespaldo.TabIndex = 19;
            this.gbRespaldo.TabStop = false;
            this.gbRespaldo.Text = "Respaldo";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(71, 24);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(434, 33);
            this.txtRuta.TabIndex = 19;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.Color.Transparent;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRuta.Location = new System.Drawing.Point(17, 32);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 24);
            this.lblRuta.TabIndex = 18;
            this.lblRuta.Text = "Ruta";
            // 
            // btnGenerarRespaldo
            // 
            this.btnGenerarRespaldo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerarRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRespaldo.Location = new System.Drawing.Point(549, 27);
            this.btnGenerarRespaldo.Name = "btnGenerarRespaldo";
            this.btnGenerarRespaldo.Size = new System.Drawing.Size(86, 29);
            this.btnGenerarRespaldo.TabIndex = 17;
            this.btnGenerarRespaldo.Text = "Generar";
            this.btnGenerarRespaldo.UseVisualStyleBackColor = false;
            this.btnGenerarRespaldo.Click += new System.EventHandler(this.btnGenerarRespaldo_Click);
            // 
            // frmRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.ClientSize = new System.Drawing.Size(692, 106);
            this.Controls.Add(this.gbRespaldo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRespaldo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respaldo";
            this.Load += new System.EventHandler(this.frmRespaldo_Load);
            this.gbRespaldo.ResumeLayout(false);
            this.gbRespaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.GroupBox gbRespaldo;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnGenerarRespaldo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}