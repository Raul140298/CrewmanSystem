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
			this.gbProducto = new System.Windows.Forms.GroupBox();
			this.lblNombreProducto = new System.Windows.Forms.Label();
			this.txtNombreProducto = new System.Windows.Forms.TextBox();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.gbZona = new System.Windows.Forms.GroupBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.btnBuscarZona = new System.Windows.Forms.Button();
			this.lblNombreZona = new System.Windows.Forms.Label();
			this.txtNombreZona = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.gbProducto.SuspendLayout();
			this.gbZona.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbProducto
			// 
			this.gbProducto.Controls.Add(this.lblNombreProducto);
			this.gbProducto.Controls.Add(this.txtNombreProducto);
			this.gbProducto.Controls.Add(this.btnBuscarProducto);
			this.gbProducto.Location = new System.Drawing.Point(22, 17);
			this.gbProducto.Name = "gbProducto";
			this.gbProducto.Size = new System.Drawing.Size(586, 112);
			this.gbProducto.TabIndex = 7;
			this.gbProducto.TabStop = false;
			this.gbProducto.Text = "Datos del Producto";
			// 
			// lblNombreProducto
			// 
			this.lblNombreProducto.Location = new System.Drawing.Point(102, 45);
			this.lblNombreProducto.Name = "lblNombreProducto";
			this.lblNombreProducto.Size = new System.Drawing.Size(100, 23);
			this.lblNombreProducto.TabIndex = 0;
			this.lblNombreProducto.Text = "Producto :";
			this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombreProducto
			// 
			this.txtNombreProducto.Location = new System.Drawing.Point(208, 45);
			this.txtNombreProducto.Name = "txtNombreProducto";
			this.txtNombreProducto.Size = new System.Drawing.Size(205, 22);
			this.txtNombreProducto.TabIndex = 1;
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
			this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarProducto.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnBuscarProducto.Location = new System.Drawing.Point(429, 45);
			this.btnBuscarProducto.Name = "btnBuscarProducto";
			this.btnBuscarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnBuscarProducto.Size = new System.Drawing.Size(40, 23);
			this.btnBuscarProducto.TabIndex = 2;
			this.btnBuscarProducto.Text = "...";
			this.btnBuscarProducto.UseVisualStyleBackColor = false;
			this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click_1);
			// 
			// gbZona
			// 
			this.gbZona.Controls.Add(this.btnRemove);
			this.gbZona.Controls.Add(this.btnAdd);
			this.gbZona.Controls.Add(this.textBox1);
			this.gbZona.Controls.Add(this.lblPrecio);
			this.gbZona.Controls.Add(this.btnBuscarZona);
			this.gbZona.Controls.Add(this.lblNombreZona);
			this.gbZona.Controls.Add(this.txtNombreZona);
			this.gbZona.Location = new System.Drawing.Point(22, 158);
			this.gbZona.Name = "gbZona";
			this.gbZona.Size = new System.Drawing.Size(586, 116);
			this.gbZona.TabIndex = 8;
			this.gbZona.TabStop = false;
			this.gbZona.Text = "Datos de la Zona";
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnRemove.FlatAppearance.BorderSize = 0;
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnRemove.Location = new System.Drawing.Point(429, 70);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(40, 23);
			this.btnRemove.TabIndex = 9;
			this.btnRemove.Text = "-";
			this.btnRemove.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnAdd.Location = new System.Drawing.Point(383, 70);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(40, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(208, 70);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(143, 22);
			this.textBox1.TabIndex = 7;
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(102, 70);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(100, 23);
			this.lblPrecio.TabIndex = 6;
			this.lblPrecio.Text = "Precio :";
			this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnBuscarZona
			// 
			this.btnBuscarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscarZona.FlatAppearance.BorderSize = 0;
			this.btnBuscarZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarZona.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnBuscarZona.Location = new System.Drawing.Point(429, 35);
			this.btnBuscarZona.Name = "btnBuscarZona";
			this.btnBuscarZona.Size = new System.Drawing.Size(40, 23);
			this.btnBuscarZona.TabIndex = 5;
			this.btnBuscarZona.Text = "...";
			this.btnBuscarZona.UseVisualStyleBackColor = false;
			this.btnBuscarZona.Click += new System.EventHandler(this.btnBuscarZona_Click_1);
			// 
			// lblNombreZona
			// 
			this.lblNombreZona.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblNombreZona.Location = new System.Drawing.Point(102, 36);
			this.lblNombreZona.Name = "lblNombreZona";
			this.lblNombreZona.Size = new System.Drawing.Size(100, 23);
			this.lblNombreZona.TabIndex = 3;
			this.lblNombreZona.Text = "Zona :";
			this.lblNombreZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombreZona
			// 
			this.txtNombreZona.Location = new System.Drawing.Point(208, 37);
			this.txtNombreZona.Name = "txtNombreZona";
			this.txtNombreZona.Size = new System.Drawing.Size(205, 22);
			this.txtNombreZona.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gbZona);
			this.panel1.Controls.Add(this.gbProducto);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(629, 290);
			this.panel1.TabIndex = 9;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnGuardar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 436);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(629, 73);
			this.panel2.TabIndex = 10;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnGuardar.Location = new System.Drawing.Point(22, 21);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(160, 40);
			this.btnGuardar.TabIndex = 9;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 290);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(629, 146);
			this.panel3.TabIndex = 11;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(4)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dataGridView1.Location = new System.Drawing.Point(23, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(583, 146);
			this.dataGridView1.TabIndex = 10;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Id";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Producto";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Precio Sugerido";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 160;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Zona";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Precio Real";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 125;
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(606, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(23, 146);
			this.panel5.TabIndex = 9;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(23, 146);
			this.panel4.TabIndex = 0;
			// 
			// frmNuevoProductoXZona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 509);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmNuevoProductoXZona";
			this.Text = "frmNuevoProductoXZona";
			this.gbProducto.ResumeLayout(false);
			this.gbProducto.PerformLayout();
			this.gbZona.ResumeLayout(false);
			this.gbZona.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox gbZona;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnBuscarZona;
        private System.Windows.Forms.Label lblNombreZona;
        private System.Windows.Forms.TextBox txtNombreZona;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}