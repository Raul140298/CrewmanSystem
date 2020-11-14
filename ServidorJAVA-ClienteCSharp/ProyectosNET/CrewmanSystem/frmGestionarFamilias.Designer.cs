namespace CrewmanSystem
{
	partial class frmGestionarFamilias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGestion = new System.Windows.Forms.Panel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dgvFamilias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGestion.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGestion
            // 
            this.pnlGestion.Controls.Add(this.pnlGridView);
            this.pnlGestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGestion.Location = new System.Drawing.Point(0, 0);
            this.pnlGestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGestion.Name = "pnlGestion";
            this.pnlGestion.Size = new System.Drawing.Size(681, 506);
            this.pnlGestion.TabIndex = 0;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dgvFamilias);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(0, 0);
            this.pnlGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(681, 506);
            this.pnlGridView.TabIndex = 11;
            // 
            // dgvFamilias
            // 
            this.dgvFamilias.AllowUserToAddRows = false;
            this.dgvFamilias.AllowUserToDeleteRows = false;
            this.dgvFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFamilias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFamilias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvFamilias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFamilias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFamilias.ColumnHeadersHeight = 30;
            this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFamilias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE});
            this.dgvFamilias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFamilias.EnableHeadersVisualStyles = false;
            this.dgvFamilias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvFamilias.Location = new System.Drawing.Point(0, 0);
            this.dgvFamilias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFamilias.MultiSelect = false;
            this.dgvFamilias.Name = "dgvFamilias";
            this.dgvFamilias.ReadOnly = true;
            this.dgvFamilias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFamilias.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFamilias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFamilias.RowTemplate.Height = 24;
            this.dgvFamilias.Size = new System.Drawing.Size(681, 506);
            this.dgvFamilias.TabIndex = 1;
            this.dgvFamilias.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvFamilias_RowStateChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idFamilia";
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "descripcion";
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 96;
            // 
            // frmGestionarFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(681, 506);
            this.Controls.Add(this.pnlGestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionarFamilias";
            this.Text = "Gestión de Familias";
            this.pnlGestion.ResumeLayout(false);
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlGestion;
		private System.Windows.Forms.Panel pnlGridView;
		private System.Windows.Forms.DataGridView dgvFamilias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
    }
}