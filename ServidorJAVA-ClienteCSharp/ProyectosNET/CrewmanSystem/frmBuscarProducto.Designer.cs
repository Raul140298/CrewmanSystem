namespace CrewmanSystem
{
	partial class frmBuscarProducto
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtSubfamilia = new System.Windows.Forms.TextBox();
			this.txtFamilia = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUBFAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIOSUGERIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANT_UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblID);
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.txtSubfamilia);
			this.panel1.Controls.Add(this.txtFamilia);
			this.panel1.Controls.Add(this.txtMarca);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(985, 100);
			this.panel1.TabIndex = 45;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Location = new System.Drawing.Point(11, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 22);
			this.label5.TabIndex = 62;
			this.label5.Text = "Nombre :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Location = new System.Drawing.Point(384, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 22);
			this.label4.TabIndex = 61;
			this.label4.Text = "Marca :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Location = new System.Drawing.Point(11, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 22);
			this.label3.TabIndex = 60;
			this.label3.Text = "Familia :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblID.Location = new System.Drawing.Point(366, 52);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(103, 22);
			this.lblID.TabIndex = 59;
			this.lblID.Text = "Subfamilia :";
			this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(707, 28);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(144, 30);
			this.btnBuscar.TabIndex = 54;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtSubfamilia
			// 
			this.txtSubfamilia.Location = new System.Drawing.Point(475, 52);
			this.txtSubfamilia.Name = "txtSubfamilia";
			this.txtSubfamilia.Size = new System.Drawing.Size(189, 22);
			this.txtSubfamilia.TabIndex = 53;
			// 
			// txtFamilia
			// 
			this.txtFamilia.Location = new System.Drawing.Point(157, 52);
			this.txtFamilia.Name = "txtFamilia";
			this.txtFamilia.Size = new System.Drawing.Size(189, 22);
			this.txtFamilia.TabIndex = 51;
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(475, 12);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(189, 22);
			this.txtMarca.TabIndex = 49;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(157, 12);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(189, 22);
			this.txtNombre.TabIndex = 46;
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProductos.ColumnHeadersHeight = 30;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.SUBFAMILIA,
            this.FAMILIA,
            this.MARCA,
            this.PRECIOSUGERIDO,
            this.CANT_UNIDADES,
            this.UNIDADES,
            this.STOCK});
			this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProductos.EnableHeadersVisualStyles = false;
			this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dgvProductos.Location = new System.Drawing.Point(0, 100);
			this.dgvProductos.MultiSelect = false;
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProductos.RowHeadersWidth = 51;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvProductos.RowTemplate.Height = 24;
			this.dgvProductos.Size = new System.Drawing.Size(985, 517);
			this.dgvProductos.TabIndex = 46;
			this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
			this.dgvProductos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvProductos_RowStateChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "idProducto";
			this.ID.HeaderText = "Id";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// NOMBRE
			// 
			this.NOMBRE.DataPropertyName = "nombre";
			this.NOMBRE.HeaderText = "Nombre";
			this.NOMBRE.MinimumWidth = 6;
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			this.NOMBRE.Width = 96;
			// 
			// SUBFAMILIA
			// 
			this.SUBFAMILIA.HeaderText = "Subfamilia";
			this.SUBFAMILIA.MinimumWidth = 6;
			this.SUBFAMILIA.Name = "SUBFAMILIA";
			this.SUBFAMILIA.ReadOnly = true;
			this.SUBFAMILIA.Width = 115;
			// 
			// FAMILIA
			// 
			this.FAMILIA.HeaderText = "Familia";
			this.FAMILIA.MinimumWidth = 6;
			this.FAMILIA.Name = "FAMILIA";
			this.FAMILIA.ReadOnly = true;
			this.FAMILIA.Width = 91;
			// 
			// MARCA
			// 
			this.MARCA.HeaderText = "Marca";
			this.MARCA.MinimumWidth = 6;
			this.MARCA.Name = "MARCA";
			this.MARCA.ReadOnly = true;
			this.MARCA.Width = 84;
			// 
			// PRECIOSUGERIDO
			// 
			this.PRECIOSUGERIDO.DataPropertyName = "precioSugerido";
			this.PRECIOSUGERIDO.HeaderText = "Precio Sugerido";
			this.PRECIOSUGERIDO.MinimumWidth = 6;
			this.PRECIOSUGERIDO.Name = "PRECIOSUGERIDO";
			this.PRECIOSUGERIDO.ReadOnly = true;
			this.PRECIOSUGERIDO.Width = 156;
			// 
			// CANT_UNIDADES
			// 
			this.CANT_UNIDADES.DataPropertyName = "cantUnidad";
			this.CANT_UNIDADES.HeaderText = "Cantidad Unid.";
			this.CANT_UNIDADES.MinimumWidth = 6;
			this.CANT_UNIDADES.Name = "CANT_UNIDADES";
			this.CANT_UNIDADES.ReadOnly = true;
			this.CANT_UNIDADES.Width = 146;
			// 
			// UNIDADES
			// 
			this.UNIDADES.DataPropertyName = "unidades";
			this.UNIDADES.HeaderText = "Unidades";
			this.UNIDADES.MinimumWidth = 6;
			this.UNIDADES.Name = "UNIDADES";
			this.UNIDADES.ReadOnly = true;
			this.UNIDADES.Width = 107;
			// 
			// STOCK
			// 
			this.STOCK.DataPropertyName = "stock";
			this.STOCK.HeaderText = "Stock";
			this.STOCK.MinimumWidth = 6;
			this.STOCK.Name = "STOCK";
			this.STOCK.ReadOnly = true;
			this.STOCK.Width = 79;
			// 
			// frmBuscarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 617);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.panel1);
			this.Name = "frmBuscarProducto";
			this.Text = "frmBuscarProducto";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtSubfamilia;
		private System.Windows.Forms.TextBox txtFamilia;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBFAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIOSUGERIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_UNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK;
    }
}