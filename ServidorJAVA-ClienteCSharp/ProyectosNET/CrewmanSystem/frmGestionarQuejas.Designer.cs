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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvQuejas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuejas)).BeginInit();
			this.SuspendLayout();
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQuejas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvQuejas.ColumnHeadersHeight = 30;
			this.dgvQuejas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvQuejas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_PEDIDO,
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQuejas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvQuejas.RowHeadersWidth = 51;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvQuejas.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvQuejas.RowTemplate.Height = 24;
			this.dgvQuejas.Size = new System.Drawing.Size(800, 450);
			this.dgvQuejas.TabIndex = 1;
			this.dgvQuejas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvQuejas_CellFormatting);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "idQueja";
			this.ID.HeaderText = "Id";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// ID_PEDIDO
			// 
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
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FECHA_CREACION.DefaultCellStyle = dataGridViewCellStyle2;
			this.FECHA_CREACION.HeaderText = "Fecha Creación";
			this.FECHA_CREACION.MinimumWidth = 6;
			this.FECHA_CREACION.Name = "FECHA_CREACION";
			this.FECHA_CREACION.ReadOnly = true;
			this.FECHA_CREACION.Width = 155;
			// 
			// frmGestionarQuejas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvQuejas);
			this.Name = "frmGestionarQuejas";
			this.Text = "frmGestionarQuejas";
			((System.ComponentModel.ISupportInitialize)(this.dgvQuejas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvQuejas;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
	}
}