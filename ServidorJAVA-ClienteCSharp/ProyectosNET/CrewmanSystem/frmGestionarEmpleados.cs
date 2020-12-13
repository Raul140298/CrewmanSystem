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
			dgv = dataGridView1;
			dataGridView1.AutoGenerateColumns = false;
			recargarDGV();
			#region colores de seleccion
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			EmpleadoWS.empleado empleado = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as EmpleadoWS.empleado;

			dataGridView1.Rows[e.RowIndex].Cells["ZONA"].Value = empleado.zona.nombre;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
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

		public static void eliminar()
		{
			empleadoSeleccionado = (EmpleadoWS.empleado)dgv.CurrentRow.DataBoundItem;
			daoEmpleado.eliminarEmpleado(empleadoSeleccionado.idEmpleado);
		}
		public void recargarDGV()
		{
			misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, "", "", "");

			if (misEmpleados != null)
				dataGridView1.DataSource = new BindingList<EmpleadoWS.empleado>(misEmpleados.ToArray());
			else
				dataGridView1.DataSource = new BindingList<EmpleadoWS.empleado>();
		}
		public void revisarDGV(object source, ElapsedEventArgs e)
		{

			if (dataGridView1.InvokeRequired)
			{
				dataGridView1.Invoke(new Action(() =>
				{
					if (dataGridView1.Rows.Count > 0)
					{
						int i = ((EmpleadoWS.empleado)dataGridView1.CurrentRow.DataBoundItem).idEmpleado;
						int j = dataGridView1.CurrentCell.ColumnIndex;

						recargarDGV();

						int k = 0;
						foreach (EmpleadoWS.empleado f in misEmpleados)
						{
							if (f.idEmpleado == i)
							{
								i = k;
								break;
							}
							k++;
						}

						if (k != misEmpleados.Length)
							dataGridView1.CurrentCell = dataGridView1[j, i];
					}
				}));
			}
		}
	}
}
