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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboZona = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProductosXZona = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_REAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBFAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosXZona)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboZona);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 46;
            // 
            // cboZona
            // 
            this.cboZona.FormattingEnabled = true;
            this.cboZona.Location = new System.Drawing.Point(158, 12);
            this.cboZona.Name = "cboZona";
            this.cboZona.Size = new System.Drawing.Size(263, 24);
            this.cboZona.TabIndex = 56;
            // 
            // lblID
            // 
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Location = new System.Drawing.Point(12, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(140, 22);
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
            this.btnBuscar.Location = new System.Drawing.Point(495, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 40);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvProductosXZona
            // 
            this.dgvProductosXZona.AllowUserToAddRows = false;
            this.dgvProductosXZona.AllowUserToDeleteRows = false;
            this.dgvProductosXZona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosXZona.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosXZona.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvProductosXZona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosXZona.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosXZona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosXZona.ColumnHeadersHeight = 30;
            this.dgvProductosXZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductosXZona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRODUCTO,
            this.CANT_UNIDADES,
            this.UNIDADES,
            this.ZONA,
            this.PRECIO_REAL,
            this.SUBFAMILIA,
            this.FAMILIA,
            this.MARCA});
            this.dgvProductosXZona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductosXZona.EnableHeadersVisualStyles = false;
            this.dgvProductosXZona.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvProductosXZona.Location = new System.Drawing.Point(0, 81);
            this.dgvProductosXZona.MultiSelect = false;
            this.dgvProductosXZona.Name = "dgvProductosXZona";
            this.dgvProductosXZona.ReadOnly = true;
            this.dgvProductosXZona.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosXZona.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosXZona.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductosXZona.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductosXZona.RowTemplate.Height = 24;
            this.dgvProductosXZona.Size = new System.Drawing.Size(800, 369);
            this.dgvProductosXZona.TabIndex = 47;
            this.dgvProductosXZona.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductosXZona_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idProductoXZona";
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
            this.CANT_UNIDADES.HeaderText = "Cant. Unidades";
            this.CANT_UNIDADES.MinimumWidth = 6;
            this.CANT_UNIDADES.Name = "CANT_UNIDADES";
            this.CANT_UNIDADES.ReadOnly = true;
            this.CANT_UNIDADES.Width = 151;
            // 
            // UNIDADES
            // 
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
            this.PRECIO_REAL.HeaderText = "Precio";
            this.PRECIO_REAL.MinimumWidth = 6;
            this.PRECIO_REAL.Name = "PRECIO_REAL";
            this.PRECIO_REAL.ReadOnly = true;
            this.PRECIO_REAL.Width = 85;
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
            // frmBuscarProductoXZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductosXZona);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuscarProductoXZona";
            this.Text = "frmProductoXZona";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosXZona)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cboZona;
        private System.Windows.Forms.DataGridView dgvProductosXZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_UNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_REAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBFAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
    }
}