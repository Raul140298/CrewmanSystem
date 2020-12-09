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
		private EmpleadoWS.EmpleadoWSClient daoEmpleado;
		private VisitaWS.VisitaWSClient daoVisita;
		
		public frmHomeVendedor()
		{
			InitializeComponent();
			btnRecarga.IconColor = Program.color1;
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			daoVisita = new VisitaWS.VisitaWSClient();
			string saludo = "";
			if (Program.empleado.genero == 'M') saludo = "Bienvenido, ";
			else saludo = "Bienvenida, ";
			lblNombre.Text = saludo + Program.empleado.nombre + " " +
				Program.empleado.apellidoPaterno + " " +
				Program.empleado.apellidoMaterno;

			lblZona.Text = Program.empleado.zona.nombre;

			cargarValores();
		}

		private void cargarValores()
        {
			this.cpbSumaVentas.ProgressColor = Program.colorR;
			this.cpbSumaVentas.Minimum = 0;
			this.cpbSumaVentas.Maximum = Convert.ToInt32(Program.empleado.objetivoVentas);
			this.cpbSumaVentas.Value = Convert.ToInt32(Program.empleado.sumVentas);
			double porcentajeVentas = (double)this.cpbSumaVentas.Value * 100 / this.cpbSumaVentas.Maximum;
			this.cpbSumaVentas.Text = Convert.ToDouble(porcentajeVentas).ToString("N2") + "%";

			VisitaWS.visita[] visitas = daoVisita.listarVisitas(Program.empleado.cartera.idCartera);
			int numClientes = 0;
			int numVisitas = 0;
			if (visitas == null)
			{
				numVisitas = 1;
				numClientes = 0;
			}
			else
			{
				numVisitas = visitas.Length;
				foreach (VisitaWS.visita v in visitas)
				{
					if (v.estado) numClientes++;
				}
			}
			this.cpbVisitados.ProgressColor = Program.colorR;
			this.cpbVisitados.Minimum = 0;
			this.cpbVisitados.Maximum = numVisitas;
			this.cpbVisitados.Value = numClientes;
			double porcentajeVisitas = (double)this.cpbVisitados.Value * 100 / this.cpbVisitados.Maximum;
			this.cpbVisitados.Text = porcentajeVisitas + "%";
		}

		private void btnRecarga_Click(object sender, EventArgs e)
        {
			cargarValores();
		}

		private void btnRecarga_MouseMove(object sender, MouseEventArgs e)
		{
			btnRecarga.IconColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.5);
		}

		private void btnRecarga_MouseLeave(object sender, EventArgs e)
		{
			btnRecarga.IconColor = Program.color1;
		}
	}
}
