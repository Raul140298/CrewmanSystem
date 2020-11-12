namespace CrewmanSystem
{
	partial class frmBuscarCliente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LINEA_CREDITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PERSONA_CONTACTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CARTERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_ULTIMA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtGrupo);
            this.panel1.Controls.Add(this.txtRazonSocial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 103);
            this.panel1.TabIndex = 47;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(496, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 40);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Grupo :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Location = new System.Drawing.Point(12, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(155, 22);
            this.lblID.TabIndex = 50;
            this.lblID.Text = "Razón Social :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(183, 55);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(241, 22);
            this.txtGrupo.TabIndex = 49;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(183, 12);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(241, 22);
            this.txtRazonSocial.TabIndex = 46;
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
            this.RAZON_SOCIAL,
            this.ID_LINEA_CREDITO,
            this.ID_PERSONA_CONTACTO,
            this.ID_CARTERA,
            this.RUC,
            this.FECHA_REGISTRO,
            this.FECHA_ULTIMA_COMPRA,
            this.GRUPO,
            this.TIPO,
            this.DIRECCION});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 103);
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
            this.dataGridView1.Size = new System.Drawing.Size(800, 347);
            this.dataGridView1.TabIndex = 48;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idCliente";
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.DataPropertyName = "razonSocial";
            this.RAZON_SOCIAL.HeaderText = "Razón Social";
            this.RAZON_SOCIAL.MinimumWidth = 6;
            this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.ReadOnly = true;
            this.RAZON_SOCIAL.Width = 136;
            // 
            // ID_LINEA_CREDITO
            // 
            this.ID_LINEA_CREDITO.HeaderText = "Id Línea Crédito";
            this.ID_LINEA_CREDITO.MinimumWidth = 6;
            this.ID_LINEA_CREDITO.Name = "ID_LINEA_CREDITO";
            this.ID_LINEA_CREDITO.ReadOnly = true;
            this.ID_LINEA_CREDITO.Width = 155;
            // 
            // ID_PERSONA_CONTACTO
            // 
            this.ID_PERSONA_CONTACTO.HeaderText = "Id Persona Contacto";
            this.ID_PERSONA_CONTACTO.MinimumWidth = 6;
            this.ID_PERSONA_CONTACTO.Name = "ID_PERSONA_CONTACTO";
            this.ID_PERSONA_CONTACTO.ReadOnly = true;
            this.ID_PERSONA_CONTACTO.Width = 189;
            // 
            // ID_CARTERA
            // 
            this.ID_CARTERA.HeaderText = "Id Cartera";
            this.ID_CARTERA.MinimumWidth = 6;
            this.ID_CARTERA.Name = "ID_CARTERA";
            this.ID_CARTERA.ReadOnly = true;
            this.ID_CARTERA.Width = 111;
            // 
            // RUC
            // 
            this.RUC.DataPropertyName = "ruc";
            this.RUC.HeaderText = "Ruc";
            this.RUC.MinimumWidth = 6;
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            this.RUC.Width = 67;
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
            // FECHA_ULTIMA_COMPRA
            // 
            this.FECHA_ULTIMA_COMPRA.DataPropertyName = "fechaUltimaCompra";
            this.FECHA_ULTIMA_COMPRA.HeaderText = "Fecha Última Compra";
            this.FECHA_ULTIMA_COMPRA.MinimumWidth = 6;
            this.FECHA_ULTIMA_COMPRA.Name = "FECHA_ULTIMA_COMPRA";
            this.FECHA_ULTIMA_COMPRA.ReadOnly = true;
            this.FECHA_ULTIMA_COMPRA.Width = 200;
            // 
            // GRUPO
            // 
            this.GRUPO.DataPropertyName = "grupo";
            this.GRUPO.HeaderText = "Grupo";
            this.GRUPO.MinimumWidth = 6;
            this.GRUPO.Name = "GRUPO";
            this.GRUPO.ReadOnly = true;
            this.GRUPO.Width = 83;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "tipoEmpresa";
            this.TIPO.HeaderText = "Tipo Cliente";
            this.TIPO.MinimumWidth = 6;
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 126;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "direccion";
            this.DIRECCION.HeaderText = "Dirección";
            this.DIRECCION.MinimumWidth = 6;
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            this.DIRECCION.Width = 109;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuscarCliente";
            this.Text = "frmBuscarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.TextBox txtGrupo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LINEA_CREDITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERSONA_CONTACTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARTERA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_ULTIMA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
    }
}