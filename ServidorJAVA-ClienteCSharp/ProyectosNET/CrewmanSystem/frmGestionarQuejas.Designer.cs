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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.dgvQuejas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuejas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 100);
            this.panel3.TabIndex = 28;
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
            this.panel2.Controls.Add(this.lblNotFound);
            this.panel2.Controls.Add(this.dgvQuejas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 350);
            this.panel2.TabIndex = 1;
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFound.Location = new System.Drawing.Point(349, 65);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(230, 20);
            this.lblNotFound.TabIndex = 14;
            this.lblNotFound.Text = "No se encontraron resultados";
            this.lblNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotFound.Visible = false;
            // 
            // dgvQuejas
            // 
            this.dgvQuejas.AllowUserToAddRows = false;
            this.dgvQuejas.AllowUserToDeleteRows = false;
            this.dgvQuejas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuejas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuejas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvQuejas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuejas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuejas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvQuejas.ColumnHeadersHeight = 30;
            this.dgvQuejas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQuejas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_PEDIDO,
            this.DESCRIPCION,
            this.FECHA_CREACION,
            this.RUC,
            this.RAZON_SOCIAL,
            this.GRUPO,
            this.TIPO_CLIENTE,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO});
            this.dgvQuejas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuejas.EnableHeadersVisualStyles = false;
            this.dgvQuejas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvQuejas.Location = new System.Drawing.Point(0, 0);
            this.dgvQuejas.MultiSelect = false;
            this.dgvQuejas.Name = "dgvQuejas";
            this.dgvQuejas.ReadOnly = true;
            this.dgvQuejas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuejas.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvQuejas.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQuejas.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvQuejas.RowTemplate.Height = 24;
            this.dgvQuejas.Size = new System.Drawing.Size(935, 350);
            this.dgvQuejas.TabIndex = 2;
            this.dgvQuejas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvQuejas_CellFormatting);
            this.dgvQuejas.SelectionChanged += new System.EventHandler(this.dgvQuejas_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idQueja";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle20;
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // ID_PEDIDO
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID_PEDIDO.DefaultCellStyle = dataGridViewCellStyle21;
            this.ID_PEDIDO.HeaderText = "Id Pedido";
            this.ID_PEDIDO.MinimumWidth = 6;
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.ReadOnly = true;
            this.ID_PEDIDO.Width = 106;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_CREACION.DefaultCellStyle = dataGridViewCellStyle22;
            this.FECHA_CREACION.HeaderText = "Fecha Creación";
            this.FECHA_CREACION.MinimumWidth = 6;
            this.FECHA_CREACION.Name = "FECHA_CREACION";
            this.FECHA_CREACION.ReadOnly = true;
            this.FECHA_CREACION.Width = 155;
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
            // sfdReporte
            // 
            this.sfdReporte.DefaultExt = "pdf";
            this.sfdReporte.FileName = "ReporteDeQuejas.pdf";
            this.sfdReporte.Filter = "PDF (*.pdf)|*.pdf";
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
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuejas)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvQuejas;
		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.SaveFileDialog sfdReporte;
		private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
        private System.Windows.Forms.Label lblNotFound;
    }
}