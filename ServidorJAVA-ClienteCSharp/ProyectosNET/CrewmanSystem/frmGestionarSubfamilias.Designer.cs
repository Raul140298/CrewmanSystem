namespace CrewmanSystem
{
	partial class frmGestionarSubfamilias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGestion = new System.Windows.Forms.Panel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dgvSubfamilias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGestion.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubfamilias)).BeginInit();
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
            this.pnlGestion.TabIndex = 1;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dgvSubfamilias);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(0, 0);
            this.pnlGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(681, 506);
            this.pnlGridView.TabIndex = 11;
            // 
            // dgvSubfamilias
            // 
            this.dgvSubfamilias.AllowUserToAddRows = false;
            this.dgvSubfamilias.AllowUserToDeleteRows = false;
            this.dgvSubfamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSubfamilias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubfamilias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSubfamilias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubfamilias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubfamilias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubfamilias.ColumnHeadersHeight = 30;
            this.dgvSubfamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubfamilias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.FAMILIA});
            this.dgvSubfamilias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubfamilias.EnableHeadersVisualStyles = false;
            this.dgvSubfamilias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvSubfamilias.Location = new System.Drawing.Point(0, 0);
            this.dgvSubfamilias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSubfamilias.MultiSelect = false;
            this.dgvSubfamilias.Name = "dgvSubfamilias";
            this.dgvSubfamilias.ReadOnly = true;
            this.dgvSubfamilias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubfamilias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubfamilias.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSubfamilias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubfamilias.RowTemplate.Height = 24;
            this.dgvSubfamilias.Size = new System.Drawing.Size(681, 506);
            this.dgvSubfamilias.TabIndex = 1;
            this.dgvSubfamilias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubfamilias_CellContentClick);
            this.dgvSubfamilias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSubfamilias_CellFormatting);
            this.dgvSubfamilias.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvSubfamilias_RowStateChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idSubFamilia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "descripcionSubFamilia";
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 96;
            // 
            // FAMILIA
            // 
            this.FAMILIA.HeaderText = "Familia";
            this.FAMILIA.MinimumWidth = 6;
            this.FAMILIA.Name = "FAMILIA";
            this.FAMILIA.ReadOnly = true;
            this.FAMILIA.Width = 91;
            // 
            // frmGestionarSubfamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 506);
            this.Controls.Add(this.pnlGestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionarSubfamilias";
            this.Text = "Gestión de Subfamilias";
            this.pnlGestion.ResumeLayout(false);
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubfamilias)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlGestion;
		private System.Windows.Forms.Panel pnlGridView;
		private System.Windows.Forms.DataGridView dgvSubfamilias;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
	}
}