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
	public partial class frmGestionarCarteras : Form
	{
		public static EmpleadoWS.EmpleadoWSClient daoEmpleado;
		public static EmpleadoWS.empleado empleadoSeleccionado;
		public static DataGridView dgv;

		public frmGestionarCarteras()
		{
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			InitializeComponent();
			dgv = dgvCarteras;
			dgvCarteras.AutoGenerateColumns = false;
			EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, "", "", "");

			if (misEmpleados != null)
				dgvCarteras.DataSource = new BindingList<EmpleadoWS.empleado>(misEmpleados.ToArray());
			else
				dgvCarteras.DataSource = new BindingList<EmpleadoWS.empleado>();
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

		private void dgvCarteras_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dgvCarteras_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
			//Preguntar al profe
			if (e.StateChanged != DataGridViewElementStates.Selected)
			{
				//frmVentanaPrincipal.act.Enabled = false;
				//frmVentanaPrincipal.elim.Enabled = false;
				return;
			}
			else
			{
				frmVentanaPrincipal.act.Enabled = true;
				frmVentanaPrincipal.elim.Enabled = true;
			}
		}
    }
}
