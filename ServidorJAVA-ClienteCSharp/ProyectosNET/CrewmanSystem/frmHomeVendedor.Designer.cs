namespace CrewmanSystem
{
	partial class frmHomeVendedor
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
			this.btnRecarga = new FontAwesome.Sharp.IconButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cpbVisitados = new CircularProgressBar.CircularProgressBar();
			this.cpbSumaVentas = new CircularProgressBar.CircularProgressBar();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblZona = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlChildForm.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlChildForm
			// 
			this.pnlChildForm.Controls.Add(this.btnRecarga);
			this.pnlChildForm.Controls.Add(this.panel2);
			this.pnlChildForm.Controls.Add(this.panel1);
			this.pnlChildForm.Controls.Add(this.cpbVisitados);
			this.pnlChildForm.Controls.Add(this.cpbSumaVentas);
			this.pnlChildForm.Controls.Add(this.lblNombre);
			this.pnlChildForm.Controls.Add(this.lblZona);
			this.pnlChildForm.Controls.Add(this.pictureBox1);
			this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlChildForm.Location = new System.Drawing.Point(0, 0);
			this.pnlChildForm.Name = "pnlChildForm";
			this.pnlChildForm.Size = new System.Drawing.Size(939, 689);
			this.pnlChildForm.TabIndex = 5;
			// 
			// btnRecarga
			// 
			this.btnRecarga.BackColor = System.Drawing.Color.Transparent;
			this.btnRecarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRecarga.FlatAppearance.BorderSize = 0;
			this.btnRecarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnRecarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRecarga.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnRecarga.ForeColor = System.Drawing.Color.Transparent;
			this.btnRecarga.IconChar = FontAwesome.Sharp.IconChar.Sync;
			this.btnRecarga.IconColor = System.Drawing.Color.Black;
			this.btnRecarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnRecarga.IconSize = 48;
			this.btnRecarga.Location = new System.Drawing.Point(873, 100);
			this.btnRecarga.Name = "btnRecarga";
			this.btnRecarga.Rotation = 0D;
			this.btnRecarga.Size = new System.Drawing.Size(42, 46);
			this.btnRecarga.TabIndex = 60;
			this.btnRecarga.UseVisualStyleBackColor = false;
			this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
			this.btnRecarga.MouseLeave += new System.EventHandler(this.btnRecarga_MouseLeave);
			this.btnRecarga.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRecarga_MouseMove);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(506, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(317, 47);
			this.panel2.TabIndex = 63;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(281, 24);
			this.label2.TabIndex = 61;
			this.label2.Text = "Progreso de visitas a los clientes";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(57, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(322, 47);
			this.panel1.TabIndex = 62;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(251, 24);
			this.label1.TabIndex = 59;
			this.label1.Text = "Progreso de suma de ventas";
			// 
			// cpbVisitados
			// 
			this.cpbVisitados.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.cpbVisitados.AnimationSpeed = 500;
			this.cpbVisitados.BackColor = System.Drawing.Color.Transparent;
			this.cpbVisitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
			this.cpbVisitados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.cpbVisitados.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cpbVisitados.InnerMargin = 2;
			this.cpbVisitados.InnerWidth = -1;
			this.cpbVisitados.Location = new System.Drawing.Point(515, 165);
			this.cpbVisitados.MarqueeAnimationSpeed = 2000;
			this.cpbVisitados.Name = "cpbVisitados";
			this.cpbVisitados.OuterColor = System.Drawing.Color.Gray;
			this.cpbVisitados.OuterMargin = -25;
			this.cpbVisitados.OuterWidth = 26;
			this.cpbVisitados.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
			this.cpbVisitados.ProgressWidth = 25;
			this.cpbVisitados.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
			this.cpbVisitados.Size = new System.Drawing.Size(300, 300);
			this.cpbVisitados.StartAngle = 270;
			this.cpbVisitados.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
			this.cpbVisitados.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.cpbVisitados.SubscriptText = "";
			this.cpbVisitados.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
			this.cpbVisitados.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.cpbVisitados.SuperscriptText = "";
			this.cpbVisitados.TabIndex = 60;
			this.cpbVisitados.Text = "84%";
			this.cpbVisitados.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.cpbVisitados.Value = 68;
			// 
			// cpbSumaVentas
			// 
			this.cpbSumaVentas.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.cpbSumaVentas.AnimationSpeed = 500;
			this.cpbSumaVentas.BackColor = System.Drawing.Color.Transparent;
			this.cpbSumaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
			this.cpbSumaVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.cpbSumaVentas.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cpbSumaVentas.InnerMargin = 2;
			this.cpbSumaVentas.InnerWidth = -1;
			this.cpbSumaVentas.Location = new System.Drawing.Point(66, 165);
			this.cpbSumaVentas.MarqueeAnimationSpeed = 2000;
			this.cpbSumaVentas.Name = "cpbSumaVentas";
			this.cpbSumaVentas.OuterColor = System.Drawing.Color.Gray;
			this.cpbSumaVentas.OuterMargin = -25;
			this.cpbSumaVentas.OuterWidth = 26;
			this.cpbSumaVentas.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
			this.cpbSumaVentas.ProgressWidth = 25;
			this.cpbSumaVentas.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
			this.cpbSumaVentas.Size = new System.Drawing.Size(300, 300);
			this.cpbSumaVentas.StartAngle = 270;
			this.cpbSumaVentas.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
			this.cpbSumaVentas.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.cpbSumaVentas.SubscriptText = "";
			this.cpbSumaVentas.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
			this.cpbSumaVentas.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.cpbSumaVentas.SuperscriptText = "";
			this.cpbSumaVentas.TabIndex = 58;
			this.cpbSumaVentas.Text = "84%";
			this.cpbSumaVentas.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.cpbSumaVentas.Value = 68;
			// 
			// lblNombre
			// 
			this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(0, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.lblNombre.Size = new System.Drawing.Size(939, 105);
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
			this.lblZona.Location = new System.Drawing.Point(3, 634);
			this.lblZona.Name = "lblZona";
			this.lblZona.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.lblZona.Size = new System.Drawing.Size(476, 55);
			this.lblZona.TabIndex = 51;
			this.lblZona.Text = "NOMBRE";
			this.lblZona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::CrewmanSystem.Properties.Resources.MARCADEAGUA;
			this.pictureBox1.Location = new System.Drawing.Point(798, 549);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 124);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			// 
			// frmHomeVendedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 689);
			this.Controls.Add(this.pnlChildForm);
			this.Name = "frmHomeVendedor";
			this.Text = "frmHomeVendedor";
			this.pnlChildForm.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlChildForm;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblZona;
		private CircularProgressBar.CircularProgressBar cpbSumaVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar cpbVisitados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRecarga;
    }
}