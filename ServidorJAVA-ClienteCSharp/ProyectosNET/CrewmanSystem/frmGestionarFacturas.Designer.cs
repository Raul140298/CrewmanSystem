namespace CrewmanSystem
{
	partial class frmGestionarFacturas
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_EMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_VENCIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPUESTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_PAGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.ColumnHeadersHeight = 30;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_PEDIDO,
            this.MONTO,
            this.FECHA_EMISION,
            this.FECHA_VENCIMIENTO,
            this.IMPUESTOS,
            this.DESCUENTOS,
            this.ESTADO_PAGAR});
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvFacturas.Location = new System.Drawing.Point(0, 0);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.Size = new System.Drawing.Size(800, 450);
            this.dgvFacturas.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idFactura";
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // ID_PEDIDO
            // 
            this.ID_PEDIDO.DataPropertyName = "pedido";
            this.ID_PEDIDO.HeaderText = "Id Pedido";
            this.ID_PEDIDO.MinimumWidth = 6;
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.ReadOnly = true;
            this.ID_PEDIDO.Width = 106;
            // 
            // MONTO
            // 
            this.MONTO.DataPropertyName = "monto";
            this.MONTO.HeaderText = "Monto";
            this.MONTO.MinimumWidth = 6;
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            this.MONTO.Width = 83;
            // 
            // FECHA_EMISION
            // 
            this.FECHA_EMISION.DataPropertyName = "fechaEmision";
            this.FECHA_EMISION.HeaderText = "Fecha Emisión";
            this.FECHA_EMISION.MinimumWidth = 6;
            this.FECHA_EMISION.Name = "FECHA_EMISION";
            this.FECHA_EMISION.ReadOnly = true;
            this.FECHA_EMISION.Width = 148;
            // 
            // FECHA_VENCIMIENTO
            // 
            this.FECHA_VENCIMIENTO.DataPropertyName = "fechaVencimiento";
            this.FECHA_VENCIMIENTO.HeaderText = "Fecha Vencimiento";
            this.FECHA_VENCIMIENTO.MinimumWidth = 6;
            this.FECHA_VENCIMIENTO.Name = "FECHA_VENCIMIENTO";
            this.FECHA_VENCIMIENTO.ReadOnly = true;
            this.FECHA_VENCIMIENTO.Width = 180;
            // 
            // IMPUESTOS
            // 
            this.IMPUESTOS.DataPropertyName = "impuestos";
            this.IMPUESTOS.HeaderText = "Impuestos";
            this.IMPUESTOS.MinimumWidth = 6;
            this.IMPUESTOS.Name = "IMPUESTOS";
            this.IMPUESTOS.ReadOnly = true;
            this.IMPUESTOS.Width = 114;
            // 
            // DESCUENTOS
            // 
            this.DESCUENTOS.HeaderText = "Descuentos";
            this.DESCUENTOS.MinimumWidth = 6;
            this.DESCUENTOS.Name = "DESCUENTOS";
            this.DESCUENTOS.ReadOnly = true;
            this.DESCUENTOS.Width = 127;
            // 
            // ESTADO_PAGAR
            // 
            this.ESTADO_PAGAR.DataPropertyName = "estadoPagar";
            this.ESTADO_PAGAR.HeaderText = "Estado Pagar";
            this.ESTADO_PAGAR.MinimumWidth = 6;
            this.ESTADO_PAGAR.Name = "ESTADO_PAGAR";
            this.ESTADO_PAGAR.ReadOnly = true;
            this.ESTADO_PAGAR.Width = 138;
            // 
            // frmGestionarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFacturas);
            this.Name = "frmGestionarFacturas";
            this.Text = "frmGestionarFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFacturas;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EMISION;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VENCIMIENTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMPUESTOS;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTOS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_PAGAR;
	}
}