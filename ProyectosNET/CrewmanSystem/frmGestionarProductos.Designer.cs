namespace CrewmanSystem
{
	partial class frmGestionarProductos
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
			this.pnlGestion = new System.Windows.Forms.Panel();
			this.pnlGridView = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUBFAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIOSUGERIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANT_UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlGestion.SuspendLayout();
			this.pnlGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlGestion
			// 
			this.pnlGestion.Controls.Add(this.pnlGridView);
			this.pnlGestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGestion.Location = new System.Drawing.Point(0, 0);
			this.pnlGestion.Name = "pnlGestion";
			this.pnlGestion.Size = new System.Drawing.Size(1097, 383);
			this.pnlGestion.TabIndex = 1;
			// 
			// pnlGridView
			// 
			this.pnlGridView.Controls.Add(this.dataGridView1);
			this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGridView.Location = new System.Drawing.Point(0, 0);
			this.pnlGridView.Name = "pnlGridView";
			this.pnlGridView.Size = new System.Drawing.Size(1097, 383);
			this.pnlGridView.TabIndex = 11;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeight = 30;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.SUBFAMILIA,
            this.FAMILIA,
            this.MARCA,
            this.PRECIOSUGERIDO,
            this.CANT_UNIDADES,
            this.UNIDADES,
            this.STOCK});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1097, 383);
			this.dataGridView1.TabIndex = 1;
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
			this.SUBFAMILIA.DataPropertyName = "subFamilia";
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
			this.MARCA.DataPropertyName = "marca";
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
			// frmGestionarProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1097, 383);
			this.Controls.Add(this.pnlGestion);
			this.Name = "frmGestionarProductos";
			this.Text = "Gestión de Productos";
			this.pnlGestion.ResumeLayout(false);
			this.pnlGridView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlGestion;
		private System.Windows.Forms.Panel pnlGridView;
		private System.Windows.Forms.DataGridView dataGridView1;
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