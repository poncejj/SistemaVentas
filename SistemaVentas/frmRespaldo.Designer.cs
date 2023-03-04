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
            this.btnGenerarRespaldo = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbRespaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarRuta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarRuta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRuta.Location = new System.Drawing.Point(681, 33);
            this.btnBuscarRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(43, 36);
            this.btnBuscarRuta.TabIndex = 18;
            this.btnBuscarRuta.Text = "...";
            this.btnBuscarRuta.UseVisualStyleBackColor = false;
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnBuscarRuta_Click);
            // 
            // gbRespaldo
            // 
            this.gbRespaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRespaldo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbRespaldo.BackColor = System.Drawing.Color.Transparent;
            this.gbRespaldo.Controls.Add(this.txtRuta);
            this.gbRespaldo.Controls.Add(this.btnGenerarRespaldo);
            this.gbRespaldo.Controls.Add(this.btnBuscarRuta);
            this.gbRespaldo.Controls.Add(this.lblRuta);
            this.gbRespaldo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbRespaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbRespaldo.Location = new System.Drawing.Point(16, 9);
            this.gbRespaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRespaldo.Name = "gbRespaldo";
            this.gbRespaldo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRespaldo.Size = new System.Drawing.Size(891, 96);
            this.gbRespaldo.TabIndex = 19;
            this.gbRespaldo.TabStop = false;
            this.gbRespaldo.Text = "Respaldo";
            // 
            // txtRuta
            // 
            this.txtRuta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuta.Location = new System.Drawing.Point(95, 30);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(577, 40);
            this.txtRuta.TabIndex = 19;
            // 
            // btnGenerarRespaldo
            // 
            this.btnGenerarRespaldo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerarRespaldo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerarRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRespaldo.Location = new System.Drawing.Point(732, 33);
            this.btnGenerarRespaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarRespaldo.Name = "btnGenerarRespaldo";
            this.btnGenerarRespaldo.Size = new System.Drawing.Size(115, 36);
            this.btnGenerarRespaldo.TabIndex = 17;
            this.btnGenerarRespaldo.Text = "Generar";
            this.btnGenerarRespaldo.UseVisualStyleBackColor = false;
            this.btnGenerarRespaldo.Click += new System.EventHandler(this.btnGenerarRespaldo_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.Color.Transparent;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRuta.Location = new System.Drawing.Point(23, 39);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(62, 29);
            this.lblRuta.TabIndex = 18;
            this.lblRuta.Text = "Ruta";
            // 
            // frmRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.ClientSize = new System.Drawing.Size(923, 130);
            this.Controls.Add(this.gbRespaldo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(941, 177);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(941, 177);
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