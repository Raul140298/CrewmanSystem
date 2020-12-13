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
	public partial class frmBuscarEmpleado : Form
	{
		private EmpleadoWS.EmpleadoWSClient daoEmpleado;
		ZonaWS.ZonaWSClient daoZona;
		public static EmpleadoWS.empleado empleadoSeleccionado;
		public static DataGridView dgv;

		public frmBuscarEmpleado()
		{
			InitializeComponent();
			dgv = dgvEmpleados;
			BindingList<ZonaWS.zona> misZonas;
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			
			misZonas = new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToList());
			
			ZonaWS.zona zonaDefault = new ZonaWS.zona();
			zonaDefault.idZona = 0;
			zonaDefault.nombre = "Cualquiera";
			
			if (misZonas == null)
			{
				misZonas = new BindingList<ZonaWS.zona>();
				misZonas.Add(zonaDefault);
				cboZona.DataSource = new BindingList<ZonaWS.zona>(misZonas);
			}
			else
			{
				misZonas.Insert(0, zonaDefault);
				cboZona.DataSource = misZonas;
				
			}
			cboZona.ValueMember = "idZona";
			cboZona.DisplayMember = "nombre";
			completarTabla();

			#region colores de seleccion
			dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvEmpleados.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvEmpleados.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvEmpleados.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
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

		public void completarTabla()
		{ 
			dgvEmpleados.AutoGenerateColumns = false;
			EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado,txtNombre.Text,txtApPaterno.Text,txtApMaterno.Text);
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
        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			EmpleadoWS.empleado empleado = dgvEmpleados.Rows[e.RowIndex].DataBoundItem
			as EmpleadoWS.empleado;

			dgvEmpleados.Rows[e.RowIndex].Cells["ZONA"].Value = empleado.zona.nombre;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
        {
			ZonaWS.zona zonaSeleccionada = new ZonaWS.zona();
			zonaSeleccionada = (ZonaWS.zona)cboZona.SelectedItem;

			if (zonaSeleccionada.idZona == 0)
			{
				EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text);
				dgvEmpleados.DataSource = misEmpleados;
			}
            else
            {
				EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentasYZona(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text,zonaSeleccionada.idZona);
				dgvEmpleados.DataSource = misEmpleados;
			}
		}
    }
}
