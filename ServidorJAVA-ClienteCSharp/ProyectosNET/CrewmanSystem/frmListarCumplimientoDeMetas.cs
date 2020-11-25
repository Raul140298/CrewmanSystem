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
	public partial class frmListarCumplimientoDeMetas : Form
	{
		private EmpleadoWS.EmpleadoWSClient daoEmpleado;

		public frmListarCumplimientoDeMetas()
		{
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			InitializeComponent();
			//Solo por un momento por favor raul no me pegues
			//this.circularProgressBar1.ProgressColor = ThemeColor.getColor(Program.indexColor);
			panel1.Visible = false;
			EmpleadoWS.empleado[] empleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado,"","","");
			BindingList<EmpleadoWS.empleado> misEmpleados;
			if (empleados == null || empleados.Length < 1) misEmpleados = new BindingList<EmpleadoWS.empleado>();
			else misEmpleados = new BindingList<EmpleadoWS.empleado>(empleados);
			dgvEmpleados.AutoGenerateColumns = false;
			dgvEmpleados.DataSource = misEmpleados;
		}

		private void circularProgressBar1_Click(object sender, EventArgs e)
		{

		}
    }
}
