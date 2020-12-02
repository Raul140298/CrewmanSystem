namespace CrewmanSystem
{
    partial class frmNuevaGuiaRemision
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
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotivoTraslado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dtpRangoIniTraslado = new System.Windows.Forms.DateTimePicker();
            this.dtpRangoIniRegistro = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdFactura.Enabled = false;
            this.txtIdFactura.Location = new System.Drawing.Point(188, 27);
            this.txtIdFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(74, 20);
            this.txtIdFactura.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(72, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 111;
            this.label9.Text = "ID Guia Remision :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(188, 57);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(74, 20);
            this.txtIdPedido.TabIndex = 110;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBuscarPedido.FlatAppearance.BorderSize = 0;
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPedido.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarPedido.Location = new System.Drawing.Point(281, 59);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnBuscarPedido.Size = new System.Drawing.Size(26, 18);
            this.btnBuscarPedido.TabIndex = 109;
            this.btnBuscarPedido.Text = "...";
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 108;
            this.label1.Text = "Código del Pedido :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(44, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 113;
            this.label2.Text = "Motivo Traslado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMotivoTraslado
            // 
            this.txtMotivoTraslado.Location = new System.Drawing.Point(188, 103);
            this.txtMotivoTraslado.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotivoTraslado.Name = "txtMotivoTraslado";
            this.txtMotivoTraslado.Size = new System.Drawing.Size(198, 20);
            this.txtMotivoTraslado.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(45, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 121;
            this.label4.Text = "Fecha Traslado Inicial :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Location = new System.Drawing.Point(44, 154);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(134, 18);
            this.lblID.TabIndex = 120;
            this.lblID.Text = "Fecha Registro Inicial:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpRangoIniTraslado
            // 
            this.dtpRangoIniTraslado.Location = new System.Drawing.Point(188, 206);
            this.dtpRangoIniTraslado.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRangoIniTraslado.Name = "dtpRangoIniTraslado";
            this.dtpRangoIniTraslado.Size = new System.Drawing.Size(198, 20);
            this.dtpRangoIniTraslado.TabIndex = 119;
            // 
            // dtpRangoIniRegistro
            // 
            this.dtpRangoIniRegistro.Location = new System.Drawing.Point(188, 154);
            this.dtpRangoIniRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRangoIniRegistro.Name = "dtpRangoIniRegistro";
            this.dtpRangoIniRegistro.Size = new System.Drawing.Size(198, 20);
            this.dtpRangoIniRegistro.TabIndex = 118;
            // 
            // frmNuevaGuiaRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 345);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtpRangoIniTraslado);
            this.Controls.Add(this.dtpRangoIniRegistro);
            this.Controls.Add(this.txtMotivoTraslado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.label1);
            this.Name = "frmNuevaGuiaRemision";
            this.Text = "frmNuevaGuiaRemision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotivoTraslado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtpRangoIniTraslado;
        private System.Windows.Forms.DateTimePicker dtpRangoIniRegistro;
    }
}