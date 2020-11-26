namespace CrewmanSystem
{
    partial class frmBuscarProductoPorZona
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProductoPorZona));
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANT_UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUBFAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_REAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_SUGERIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtSubfamilia = new System.Windows.Forms.TextBox();
			this.txtFamilia = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvProductos.ColumnHeadersHeight = 30;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.CANT_UNIDADES,
            this.UNIDADES,
            this.MARCA,
            this.SUBFAMILIA,
            this.FAMILIA,
            this.PRECIO_REAL,
            this.PRECIO_SUGERIDO,
            this.STOCK});
			this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProductos.EnableHeadersVisualStyles = false;
			this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dgvProductos.Location = new System.Drawing.Point(0, 128);
			this.dgvProductos.MultiSelect = false;
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.dgvProductos.RowHeadersWidth = 51;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvProductos.RowTemplate.Height = 24;
			this.dgvProductos.Size = new System.Drawing.Size(998, 322);
			this.dgvProductos.TabIndex = 48;
			this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
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
			// NOMBRE
			// 
			this.NOMBRE.HeaderText = "Nombre";
			this.NOMBRE.MinimumWidth = 6;
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			this.NOMBRE.Width = 96;
			// 
			// CANT_UNIDADES
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.CANT_UNIDADES.DefaultCellStyle = dataGridViewCellStyle10;
			this.CANT_UNIDADES.HeaderText = "Cantidad Unid.";
			this.CANT_UNIDADES.MinimumWidth = 6;
			this.CANT_UNIDADES.Name = "CANT_UNIDADES";
			this.CANT_UNIDADES.ReadOnly = true;
			this.CANT_UNIDADES.Width = 146;
			// 
			// UNIDADES
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.UNIDADES.DefaultCellStyle = dataGridViewCellStyle11;
			this.UNIDADES.HeaderText = "Unidades";
			this.UNIDADES.MinimumWidth = 6;
			this.UNIDADES.Name = "UNIDADES";
			this.UNIDADES.ReadOnly = true;
			this.UNIDADES.Width = 107;
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
			// PRECIO_REAL
			// 
			this.PRECIO_REAL.DataPropertyName = "precioReal";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.Format = "N2";
			this.PRECIO_REAL.DefaultCellStyle = dataGridViewCellStyle12;
			this.PRECIO_REAL.HeaderText = "Precio Real";
			this.PRECIO_REAL.MinimumWidth = 6;
			this.PRECIO_REAL.Name = "PRECIO_REAL";
			this.PRECIO_REAL.ReadOnly = true;
			this.PRECIO_REAL.Width = 124;
			// 
			// PRECIO_SUGERIDO
			// 
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.Format = "N2";
			this.PRECIO_SUGERIDO.DefaultCellStyle = dataGridViewCellStyle13;
			this.PRECIO_SUGERIDO.HeaderText = "Precio Sugerido";
			this.PRECIO_SUGERIDO.MinimumWidth = 6;
			this.PRECIO_SUGERIDO.Name = "PRECIO_SUGERIDO";
			this.PRECIO_SUGERIDO.ReadOnly = true;
			this.PRECIO_SUGERIDO.Width = 156;
			// 
			// STOCK
			// 
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.STOCK.DefaultCellStyle = dataGridViewCellStyle14;
			this.STOCK.HeaderText = "Stock";
			this.STOCK.MinimumWidth = 6;
			this.STOCK.Name = "STOCK";
			this.STOCK.ReadOnly = true;
			this.STOCK.Width = 79;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSeleccionar);
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
			this.panel1.Size = new System.Drawing.Size(998, 128);
			this.panel1.TabIndex = 47;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
			this.btnSeleccionar.Location = new System.Drawing.Point(686, 73);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(140, 30);
			this.btnSeleccionar.TabIndex = 63;
			this.btnSeleccionar.Text = "SELECCIONAR";
			this.btnSeleccionar.UseVisualStyleBackColor = false;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Location = new System.Drawing.Point(13, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 22);
			this.label5.TabIndex = 62;
			this.label5.Text = "Nombre :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Location = new System.Drawing.Point(358, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 22);
			this.label4.TabIndex = 61;
			this.label4.Text = "Marca :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Location = new System.Drawing.Point(13, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 22);
			this.label3.TabIndex = 60;
			this.label3.Text = "Familia :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblID.Location = new System.Drawing.Point(361, 77);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(97, 22);
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
			this.btnBuscar.Location = new System.Drawing.Point(686, 30);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(140, 30);
			this.btnBuscar.TabIndex = 54;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtSubfamilia
			// 
			this.txtSubfamilia.Location = new System.Drawing.Point(464, 77);
			this.txtSubfamilia.Name = "txtSubfamilia";
			this.txtSubfamilia.Size = new System.Drawing.Size(176, 22);
			this.txtSubfamilia.TabIndex = 53;
			// 
			// txtFamilia
			// 
			this.txtFamilia.Location = new System.Drawing.Point(159, 77);
			this.txtFamilia.Name = "txtFamilia";
			this.txtFamilia.Size = new System.Drawing.Size(176, 22);
			this.txtFamilia.TabIndex = 51;
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(464, 34);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(176, 22);
			this.txtMarca.TabIndex = 49;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(159, 34);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(176, 22);
			this.txtNombre.TabIndex = 46;
			// 
			// frmBuscarProductoPorZona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 450);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBuscarProductoPorZona";
			this.Text = "Búsqueda de Productos por Zona";
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtSubfamilia;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_UNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBFAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_REAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_SUGERIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK;
    }
}