namespace CrewmanSystem
{
    partial class frmConfirmarVisita
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancelar = new FontAwesome.Sharp.IconButton();
			this.btnConfirmar = new FontAwesome.Sharp.IconButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(69, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(322, 130);
			this.panel4.TabIndex = 13;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(391, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(69, 170);
			this.panel3.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(69, 170);
			this.panel2.TabIndex = 11;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnCancelar.IconColor = System.Drawing.Color.Black;
			this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancelar.IconSize = 16;
			this.btnCancelar.Location = new System.Drawing.Point(229, 130);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Rotation = 0D;
			this.btnCancelar.Size = new System.Drawing.Size(162, 40);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
			this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnConfirmar.FlatAppearance.BorderSize = 0;
			this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
			this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirmar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnConfirmar.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnConfirmar.IconColor = System.Drawing.Color.Black;
			this.btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnConfirmar.IconSize = 16;
			this.btnConfirmar.Location = new System.Drawing.Point(69, 130);
			this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Rotation = 0D;
			this.btnConfirmar.Size = new System.Drawing.Size(160, 40);
			this.btnConfirmar.TabIndex = 14;
			this.btnConfirmar.Text = "CONFIRMAR";
			this.btnConfirmar.UseVisualStyleBackColor = false;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(-1, 45);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.label1.Size = new System.Drawing.Size(325, 41);
			this.label1.TabIndex = 38;
			this.label1.Text = "¿Está seguro que desea registrar la visita?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmConfirmarVisita
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(460, 170);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmConfirmarVisita";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmConfirmarVisita";
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnConfirmar;
		private System.Windows.Forms.Label label1;
	}
}