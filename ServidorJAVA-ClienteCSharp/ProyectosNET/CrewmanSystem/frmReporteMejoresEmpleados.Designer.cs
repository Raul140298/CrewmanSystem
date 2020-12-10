
namespace CrewmanSystem
{
	partial class frmReporteMejoresEmpleados
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
			this.btnGenerar = new System.Windows.Forms.Button();
			this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// btnGenerar
			// 
			this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnGenerar.FlatAppearance.BorderSize = 0;
			this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerar.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGenerar.Location = new System.Drawing.Point(70, 110);
			this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(418, 57);
			this.btnGenerar.TabIndex = 2;
			this.btnGenerar.Text = "Generar Reporte de Mejores Empleados";
			this.btnGenerar.UseVisualStyleBackColor = false;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// frmReporteMejoresEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 268);
			this.Controls.Add(this.btnGenerar);
			this.Name = "frmReporteMejoresEmpleados";
			this.Text = "frmReporteMejoresEmpleados";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.SaveFileDialog sfdReporte;
	}
}