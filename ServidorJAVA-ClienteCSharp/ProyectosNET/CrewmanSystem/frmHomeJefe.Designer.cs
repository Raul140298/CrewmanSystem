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
			this.pnlChildForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlChildForm
			// 
			this.pnlChildForm.Controls.Add(this.pictureBox1);
			this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlChildForm.Location = new System.Drawing.Point(0, 0);
			this.pnlChildForm.Name = "pnlChildForm";
			this.pnlChildForm.Size = new System.Drawing.Size(800, 450);
			this.pnlChildForm.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::CrewmanSystem.Properties.Resources.MARCADEAGUA;
			this.pictureBox1.Location = new System.Drawing.Point(659, 310);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 124);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			// 
			// frmHomeJefe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}