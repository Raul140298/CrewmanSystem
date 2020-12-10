namespace CrewmanSystem
{
    partial class frmNuevoProductoXZona
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gbZona = new System.Windows.Forms.GroupBox();
			this.cboZona = new System.Windows.Forms.ComboBox();
			this.lblNombreZona = new System.Windows.Forms.Label();
			this.lblNombreProducto = new System.Windows.Forms.Label();
			this.txtNombreProducto = new System.Windows.Forms.TextBox();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.gbProducto = new System.Windows.Forms.GroupBox();
			this.txtUnidades = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCantUnidades = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrecioSugerido = new System.Windows.Forms.TextBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtPrecioReal = new System.Windows.Forms.TextBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvProducto = new System.Windows.Forms.DataGridView();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANT_UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_REAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbZona.SuspendLayout();
			this.gbProducto.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
			this.SuspendLayout();
			// 
			// gbZona
			// 
			this.gbZona.Controls.Add(this.cboZona);
			this.gbZona.Controls.Add(this.lblNombreZona);
			this.gbZona.Location = new System.Drawing.Point(23, 22);
			this.gbZona.Name = "gbZona";
			this.gbZona.Size = new System.Drawing.Size(586, 98);
			this.gbZona.TabIndex = 7;
			this.gbZona.TabStop = false;
			this.gbZona.Text = "Datos de la Zona";
			// 
			// cboZona
			// 
			this.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboZona.FormattingEnabled = true;
			this.cboZona.Location = new System.Drawing.Point(166, 50);
			this.cboZona.Name = "cboZona";
			this.cboZona.Size = new System.Drawing.Size(231, 24);
			this.cboZona.TabIndex = 6;
			// 
			// lblNombreZona
			// 
			this.lblNombreZona.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblNombreZona.Location = new System.Drawing.Point(60, 51);
			this.lblNombreZona.Name = "lblNombreZona";
			this.lblNombreZona.Size = new System.Drawing.Size(100, 23);
			this.lblNombreZona.TabIndex = 3;
			this.lblNombreZona.Text = "Zona :";
			this.lblNombreZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblNombreProducto
			// 
			this.lblNombreProducto.Location = new System.Drawing.Point(61, 41);
			this.lblNombreProducto.Name = "lblNombreProducto";
			this.lblNombreProducto.Size = new System.Drawing.Size(100, 23);
			this.lblNombreProducto.TabIndex = 0;
			this.lblNombreProducto.Text = "Producto :";
			this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombreProducto
			// 
			this.txtNombreProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtNombreProducto.Location = new System.Drawing.Point(167, 41);
			this.txtNombreProducto.Name = "txtNombreProducto";
			this.txtNombreProducto.Size = new System.Drawing.Size(231, 22);
			this.txtNombreProducto.TabIndex = 1;
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
			this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarProducto.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnBuscarProducto.Location = new System.Drawing.Point(419, 41);
			this.btnBuscarProducto.Name = "btnBuscarProducto";
			this.btnBuscarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnBuscarProducto.Size = new System.Drawing.Size(40, 23);
			this.btnBuscarProducto.TabIndex = 2;
			this.btnBuscarProducto.Text = "...";
			this.btnBuscarProducto.UseVisualStyleBackColor = false;
			this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click_1);
			// 
			// gbProducto
			// 
			this.gbProducto.Controls.Add(this.txtUnidades);
			this.gbProducto.Controls.Add(this.label5);
			this.gbProducto.Controls.Add(this.label4);
			this.gbProducto.Controls.Add(this.txtCantUnidades);
			this.gbProducto.Controls.Add(this.label3);
			this.gbProducto.Controls.Add(this.txtPrecioSugerido);
			this.gbProducto.Controls.Add(this.lblNombreProducto);
			this.gbProducto.Controls.Add(this.btnRemove);
			this.gbProducto.Controls.Add(this.txtNombreProducto);
			this.gbProducto.Controls.Add(this.btnBuscarProducto);
			this.gbProducto.Controls.Add(this.btnAdd);
			this.gbProducto.Controls.Add(this.txtPrecioReal);
			this.gbProducto.Controls.Add(this.lblPrecio);
			this.gbProducto.Location = new System.Drawing.Point(22, 133);
			this.gbProducto.Name = "gbProducto";
			this.gbProducto.Size = new System.Drawing.Size(584, 163);
			this.gbProducto.TabIndex = 8;
			this.gbProducto.TabStop = false;
			this.gbProducto.Text = "Datos del Producto";
			// 
			// txtUnidades
			// 
			this.txtUnidades.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtUnidades.Enabled = false;
			this.txtUnidades.Location = new System.Drawing.Point(378, 78);
			this.txtUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUnidades.Name = "txtUnidades";
			this.txtUnidades.Size = new System.Drawing.Size(81, 22);
			this.txtUnidades.TabIndex = 95;
			// 
			// label5
			// 
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Location = new System.Drawing.Point(270, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 22);
			this.label5.TabIndex = 94;
			this.label5.Text = "Unidades :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Location = new System.Drawing.Point(20, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 22);
			this.label4.TabIndex = 93;
			this.label4.Text = "Cant. Unidades :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCantUnidades
			// 
			this.txtCantUnidades.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtCantUnidades.Enabled = false;
			this.txtCantUnidades.Location = new System.Drawing.Point(167, 78);
			this.txtCantUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCantUnidades.Name = "txtCantUnidades";
			this.txtCantUnidades.Size = new System.Drawing.Size(81, 22);
			this.txtCantUnidades.TabIndex = 92;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Location = new System.Drawing.Point(267, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 22);
			this.label3.TabIndex = 91;
			this.label3.Text = "Precio Real :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPrecioSugerido
			// 
			this.txtPrecioSugerido.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtPrecioSugerido.Enabled = false;
			this.txtPrecioSugerido.Location = new System.Drawing.Point(167, 116);
			this.txtPrecioSugerido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPrecioSugerido.Name = "txtPrecioSugerido";
			this.txtPrecioSugerido.Size = new System.Drawing.Size(81, 22);
			this.txtPrecioSugerido.TabIndex = 90;
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnRemove.FlatAppearance.BorderSize = 0;
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnRemove.Location = new System.Drawing.Point(523, 117);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(40, 23);
			this.btnRemove.TabIndex = 9;
			this.btnRemove.Text = "-";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnAdd.Location = new System.Drawing.Point(477, 117);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(40, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtPrecioReal
			// 
			this.txtPrecioReal.Location = new System.Drawing.Point(378, 117);
			this.txtPrecioReal.Name = "txtPrecioReal";
			this.txtPrecioReal.Size = new System.Drawing.Size(81, 22);
			this.txtPrecioReal.TabIndex = 7;
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(20, 116);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(141, 23);
			this.lblPrecio.TabIndex = 6;
			this.lblPrecio.Text = "Precio Sugerido :";
			this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gbProducto);
			this.panel1.Controls.Add(this.gbZona);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(794, 313);
			this.panel1.TabIndex = 9;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnGuardar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 427);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(794, 74);
			this.panel2.TabIndex = 10;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnGuardar.Location = new System.Drawing.Point(234, 22);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(160, 30);
			this.btnGuardar.TabIndex = 9;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvProducto);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 313);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(794, 114);
			this.panel3.TabIndex = 11;
			// 
			// dgvProducto
			// 
			this.dgvProducto.AllowUserToAddRows = false;
			this.dgvProducto.AllowUserToDeleteRows = false;
			this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(4)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProducto.ColumnHeadersHeight = 30;
			this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRO,
            this.PRODUCTO,
            this.CANT_UNIDADES,
            this.UNIDADES,
            this.PRECIO_REAL});
			this.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProducto.EnableHeadersVisualStyles = false;
			this.dgvProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dgvProducto.Location = new System.Drawing.Point(23, 0);
			this.dgvProducto.MultiSelect = false;
			this.dgvProducto.Name = "dgvProducto";
			this.dgvProducto.ReadOnly = true;
			this.dgvProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvProducto.RowHeadersWidth = 51;
			this.dgvProducto.RowTemplate.Height = 24;
			this.dgvProducto.Size = new System.Drawing.Size(748, 114);
			this.dgvProducto.TabIndex = 10;
			this.dgvProducto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductoXZona_CellFormatting);
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(771, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(23, 114);
			this.panel5.TabIndex = 9;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(23, 114);
			this.panel4.TabIndex = 0;
			// 
			// NRO
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.NRO.DefaultCellStyle = dataGridViewCellStyle2;
			this.NRO.HeaderText = "Nro";
			this.NRO.MinimumWidth = 6;
			this.NRO.Name = "NRO";
			this.NRO.ReadOnly = true;
			this.NRO.Width = 64;
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
			this.UNIDADES.HeaderText = "Unidades";
			this.UNIDADES.MinimumWidth = 6;
			this.UNIDADES.Name = "UNIDADES";
			this.UNIDADES.ReadOnly = true;
			this.UNIDADES.Width = 107;
			// 
			// PRECIO_REAL
			// 
			this.PRECIO_REAL.DataPropertyName = "precioReal";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = null;
			this.PRECIO_REAL.DefaultCellStyle = dataGridViewCellStyle4;
			this.PRECIO_REAL.HeaderText = "Precio Real";
			this.PRECIO_REAL.MinimumWidth = 6;
			this.PRECIO_REAL.Name = "PRECIO_REAL";
			this.PRECIO_REAL.ReadOnly = true;
			this.PRECIO_REAL.Width = 124;
			// 
			// frmNuevoProductoXZona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 501);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmNuevoProductoXZona";
			this.Text = "frmNuevoProductoXZona";
			this.gbZona.ResumeLayout(false);
			this.gbProducto.ResumeLayout(false);
			this.gbProducto.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbZona;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrecioReal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreZona;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboZona;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantUnidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioSugerido;
		private System.Windows.Forms.DataGridViewTextBoxColumn NRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANT_UNIDADES;
		private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_REAL;
	}
}