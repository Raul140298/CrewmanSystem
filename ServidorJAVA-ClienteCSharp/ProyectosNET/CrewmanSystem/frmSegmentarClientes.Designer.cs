namespace CrewmanSystem
{
    partial class frmSegmentarClientes
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnSegmentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(155, 149);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(188, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha última segmentación :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(361, 149);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnSegmentar
            // 
            this.btnSegmentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSegmentar.FlatAppearance.BorderSize = 0;
            this.btnSegmentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegmentar.ForeColor = System.Drawing.Color.White;
            this.btnSegmentar.Location = new System.Drawing.Point(295, 218);
            this.btnSegmentar.Name = "btnSegmentar";
            this.btnSegmentar.Size = new System.Drawing.Size(160, 40);
            this.btnSegmentar.TabIndex = 50;
            this.btnSegmentar.Text = "SEGMENTAR";
            this.btnSegmentar.UseVisualStyleBackColor = false;
            this.btnSegmentar.Click += new System.EventHandler(this.btnSegmentar_Click);
            // 
            // frmSegmentarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSegmentar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmSegmentarClientes";
            this.Text = "frmSegmentarClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnSegmentar;
    }
}