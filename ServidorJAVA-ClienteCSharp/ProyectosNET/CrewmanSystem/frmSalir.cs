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
	public partial class frmSalir : Form
	{
		public frmSalir()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Environment.Exit(Environment.ExitCode);//<- Detiene todos los threads y la aplicación.
			//Application.Exit();
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			frmVentanaPrincipal.banderaWhile = false;
			frmVentanaPrincipal.a.Join();
			Program.panel.Hide();
			this.Hide();
			frmLogeo logeo = new frmLogeo();
			logeo.Show();
			Program.panel.Closed += (s, args) => this.Close();
		}
	}
}
