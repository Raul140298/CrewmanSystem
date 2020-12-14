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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGuiasDeRemision = new System.Windows.Forms.DataGridView();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.reportDownload = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_EMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfdGuia = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuiasDeRemision)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuiasDeRemision
            // 
            this.dgvGuiasDeRemision.AllowUserToAddRows = false;
            this.dgvGuiasDeRemision.AllowUserToDeleteRows = false;
            this.dgvGuiasDeRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGuiasDeRemision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGuiasDeRemision.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGuiasDeRemision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGuiasDeRemision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuiasDeRemision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvGuiasDeRemision.ColumnHeadersHeight = 30;
            this.dgvGuiasDeRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGuiasDeRemision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportDownload,
            this.ID,
            this.ID_PEDIDO,
            this.FECHA_EMISION,
            this.MOTIVO_TRASLADO,
            this.FECHA_REGISTRO,
            this.FECHA_TRASLADO,
            this.RUC,
            this.RAZON_SOCIAL,
            this.GRUPO,
            this.TIPO_CLIENTE,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO});
            this.dgvGuiasDeRemision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGuiasDeRemision.EnableHeadersVisualStyles = false;
            this.dgvGuiasDeRemision.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvGuiasDeRemision.Location = new System.Drawing.Point(0, 0);
            this.dgvGuiasDeRemision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGuiasDeRemision.MultiSelect = false;
            this.dgvGuiasDeRemision.Name = "dgvGuiasDeRemision";
            this.dgvGuiasDeRemision.ReadOnly = true;
            this.dgvGuiasDeRemision.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuiasDeRemision.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvGuiasDeRemision.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGuiasDeRemision.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvGuiasDeRemision.RowTemplate.Height = 24;
            this.dgvGuiasDeRemision.Size = new System.Drawing.Size(997, 450);
            this.dgvGuiasDeRemision.TabIndex = 5;
            this.dgvGuiasDeRemision.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuiasDeRemision_CellContentClick);
            this.dgvGuiasDeRemision.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGuiasDeRemision_CellFormatting);
            this.dgvGuiasDeRemision.SelectionChanged += new System.EventHandler(this.dgvGuiasDeRemision_SelectionChanged);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFound.Location = new System.Drawing.Point(383, 60);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(230, 20);
            this.lblNotFound.TabIndex = 10;
            this.lblNotFound.Text = "No se encontraron resultados";
            this.lblNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotFound.Visible = false;
            // 
            // reportDownload
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.reportDownload.DefaultCellStyle = dataGridViewCellStyle12;
            this.reportDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportDownload.HeaderText = "Bajar";
            this.reportDownload.MinimumWidth = 6;
            this.reportDownload.Name = "reportDownload";
            this.reportDownload.ReadOnly = true;
            this.reportDownload.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reportDownload.Width = 54;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idGuiaRemision";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle13;
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // ID_PEDIDO
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID_PEDIDO.DefaultCellStyle = dataGridViewCellStyle14;
            this.ID_PEDIDO.HeaderText = "Id Pedido";
            this.ID_PEDIDO.MinimumWidth = 6;
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.ReadOnly = true;
            this.ID_PEDIDO.Width = 106;
            // 
            // FECHA_EMISION
            // 
            this.FECHA_EMISION.DataPropertyName = "fechaRegistro";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_EMISION.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_REGISTRO.DefaultCellStyle = dataGridViewCellStyle16;
            this.FECHA_REGISTRO.HeaderText = "Fecha Registro";
            this.FECHA_REGISTRO.MinimumWidth = 6;
            this.FECHA_REGISTRO.Name = "FECHA_REGISTRO";
            this.FECHA_REGISTRO.ReadOnly = true;
            this.FECHA_REGISTRO.Width = 151;
            // 
            // FECHA_TRASLADO
            // 
            this.FECHA_TRASLADO.DataPropertyName = "fechaTraslado";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_TRASLADO.DefaultCellStyle = dataGridViewCellStyle17;
            this.FECHA_TRASLADO.HeaderText = "Fecha Traslado";
            this.FECHA_TRASLADO.MinimumWidth = 6;
            this.FECHA_TRASLADO.Name = "FECHA_TRASLADO";
            this.FECHA_TRASLADO.ReadOnly = true;
            this.FECHA_TRASLADO.Width = 153;
            // 
            // RUC
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RUC.DefaultCellStyle = dataGridViewCellStyle18;
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
            // sfdGuia
            // 
            this.sfdGuia.DefaultExt = "pdf";
            this.sfdGuia.FileName = "GuiaDeRemision.pdf";
            this.sfdGuia.Filter = "PDF (*.pdf)|*.pdf";
            // 
            // frmGestionarGuiasRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.dgvGuiasDeRemision);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionarGuiasRemision";
            this.Text = "frmGestionarGuiasRemision";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuiasDeRemision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.DataGridView dgvGuiasDeRemision;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.DataGridViewButtonColumn reportDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
        private System.Windows.Forms.SaveFileDialog sfdGuia;
    }
}