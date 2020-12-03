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
		EmpleadoWS.EmpleadoWSClient daoEmpleado;
		public frmHomeVendedor()
		{
			InitializeComponent();
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			string saludo = "";
			if (Program.empleado.genero == 'M') saludo = "Bienvenido, ";
			else saludo = "Bienvenida, ";
			lblNombre.Text = saludo + Program.empleado.nombre + " " +
				Program.empleado.apellidoPaterno + " " +
				Program.empleado.apellidoMaterno;

			lblZona.Text = Program.empleado.zona.nombre;
			int[] numClientes = daoEmpleado.obtenerNumClientes(Program.empleado.idEmpleado);
			int[] numVisitados = daoEmpleado.obtenerNumVisitas(Program.empleado.idEmpleado);


			this.cpbSumaVentas.ProgressColor = Program.colorR;
			this.cpbSumaVentas.Minimum = 0;
			this.cpbSumaVentas.Maximum = Convert.ToInt32(Program.empleado.objetivoVentas);
			this.cpbSumaVentas.Value   = Convert.ToInt32(Program.empleado.sumVentas);
			double porcentajeVentas = (double)this.cpbSumaVentas.Value*100 / this.cpbSumaVentas.Maximum;
			this.cpbSumaVentas.Text = Convert.ToDouble(porcentajeVentas).ToString("N2") + "%";

			this.cpbVisitados.ProgressColor = Program.colorR;
			this.cpbVisitados.Minimum = 0;
			this.cpbVisitados.Maximum = 0;
			this.cpbVisitados.Value = 0;
			this.cpbVisitados.Text = 0 + "%";
		}
	}
}
