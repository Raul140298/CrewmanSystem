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
    public partial class frmBuscarCartera : Form
    {
        private EmpleadoWS.EmpleadoWSClient daoEmpleado;
        ZonaWS.ZonaWSClient daoZona;
        private BindingList<ZonaWS.zona> misZonas;
        ZonaWS.zona zonaAux = new ZonaWS.zona();

        public frmBuscarCartera()
        {
			InitializeComponent();

			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			ZonaWS.zona[] listaZonas = daoZona.listarZonas();
			ZonaWS.zona zonaDefault = new ZonaWS.zona();
			zonaDefault.idZona = 0;
			zonaDefault.nombre = "Cualquiera";

			if (listaZonas == null)
			{
				ZonaWS.zona[] listaZonas2 = new ZonaWS.zona[1];
				listaZonas2[0] = zonaDefault;
				cboZona.DataSource = new BindingList<ZonaWS.zona>(listaZonas2);
			}
			else
			{

				ZonaWS.zona[] listaZonas2 = new ZonaWS.zona[listaZonas.Length + 1];
				listaZonas2[0] = zonaDefault;
				for (int i = 0; i < listaZonas.Length; i++)
				{
					listaZonas2[i + 1] = listaZonas[i];
				}
				misZonas = new BindingList<ZonaWS.zona>(listaZonas2);

				cboZona.DataSource = misZonas;

			}
			cboZona.ValueMember = "idZona";
			cboZona.DisplayMember = "nombre";
			completarTabla();

			#region colores de seleccion
			dgvCarteras.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvCarteras.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvCarteras.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvCarteras.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvCarteras.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvCarteras.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void completarTabla()
		{
			dgvCarteras.AutoGenerateColumns = false;
			EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text);
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

		private void dgvCarteras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			EmpleadoWS.empleado empleado = dgvCarteras.Rows[e.RowIndex].DataBoundItem
			as EmpleadoWS.empleado;

			dgvCarteras.Rows[e.RowIndex].Cells["ZONA"].Value = empleado.zona.nombre;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			ZonaWS.zona zonaSeleccionada = new ZonaWS.zona();
			zonaSeleccionada = (ZonaWS.zona)cboZona.SelectedItem;

			if (zonaSeleccionada.idZona == 0)
			{
				EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text);
				dgvCarteras.DataSource = misEmpleados;
			}
			else
			{
				EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentasYZona(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, zonaSeleccionada.idZona);
				dgvCarteras.DataSource = misEmpleados;
			}
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
	}
}
