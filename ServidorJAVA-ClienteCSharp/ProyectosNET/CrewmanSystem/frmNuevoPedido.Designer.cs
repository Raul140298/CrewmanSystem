namespace CrewmanSystem
{
	partial class frmNuevoPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gboPedido = new System.Windows.Forms.GroupBox();
            this.dtpFechaEstimada = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtIDOrdenVenta = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gboCliente = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRucCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboLineaPedido = new System.Windows.Forms.GroupBox();
            this.btnBuscarProductoXZona = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLineas = new System.Windows.Forms.DataGridView();
            this.IDPRODUCTOXZONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.gboPedido.SuspendLayout();
            this.gboCliente.SuspendLayout();
            this.gboLineaPedido.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.gboPedido);
            this.panel6.Controls.Add(this.gboCliente);
            this.panel6.Controls.Add(this.gboLineaPedido);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(723, 544);
            this.panel6.TabIndex = 3;
            // 
            // gboPedido
            // 
            this.gboPedido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gboPedido.Controls.Add(this.dtpFechaEstimada);
            this.gboPedido.Controls.Add(this.label12);
            this.gboPedido.Controls.Add(this.label11);
            this.gboPedido.Controls.Add(this.cboEstado);
            this.gboPedido.Controls.Add(this.txtIDOrdenVenta);
            this.gboPedido.Controls.Add(this.dtpFechaVenta);
            this.gboPedido.Controls.Add(this.label5);
            this.gboPedido.Controls.Add(this.label4);
            this.gboPedido.Enabled = false;
            this.gboPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPedido.Location = new System.Drawing.Point(31, 27);
            this.gboPedido.Name = "gboPedido";
            this.gboPedido.Size = new System.Drawing.Size(428, 167);
            this.gboPedido.TabIndex = 97;
            this.gboPedido.TabStop = false;
            this.gboPedido.Text = "Datos de la Orden de Venta";
            // 
            // dtpFechaEstimada
            // 
            this.dtpFechaEstimada.Location = new System.Drawing.Point(159, 128);
            this.dtpFechaEstimada.Name = "dtpFechaEstimada";
            this.dtpFechaEstimada.Size = new System.Drawing.Size(248, 23);
            this.dtpFechaEstimada.TabIndex = 93;
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(23, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 18);
            this.label12.TabIndex = 92;
            this.label12.Text = "Fecha estimada :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(88, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 91;
            this.label11.Text = "Estado :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(158, 59);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(161, 24);
            this.cboEstado.TabIndex = 84;
            // 
            // txtIDOrdenVenta
            // 
            this.txtIDOrdenVenta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIDOrdenVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDOrdenVenta.Enabled = false;
            this.txtIDOrdenVenta.Location = new System.Drawing.Point(158, 34);
            this.txtIDOrdenVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDOrdenVenta.Name = "txtIDOrdenVenta";
            this.txtIDOrdenVenta.Size = new System.Drawing.Size(61, 16);
            this.txtIDOrdenVenta.TabIndex = 90;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Enabled = false;
            this.dtpFechaVenta.Location = new System.Drawing.Point(158, 95);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(248, 23);
            this.dtpFechaVenta.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(22, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 88;
            this.label5.Text = "Fecha de la Venta :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 87;
            this.label4.Text = "Id Orden Venta :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gboCliente
            // 
            this.gboCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gboCliente.Controls.Add(this.txtDireccion);
            this.gboCliente.Controls.Add(this.label10);
            this.gboCliente.Controls.Add(this.btnBuscarCliente);
            this.gboCliente.Controls.Add(this.txtRazonSocial);
            this.gboCliente.Controls.Add(this.txtRucCliente);
            this.gboCliente.Controls.Add(this.label3);
            this.gboCliente.Controls.Add(this.label2);
            this.gboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboCliente.Location = new System.Drawing.Point(31, 211);
            this.gboCliente.Name = "gboCliente";
            this.gboCliente.Size = new System.Drawing.Size(428, 132);
            this.gboCliente.TabIndex = 96;
            this.gboCliente.TabStop = false;
            this.gboCliente.Text = "Datos del Cliente";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Location = new System.Drawing.Point(159, 95);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(247, 16);
            this.txtDireccion.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(20, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 18);
            this.label10.TabIndex = 87;
            this.label10.Text = "Dirección de entrega :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarCliente.Location = new System.Drawing.Point(280, 36);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnBuscarCliente.Size = new System.Drawing.Size(26, 18);
            this.btnBuscarCliente.TabIndex = 84;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(159, 66);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(181, 16);
            this.txtRazonSocial.TabIndex = 86;
            // 
            // txtRucCliente
            // 
            this.txtRucCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRucCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRucCliente.Enabled = false;
            this.txtRucCliente.Location = new System.Drawing.Point(159, 37);
            this.txtRucCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRucCliente.Name = "txtRucCliente";
            this.txtRucCliente.Size = new System.Drawing.Size(107, 16);
            this.txtRucCliente.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 85;
            this.label3.Text = "Razón social :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 84;
            this.label2.Text = "Ruc del Cliente :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gboLineaPedido
            // 
            this.gboLineaPedido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gboLineaPedido.Controls.Add(this.btnBuscarProductoXZona);
            this.gboLineaPedido.Controls.Add(this.btnAdd);
            this.gboLineaPedido.Controls.Add(this.btnRemove);
            this.gboLineaPedido.Controls.Add(this.txtCantidad);
            this.gboLineaPedido.Controls.Add(this.txtPrecioUnitario);
            this.gboLineaPedido.Controls.Add(this.txtNombreProducto);
            this.gboLineaPedido.Controls.Add(this.txtIdProducto);
            this.gboLineaPedido.Controls.Add(this.label8);
            this.gboLineaPedido.Controls.Add(this.label7);
            this.gboLineaPedido.Controls.Add(this.label6);
            this.gboLineaPedido.Controls.Add(this.label1);
            this.gboLineaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboLineaPedido.Location = new System.Drawing.Point(31, 367);
            this.gboLineaPedido.Name = "gboLineaPedido";
            this.gboLineaPedido.Size = new System.Drawing.Size(428, 153);
            this.gboLineaPedido.TabIndex = 92;
            this.gboLineaPedido.TabStop = false;
            this.gboLineaPedido.Text = "Línea Pedido";
            // 
            // btnBuscarProductoXZona
            // 
            this.btnBuscarProductoXZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBuscarProductoXZona.FlatAppearance.BorderSize = 0;
            this.btnBuscarProductoXZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProductoXZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoXZona.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProductoXZona.Location = new System.Drawing.Point(229, 32);
            this.btnBuscarProductoXZona.Name = "btnBuscarProductoXZona";
            this.btnBuscarProductoXZona.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnBuscarProductoXZona.Size = new System.Drawing.Size(26, 18);
            this.btnBuscarProductoXZona.TabIndex = 83;
            this.btnBuscarProductoXZona.Text = "...";
            this.btnBuscarProductoXZona.UseVisualStyleBackColor = false;
            this.btnBuscarProductoXZona.Click += new System.EventHandler(this.btnBuscarProductoXZona_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(229, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnAdd.Size = new System.Drawing.Size(29, 18);
            this.btnAdd.TabIndex = 82;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.Location = new System.Drawing.Point(264, 113);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnRemove.Size = new System.Drawing.Size(29, 18);
            this.btnRemove.TabIndex = 81;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Location = new System.Drawing.Point(165, 114);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(53, 16);
            this.txtCantidad.TabIndex = 79;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(164, 87);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(55, 16);
            this.txtPrecioUnitario.TabIndex = 78;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(164, 60);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(176, 16);
            this.txtNombreProducto.TabIndex = 77;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(164, 32);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(55, 16);
            this.txtIdProducto.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(56, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 76;
            this.label8.Text = "Cantidad :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(19, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 75;
            this.label7.Text = "Precio Unitario :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(19, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Producto :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "Código del Producto :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 592);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Controls.Add(this.txtMontoTotal);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.btnGuardar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 732);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(723, 82);
            this.panel7.TabIndex = 6;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMontoTotal.Location = new System.Drawing.Point(362, 19);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(74, 16);
            this.txtMontoTotal.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(265, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 106;
            this.label9.Text = "TOTAL :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(62, 15);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 24);
            this.btnGuardar.TabIndex = 105;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvLineas);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 544);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 188);
            this.panel3.TabIndex = 5;
            // 
            // dgvLineas
            // 
            this.dgvLineas.AllowUserToAddRows = false;
            this.dgvLineas.AllowUserToDeleteRows = false;
            this.dgvLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLineas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLineas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLineas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLineas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLineas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLineas.ColumnHeadersHeight = 30;
            this.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCTOXZONA,
            this.NOMBRE,
            this.PRECIO,
            this.Column3,
            this.Column4});
            this.dgvLineas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLineas.EnableHeadersVisualStyles = false;
            this.dgvLineas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvLineas.Location = new System.Drawing.Point(15, 0);
            this.dgvLineas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLineas.Name = "dgvLineas";
            this.dgvLineas.ReadOnly = true;
            this.dgvLineas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLineas.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvLineas.RowHeadersWidth = 51;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLineas.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvLineas.RowTemplate.Height = 24;
            this.dgvLineas.Size = new System.Drawing.Size(693, 188);
            this.dgvLineas.TabIndex = 101;
            this.dgvLineas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLineas_CellFormatting);
            // 
            // IDPRODUCTOXZONA
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IDPRODUCTOXZONA.DefaultCellStyle = dataGridViewCellStyle16;
            this.IDPRODUCTOXZONA.HeaderText = "Id";
            this.IDPRODUCTOXZONA.MinimumWidth = 6;
            this.IDPRODUCTOXZONA.Name = "IDPRODUCTOXZONA";
            this.IDPRODUCTOXZONA.ReadOnly = true;
            this.IDPRODUCTOXZONA.Width = 43;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "Nombre Producto";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 143;
            // 
            // PRECIO
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle17;
            this.PRECIO.HeaderText = "Precio Unit.";
            this.PRECIO.MinimumWidth = 6;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 105;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cantidad";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column3.HeaderText = "Cant.";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 65;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "montoSubTotal";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column4.HeaderText = "Subtotal";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 84;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(708, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 188);
            this.panel5.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 188);
            this.panel4.TabIndex = 99;
            // 
            // frmNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(740, 592);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNuevoPedido";
            this.Text = "frmNuevoPedido";
            this.panel6.ResumeLayout(false);
            this.gboPedido.ResumeLayout(false);
            this.gboPedido.PerformLayout();
            this.gboCliente.ResumeLayout(false);
            this.gboCliente.PerformLayout();
            this.gboLineaPedido.ResumeLayout(false);
            this.gboLineaPedido.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox gboPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaEstimada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtIDOrdenVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRucCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboLineaPedido;
        private System.Windows.Forms.Button btnBuscarProductoXZona;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLineas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCTOXZONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}