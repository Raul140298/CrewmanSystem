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
		private BindingList<int> numVisitados;
		private BindingList<int> numAsignados;

		public frmListarCumplimientoDeMetas()
		{
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			InitializeComponent();
			//Solo por un momento por favor raul no me pegues
			EmpleadoWS.empleado[] empleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado,"","","");
			BindingList<EmpleadoWS.empleado> misEmpleados;
			if (empleados == null || empleados.Length < 1) misEmpleados = new BindingList<EmpleadoWS.empleado>();
			else misEmpleados = new BindingList<EmpleadoWS.empleado>(empleados);

			int[] visitados = daoEmpleado.obtenerNumVisitas(Program.empleado.idEmpleado);
			if (visitados == null || visitados.Length < 1) numVisitados = new BindingList<int>();
			else numVisitados = new BindingList<int>(visitados.ToArray());
			
			int[] asignados = daoEmpleado.obtenerNumClientes(Program.empleado.idEmpleado);
			if (asignados == null || asignados.Length < 1) numAsignados = new BindingList<int>();
			else numAsignados = new BindingList<int>(asignados.ToArray());

			dgvEmpleados.AutoGenerateColumns = false;
			dgvEmpleados.DataSource = misEmpleados;

			#region colores de seleccion
			dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvEmpleados.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvEmpleados.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void circularProgressBar1_Click(object sender, EventArgs e)
		{

		}

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			EmpleadoWS.empleado empleado = dgvEmpleados.Rows[e.RowIndex].DataBoundItem
				as EmpleadoWS.empleado; 
			try 
			{
				dgvEmpleados.Rows[e.RowIndex].Cells["ZONA"].Value = empleado.zona.nombre;
				dgvEmpleados.Rows[e.RowIndex].Cells["CLIENTES_VISITADOS"].Value = numVisitados.ElementAt(e.RowIndex);
				dgvEmpleados.Rows[e.RowIndex].Cells["CLIENTES_ASIGNADOS"].Value = numAsignados.ElementAt(e.RowIndex);
			}
            catch (Exception)
            {

            }
		}
	}
}
