namespace CrewmanSystem
{
    partial class frmGestionarAprobados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO_PAGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_APROBADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_ESTIMADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNotFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeight = 30;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TIPO_PEDIDO,
            this.ESTADO,
            this.Column2,
            this.MONTO_PAGAR,
            this.Column3,
            this.FECHA_REGISTRO,
            this.FECHA_APROBADO,
            this.FECHA_ESTIMADA,
            this.RUC,
            this.RAZON_SOCIAL,
            this.GRUPO,
            this.TIPO_CLIENTE,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO});
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPedidos.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(800, 450);
            this.dgvPedidos.TabIndex = 3;
            this.dgvPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPedidos_CellFormatting);
            this.dgvPedidos.SelectionChanged += new System.EventHandler(this.dgvPedidos_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idPedido";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
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
            // Column2
            // 
            this.Column2.DataPropertyName = "montoTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Monto Total";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // MONTO_PAGAR
            // 
            this.MONTO_PAGAR.DataPropertyName = "montoPagar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.MONTO_PAGAR.DefaultCellStyle = dataGridViewCellStyle4;
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
            // FECHA_REGISTRO
            // 
            this.FECHA_REGISTRO.HeaderText = "Fecha Registro";
            this.FECHA_REGISTRO.MinimumWidth = 6;
            this.FECHA_REGISTRO.Name = "FECHA_REGISTRO";
            this.FECHA_REGISTRO.ReadOnly = true;
            this.FECHA_REGISTRO.Width = 151;
            // 
            // FECHA_APROBADO
            // 
            this.FECHA_APROBADO.HeaderText = "Fecha Aprobado";
            this.FECHA_APROBADO.MinimumWidth = 6;
            this.FECHA_APROBADO.Name = "FECHA_APROBADO";
            this.FECHA_APROBADO.ReadOnly = true;
            this.FECHA_APROBADO.Width = 159;
            // 
            // FECHA_ESTIMADA
            // 
            this.FECHA_ESTIMADA.HeaderText = "Fecha Estimada";
            this.FECHA_ESTIMADA.MinimumWidth = 6;
            this.FECHA_ESTIMADA.Name = "FECHA_ESTIMADA";
            this.FECHA_ESTIMADA.ReadOnly = true;
            this.FECHA_ESTIMADA.Width = 158;
            // 
            // RUC
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RUC.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TIPO_CLIENTE.DefaultCellStyle = dataGridViewCellStyle6;
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
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFound.Location = new System.Drawing.Point(400, 64);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(230, 20);
            this.lblNotFound.TabIndex = 4;
            this.lblNotFound.Text = "No se encontraron resultados";
            this.lblNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotFound.Visible = false;
            // 
            // frmGestionarAprobados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "frmGestionarAprobados";
            this.Text = "frmGestionarAprobados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO_PAGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_APROBADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_ESTIMADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
        private System.Windows.Forms.Label lblNotFound;
    }
}