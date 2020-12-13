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
	public partial class frmGestionarCarteras : Form
	{
		public static EmpleadoWS.EmpleadoWSClient daoEmpleado;
		public static EmpleadoWS.empleado empleadoSeleccionado;
		public static DataGridView dgv;
		private EmpleadoWS.empleado[] misEmpleados;
		public frmGestionarCarteras()
		{
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			InitializeComponent();
			dgv = dgvCarteras;
			recargarDGV();
			#region colores de seleccion
			dgvCarteras.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvCarteras.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvCarteras.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvCarteras.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvCarteras.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvCarteras.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dgvCarteras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			EmpleadoWS.empleado empleado = dgvCarteras.Rows[e.RowIndex].DataBoundItem
			as EmpleadoWS.empleado;

			dgvCarteras.Rows[e.RowIndex].Cells["ZONA"].Value = empleado.zona.nombre;
		}
		private void dgvCarteras_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvCarteras.SelectedCells.Count != 1 && dgvCarteras.SelectedCells.Count != 0)
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
        public void recargarDGV()
		{
			misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, "", "", "");
			dgvCarteras.AutoGenerateColumns = false;
			if (misEmpleados != null)
			{
				dgvCarteras.DataSource = new BindingList<EmpleadoWS.empleado>(misEmpleados.ToArray());
				lblNotFound.Visible = false;
			}
			else
			{
				dgvCarteras.DataSource = new BindingList<EmpleadoWS.empleado>();
				lblNotFound.Visible = true;
			}
		}
	}
}
