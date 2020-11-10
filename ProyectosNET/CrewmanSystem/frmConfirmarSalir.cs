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
	public partial class frmConfirmarSalir : Form
	{
		public frmConfirmarSalir()
		{
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
		}
	}
}
