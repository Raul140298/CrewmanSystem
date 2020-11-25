namespace CrewmanSystem
{
	partial class frmGestionarCarteras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCarteras = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUMA_VENTAS_MENSUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJETIVO_VENTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarteras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarteras
            // 
            this.dgvCarteras.AllowUserToAddRows = false;
            this.dgvCarteras.AllowUserToDeleteRows = false;
            this.dgvCarteras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCarteras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarteras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCarteras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarteras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarteras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarteras.ColumnHeadersHeight = 30;
            this.dgvCarteras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCarteras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO,
            this.ZONA,
            this.SUMA_VENTAS_MENSUAL,
            this.OBJETIVO_VENTAS});
            this.dgvCarteras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarteras.EnableHeadersVisualStyles = false;
            this.dgvCarteras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvCarteras.Location = new System.Drawing.Point(0, 0);
            this.dgvCarteras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCarteras.MultiSelect = false;
            this.dgvCarteras.Name = "dgvCarteras";
            this.dgvCarteras.ReadOnly = true;
            this.dgvCarteras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarteras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarteras.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCarteras.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCarteras.RowTemplate.Height = 24;
            this.dgvCarteras.Size = new System.Drawing.Size(800, 450);
            this.dgvCarteras.TabIndex = 3;
            this.dgvCarteras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarteras_CellContentClick);
            this.dgvCarteras.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCarteras_CellFormatting);
            this.dgvCarteras.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvCarteras_RowStateChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idEmpleado";
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
            // SUMA_VENTAS_MENSUAL
            // 
            this.SUMA_VENTAS_MENSUAL.DataPropertyName = "sumVentas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            this.SUMA_VENTAS_MENSUAL.DefaultCellStyle = dataGridViewCellStyle2;
            this.SUMA_VENTAS_MENSUAL.HeaderText = "Suma Ventas";
            this.SUMA_VENTAS_MENSUAL.MinimumWidth = 6;
            this.SUMA_VENTAS_MENSUAL.Name = "SUMA_VENTAS_MENSUAL";
            this.SUMA_VENTAS_MENSUAL.ReadOnly = true;
            this.SUMA_VENTAS_MENSUAL.Width = 137;
            // 
            // OBJETIVO_VENTAS
            // 
            this.OBJETIVO_VENTAS.DataPropertyName = "objetivoVentas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            this.OBJETIVO_VENTAS.DefaultCellStyle = dataGridViewCellStyle3;
            this.OBJETIVO_VENTAS.HeaderText = "Objetivo Ventas";
            this.OBJETIVO_VENTAS.MinimumWidth = 6;
            this.OBJETIVO_VENTAS.Name = "OBJETIVO_VENTAS";
            this.OBJETIVO_VENTAS.ReadOnly = true;
            this.OBJETIVO_VENTAS.Width = 155;
            // 
            // frmGestionarCarteras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCarteras);
            this.Name = "frmGestionarCarteras";
            this.Text = "frmGestionarCarteras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarteras)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DataGridView dgvCarteras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUMA_VENTAS_MENSUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJETIVO_VENTAS;
    }
}