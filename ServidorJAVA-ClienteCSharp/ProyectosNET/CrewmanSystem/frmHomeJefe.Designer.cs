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
			this.lblZona = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
			this.pnlChildForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlChildForm
			// 
			this.pnlChildForm.Controls.Add(this.lblNombre);
			this.pnlChildForm.Controls.Add(this.circularProgressBar1);
			this.pnlChildForm.Controls.Add(this.lblZona);
			this.pnlChildForm.Controls.Add(this.pictureBox1);
			this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlChildForm.Location = new System.Drawing.Point(0, 0);
			this.pnlChildForm.Name = "pnlChildForm";
			this.pnlChildForm.Size = new System.Drawing.Size(800, 627);
			this.pnlChildForm.TabIndex = 4;
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
			// lblNombre
			// 
			this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(0, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.lblNombre.Size = new System.Drawing.Size(800, 105);
			this.lblNombre.TabIndex = 56;
			this.lblNombre.Text = "NOMBRE";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// circularProgressBar1
			// 
			this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.circularProgressBar1.AnimationSpeed = 500;
			this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
			this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
			this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.circularProgressBar1.InnerMargin = 2;
			this.circularProgressBar1.InnerWidth = -1;
			this.circularProgressBar1.Location = new System.Drawing.Point(24, 118);
			this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
			this.circularProgressBar1.Name = "circularProgressBar1";
			this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
			this.circularProgressBar1.OuterMargin = -25;
			this.circularProgressBar1.OuterWidth = 26;
			this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
			this.circularProgressBar1.ProgressWidth = 25;
			this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
			this.circularProgressBar1.Size = new System.Drawing.Size(407, 407);
			this.circularProgressBar1.StartAngle = 270;
			this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
			this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.circularProgressBar1.SubscriptText = "";
			this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
			this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.circularProgressBar1.SuperscriptText = "";
			this.circularProgressBar1.TabIndex = 57;
			this.circularProgressBar1.Text = "84%";
			this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.circularProgressBar1.Value = 68;
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlChildForm;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblZona;
		private System.Windows.Forms.Label lblNombre;
		private CircularProgressBar.CircularProgressBar circularProgressBar1;
	}
}