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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRutaClientes = new System.Windows.Forms.Button();
            this.sfdPromocion = new System.Windows.Forms.SaveFileDialog();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.pnlPromocion.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnDetallePromocion.Location = new System.Drawing.Point(251, 201);
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
            this.pnlPromocion.Controls.Add(this.btnDetallePromocion);
            this.pnlPromocion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPromocion.Location = new System.Drawing.Point(0, 0);
            this.pnlPromocion.Name = "pnlPromocion";
            this.pnlPromocion.Size = new System.Drawing.Size(800, 278);
            this.pnlPromocion.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRutaClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 297);
            this.panel2.TabIndex = 12;
            // 
            // btnRutaClientes
            // 
            this.btnRutaClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRutaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnRutaClientes.FlatAppearance.BorderSize = 0;
            this.btnRutaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutaClientes.ForeColor = System.Drawing.Color.White;
            this.btnRutaClientes.Location = new System.Drawing.Point(251, 223);
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
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPromocion);
            this.Name = "frmRecursosEmpleado";
            this.Text = "Recursos Empleado";
            this.pnlPromocion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetallePromocion;
        private System.Windows.Forms.Panel pnlPromocion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRutaClientes;
        private System.Windows.Forms.SaveFileDialog sfdPromocion;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
    }
}