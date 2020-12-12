namespace CrewmanSystem
{
    partial class frmReportePedidosXCliente
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
            this.sfdReportePedidos = new System.Windows.Forms.SaveFileDialog();
            this.btnReportePedidosXCliente = new System.Windows.Forms.Button();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnReportePedidos = new System.Windows.Forms.Button();
            this.sfdReportePedidosXCliente = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfdReportePedidos
            // 
            this.sfdReportePedidos.DefaultExt = "pdf";
            this.sfdReportePedidos.FileName = "ReporteDePedidos.pdf";
            this.sfdReportePedidos.Filter = "PDF (*.pdf)|*.pdf";
            // 
            // btnReportePedidosXCliente
            // 
            this.btnReportePedidosXCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportePedidosXCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReportePedidosXCliente.FlatAppearance.BorderSize = 0;
            this.btnReportePedidosXCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePedidosXCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePedidosXCliente.ForeColor = System.Drawing.Color.White;
            this.btnReportePedidosXCliente.Location = new System.Drawing.Point(114, 413);
            this.btnReportePedidosXCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportePedidosXCliente.Name = "btnReportePedidosXCliente";
            this.btnReportePedidosXCliente.Size = new System.Drawing.Size(418, 45);
            this.btnReportePedidosXCliente.TabIndex = 8;
            this.btnReportePedidosXCliente.Text = "Generar Reporte de Pedidos por Cliente";
            this.btnReportePedidosXCliente.UseVisualStyleBackColor = false;
            this.btnReportePedidosXCliente.Click += new System.EventHandler(this.btnReportePedidosXCliente_Click);
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(271, 303);
            this.cboTipoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(261, 24);
            this.cboTipoCliente.TabIndex = 10;
            // 
            // btnReportePedidos
            // 
            this.btnReportePedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportePedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReportePedidos.FlatAppearance.BorderSize = 0;
            this.btnReportePedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePedidos.ForeColor = System.Drawing.Color.White;
            this.btnReportePedidos.Location = new System.Drawing.Point(114, 735);
            this.btnReportePedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportePedidos.Name = "btnReportePedidos";
            this.btnReportePedidos.Size = new System.Drawing.Size(418, 45);
            this.btnReportePedidos.TabIndex = 11;
            this.btnReportePedidos.Text = "Generar Reporte Total de Pedidos";
            this.btnReportePedidos.UseVisualStyleBackColor = false;
            this.btnReportePedidos.Click += new System.EventHandler(this.btnReportePedidos_Click);
            // 
            // sfdReportePedidosXCliente
            // 
            this.sfdReportePedidosXCliente.DefaultExt = "pdf";
            this.sfdReportePedidosXCliente.FileName = "ReporteDePedidosPorCliente.pdf";
            this.sfdReportePedidosXCliente.Filter = "PDF (*.pdf)|*.pdf";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tipo de Cliente :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::CrewmanSystem.Properties.Resources.reportePedidos2;
            this.pictureBox2.Location = new System.Drawing.Point(114, 496);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CrewmanSystem.Properties.Resources.reportePedidosXCliente2;
            this.pictureBox1.Location = new System.Drawing.Point(114, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Estado del pedido :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEstado
            // 
            this.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(271, 349);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(261, 24);
            this.cboEstado.TabIndex = 51;
            // 
            // frmReportePedidosXCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 906);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReportePedidos);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.btnReportePedidosXCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReportePedidosXCliente";
            this.Text = "frmReportePedidosXCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfdReportePedidos;
        private System.Windows.Forms.Button btnReportePedidosXCliente;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Button btnReportePedidos;
        private System.Windows.Forms.SaveFileDialog sfdReportePedidosXCliente;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}