namespace CrewmanSystem
{
    partial class frmBuscarPedidoAPagar
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPedidoAPagar));
			this.dgvPedidos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_ESTIMADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MONTO_PAGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dtpRangoFin = new System.Windows.Forms.DateTimePicker();
			this.dtpRangoIni = new System.Windows.Forms.DateTimePicker();
			this.txtCliente = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvPedidos
			// 
			this.dgvPedidos.AllowUserToAddRows = false;
			this.dgvPedidos.AllowUserToDeleteRows = false;
			this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvPedidos.ColumnHeadersHeight = 30;
			this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CLIENTE,
            this.Column1,
            this.FECHA_ESTIMADA,
            this.Column2,
            this.MONTO_PAGAR,
            this.Column3,
            this.TIPO_PEDIDO,
            this.ESTADO});
			this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPedidos.EnableHeadersVisualStyles = false;
			this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dgvPedidos.Location = new System.Drawing.Point(0, 176);
			this.dgvPedidos.MultiSelect = false;
			this.dgvPedidos.Name = "dgvPedidos";
			this.dgvPedidos.ReadOnly = true;
			this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvPedidos.RowHeadersWidth = 51;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvPedidos.RowTemplate.Height = 24;
			this.dgvPedidos.Size = new System.Drawing.Size(800, 274);
			this.dgvPedidos.TabIndex = 51;
			this.dgvPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPedidos_CellFormatting);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "idPedido";
			this.ID.HeaderText = "Id";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// CLIENTE
			// 
			this.CLIENTE.HeaderText = "Cliente";
			this.CLIENTE.MinimumWidth = 6;
			this.CLIENTE.Name = "CLIENTE";
			this.CLIENTE.ReadOnly = true;
			this.CLIENTE.Width = 89;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "fechaAprobado";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
			this.Column1.HeaderText = "Fecha Aprobado";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 159;
			// 
			// FECHA_ESTIMADA
			// 
			this.FECHA_ESTIMADA.DataPropertyName = "fechaEstim";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FECHA_ESTIMADA.DefaultCellStyle = dataGridViewCellStyle10;
			this.FECHA_ESTIMADA.HeaderText = "Fecha Estimada";
			this.FECHA_ESTIMADA.MinimumWidth = 6;
			this.FECHA_ESTIMADA.Name = "FECHA_ESTIMADA";
			this.FECHA_ESTIMADA.ReadOnly = true;
			this.FECHA_ESTIMADA.Width = 158;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "montoTotal";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.Format = "N2";
			this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
			this.Column2.HeaderText = "Monto Total";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// MONTO_PAGAR
			// 
			this.MONTO_PAGAR.DataPropertyName = "montoPagar";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.Format = "N2";
			this.MONTO_PAGAR.DefaultCellStyle = dataGridViewCellStyle12;
			this.MONTO_PAGAR.HeaderText = "Monto a Pagar";
			this.MONTO_PAGAR.MinimumWidth = 6;
			this.MONTO_PAGAR.Name = "MONTO_PAGAR";
			this.MONTO_PAGAR.ReadOnly = true;
			this.MONTO_PAGAR.Width = 146;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "direccionEntrega";
			this.Column3.HeaderText = "Dir. de Entrega";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 150;
			// 
			// TIPO_PEDIDO
			// 
			this.TIPO_PEDIDO.DataPropertyName = "tipoPedido";
			this.TIPO_PEDIDO.HeaderText = "Tipo ";
			this.TIPO_PEDIDO.MinimumWidth = 6;
			this.TIPO_PEDIDO.Name = "TIPO_PEDIDO";
			this.TIPO_PEDIDO.ReadOnly = true;
			this.TIPO_PEDIDO.Width = 69;
			// 
			// ESTADO
			// 
			this.ESTADO.DataPropertyName = "estadoPedido";
			this.ESTADO.HeaderText = "Estado";
			this.ESTADO.MinimumWidth = 6;
			this.ESTADO.Name = "ESTADO";
			this.ESTADO.ReadOnly = true;
			this.ESTADO.Width = 89;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSeleccionar);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnBuscarCliente);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblID);
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.dtpRangoFin);
			this.panel1.Controls.Add(this.dtpRangoIni);
			this.panel1.Controls.Add(this.txtCliente);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 176);
			this.panel1.TabIndex = 50;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
			this.btnSeleccionar.Location = new System.Drawing.Point(499, 76);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(160, 30);
			this.btnSeleccionar.TabIndex = 89;
			this.btnSeleccionar.Text = "SELECCIONAR";
			this.btnSeleccionar.UseVisualStyleBackColor = false;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Location = new System.Drawing.Point(3, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 22);
			this.label4.TabIndex = 88;
			this.label4.Text = "Fecha Final :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
			this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarCliente.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnBuscarCliente.Location = new System.Drawing.Point(417, 28);
			this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
			this.btnBuscarCliente.Size = new System.Drawing.Size(41, 22);
			this.btnBuscarCliente.TabIndex = 85;
			this.btnBuscarCliente.Text = "...";
			this.btnBuscarCliente.UseVisualStyleBackColor = false;
			this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Location = new System.Drawing.Point(3, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(179, 22);
			this.label3.TabIndex = 60;
			this.label3.Text = "Cliente :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblID
			// 
			this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblID.Location = new System.Drawing.Point(3, 76);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(179, 22);
			this.lblID.TabIndex = 57;
			this.lblID.Text = "Fecha Inicial :";
			this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(499, 28);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(160, 30);
			this.btnBuscar.TabIndex = 55;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// dtpRangoFin
			// 
			this.dtpRangoFin.Location = new System.Drawing.Point(195, 121);
			this.dtpRangoFin.Name = "dtpRangoFin";
			this.dtpRangoFin.Size = new System.Drawing.Size(263, 22);
			this.dtpRangoFin.TabIndex = 53;
			// 
			// dtpRangoIni
			// 
			this.dtpRangoIni.Location = new System.Drawing.Point(195, 76);
			this.dtpRangoIni.Name = "dtpRangoIni";
			this.dtpRangoIni.Size = new System.Drawing.Size(263, 22);
			this.dtpRangoIni.TabIndex = 52;
			// 
			// txtCliente
			// 
			this.txtCliente.Enabled = false;
			this.txtCliente.Location = new System.Drawing.Point(195, 28);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(199, 22);
			this.txtCliente.TabIndex = 46;
			// 
			// frmBuscarPedidoAPagar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvPedidos);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBuscarPedidoAPagar";
			this.Text = "Búsqueda de Pedidos a pagar";
			((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpRangoFin;
        private System.Windows.Forms.DateTimePicker dtpRangoIni;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_ESTIMADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO_PAGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}