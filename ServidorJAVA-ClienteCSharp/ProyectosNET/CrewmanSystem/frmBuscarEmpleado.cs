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
			dgv = dataGridView1;
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
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void completarTabla()
		{ 
			dataGridView1.AutoGenerateColumns = false;
			EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado,txtNombre.Text,txtApPaterno.Text,txtApMaterno.Text);
			if (misEmpleados != null)
			{
				dataGridView1.DataSource = new BindingList<EmpleadoWS.empleado>(misEmpleados.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<EmpleadoWS.empleado>();
			}
		}

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			//castear objetos y mostrar valor determinado
			EmpleadoWS.empleado empleado = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as EmpleadoWS.empleado;

			dataGridView1.Rows[e.RowIndex].Cells["ZONA"].Value = empleado.zona.nombre;
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			ZonaWS.zona zonaSeleccionada = new ZonaWS.zona();
			zonaSeleccionada = (ZonaWS.zona)cboZona.SelectedItem;

			if (zonaSeleccionada.idZona == 0)
			{
				EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text);
				dataGridView1.DataSource = misEmpleados;
			}
            else
            {
				EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentasYZona(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text,zonaSeleccionada.idZona);
				dataGridView1.DataSource = misEmpleados;
			}
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
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
