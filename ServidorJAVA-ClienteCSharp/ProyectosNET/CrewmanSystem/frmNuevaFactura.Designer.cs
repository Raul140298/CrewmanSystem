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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.txtMontoPendiente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(244, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 40);
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
            this.btnBuscarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPedido.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarPedido.Location = new System.Drawing.Point(364, 30);
            this.btnBuscarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnBuscarPedido.Size = new System.Drawing.Size(34, 22);
            this.btnBuscarPedido.TabIndex = 86;
            this.btnBuscarPedido.Text = "...";
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarProductoXZona_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 85;
            this.label1.Text = "Código del Pedido :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 208);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(434, 22);
            this.dateTimePicker1.TabIndex = 90;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 4, 9, 52, 39, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 22);
            this.textBox1.TabIndex = 91;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 163);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 22);
            this.textBox2.TabIndex = 92;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(244, 252);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(434, 22);
            this.dateTimePicker2.TabIndex = 93;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(244, 301);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 22);
            this.textBox3.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 95;
            this.label2.Text = "Monto :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(60, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 96;
            this.label3.Text = "Observación :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(59, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 22);
            this.label4.TabIndex = 97;
            this.label4.Text = "Fecha de emisión :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(59, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 22);
            this.label5.TabIndex = 98;
            this.label5.Text = "Fecha de vencimiento :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(59, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 22);
            this.label6.TabIndex = 99;
            this.label6.Text = "Impuestos :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(244, 31);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(97, 22);
            this.txtIdPedido.TabIndex = 101;
            // 
            // txtMontoPendiente
            // 
            this.txtMontoPendiente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMontoPendiente.Enabled = false;
            this.txtMontoPendiente.Location = new System.Drawing.Point(244, 75);
            this.txtMontoPendiente.Name = "txtMontoPendiente";
            this.txtMontoPendiente.Size = new System.Drawing.Size(97, 22);
            this.txtMontoPendiente.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(60, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 22);
            this.label7.TabIndex = 102;
            this.label7.Text = "Monto pendiente :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.txtMontoPendiente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.TextBox txtMontoPendiente;
        private System.Windows.Forms.Label label7;
    }
}