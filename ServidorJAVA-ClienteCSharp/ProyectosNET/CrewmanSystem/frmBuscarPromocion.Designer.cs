namespace CrewmanSystem
{
	partial class frmBuscarPromocion
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dtpFechaFIn = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 532);
			this.panel1.TabIndex = 0;
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
            this.DESCRIPCION,
            this.FECHA_INICIO,
            this.FECHA_FIN});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 164);
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
			this.dataGridView1.Size = new System.Drawing.Size(800, 368);
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
			// NOMBRE
			// 
			this.NOMBRE.HeaderText = "Nombre";
			this.NOMBRE.MinimumWidth = 6;
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			this.NOMBRE.Width = 96;
			// 
			// DESCRIPCION
			// 
			this.DESCRIPCION.HeaderText = "Descripción";
			this.DESCRIPCION.MinimumWidth = 6;
			this.DESCRIPCION.Name = "DESCRIPCION";
			this.DESCRIPCION.ReadOnly = true;
			this.DESCRIPCION.Width = 127;
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
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lblID);
			this.panel2.Controls.Add(this.btnBuscar);
			this.panel2.Controls.Add(this.dtpFechaFIn);
			this.panel2.Controls.Add(this.dtpFechaInicio);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 164);
			this.panel2.TabIndex = 46;
			// 
			// dtpFechaFIn
			// 
			this.dtpFechaFIn.Location = new System.Drawing.Point(172, 103);
			this.dtpFechaFIn.Name = "dtpFechaFIn";
			this.dtpFechaFIn.Size = new System.Drawing.Size(281, 22);
			this.dtpFechaFIn.TabIndex = 56;
			// 
			// dtpFechaInicio
			// 
			this.dtpFechaInicio.Location = new System.Drawing.Point(172, 58);
			this.dtpFechaInicio.Name = "dtpFechaInicio";
			this.dtpFechaInicio.Size = new System.Drawing.Size(281, 22);
			this.dtpFechaInicio.TabIndex = 55;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(172, 13);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(281, 22);
			this.txtNombre.TabIndex = 46;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(495, 13);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(160, 40);
			this.btnBuscar.TabIndex = 58;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblID.Location = new System.Drawing.Point(3, 13);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(163, 22);
			this.lblID.TabIndex = 59;
			this.lblID.Text = "Nombre :";
			this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(0, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 22);
			this.label1.TabIndex = 60;
			this.label1.Text = "Fecha Inicio :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Location = new System.Drawing.Point(0, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 22);
			this.label2.TabIndex = 61;
			this.label2.Text = "Fecha Fin :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmBuscarPromocion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 532);
			this.Controls.Add(this.panel1);
			this.Name = "frmBuscarPromocion";
			this.Text = "frmBuscarPromocion";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DateTimePicker dtpFechaFIn;
		private System.Windows.Forms.DateTimePicker dtpFechaInicio;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_FIN;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblID;
	}
}