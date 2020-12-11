namespace CrewmanSystem
{
	partial class frmListarCumplimientoDeMetas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvEmpleados = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ZONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUMA_VENTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBJETIVO_VENTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTES_VISITADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTES_ASIGNADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgvEmpleados);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(758, 524);
			this.panel2.TabIndex = 2;
			// 
			// dgvEmpleados
			// 
			this.dgvEmpleados.AllowUserToAddRows = false;
			this.dgvEmpleados.AllowUserToDeleteRows = false;
			this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvEmpleados.ColumnHeadersHeight = 30;
			this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO,
            this.ZONA,
            this.SUMA_VENTAS,
            this.OBJETIVO_VENTAS,
            this.CLIENTES_VISITADOS,
            this.CLIENTES_ASIGNADOS});
			this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEmpleados.EnableHeadersVisualStyles = false;
			this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dgvEmpleados.Location = new System.Drawing.Point(0, 0);
			this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvEmpleados.MultiSelect = false;
			this.dgvEmpleados.Name = "dgvEmpleados";
			this.dgvEmpleados.ReadOnly = true;
			this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvEmpleados.RowHeadersWidth = 51;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvEmpleados.RowTemplate.Height = 24;
			this.dgvEmpleados.Size = new System.Drawing.Size(758, 524);
			this.dgvEmpleados.TabIndex = 5;
			this.dgvEmpleados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmpleados_CellFormatting);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "idEmpleado";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ID.DefaultCellStyle = dataGridViewCellStyle2;
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
			// APELLIDO_PATERNO
			// 
			this.APELLIDO_PATERNO.DataPropertyName = "apellidoPaterno";
			this.APELLIDO_PATERNO.HeaderText = "Apellido Paterno";
			this.APELLIDO_PATERNO.MinimumWidth = 6;
			this.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO";
			this.APELLIDO_PATERNO.ReadOnly = true;
			this.APELLIDO_PATERNO.Width = 159;
			// 
			// APELLIDO_MATERNO
			// 
			this.APELLIDO_MATERNO.DataPropertyName = "apellidoMaterno";
			this.APELLIDO_MATERNO.HeaderText = "Apellido Materno";
			this.APELLIDO_MATERNO.MinimumWidth = 6;
			this.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO";
			this.APELLIDO_MATERNO.ReadOnly = true;
			this.APELLIDO_MATERNO.Width = 162;
			// 
			// ZONA
			// 
			this.ZONA.HeaderText = "Zona";
			this.ZONA.MinimumWidth = 6;
			this.ZONA.Name = "ZONA";
			this.ZONA.ReadOnly = true;
			this.ZONA.Width = 73;
			// 
			// SUMA_VENTAS
			// 
			this.SUMA_VENTAS.DataPropertyName = "sumVentas";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N2";
			this.SUMA_VENTAS.DefaultCellStyle = dataGridViewCellStyle3;
			this.SUMA_VENTAS.HeaderText = "Suma Ventas";
			this.SUMA_VENTAS.MinimumWidth = 6;
			this.SUMA_VENTAS.Name = "SUMA_VENTAS";
			this.SUMA_VENTAS.ReadOnly = true;
			this.SUMA_VENTAS.Width = 137;
			// 
			// OBJETIVO_VENTAS
			// 
			this.OBJETIVO_VENTAS.DataPropertyName = "objetivoVentas";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N2";
			this.OBJETIVO_VENTAS.DefaultCellStyle = dataGridViewCellStyle4;
			this.OBJETIVO_VENTAS.HeaderText = "Objetivo Ventas";
			this.OBJETIVO_VENTAS.MinimumWidth = 6;
			this.OBJETIVO_VENTAS.Name = "OBJETIVO_VENTAS";
			this.OBJETIVO_VENTAS.ReadOnly = true;
			this.OBJETIVO_VENTAS.Width = 155;
			// 
			// CLIENTES_VISITADOS
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.CLIENTES_VISITADOS.DefaultCellStyle = dataGridViewCellStyle5;
			this.CLIENTES_VISITADOS.HeaderText = "Clientes Visitados";
			this.CLIENTES_VISITADOS.MinimumWidth = 6;
			this.CLIENTES_VISITADOS.Name = "CLIENTES_VISITADOS";
			this.CLIENTES_VISITADOS.ReadOnly = true;
			this.CLIENTES_VISITADOS.Width = 172;
			// 
			// CLIENTES_ASIGNADOS
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.CLIENTES_ASIGNADOS.DefaultCellStyle = dataGridViewCellStyle6;
			this.CLIENTES_ASIGNADOS.HeaderText = "Clientes Asignados";
			this.CLIENTES_ASIGNADOS.MinimumWidth = 6;
			this.CLIENTES_ASIGNADOS.Name = "CLIENTES_ASIGNADOS";
			this.CLIENTES_ASIGNADOS.ReadOnly = true;
			this.CLIENTES_ASIGNADOS.Width = 181;
			// 
			// frmListarCumplimientoDeMetas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 524);
			this.Controls.Add(this.panel2);
			this.Name = "frmListarCumplimientoDeMetas";
			this.Text = "frmListarCumplimientoDeMetas";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZONA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUMA_VENTAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBJETIVO_VENTAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTES_VISITADOS;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTES_ASIGNADOS;
	}
}