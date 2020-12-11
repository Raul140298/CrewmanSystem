namespace CrewmanSystem
{
	partial class frmGestionarQuejas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvQuejas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuejas)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.btnGenerar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 350);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(935, 100);
			this.panel1.TabIndex = 0;
			// 
			// btnGenerar
			// 
			this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnGenerar.FlatAppearance.BorderSize = 0;
			this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerar.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGenerar.Location = new System.Drawing.Point(30, 27);
			this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(418, 45);
			this.btnGenerar.TabIndex = 27;
			this.btnGenerar.Text = "Generar Reporte de Quejas del último mes";
			this.btnGenerar.UseVisualStyleBackColor = false;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgvQuejas);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(935, 350);
			this.panel2.TabIndex = 1;
			// 
			// dgvQuejas
			// 
			this.dgvQuejas.AllowUserToAddRows = false;
			this.dgvQuejas.AllowUserToDeleteRows = false;
			this.dgvQuejas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvQuejas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvQuejas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dgvQuejas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvQuejas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQuejas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvQuejas.ColumnHeadersHeight = 30;
			this.dgvQuejas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvQuejas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_PEDIDO,
            this.RUC,
            this.RAZON_SOCIAL,
            this.GRUPO,
            this.TIPO_CLIENTE,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO,
            this.DESCRIPCION,
            this.FECHA_CREACION});
			this.dgvQuejas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvQuejas.EnableHeadersVisualStyles = false;
			this.dgvQuejas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dgvQuejas.Location = new System.Drawing.Point(0, 0);
			this.dgvQuejas.MultiSelect = false;
			this.dgvQuejas.Name = "dgvQuejas";
			this.dgvQuejas.ReadOnly = true;
			this.dgvQuejas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQuejas.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dgvQuejas.RowHeadersWidth = 51;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvQuejas.RowsDefaultCellStyle = dataGridViewCellStyle18;
			this.dgvQuejas.RowTemplate.Height = 24;
			this.dgvQuejas.Size = new System.Drawing.Size(935, 350);
			this.dgvQuejas.TabIndex = 2;
			this.dgvQuejas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvQuejas_CellFormatting_1);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "idQueja";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ID.DefaultCellStyle = dataGridViewCellStyle14;
			this.ID.HeaderText = "Id";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// ID_PEDIDO
			// 
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ID_PEDIDO.DefaultCellStyle = dataGridViewCellStyle15;
			this.ID_PEDIDO.HeaderText = "Id Pedido";
			this.ID_PEDIDO.MinimumWidth = 6;
			this.ID_PEDIDO.Name = "ID_PEDIDO";
			this.ID_PEDIDO.ReadOnly = true;
			this.ID_PEDIDO.Width = 106;
			// 
			// RUC
			// 
			this.RUC.HeaderText = "RUC";
			this.RUC.MinimumWidth = 6;
			this.RUC.Name = "RUC";
			this.RUC.ReadOnly = true;
			this.RUC.Width = 73;
			// 
			// RAZON_SOCIAL
			// 
			this.RAZON_SOCIAL.HeaderText = "Razón Social";
			this.RAZON_SOCIAL.MinimumWidth = 6;
			this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
			this.RAZON_SOCIAL.ReadOnly = true;
			this.RAZON_SOCIAL.Width = 136;
			// 
			// GRUPO
			// 
			this.GRUPO.HeaderText = "Grupo";
			this.GRUPO.MinimumWidth = 6;
			this.GRUPO.Name = "GRUPO";
			this.GRUPO.ReadOnly = true;
			this.GRUPO.Width = 83;
			// 
			// TIPO_CLIENTE
			// 
			this.TIPO_CLIENTE.HeaderText = "Tipo Cliente";
			this.TIPO_CLIENTE.MinimumWidth = 6;
			this.TIPO_CLIENTE.Name = "TIPO_CLIENTE";
			this.TIPO_CLIENTE.ReadOnly = true;
			this.TIPO_CLIENTE.Width = 126;
			// 
			// NOMBRE
			// 
			this.NOMBRE.HeaderText = "Nombre";
			this.NOMBRE.MinimumWidth = 6;
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			this.NOMBRE.Width = 96;
			// 
			// APELLIDO_PATERNO
			// 
			this.APELLIDO_PATERNO.HeaderText = "Apellido Paterno";
			this.APELLIDO_PATERNO.MinimumWidth = 6;
			this.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO";
			this.APELLIDO_PATERNO.ReadOnly = true;
			this.APELLIDO_PATERNO.Width = 159;
			// 
			// APELLIDO_MATERNO
			// 
			this.APELLIDO_MATERNO.HeaderText = "Apellido Materno";
			this.APELLIDO_MATERNO.MinimumWidth = 6;
			this.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO";
			this.APELLIDO_MATERNO.ReadOnly = true;
			this.APELLIDO_MATERNO.Width = 162;
			// 
			// DESCRIPCION
			// 
			this.DESCRIPCION.DataPropertyName = "descripcion";
			this.DESCRIPCION.HeaderText = "Descripcion";
			this.DESCRIPCION.MinimumWidth = 6;
			this.DESCRIPCION.Name = "DESCRIPCION";
			this.DESCRIPCION.ReadOnly = true;
			this.DESCRIPCION.Width = 127;
			// 
			// FECHA_CREACION
			// 
			this.FECHA_CREACION.DataPropertyName = "fechaCreacion";
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FECHA_CREACION.DefaultCellStyle = dataGridViewCellStyle16;
			this.FECHA_CREACION.HeaderText = "Fecha Creación";
			this.FECHA_CREACION.MinimumWidth = 6;
			this.FECHA_CREACION.Name = "FECHA_CREACION";
			this.FECHA_CREACION.ReadOnly = true;
			this.FECHA_CREACION.Width = 155;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(23, 100);
			this.panel3.TabIndex = 28;
			// 
			// frmGestionarQuejas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmGestionarQuejas";
			this.Text = "frmGestionarQuejas";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvQuejas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvQuejas;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.SaveFileDialog sfdReporte;
		private System.Windows.Forms.Panel panel3;
	}
}