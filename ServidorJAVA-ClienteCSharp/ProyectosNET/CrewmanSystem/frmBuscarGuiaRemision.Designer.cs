namespace CrewmanSystem
{
    partial class frmBuscarGuiaRemision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpRangoFin = new System.Windows.Forms.DateTimePicker();
            this.dtpRangoIni = new System.Windows.Forms.DateTimePicker();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvGuiasDeRemision = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_EMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuiasDeRemision)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGrupo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpRangoFin);
            this.panel1.Controls.Add(this.dtpRangoIni);
            this.panel1.Controls.Add(this.txtRuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 194);
            this.panel1.TabIndex = 110;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(394, 66);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(120, 24);
            this.btnSeleccionar.TabIndex = 119;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 118;
            this.label1.Text = "Cliente :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(170, 70);
            this.txtGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(198, 20);
            this.txtGrupo.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 117;
            this.label4.Text = "Fecha Traslado :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(26, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 116;
            this.label3.Text = "Motivo Traslado :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Location = new System.Drawing.Point(26, 108);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(134, 18);
            this.lblID.TabIndex = 115;
            this.lblID.Text = "Fecha Registro :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(394, 36);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 24);
            this.btnBuscar.TabIndex = 114;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dtpRangoFin
            // 
            this.dtpRangoFin.Location = new System.Drawing.Point(170, 138);
            this.dtpRangoFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRangoFin.Name = "dtpRangoFin";
            this.dtpRangoFin.Size = new System.Drawing.Size(198, 20);
            this.dtpRangoFin.TabIndex = 113;
            // 
            // dtpRangoIni
            // 
            this.dtpRangoIni.Location = new System.Drawing.Point(170, 108);
            this.dtpRangoIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRangoIni.Name = "dtpRangoIni";
            this.dtpRangoIni.Size = new System.Drawing.Size(198, 20);
            this.dtpRangoIni.TabIndex = 112;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(170, 39);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(198, 20);
            this.txtRuc.TabIndex = 110;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvGuiasDeRemision);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 203);
            this.panel2.TabIndex = 111;
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
            this.dgvGuiasDeRemision.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGuiasDeRemision.MultiSelect = false;
            this.dgvGuiasDeRemision.Name = "dgvGuiasDeRemision";
            this.dgvGuiasDeRemision.ReadOnly = true;
            this.dgvGuiasDeRemision.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuiasDeRemision.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGuiasDeRemision.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGuiasDeRemision.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGuiasDeRemision.RowTemplate.Height = 24;
            this.dgvGuiasDeRemision.Size = new System.Drawing.Size(540, 203);
            this.dgvGuiasDeRemision.TabIndex = 4;
            this.dgvGuiasDeRemision.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuiasDeRemision_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idGuiaRemision";
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // ID_PEDIDO
            // 
            this.ID_PEDIDO.HeaderText = "Id Pedido";
            this.ID_PEDIDO.MinimumWidth = 6;
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.ReadOnly = true;
            this.ID_PEDIDO.Width = 91;
            // 
            // FECHA_EMISION
            // 
            this.FECHA_EMISION.DataPropertyName = "fechaRegistro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_EMISION.DefaultCellStyle = dataGridViewCellStyle2;
            this.FECHA_EMISION.HeaderText = "Fecha Emisión";
            this.FECHA_EMISION.MinimumWidth = 6;
            this.FECHA_EMISION.Name = "FECHA_EMISION";
            this.FECHA_EMISION.ReadOnly = true;
            this.FECHA_EMISION.Width = 124;
            // 
            // MOTIVO_TRASLADO
            // 
            this.MOTIVO_TRASLADO.DataPropertyName = "motivoTraslado";
            this.MOTIVO_TRASLADO.HeaderText = "Motivo Traslado";
            this.MOTIVO_TRASLADO.MinimumWidth = 6;
            this.MOTIVO_TRASLADO.Name = "MOTIVO_TRASLADO";
            this.MOTIVO_TRASLADO.ReadOnly = true;
            this.MOTIVO_TRASLADO.Width = 133;
            // 
            // FECHA_REGISTRO
            // 
            this.FECHA_REGISTRO.DataPropertyName = "fechaRegistro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_REGISTRO.DefaultCellStyle = dataGridViewCellStyle3;
            this.FECHA_REGISTRO.HeaderText = "Fecha Registro";
            this.FECHA_REGISTRO.MinimumWidth = 6;
            this.FECHA_REGISTRO.Name = "FECHA_REGISTRO";
            this.FECHA_REGISTRO.ReadOnly = true;
            this.FECHA_REGISTRO.Width = 128;
            // 
            // FECHA_TRASLADO
            // 
            this.FECHA_TRASLADO.DataPropertyName = "fechaTraslado";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FECHA_TRASLADO.DefaultCellStyle = dataGridViewCellStyle4;
            this.FECHA_TRASLADO.HeaderText = "Fecha Traslado";
            this.FECHA_TRASLADO.MinimumWidth = 6;
            this.FECHA_TRASLADO.Name = "FECHA_TRASLADO";
            this.FECHA_TRASLADO.ReadOnly = true;
            this.FECHA_TRASLADO.Width = 131;
            // 
            // frmBuscarGuiaRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuscarGuiaRemision";
            this.Text = "frmBuscarGuiaRemision";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuiasDeRemision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpRangoFin;
        private System.Windows.Forms.DateTimePicker dtpRangoIni;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvGuiasDeRemision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_TRASLADO;
    }
}