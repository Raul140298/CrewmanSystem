namespace CrewmanSystem
{
	partial class frmNuevoProducto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboUnidades = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecioSugerido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboSubfamilia = new System.Windows.Forms.ComboBox();
            this.cboFamilia = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecioSugerido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.cboUnidades);
            this.panel2.Controls.Add(this.cboMarca);
            this.panel2.Controls.Add(this.txtPrecioSugerido);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.cboSubfamilia);
            this.panel2.Controls.Add(this.cboFamilia);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 594);
            this.panel2.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(5, 316);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(280, 22);
            this.txtCantidad.TabIndex = 55;
            // 
            // cboUnidades
            // 
            this.cboUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidades.FormattingEnabled = true;
            this.cboUnidades.Location = new System.Drawing.Point(5, 267);
            this.cboUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(280, 24);
            this.cboUnidades.TabIndex = 54;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(5, 219);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(280, 24);
            this.cboMarca.TabIndex = 53;
            // 
            // txtPrecioSugerido
            // 
            this.txtPrecioSugerido.Location = new System.Drawing.Point(5, 358);
            this.txtPrecioSugerido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioSugerido.Name = "txtPrecioSugerido";
            this.txtPrecioSugerido.Size = new System.Drawing.Size(280, 22);
            this.txtPrecioSugerido.TabIndex = 51;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(3, 453);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 39);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboSubfamilia
            // 
            this.cboSubfamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubfamilia.FormattingEnabled = true;
            this.cboSubfamilia.Location = new System.Drawing.Point(5, 169);
            this.cboSubfamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSubfamilia.Name = "cboSubfamilia";
            this.cboSubfamilia.Size = new System.Drawing.Size(280, 24);
            this.cboSubfamilia.TabIndex = 49;
            // 
            // cboFamilia
            // 
            this.cboFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilia.FormattingEnabled = true;
            this.cboFamilia.Location = new System.Drawing.Point(5, 123);
            this.cboFamilia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFamilia.Name = "cboFamilia";
            this.cboFamilia.Size = new System.Drawing.Size(280, 24);
            this.cboFamilia.TabIndex = 19;
            this.cboFamilia.SelectedIndexChanged += new System.EventHandler(this.cboFamilia_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(5, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 22);
            this.txtNombre.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(5, 38);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 22);
            this.txtId.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPrecioSugerido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 594);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(-5, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "Cantidad :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(-5, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "Unidades :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(0, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Marca :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecioSugerido
            // 
            this.lblPrecioSugerido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecioSugerido.Location = new System.Drawing.Point(-5, 358);
            this.lblPrecioSugerido.Name = "lblPrecioSugerido";
            this.lblPrecioSugerido.Size = new System.Drawing.Size(157, 22);
            this.lblPrecioSugerido.TabIndex = 50;
            this.lblPrecioSugerido.Text = "Precio Sugerido :";
            this.lblPrecioSugerido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(0, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Subfamilia :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(0, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Familia :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(0, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Location = new System.Drawing.Point(3, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(155, 22);
            this.lblID.TabIndex = 46;
            this.lblID.Text = "Id :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(-6, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "Stock :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(3, 397);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(280, 22);
            this.txtStock.TabIndex = 56;
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNuevoProducto";
            this.Text = "Nuevo Producto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cboSubfamilia;
		private System.Windows.Forms.ComboBox cboFamilia;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPrecioSugerido;
        private System.Windows.Forms.Label lblPrecioSugerido;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboUnidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label7;
    }
}