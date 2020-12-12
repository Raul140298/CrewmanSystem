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
            this.txtIdGuiaRemision = new System.Windows.Forms.TextBox();
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdGuiaRemision
            // 
            this.txtIdGuiaRemision.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdGuiaRemision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdGuiaRemision.Enabled = false;
            this.txtIdGuiaRemision.Location = new System.Drawing.Point(251, 33);
            this.txtIdGuiaRemision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdGuiaRemision.Name = "txtIdGuiaRemision";
            this.txtIdGuiaRemision.Size = new System.Drawing.Size(97, 15);
            this.txtIdGuiaRemision.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(12, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 25);
            this.label9.TabIndex = 111;
            this.label9.Text = "ID Guia Remision :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Location = new System.Drawing.Point(251, 70);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(97, 15);
            this.txtIdPedido.TabIndex = 110;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBuscarPedido.FlatAppearance.BorderSize = 0;
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPedido.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarPedido.Location = new System.Drawing.Point(375, 73);
            this.btnBuscarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Padding = new System.Windows.Forms.Padding(3, 0, 0, 1);
            this.btnBuscarPedido.Size = new System.Drawing.Size(35, 22);
            this.btnBuscarPedido.TabIndex = 109;
            this.btnBuscarPedido.Text = "...";
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 108;
            this.label1.Text = "Código del Pedido :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(60, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 113;
            this.label2.Text = "Motivo Traslado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMotivoTraslado
            // 
            this.txtMotivoTraslado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivoTraslado.Location = new System.Drawing.Point(251, 109);
            this.txtMotivoTraslado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotivoTraslado.Name = "txtMotivoTraslado";
            this.txtMotivoTraslado.Size = new System.Drawing.Size(263, 15);
            this.txtMotivoTraslado.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(58, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 121;
            this.label4.Text = "Fecha Traslado Inicial :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Location = new System.Drawing.Point(60, 151);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(179, 22);
            this.lblID.TabIndex = 120;
            this.lblID.Text = "Fecha Registro Inicial:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpRangoIniTraslado
            // 
            this.dtpRangoIniTraslado.Location = new System.Drawing.Point(251, 187);
            this.dtpRangoIniTraslado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRangoIniTraslado.Name = "dtpRangoIniTraslado";
            this.dtpRangoIniTraslado.Size = new System.Drawing.Size(263, 22);
            this.dtpRangoIniTraslado.TabIndex = 119;
            // 
            // dtpRangoIniRegistro
            // 
            this.dtpRangoIniRegistro.Location = new System.Drawing.Point(251, 149);
            this.dtpRangoIniRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRangoIniRegistro.Name = "dtpRangoIniRegistro";
            this.dtpRangoIniRegistro.Size = new System.Drawing.Size(263, 22);
            this.dtpRangoIniRegistro.TabIndex = 118;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(251, 244);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 30);
            this.btnGuardar.TabIndex = 122;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmNuevaGuiaRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(628, 305);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtpRangoIniTraslado);
            this.Controls.Add(this.dtpRangoIniRegistro);
            this.Controls.Add(this.txtMotivoTraslado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdGuiaRemision);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNuevaGuiaRemision";
            this.Text = "frmNuevaGuiaRemision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdGuiaRemision;
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
        private System.Windows.Forms.Button btnGuardar;
    }
}