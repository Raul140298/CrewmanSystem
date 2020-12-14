namespace CrewmanSystem
{
    partial class frmIniciarTemporada
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
            this.btnSegmentar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(124, 303);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(212, 29);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha última temporada :";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSegmentar
            // 
            this.btnSegmentar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSegmentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSegmentar.FlatAppearance.BorderSize = 0;
            this.btnSegmentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegmentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegmentar.ForeColor = System.Drawing.Color.White;
            this.btnSegmentar.Location = new System.Drawing.Point(124, 349);
            this.btnSegmentar.Name = "btnSegmentar";
            this.btnSegmentar.Size = new System.Drawing.Size(351, 45);
            this.btnSegmentar.TabIndex = 50;
            this.btnSegmentar.Text = "INICIAR";
            this.btnSegmentar.UseVisualStyleBackColor = false;
            this.btnSegmentar.Click += new System.EventHandler(this.btnSegmentar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(356, 307);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(105, 19);
            this.txtFecha.TabIndex = 51;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CrewmanSystem.Properties.Resources.segmentar;
            this.pictureBox1.Location = new System.Drawing.Point(124, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // frmIniciarTemporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(587, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnSegmentar);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmIniciarTemporada";
            this.Text = "frmIniciarTemporada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnSegmentar;
        private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}