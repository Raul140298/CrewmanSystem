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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnReportePedidos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sfdReportePedidosXCliente = new System.Windows.Forms.SaveFileDialog();
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
            this.btnReportePedidosXCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReportePedidosXCliente.FlatAppearance.BorderSize = 0;
            this.btnReportePedidosXCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePedidosXCliente.ForeColor = System.Drawing.Color.White;
            this.btnReportePedidosXCliente.Location = new System.Drawing.Point(114, 94);
            this.btnReportePedidosXCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportePedidosXCliente.Name = "btnReportePedidosXCliente";
            this.btnReportePedidosXCliente.Size = new System.Drawing.Size(274, 30);
            this.btnReportePedidosXCliente.TabIndex = 8;
            this.btnReportePedidosXCliente.Text = "Generar Reporte Pedidos por Cliente";
            this.btnReportePedidosXCliente.UseVisualStyleBackColor = false;
            this.btnReportePedidosXCliente.Click += new System.EventHandler(this.btnReportePedidosXCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de Cliente: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(267, 47);
            this.cboTipoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(121, 24);
            this.cboTipoCliente.TabIndex = 10;
            // 
            // btnReportePedidos
            // 
            this.btnReportePedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReportePedidos.FlatAppearance.BorderSize = 0;
            this.btnReportePedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePedidos.ForeColor = System.Drawing.Color.White;
            this.btnReportePedidos.Location = new System.Drawing.Point(112, 226);
            this.btnReportePedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportePedidos.Name = "btnReportePedidos";
            this.btnReportePedidos.Size = new System.Drawing.Size(276, 31);
            this.btnReportePedidos.TabIndex = 11;
            this.btnReportePedidos.Text = "Generar Reporte Pedidos";
            this.btnReportePedidos.UseVisualStyleBackColor = false;
            this.btnReportePedidos.Click += new System.EventHandler(this.btnReportePedidos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reporte total de pedidos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sfdReportePedidosXCliente
            // 
            this.sfdReportePedidosXCliente.DefaultExt = "pdf";
            this.sfdReportePedidosXCliente.FileName = "ReporteDePedidosPorCliente.pdf";
            this.sfdReportePedidosXCliente.Filter = "PDF (*.pdf)|*.pdf";
            // 
            // frmReportePedidosXCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReportePedidos);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReportePedidosXCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReportePedidosXCliente";
            this.Text = "frmReportePedidosXCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfdReportePedidos;
        private System.Windows.Forms.Button btnReportePedidosXCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Button btnReportePedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog sfdReportePedidosXCliente;
    }
}