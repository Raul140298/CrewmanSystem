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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarFactura));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtMontoPendiente = new System.Windows.Forms.TextBox();
			this.txtIdPedido = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuscarPedido = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtMontoPendiente);
			this.panel1.Controls.Add(this.txtIdPedido);
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnBuscarPedido);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 115);
			this.panel1.TabIndex = 93;
			// 
			// txtMontoPendiente
			// 
			this.txtMontoPendiente.BackColor = System.Drawing.SystemColors.Window;
			this.txtMontoPendiente.Enabled = false;
			this.txtMontoPendiente.Location = new System.Drawing.Point(202, 57);
			this.txtMontoPendiente.Name = "txtMontoPendiente";
			this.txtMontoPendiente.Size = new System.Drawing.Size(198, 22);
			this.txtMontoPendiente.TabIndex = 100;
			// 
			// txtIdPedido
			// 
			this.txtIdPedido.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdPedido.Enabled = false;
			this.txtIdPedido.Location = new System.Drawing.Point(202, 17);
			this.txtIdPedido.Name = "txtIdPedido";
			this.txtIdPedido.Size = new System.Drawing.Size(144, 22);
			this.txtIdPedido.TabIndex = 99;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(475, 17);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(160, 40);
			this.btnBuscar.TabIndex = 98;
			this.btnBuscar.Text = "BUSCAR";
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Location = new System.Drawing.Point(18, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 22);
			this.label2.TabIndex = 97;
			this.label2.Text = "Monto pendiente :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnBuscarPedido
			// 
			this.btnBuscarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnBuscarPedido.FlatAppearance.BorderSize = 0;
			this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarPedido.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnBuscarPedido.Location = new System.Drawing.Point(366, 17);
			this.btnBuscarPedido.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscarPedido.Name = "btnBuscarPedido";
			this.btnBuscarPedido.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
			this.btnBuscarPedido.Size = new System.Drawing.Size(34, 22);
			this.btnBuscarPedido.TabIndex = 95;
			this.btnBuscarPedido.Text = "...";
			this.btnBuscarPedido.UseVisualStyleBackColor = false;
			this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(18, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 22);
			this.label1.TabIndex = 94;
			this.label1.Text = "Código del Pedido :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView1.ColumnHeadersHeight = 30;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 115);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(800, 335);
			this.dataGridView1.TabIndex = 94;
			// 
			// ID
			// 
			this.ID.HeaderText = "Id";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// Column1
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Format = "N2";
			this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
			this.Column1.HeaderText = "Monto";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 83;
			// 
			// Column2
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column2.DefaultCellStyle = dataGridViewCellStyle9;
			this.Column2.HeaderText = "Fecha de emisión";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 169;
			// 
			// Column3
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle10;
			this.Column3.HeaderText = "Fecha de vencimiento";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 200;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Estado";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 89;
			// 
			// frmBuscarFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBuscarFactura";
			this.Text = "Búsqueda de Facturas";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMontoPendiente;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}