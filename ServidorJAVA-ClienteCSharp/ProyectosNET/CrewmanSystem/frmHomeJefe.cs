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
		private EmpleadoWS.EmpleadoWSClient daoEmpleado;
		public frmHomeJefe()
		{
			InitializeComponent();

			chartVentas.PaletteCustomColors = new System.Drawing.Color[] {Program.colorR};

			btnRecarga.IconColor = Program.color1;
			
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			string saludo = "";
			if (Program.empleado.genero == 'M') saludo = "Bienvenido, ";
			else saludo = "Bienvenida, ";
			lblNombre.Text = saludo + Program.empleado.nombre + " " +
				Program.empleado.apellidoPaterno + " " +
				Program.empleado.apellidoMaterno;

			lblZona.Text = Program.empleado.zona.nombre;
			actualizarMapa();
		}

		private void actualizarMapa()
        {
			chartVentas.Series.Clear();
			BindingList<EmpleadoWS.empleado> misEmpleados;
			EmpleadoWS.empleado[] empleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, "", "", "");
			if (empleados == null || empleados.Length < 1) misEmpleados = new BindingList<EmpleadoWS.empleado>();
			else misEmpleados = new BindingList<EmpleadoWS.empleado>(empleados.ToList());
			chartVentas.Series.Add("Suma Ventas");
			chartVentas.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
			chartVentas.ChartAreas[0].AxisX.Interval = 1;
			foreach (EmpleadoWS.empleado emp in empleados)
			{
				chartVentas.Series["Suma Ventas"].Points.AddXY(emp.apellidoPaterno + " " + emp.apellidoMaterno + ", " + emp.nombre, emp.sumVentas);
			}
		}

        private void btnRecarga_Click(object sender, EventArgs e)
		{
			actualizarMapa();
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
