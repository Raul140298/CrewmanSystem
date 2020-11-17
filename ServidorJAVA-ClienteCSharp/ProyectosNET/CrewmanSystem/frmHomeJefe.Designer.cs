namespace CrewmanSystem
{
	partial class frmHomeJefe
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
			this.pnlChildForm = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblZona = new System.Windows.Forms.Label();
			this.lblDni = new System.Windows.Forms.Label();
			this.lblDatos = new System.Windows.Forms.Label();
			this.pnlChildForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlChildForm
			// 
			this.pnlChildForm.Controls.Add(this.panel1);
			this.pnlChildForm.Controls.Add(this.lblZona);
			this.pnlChildForm.Controls.Add(this.pictureBox1);
			this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlChildForm.Location = new System.Drawing.Point(0, 0);
			this.pnlChildForm.Name = "pnlChildForm";
			this.pnlChildForm.Size = new System.Drawing.Size(800, 627);
			this.pnlChildForm.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::CrewmanSystem.Properties.Resources.MARCADEAGUA;
			this.pictureBox1.Location = new System.Drawing.Point(659, 487);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 124);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.panel1.Controls.Add(this.lblDatos);
			this.panel1.Controls.Add(this.lblDni);
			this.panel1.Controls.Add(this.lblNombre);
			this.panel1.Location = new System.Drawing.Point(24, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(607, 525);
			this.panel1.TabIndex = 25;
			// 
			// lblNombre
			// 
			this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(0, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(604, 55);
			this.lblNombre.TabIndex = 48;
			this.lblNombre.Text = "NOMBRE";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblZona
			// 
			this.lblZona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblZona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
			this.lblZona.Location = new System.Drawing.Point(3, 572);
			this.lblZona.Name = "lblZona";
			this.lblZona.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.lblZona.Size = new System.Drawing.Size(476, 55);
			this.lblZona.TabIndex = 49;
			this.lblZona.Text = "NOMBRE";
			this.lblZona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDni
			// 
			this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDni.Location = new System.Drawing.Point(1, 131);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(607, 55);
			this.lblDni.TabIndex = 50;
			this.lblDni.Text = "DNI";
			this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDatos
			// 
			this.lblDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatos.Location = new System.Drawing.Point(0, 65);
			this.lblDatos.Name = "lblDatos";
			this.lblDatos.Size = new System.Drawing.Size(607, 55);
			this.lblDatos.TabIndex = 51;
			this.lblDatos.Text = "Datos del Empleado :";
			this.lblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmHomeJefe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 627);
			this.Controls.Add(this.pnlChildForm);
			this.Name = "frmHomeJefe";
			this.Text = "frmHome";
			this.pnlChildForm.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlChildForm;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblZona;
		private System.Windows.Forms.Label lblDni;
		private System.Windows.Forms.Label lblDatos;
	}
}