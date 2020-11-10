namespace CrewmanSystem
{
	partial class frmConfirmarSalir
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
			this.btnSalir = new FontAwesome.Sharp.IconButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnCerrarSesion);
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(460, 170);
			this.panel1.TabIndex = 0;
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
			this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
			this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCerrarSesion.IconColor = System.Drawing.Color.Black;
			this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCerrarSesion.IconSize = 16;
			this.btnCerrarSesion.Location = new System.Drawing.Point(230, 130);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Rotation = 0D;
			this.btnCerrarSesion.Size = new System.Drawing.Size(158, 38);
			this.btnCerrarSesion.TabIndex = 4;
			this.btnCerrarSesion.Text = "CANCELAR";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Transparent;
			this.btnSalir.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnSalir.IconColor = System.Drawing.Color.Black;
			this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSalir.IconSize = 16;
			this.btnSalir.Location = new System.Drawing.Point(70, 130);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Rotation = 0D;
			this.btnSalir.Size = new System.Drawing.Size(160, 38);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "CONFIRMAR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(70, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(318, 130);
			this.panel4.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(23, 65);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.label1.Size = new System.Drawing.Size(269, 20);
			this.label1.TabIndex = 37;
			this.label1.Text = "¿Está seguro que desea eliminar?";
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(388, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(70, 168);
			this.panel3.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(70, 168);
			this.panel2.TabIndex = 0;
			// 
			// frmConfirmarSalir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(460, 170);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmConfirmarSalir";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmConfirmarSalir";
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private FontAwesome.Sharp.IconButton btnSalir;
		private FontAwesome.Sharp.IconButton btnCerrarSesion;
		private System.Windows.Forms.Label label1;
	}
}