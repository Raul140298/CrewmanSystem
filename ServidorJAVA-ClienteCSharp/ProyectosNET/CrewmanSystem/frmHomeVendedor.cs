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
	public partial class frmHomeVendedor : Form
	{
		public frmHomeVendedor()
		{
			InitializeComponent();
			string saludo = "";
			if (Program.empleado.genero == 'M') saludo = "Bienvenido, ";
			else saludo = "Bienvenida, ";
			lblNombre.Text = saludo + Program.empleado.nombre + " " +
				Program.empleado.apellidoPaterno + " " +
				Program.empleado.apellidoMaterno;

			lblZona.Text = Program.empleado.zona.nombre;

			this.circularProgressBar1.ProgressColor = Program.colorR;
			this.circularProgressBar1.Minimum = 0;
			this.circularProgressBar1.Maximum = Convert.ToInt32(Program.empleado.objetivoVentas);
			this.circularProgressBar1.Value   = Convert.ToInt32(Program.empleado.sumVentas);
			this.circularProgressBar1.Text = this.circularProgressBar1.Value.ToString() + "%";
		}
	}
}
