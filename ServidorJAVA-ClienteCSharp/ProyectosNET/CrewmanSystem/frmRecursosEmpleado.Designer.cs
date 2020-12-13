namespace CrewmanSystem
{
    partial class frmRecursosEmpleado
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
			this.btnDetallePromocion = new System.Windows.Forms.Button();
			this.pnlPromocion = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnRutaClientes = new System.Windows.Forms.Button();
			this.sfdPromocion = new System.Windows.Forms.SaveFileDialog();
			this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
			this.pnlPromocion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDetallePromocion
			// 
			this.btnDetallePromocion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDetallePromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnDetallePromocion.FlatAppearance.BorderSize = 0;
			this.btnDetallePromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDetallePromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDetallePromocion.ForeColor = System.Drawing.Color.White;
			this.btnDetallePromocion.Location = new System.Drawing.Point(128, 241);
			this.btnDetallePromocion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDetallePromocion.Name = "btnDetallePromocion";
			this.btnDetallePromocion.Size = new System.Drawing.Size(351, 45);
			this.btnDetallePromocion.TabIndex = 10;
			this.btnDetallePromocion.Text = "Generar PDF de la promoción";
			this.btnDetallePromocion.UseVisualStyleBackColor = false;
			this.btnDetallePromocion.Click += new System.EventHandler(this.btnDetallePromocion_Click);
			// 
			// pnlPromocion
			// 
			this.pnlPromocion.Controls.Add(this.pictureBox2);
			this.pnlPromocion.Controls.Add(this.btnDetallePromocion);
			this.pnlPromocion.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlPromocion.Location = new System.Drawing.Point(0, 0);
			this.pnlPromocion.Name = "pnlPromocion";
			this.pnlPromocion.Size = new System.Drawing.Size(604, 300);
			this.pnlPromocion.TabIndex = 11;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.Image = global::CrewmanSystem.Properties.Resources.promocion;
			this.pictureBox2.Location = new System.Drawing.Point(128, 14);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(351, 222);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.btnRutaClientes);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 300);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(604, 300);
			this.panel2.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = global::CrewmanSystem.Properties.Resources.ruta;
			this.pictureBox1.Location = new System.Drawing.Point(128, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(351, 222);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 28;
			this.pictureBox1.TabStop = false;
			// 
			// btnRutaClientes
			// 
			this.btnRutaClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRutaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnRutaClientes.FlatAppearance.BorderSize = 0;
			this.btnRutaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRutaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRutaClientes.ForeColor = System.Drawing.Color.White;
			this.btnRutaClientes.Location = new System.Drawing.Point(128, 244);
			this.btnRutaClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRutaClientes.Name = "btnRutaClientes";
			this.btnRutaClientes.Size = new System.Drawing.Size(351, 45);
			this.btnRutaClientes.TabIndex = 11;
			this.btnRutaClientes.Text = "Generar PDF de la ruta de clientes";
			this.btnRutaClientes.UseVisualStyleBackColor = false;
			this.btnRutaClientes.Click += new System.EventHandler(this.btnRutaClientes_Click);
			// 
			// sfdPromocion
			// 
			this.sfdPromocion.DefaultExt = "pdf";
			this.sfdPromocion.FileName = "DetalleDePromocion.pdf";
			this.sfdPromocion.Filter = "PDF (*.pdf)|*.pdf";
			// 
			// sfdRuta
			// 
			this.sfdRuta.DefaultExt = "pdf";
			this.sfdRuta.FileName = "RutaDeClientes.pdf";
			this.sfdRuta.Filter = "PDF (*.pdf)|*.pdf";
			// 
			// frmRecursosEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(604, 600);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlPromocion);
			this.Name = "frmRecursosEmpleado";
			this.Text = "Recursos Empleado";
			this.pnlPromocion.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetallePromocion;
        private System.Windows.Forms.Panel pnlPromocion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRutaClientes;
        private System.Windows.Forms.SaveFileDialog sfdPromocion;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}