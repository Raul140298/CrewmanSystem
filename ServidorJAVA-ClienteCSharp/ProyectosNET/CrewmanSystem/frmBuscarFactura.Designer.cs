namespace CrewmanSystem
{
    partial class frmBuscarFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaVencimientoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimientoIni = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbPagadoAmbos = new System.Windows.Forms.RadioButton();
            this.rbPagadoNo = new System.Windows.Forms.RadioButton();
            this.rbPagadoSi = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbEmisionAmbos = new System.Windows.Forms.RadioButton();
            this.rbAnuladoNo = new System.Windows.Forms.RadioButton();
            this.rbAnuladoSi = new System.Windows.Forms.RadioButton();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaEmisionFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEmisionIni = new System.Windows.Forms.DateTimePicker();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_VENCIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_EMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPUESTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANULADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_PAGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpFechaVencimientoFinal);
            this.panel1.Controls.Add(this.dtpFechaVencimientoIni);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGrupo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpFechaEmisionFinal);
            this.panel1.Controls.Add(this.dtpFechaEmisionIni);
            this.panel1.Controls.Add(this.txtRazonSocial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 238);
            this.panel1.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(535, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 22);
            this.label6.TabIndex = 115;
            this.label6.Text = "Fecha Vencimiento Final :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(48, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 22);
            this.label7.TabIndex = 114;
            this.label7.Text = "Fecha Vencimiento Inicial :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaVencimientoFinal
            // 
            this.dtpFechaVencimientoFinal.Location = new System.Drawing.Point(727, 186);
            this.dtpFechaVencimientoFinal.Name = "dtpFechaVencimientoFinal";
            this.dtpFechaVencimientoFinal.Size = new System.Drawing.Size(263, 22);
            this.dtpFechaVencimientoFinal.TabIndex = 113;
            // 
            // dtpFechaVencimientoIni
            // 
            this.dtpFechaVencimientoIni.Location = new System.Drawing.Point(240, 186);
            this.dtpFechaVencimientoIni.Name = "dtpFechaVencimientoIni";
            this.dtpFechaVencimientoIni.Size = new System.Drawing.Size(263, 22);
            this.dtpFechaVencimientoIni.TabIndex = 112;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbPagadoAmbos);
            this.panel3.Controls.Add(this.rbPagadoNo);
            this.panel3.Controls.Add(this.rbPagadoSi);
            this.panel3.Location = new System.Drawing.Point(617, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 34);
            this.panel3.TabIndex = 111;
            // 
            // rbPagadoAmbos
            // 
            this.rbPagadoAmbos.AutoSize = true;
            this.rbPagadoAmbos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbPagadoAmbos.Location = new System.Drawing.Point(100, 13);
            this.rbPagadoAmbos.Name = "rbPagadoAmbos";
            this.rbPagadoAmbos.Size = new System.Drawing.Size(72, 21);
            this.rbPagadoAmbos.TabIndex = 3;
            this.rbPagadoAmbos.TabStop = true;
            this.rbPagadoAmbos.Text = "Ambos";
            this.rbPagadoAmbos.UseVisualStyleBackColor = true;
            // 
            // rbPagadoNo
            // 
            this.rbPagadoNo.AutoSize = true;
            this.rbPagadoNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbPagadoNo.Location = new System.Drawing.Point(47, 13);
            this.rbPagadoNo.Name = "rbPagadoNo";
            this.rbPagadoNo.Size = new System.Drawing.Size(47, 21);
            this.rbPagadoNo.TabIndex = 1;
            this.rbPagadoNo.TabStop = true;
            this.rbPagadoNo.Text = "No";
            this.rbPagadoNo.UseVisualStyleBackColor = true;
            // 
            // rbPagadoSi
            // 
            this.rbPagadoSi.AutoSize = true;
            this.rbPagadoSi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbPagadoSi.Location = new System.Drawing.Point(0, 13);
            this.rbPagadoSi.Name = "rbPagadoSi";
            this.rbPagadoSi.Size = new System.Drawing.Size(41, 21);
            this.rbPagadoSi.TabIndex = 0;
            this.rbPagadoSi.TabStop = true;
            this.rbPagadoSi.Text = "Sí";
            this.rbPagadoSi.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbEmisionAmbos);
            this.panel2.Controls.Add(this.rbAnuladoNo);
            this.panel2.Controls.Add(this.rbAnuladoSi);
            this.panel2.Location = new System.Drawing.Point(240, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 34);
            this.panel2.TabIndex = 110;
            // 
            // rbEmisionAmbos
            // 
            this.rbEmisionAmbos.AutoSize = true;
            this.rbEmisionAmbos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbEmisionAmbos.Location = new System.Drawing.Point(100, 13);
            this.rbEmisionAmbos.Name = "rbEmisionAmbos";
            this.rbEmisionAmbos.Size = new System.Drawing.Size(72, 21);
            this.rbEmisionAmbos.TabIndex = 2;
            this.rbEmisionAmbos.TabStop = true;
            this.rbEmisionAmbos.Text = "Ambos";
            this.rbEmisionAmbos.UseVisualStyleBackColor = true;
            // 
            // rbAnuladoNo
            // 
            this.rbAnuladoNo.AutoSize = true;
            this.rbAnuladoNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbAnuladoNo.Location = new System.Drawing.Point(47, 13);
            this.rbAnuladoNo.Name = "rbAnuladoNo";
            this.rbAnuladoNo.Size = new System.Drawing.Size(47, 21);
            this.rbAnuladoNo.TabIndex = 1;
            this.rbAnuladoNo.TabStop = true;
            this.rbAnuladoNo.Text = "No";
            this.rbAnuladoNo.UseVisualStyleBackColor = true;
            // 
            // rbAnuladoSi
            // 
            this.rbAnuladoSi.AutoSize = true;
            this.rbAnuladoSi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbAnuladoSi.Location = new System.Drawing.Point(0, 13);
            this.rbAnuladoSi.Name = "rbAnuladoSi";
            this.rbAnuladoSi.Size = new System.Drawing.Size(41, 21);
            this.rbAnuladoSi.TabIndex = 0;
            this.rbAnuladoSi.TabStop = true;
            this.rbAnuladoSi.Text = "Sí";
            this.rbAnuladoSi.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(727, 23);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(160, 30);
            this.btnSeleccionar.TabIndex = 109;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(535, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 108;
            this.label5.Text = "Pagado :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 107;
            this.label2.Text = "Anulado :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(48, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 106;
            this.label1.Text = "Grupo :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrupo
            // 
            this.txtGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrupo.Location = new System.Drawing.Point(240, 65);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(263, 15);
            this.txtGrupo.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(563, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 105;
            this.label4.Text = "Fecha Emisión Final :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(48, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 104;
            this.label3.Text = "Razón Social :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Location = new System.Drawing.Point(48, 148);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(179, 22);
            this.lblID.TabIndex = 103;
            this.lblID.Text = "Fecha Emisión Inicial :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(538, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 30);
            this.btnBuscar.TabIndex = 102;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaEmisionFinal
            // 
            this.dtpFechaEmisionFinal.Location = new System.Drawing.Point(727, 148);
            this.dtpFechaEmisionFinal.Name = "dtpFechaEmisionFinal";
            this.dtpFechaEmisionFinal.Size = new System.Drawing.Size(263, 22);
            this.dtpFechaEmisionFinal.TabIndex = 101;
            // 
            // dtpFechaEmisionIni
            // 
            this.dtpFechaEmisionIni.Location = new System.Drawing.Point(240, 148);
            this.dtpFechaEmisionIni.Name = "dtpFechaEmisionIni";
            this.dtpFechaEmisionIni.Size = new System.Drawing.Size(263, 22);
            this.dtpFechaEmisionIni.TabIndex = 100;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.Location = new System.Drawing.Point(240, 27);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(263, 15);
            this.txtRazonSocial.TabIndex = 96;
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
            this.FECHA_VENCIMIENTO,
            this.FECHA_EMISION,
            this.IMPUESTOS,
            this.ANULADO,
            this.ESTADO_PAGAR,
            this.RUC,
            this.RAZON_SOCIAL,
            this.GRUPO,
            this.TIPO_CLIENTE,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO});
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvFacturas.Location = new System.Drawing.Point(0, 238);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFacturas.RowHeadersWidth = 51;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.Size = new System.Drawing.Size(1127, 212);
            this.dgvFacturas.TabIndex = 94;
            this.dgvFacturas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFacturas_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idFactura";
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
            // MONTO
            // 
            this.MONTO.DataPropertyName = "monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            this.MONTO.DefaultCellStyle = dataGridViewCellStyle4;
            this.MONTO.HeaderText = "Monto";
            this.MONTO.MinimumWidth = 6;
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            this.MONTO.Width = 83;
            // 
            // FECHA_VENCIMIENTO
            // 
            this.FECHA_VENCIMIENTO.DataPropertyName = "fechaVencimiento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_VENCIMIENTO.DefaultCellStyle = dataGridViewCellStyle5;
            this.FECHA_VENCIMIENTO.HeaderText = "Fecha Vencimiento";
            this.FECHA_VENCIMIENTO.MinimumWidth = 6;
            this.FECHA_VENCIMIENTO.Name = "FECHA_VENCIMIENTO";
            this.FECHA_VENCIMIENTO.ReadOnly = true;
            this.FECHA_VENCIMIENTO.Width = 180;
            // 
            // FECHA_EMISION
            // 
            this.FECHA_EMISION.DataPropertyName = "fechaEmision";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_EMISION.DefaultCellStyle = dataGridViewCellStyle6;
            this.FECHA_EMISION.HeaderText = "Fecha Emisión";
            this.FECHA_EMISION.MinimumWidth = 6;
            this.FECHA_EMISION.Name = "FECHA_EMISION";
            this.FECHA_EMISION.ReadOnly = true;
            this.FECHA_EMISION.Width = 148;
            // 
            // IMPUESTOS
            // 
            this.IMPUESTOS.DataPropertyName = "impuestos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.IMPUESTOS.DefaultCellStyle = dataGridViewCellStyle7;
            this.IMPUESTOS.HeaderText = "Impuestos";
            this.IMPUESTOS.MinimumWidth = 6;
            this.IMPUESTOS.Name = "IMPUESTOS";
            this.IMPUESTOS.ReadOnly = true;
            this.IMPUESTOS.Width = 114;
            // 
            // ANULADO
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ANULADO.DefaultCellStyle = dataGridViewCellStyle8;
            this.ANULADO.HeaderText = "Anulado";
            this.ANULADO.MinimumWidth = 6;
            this.ANULADO.Name = "ANULADO";
            this.ANULADO.ReadOnly = true;
            this.ANULADO.Width = 97;
            // 
            // ESTADO_PAGAR
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ESTADO_PAGAR.DefaultCellStyle = dataGridViewCellStyle9;
            this.ESTADO_PAGAR.HeaderText = "Pagado";
            this.ESTADO_PAGAR.MinimumWidth = 6;
            this.ESTADO_PAGAR.Name = "ESTADO_PAGAR";
            this.ESTADO_PAGAR.ReadOnly = true;
            this.ESTADO_PAGAR.Width = 93;
            // 
            // RUC
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RUC.DefaultCellStyle = dataGridViewCellStyle10;
            this.RUC.HeaderText = "RUC";
            this.RUC.MinimumWidth = 6;
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            this.RUC.Width = 73;
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.HeaderText = "Razon Social";
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TIPO_CLIENTE.DefaultCellStyle = dataGridViewCellStyle11;
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
            // frmBuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarFactura";
            this.Text = "Búsqueda de Facturas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoIni;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbPagadoNo;
        private System.Windows.Forms.RadioButton rbPagadoSi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAnuladoNo;
        private System.Windows.Forms.RadioButton rbAnuladoSi;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaEmisionFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaEmisionIni;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.RadioButton rbPagadoAmbos;
        private System.Windows.Forms.RadioButton rbEmisionAmbos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VENCIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPUESTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANULADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_PAGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
    }
}