
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
			this.btnGenerar.Location = new System.Drawing.Point(247, 55);
			this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(308, 28);
			this.btnGenerar.TabIndex = 2;
			this.btnGenerar.Text = "Generar Reporte de Mejores Empleados";
			this.btnGenerar.UseVisualStyleBackColor = true;
			// 
			// frmReporteMejoresEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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