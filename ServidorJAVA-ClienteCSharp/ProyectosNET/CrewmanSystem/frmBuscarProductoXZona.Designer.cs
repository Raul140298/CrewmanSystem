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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_ZONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ZONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_REAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblID);
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 60);
			this.panel1.TabIndex = 46;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(168, 12);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(280, 22);
			this.txtNombre.TabIndex = 46;
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
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView1.ColumnHeadersHeight = 30;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_PRODUCTO,
            this.PRODUCTO,
            this.ID_ZONA,
            this.ZONA,
            this.PRECIO_REAL,
            this.FECHA_INICIO,
            this.FECHA_FIN});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 60);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(800, 390);
			this.dataGridView1.TabIndex = 47;
			// 
			// ID
			// 
			this.ID.HeaderText = "Id";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// ID_PRODUCTO
			// 
			this.ID_PRODUCTO.HeaderText = "Id Producto";
			this.ID_PRODUCTO.MinimumWidth = 6;
			this.ID_PRODUCTO.Name = "ID_PRODUCTO";
			this.ID_PRODUCTO.ReadOnly = true;
			this.ID_PRODUCTO.Width = 122;
			// 
			// PRODUCTO
			// 
			this.PRODUCTO.HeaderText = "Producto";
			this.PRODUCTO.MinimumWidth = 6;
			this.PRODUCTO.Name = "PRODUCTO";
			this.PRODUCTO.ReadOnly = true;
			this.PRODUCTO.Width = 104;
			// 
			// ID_ZONA
			// 
			this.ID_ZONA.HeaderText = "Id Zona";
			this.ID_ZONA.MinimumWidth = 6;
			this.ID_ZONA.Name = "ID_ZONA";
			this.ID_ZONA.ReadOnly = true;
			this.ID_ZONA.Width = 91;
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
			this.PRECIO_REAL.HeaderText = "Precio";
			this.PRECIO_REAL.MinimumWidth = 6;
			this.PRECIO_REAL.Name = "PRECIO_REAL";
			this.PRECIO_REAL.ReadOnly = true;
			this.PRECIO_REAL.Width = 85;
			// 
			// FECHA_INICIO
			// 
			this.FECHA_INICIO.HeaderText = "Fecha Inicio";
			this.FECHA_INICIO.MinimumWidth = 6;
			this.FECHA_INICIO.Name = "FECHA_INICIO";
			this.FECHA_INICIO.ReadOnly = true;
			this.FECHA_INICIO.Width = 127;
			// 
			// FECHA_FIN
			// 
			this.FECHA_FIN.HeaderText = "Fecha Fin";
			this.FECHA_FIN.MinimumWidth = 6;
			this.FECHA_FIN.Name = "FECHA_FIN";
			this.FECHA_FIN.ReadOnly = true;
			this.FECHA_FIN.Width = 111;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(505, 12);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(160, 40);
			this.btnBuscar.TabIndex = 53;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
			// frmBuscarProductoXZona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "frmBuscarProductoXZona";
			this.Text = "frmProductoXZona";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_ZONA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZONA;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_REAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_FIN;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblID;
	}
}