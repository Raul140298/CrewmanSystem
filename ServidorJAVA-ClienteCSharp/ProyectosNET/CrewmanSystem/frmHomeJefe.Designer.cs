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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.pnlChildForm = new System.Windows.Forms.Panel();
			this.btnRecarga = new FontAwesome.Sharp.IconButton();
			this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblZona = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlChildForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlChildForm
			// 
			this.pnlChildForm.Controls.Add(this.btnRecarga);
			this.pnlChildForm.Controls.Add(this.chartVentas);
			this.pnlChildForm.Controls.Add(this.lblNombre);
			this.pnlChildForm.Controls.Add(this.lblZona);
			this.pnlChildForm.Controls.Add(this.pictureBox1);
			this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlChildForm.Location = new System.Drawing.Point(0, 0);
			this.pnlChildForm.Name = "pnlChildForm";
			this.pnlChildForm.Size = new System.Drawing.Size(997, 850);
			this.pnlChildForm.TabIndex = 4;
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
			this.btnRecarga.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
			this.btnRecarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnRecarga.IconSize = 48;
			this.btnRecarga.Location = new System.Drawing.Point(873, 129);
			this.btnRecarga.Name = "btnRecarga";
			this.btnRecarga.Rotation = 0D;
			this.btnRecarga.Size = new System.Drawing.Size(42, 46);
			this.btnRecarga.TabIndex = 59;
			this.btnRecarga.UseVisualStyleBackColor = false;
			this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
			this.btnRecarga.MouseLeave += new System.EventHandler(this.btnRecarga_MouseLeave);
			this.btnRecarga.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRecarga_MouseMove);
			// 
			// chartVentas
			// 
			this.chartVentas.BackColor = System.Drawing.SystemColors.Control;
			this.chartVentas.BackSecondaryColor = System.Drawing.SystemColors.Control;
			this.chartVentas.BorderlineColor = System.Drawing.SystemColors.Control;
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
			chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
			chartArea1.BackColor = System.Drawing.SystemColors.Control;
			chartArea1.Name = "ChartArea1";
			this.chartVentas.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.SystemColors.Control;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chartVentas.Legends.Add(legend1);
			this.chartVentas.Location = new System.Drawing.Point(39, 108);
			this.chartVentas.Name = "chartVentas";
			this.chartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series1.ChartArea = "ChartArea1";
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend1";
			series1.Name = "Suma Ventas";
			this.chartVentas.Series.Add(series1);
			this.chartVentas.Size = new System.Drawing.Size(876, 541);
			this.chartVentas.TabIndex = 58;
			this.chartVentas.Text = "chart1";
			title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			title1.Name = "Title1";
			title1.Text = "Suma de ventas en el mes";
			this.chartVentas.Titles.Add(title1);
			// 
			// lblNombre
			// 
			this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(0, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.lblNombre.Size = new System.Drawing.Size(997, 105);
			this.lblNombre.TabIndex = 56;
			this.lblNombre.Text = "NOMBRE";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblZona
			// 
			this.lblZona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblZona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
			this.lblZona.Location = new System.Drawing.Point(3, 795);
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
			this.pictureBox1.Location = new System.Drawing.Point(856, 710);
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
			this.ClientSize = new System.Drawing.Size(997, 850);
			this.Controls.Add(this.pnlChildForm);
			this.Name = "frmHomeJefe";
			this.Text = "frmHome";
			this.pnlChildForm.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlChildForm;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblZona;
		private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private FontAwesome.Sharp.IconButton btnRecarga;
    }
}