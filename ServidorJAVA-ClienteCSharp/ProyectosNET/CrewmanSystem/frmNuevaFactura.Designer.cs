namespace CrewmanSystem
{
	partial class frmNuevaFactura
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
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.txtMontoPendiente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEstadoPagar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(222, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 30);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBuscarPedido.FlatAppearance.BorderSize = 0;
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscarPedido.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarPedido.Location = new System.Drawing.Point(318, 67);
            this.btnBuscarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnBuscarPedido.Size = new System.Drawing.Size(34, 22);
            this.btnBuscarPedido.TabIndex = 86;
            this.btnBuscarPedido.Text = "...";
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 85;
            this.label1.Text = "Código del Pedido :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpEmision
            // 
            this.dtpEmision.Enabled = false;
            this.dtpEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpEmision.Location = new System.Drawing.Point(222, 260);
            this.dtpEmision.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(330, 26);
            this.dtpEmision.TabIndex = 90;
            this.dtpEmision.Value = new System.DateTime(2020, 12, 14, 19, 36, 30, 0);
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMonto.Location = new System.Drawing.Point(222, 146);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(70, 19);
            this.txtMonto.TabIndex = 91;
            // 
            // txtObservacion
            // 
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtObservacion.Location = new System.Drawing.Point(222, 188);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(438, 57);
            this.txtObservacion.TabIndex = 92;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpVencimiento.Location = new System.Drawing.Point(222, 304);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(330, 26);
            this.dtpVencimiento.TabIndex = 93;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImpuestos.Enabled = false;
            this.txtImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImpuestos.Location = new System.Drawing.Point(222, 348);
            this.txtImpuestos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(154, 19);
            this.txtImpuestos.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(37, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 95;
            this.label2.Text = "Monto :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(38, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 96;
            this.label3.Text = "Observación :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(37, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 22);
            this.label4.TabIndex = 97;
            this.label4.Text = "Fecha de emisión :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(17, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 98;
            this.label5.Text = "Fecha de vencimiento :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(38, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 22);
            this.label6.TabIndex = 99;
            this.label6.Text = "Impuestos :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdPedido.Location = new System.Drawing.Point(222, 70);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(70, 19);
            this.txtIdPedido.TabIndex = 101;
            // 
            // txtMontoPendiente
            // 
            this.txtMontoPendiente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMontoPendiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoPendiente.Enabled = false;
            this.txtMontoPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMontoPendiente.Location = new System.Drawing.Point(222, 107);
            this.txtMontoPendiente.Name = "txtMontoPendiente";
            this.txtMontoPendiente.Size = new System.Drawing.Size(70, 19);
            this.txtMontoPendiente.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(37, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 22);
            this.label7.TabIndex = 102;
            this.label7.Text = "Monto pendiente :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEstadoPagar
            // 
            this.cboEstadoPagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstadoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboEstadoPagar.FormattingEnabled = true;
            this.cboEstadoPagar.Location = new System.Drawing.Point(486, 141);
            this.cboEstadoPagar.Name = "cboEstadoPagar";
            this.cboEstadoPagar.Size = new System.Drawing.Size(174, 28);
            this.cboEstadoPagar.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(344, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 22);
            this.label8.TabIndex = 105;
            this.label8.Text = "Estado de pago :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(112, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 22);
            this.label9.TabIndex = 106;
            this.label9.Text = "ID Factura :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdFactura.Enabled = false;
            this.txtIdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIdFactura.Location = new System.Drawing.Point(222, 33);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(70, 19);
            this.txtIdFactura.TabIndex = 107;
            // 
            // frmNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboEstadoPagar);
            this.Controls.Add(this.txtMontoPendiente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImpuestos);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dtpEmision);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmNuevaFactura";
            this.Text = "frmNuevaFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.TextBox txtMontoPendiente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEstadoPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdFactura;
    }
}