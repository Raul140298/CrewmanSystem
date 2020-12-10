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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvGuiasDeRemision = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.RUC,
            this.RAZON_SOCIAL,
            this.GRUPO,
            this.TIPO_CLIENTE,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO,
            this.FECHA_EMISION,
            this.MOTIVO_TRASLADO,
            this.FECHA_REGISTRO,
            this.FECHA_TRASLADO});
			this.dgvGuiasDeRemision.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGuiasDeRemision.EnableHeadersVisualStyles = false;
			this.dgvGuiasDeRemision.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dgvGuiasDeRemision.Location = new System.Drawing.Point(0, 0);
			this.dgvGuiasDeRemision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvGuiasDeRemision.MultiSelect = false;
			this.dgvGuiasDeRemision.Name = "dgvGuiasDeRemision";
			this.dgvGuiasDeRemision.ReadOnly = true;
			this.dgvGuiasDeRemision.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvGuiasDeRemision.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvGuiasDeRemision.RowHeadersWidth = 51;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvGuiasDeRemision.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvGuiasDeRemision.RowTemplate.Height = 24;
			this.dgvGuiasDeRemision.Size = new System.Drawing.Size(997, 450);
			this.dgvGuiasDeRemision.TabIndex = 5;
			this.dgvGuiasDeRemision.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGuiasDeRemision_CellFormatting);
			this.dgvGuiasDeRemision.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvGuiasDeRemision_RowStateChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "idGuiaRemision";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ID.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID.HeaderText = "Id";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// ID_PEDIDO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ID_PEDIDO.DefaultCellStyle = dataGridViewCellStyle3;
			this.ID_PEDIDO.HeaderText = "Id Pedido";
			this.ID_PEDIDO.MinimumWidth = 6;
			this.ID_PEDIDO.Name = "ID_PEDIDO";
			this.ID_PEDIDO.ReadOnly = true;
			this.ID_PEDIDO.Width = 106;
			// 
			// RUC
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.RUC.DefaultCellStyle = dataGridViewCellStyle4;
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
			// FECHA_EMISION
			// 
			this.FECHA_EMISION.DataPropertyName = "fechaRegistro";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FECHA_EMISION.DefaultCellStyle = dataGridViewCellStyle5;
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
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FECHA_REGISTRO.DefaultCellStyle = dataGridViewCellStyle6;
			this.FECHA_REGISTRO.HeaderText = "Fecha Registro";
			this.FECHA_REGISTRO.MinimumWidth = 6;
			this.FECHA_REGISTRO.Name = "FECHA_REGISTRO";
			this.FECHA_REGISTRO.ReadOnly = true;
			this.FECHA_REGISTRO.Width = 151;
			// 
			// FECHA_TRASLADO
			// 
			this.FECHA_TRASLADO.DataPropertyName = "fechaTraslado";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FECHA_TRASLADO.DefaultCellStyle = dataGridViewCellStyle7;
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
			this.ClientSize = new System.Drawing.Size(997, 450);
			this.Controls.Add(this.dgvGuiasDeRemision);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmGestionarGuiasRemision";
			this.Text = "frmGestionarGuiasRemision";
			((System.ComponentModel.ISupportInitialize)(this.dgvGuiasDeRemision)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DataGridView dgvGuiasDeRemision;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EMISION;
		private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO_TRASLADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_TRASLADO;
	}
}