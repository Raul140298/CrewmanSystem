namespace CrewmanSystem
{
	partial class frmBuscarProductoXZona
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProductoXZona));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSubfamilia = new System.Windows.Forms.TextBox();
			this.txtFamilia = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.cboZona = new System.Windows.Forms.ComboBox();
			this.lblID = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dgvProductoXZona = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANT_UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ZONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_REAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUBFAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductoXZona)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtSubfamilia);
			this.panel1.Controls.Add(this.txtFamilia);
			this.panel1.Controls.Add(this.txtMarca);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.cboZona);
			this.panel1.Controls.Add(this.lblID);
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 160);
			this.panel1.TabIndex = 46;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Location = new System.Drawing.Point(48, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 22);
			this.label5.TabIndex = 70;
			this.label5.Text = "Nombre :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Location = new System.Drawing.Point(382, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 22);
			this.label4.TabIndex = 69;
			this.label4.Text = "Marca :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Location = new System.Drawing.Point(48, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 22);
			this.label3.TabIndex = 68;
			this.label3.Text = "Familia :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(364, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 22);
			this.label1.TabIndex = 67;
			this.label1.Text = "Subfamilia :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSubfamilia
			// 
			this.txtSubfamilia.Location = new System.Drawing.Point(473, 107);
			this.txtSubfamilia.Name = "txtSubfamilia";
			this.txtSubfamilia.Size = new System.Drawing.Size(189, 22);
			this.txtSubfamilia.TabIndex = 66;
			// 
			// txtFamilia
			// 
			this.txtFamilia.Location = new System.Drawing.Point(155, 107);
			this.txtFamilia.Name = "txtFamilia";
			this.txtFamilia.Size = new System.Drawing.Size(189, 22);
			this.txtFamilia.TabIndex = 65;
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(473, 67);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(189, 22);
			this.txtMarca.TabIndex = 64;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(155, 67);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(189, 22);
			this.txtNombre.TabIndex = 63;
			// 
			// cboZona
			// 
			this.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboZona.FormattingEnabled = true;
			this.cboZona.Location = new System.Drawing.Point(155, 27);
			this.cboZona.Name = "cboZona";
			this.cboZona.Size = new System.Drawing.Size(189, 24);
			this.cboZona.TabIndex = 56;
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblID.Location = new System.Drawing.Point(45, 26);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(103, 22);
			this.lblID.TabIndex = 55;
			this.lblID.Text = "Zona :";
			this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(473, 23);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(189, 30);
			this.btnBuscar.TabIndex = 53;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// dgvProductoXZona
			// 
			this.dgvProductoXZona.AllowUserToAddRows = false;
			this.dgvProductoXZona.AllowUserToDeleteRows = false;
			this.dgvProductoXZona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvProductoXZona.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProductoXZona.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dgvProductoXZona.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProductoXZona.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductoXZona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProductoXZona.ColumnHeadersHeight = 30;
			this.dgvProductoXZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvProductoXZona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRODUCTO,
            this.CANT_UNIDADES,
            this.UNIDADES,
            this.ZONA,
            this.PRECIO_REAL,
            this.MARCA,
            this.SUBFAMILIA,
            this.FAMILIA});
			this.dgvProductoXZona.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProductoXZona.EnableHeadersVisualStyles = false;
			this.dgvProductoXZona.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dgvProductoXZona.Location = new System.Drawing.Point(0, 160);
			this.dgvProductoXZona.MultiSelect = false;
			this.dgvProductoXZona.Name = "dgvProductoXZona";
			this.dgvProductoXZona.ReadOnly = true;
			this.dgvProductoXZona.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductoXZona.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvProductoXZona.RowHeadersWidth = 51;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvProductoXZona.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvProductoXZona.RowTemplate.Height = 24;
			this.dgvProductoXZona.Size = new System.Drawing.Size(800, 290);
			this.dgvProductoXZona.TabIndex = 47;
			this.dgvProductoXZona.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductoXZona_CellFormatting);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "idProductoXZona";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ID.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID.HeaderText = "Id";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// PRODUCTO
			// 
			this.PRODUCTO.HeaderText = "Producto";
			this.PRODUCTO.MinimumWidth = 6;
			this.PRODUCTO.Name = "PRODUCTO";
			this.PRODUCTO.ReadOnly = true;
			this.PRODUCTO.Width = 104;
			// 
			// CANT_UNIDADES
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = null;
			this.CANT_UNIDADES.DefaultCellStyle = dataGridViewCellStyle3;
			this.CANT_UNIDADES.HeaderText = "Cant. Unidades";
			this.CANT_UNIDADES.MinimumWidth = 6;
			this.CANT_UNIDADES.Name = "CANT_UNIDADES";
			this.CANT_UNIDADES.ReadOnly = true;
			this.CANT_UNIDADES.Width = 151;
			// 
			// UNIDADES
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.UNIDADES.DefaultCellStyle = dataGridViewCellStyle4;
			this.UNIDADES.HeaderText = "Unidades";
			this.UNIDADES.MinimumWidth = 6;
			this.UNIDADES.Name = "UNIDADES";
			this.UNIDADES.ReadOnly = true;
			this.UNIDADES.Width = 107;
			// 
			// ZONA
			// 
			this.ZONA.HeaderText = "Zona";
			this.ZONA.MinimumWidth = 6;
			this.ZONA.Name = "ZONA";
			this.ZONA.ReadOnly = true;
			this.ZONA.Width = 73;
			// 
			// PRECIO_REAL
			// 
			this.PRECIO_REAL.DataPropertyName = "precioReal";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N2";
			this.PRECIO_REAL.DefaultCellStyle = dataGridViewCellStyle5;
			this.PRECIO_REAL.HeaderText = "Precio";
			this.PRECIO_REAL.MinimumWidth = 6;
			this.PRECIO_REAL.Name = "PRECIO_REAL";
			this.PRECIO_REAL.ReadOnly = true;
			this.PRECIO_REAL.Width = 85;
			// 
			// MARCA
			// 
			this.MARCA.HeaderText = "Marca";
			this.MARCA.MinimumWidth = 6;
			this.MARCA.Name = "MARCA";
			this.MARCA.ReadOnly = true;
			this.MARCA.Width = 84;
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
			// frmBuscarProductoXZona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvProductoXZona);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBuscarProductoXZona";
			this.Text = "Búsqueda de Productos por Zona";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductoXZona)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvProductoXZona;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cboZona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubfamilia;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANT_UNIDADES;
		private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZONA;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_REAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUBFAMILIA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
	}
}