 using CrewmanSystem.VisitaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public partial class frmGestionarEmpleados : Form
	{
		public static EmpleadoWS.EmpleadoWSClient daoEmpleado;
		public static EmpleadoWS.empleado empleadoSeleccionado;
		public static DataGridView dgv;
		private EmpleadoWS.empleado[] misEmpleados;
		public frmGestionarEmpleados()
		{
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			InitializeComponent();
			dgv = dgvEmpleados;
			dgvEmpleados.AutoGenerateColumns = false;
			recargarDGV();
			#region colores de seleccion
			dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvEmpleados.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvEmpleados.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			EmpleadoWS.empleado empleado = dgvEmpleados.Rows[e.RowIndex].DataBoundItem
			as EmpleadoWS.empleado;

			dgvEmpleados.Rows[e.RowIndex].Cells["ZONA"].Value = empleado.zona.nombre;
		}
		private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvEmpleados.SelectedCells.Count != 1 && dgvEmpleados.SelectedCells.Count != 0)
			{
				frmVentanaPrincipal.act.Enabled = true;
				frmVentanaPrincipal.elim.Enabled = true;
				return;
			}
			else
			{
				frmVentanaPrincipal.act.Enabled = false;
				frmVentanaPrincipal.elim.Enabled = false;
			}
		}

        public static void eliminar()
		{
			empleadoSeleccionado = (EmpleadoWS.empleado)dgv.CurrentRow.DataBoundItem;
			daoEmpleado.eliminarEmpleado(empleadoSeleccionado.idEmpleado);
		}
		public void recargarDGV()
		{
			misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, "", "", "");

			if (misEmpleados != null)
			{
				dgvEmpleados.DataSource = new BindingList<EmpleadoWS.empleado>(misEmpleados.ToArray());
				lblNotFound.Visible = false;
			}
			else
			{
				dgvEmpleados.DataSource = new BindingList<EmpleadoWS.empleado>();
				lblNotFound.Visible = true;
			}
		}
		
	}
}
