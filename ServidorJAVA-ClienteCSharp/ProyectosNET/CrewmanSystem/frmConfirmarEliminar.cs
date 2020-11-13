using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public partial class frmConfirmarEliminar : Form
	{
		public frmConfirmarEliminar()
		{
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
			this.DialogResult = DialogResult.OK;
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
		}
	}
}
