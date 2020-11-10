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
	public partial class frmGestionarEmpleados : Form
	{
		EmpleadoWS.EmpleadoWSClient daoEmpleado;
		public frmGestionarEmpleados()
		{
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<EmpleadoWS.empleado>(daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado,"","","").ToArray());
		}
	}
}
