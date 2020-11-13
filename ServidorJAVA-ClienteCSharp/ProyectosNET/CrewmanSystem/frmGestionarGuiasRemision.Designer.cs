namespace CrewmanSystem
{
	partial class frmGestionarGuiasRemision
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
            this.dgvGuiasDeRemision = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_EMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuiasDeRemision)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuiasDeRemision
            // 
            this.dgvGuiasDeRemision.AllowUserToAddRows = false;
            this.dgvGuiasDeRemision.AllowUserToDeleteRows = false;
            this.dgvGuiasDeRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGuiasDeRemision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGuiasDeRemision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvGuiasDeRemision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGuiasDeRemision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuiasDeRemision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuiasDeRemision.ColumnHeadersHeight = 30;
            this.dgvGuiasDeRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGuiasDeRemision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_PEDIDO,
            this.FECHA_EMISION,
            this.MOTIVO_TRASLADO,
            this.FECHA_REGISTRO,
            this.FECHA_TRASLADO});
            this.dgvGuiasDeRemision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGuiasDeRemision.EnableHeadersVisualStyles = false;
            this.dgvGuiasDeRemision.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvGuiasDeRemision.Location = new System.Drawing.Point(0, 0);
            this.dgvGuiasDeRemision.MultiSelect = false;
            this.dgvGuiasDeRemision.Name = "dgvGuiasDeRemision";
            this.dgvGuiasDeRemision.ReadOnly = true;
            this.dgvGuiasDeRemision.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuiasDeRemision.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGuiasDeRemision.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGuiasDeRemision.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuiasDeRemision.RowTemplate.Height = 24;
            this.dgvGuiasDeRemision.Size = new System.Drawing.Size(998, 450);
            this.dgvGuiasDeRemision.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
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
            // FECHA_EMISION
            // 
            this.FECHA_EMISION.DataPropertyName = "fechaRegistro";
            this.FECHA_EMISION.HeaderText = "Fecha Emisión";
            this.FECHA_EMISION.MinimumWidth = 6;
            this.FECHA_EMISION.Name = "FECHA_EMISION";
            this.FECHA_EMISION.ReadOnly = true;
            this.FECHA_EMISION.Width = 148;
            // 
            // MOTIVO_TRASLADO
            // 
            this.MOTIVO_TRASLADO.DataPropertyName = "motivoTraslado";
            this.MOTIVO_TRASLADO.HeaderText = "Motivo Traslado";
            this.MOTIVO_TRASLADO.MinimumWidth = 6;
            this.MOTIVO_TRASLADO.Name = "MOTIVO_TRASLADO";
            this.MOTIVO_TRASLADO.ReadOnly = true;
            this.MOTIVO_TRASLADO.Width = 156;
            // 
            // FECHA_REGISTRO
            // 
            this.FECHA_REGISTRO.DataPropertyName = "fechaRegistro";
            this.FECHA_REGISTRO.HeaderText = "Fecha Registro";
            this.FECHA_REGISTRO.MinimumWidth = 6;
            this.FECHA_REGISTRO.Name = "FECHA_REGISTRO";
            this.FECHA_REGISTRO.ReadOnly = true;
            this.FECHA_REGISTRO.Width = 151;
            // 
            // FECHA_TRASLADO
            // 
            this.FECHA_TRASLADO.DataPropertyName = "fechaTraslado";
            this.FECHA_TRASLADO.HeaderText = "Fecha Traslado";
            this.FECHA_TRASLADO.MinimumWidth = 6;
            this.FECHA_TRASLADO.Name = "FECHA_TRASLADO";
            this.FECHA_TRASLADO.ReadOnly = true;
            this.FECHA_TRASLADO.Width = 153;
            // 
            // frmGestionarGuiasRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.dgvGuiasDeRemision);
            this.Name = "frmGestionarGuiasRemision";
            this.Text = "frmGestionarGuiasRemision";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuiasDeRemision)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvGuiasDeRemision;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EMISION;
		private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO_TRASLADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_TRASLADO;
	}
}