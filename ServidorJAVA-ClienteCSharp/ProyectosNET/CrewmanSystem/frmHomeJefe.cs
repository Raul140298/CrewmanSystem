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
	public partial class frmHomeJefe : Form
	{
		public frmHomeJefe()
		{
			InitializeComponent();
			string saludo = "";
			if (Program.empleado.genero == 'M') saludo = "Bienvenido, ";
			else saludo = "Bienvenida, ";
			lblNombre.Text = saludo + Program.empleado.nombre + " " +
				Program.empleado.apellidoPaterno + " " +
				Program.empleado.apellidoMaterno;

			lblZona.Text = Program.empleado.zona.nombre;
			lblDni.Text = Program.empleado.dni;
		}
	}
}
