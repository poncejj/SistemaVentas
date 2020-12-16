namespace SistemaVentas
{
    partial class frmPago
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
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbDeposito = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.calFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPagado = new System.Windows.Forms.TextBox();
            this.gbPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPago
            // 
            this.gbPago.BackColor = System.Drawing.Color.Transparent;
            this.gbPago.Controls.Add(this.rbEfectivo);
            this.gbPago.Controls.Add(this.rbDeposito);
            this.gbPago.Controls.Add(this.rbCheque);
            this.gbPago.Controls.Add(this.calFecha);
            this.gbPago.Controls.Add(this.lblFecha);
            this.gbPago.Controls.Add(this.dgPagos);
            this.gbPago.Controls.Add(this.txtValor);
            this.gbPago.Controls.Add(this.lblValor);
            this.gbPago.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gbPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbPago.Location = new System.Drawing.Point(12, 16);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(418, 185);
            this.gbPago.TabIndex = 41;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(254, 66);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(97, 30);
            this.rbEfectivo.TabIndex = 28;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbDeposito
            // 
            this.rbDeposito.AutoSize = true;
            this.rbDeposito.Location = new System.Drawing.Point(152, 66);
            this.rbDeposito.Name = "rbDeposito";
            this.rbDeposito.Size = new System.Drawing.Size(104, 30);
            this.rbDeposito.TabIndex = 27;
            this.rbDeposito.Text = "Deposito";
            this.rbDeposito.UseVisualStyleBackColor = true;
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Checked = true;
            this.rbCheque.Location = new System.Drawing.Point(53, 64);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(93, 30);
            this.rbCheque.TabIndex = 26;
            this.rbCheque.TabStop = true;
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            // 
            // calFecha
            // 
            this.calFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calFecha.Location = new System.Drawing.Point(224, 27);
            this.calFecha.Name = "calFecha";
            this.calFecha.Size = new System.Drawing.Size(134, 33);
            this.calFecha.TabIndex = 25;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFecha.Location = new System.Drawing.Point(158, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 26);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha";
            // 
            // dgPagos
            // 
            this.dgPagos.AllowUserToAddRows = false;
            this.dgPagos.AllowUserToDeleteRows = false;
            this.dgPagos.AllowUserToResizeRows = false;
            this.dgPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPagos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgPagos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPagos.GridColor = System.Drawing.Color.White;
            this.dgPagos.Location = new System.Drawing.Point(19, 95);
            this.dgPagos.MultiSelect = false;
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.ReadOnly = true;
            this.dgPagos.RowHeadersVisible = false;
            this.dgPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPagos.ShowCellToolTips = false;
            this.dgPagos.ShowEditingIcon = false;
            this.dgPagos.ShowRowErrors = false;
            this.dgPagos.Size = new System.Drawing.Size(393, 73);
            this.dgPagos.TabIndex = 23;
            this.dgPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPagos_CellContentClick);
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Location = new System.Drawing.Point(67, 32);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(85, 26);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblValor.Location = new System.Drawing.Point(6, 32);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(55, 26);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Valor";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(340, 207);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(79, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 26);
            this.label5.TabIndex = 59;
            this.label5.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(18, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "Total";
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagado.Enabled = false;
            this.txtTotalPagado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.txtTotalPagado.Location = new System.Drawing.Point(107, 207);
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.Size = new System.Drawing.Size(81, 26);
            this.txtTotalPagado.TabIndex = 57;
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SistemaVentas.Properties.Resources.fondo_2;
            this.ClientSize = new System.Drawing.Size(442, 248);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPagado);
            this.Controls.Add(this.gbPago);
            this.Controls.Add(this.btnGuardar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPago";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPagado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker calFecha;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbDeposito;
        private System.Windows.Forms.RadioButton rbCheque;
    }
}