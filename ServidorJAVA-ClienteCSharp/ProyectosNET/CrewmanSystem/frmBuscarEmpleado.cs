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
		private BindingList<ZonaWS.zona> misZonas;
		ZonaWS.zona zonaAux=new ZonaWS.zona();
		public frmBuscarEmpleado()
		{
			InitializeComponent();

			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			ZonaWS.zona[] listaZonas=daoZona.listarZonas();
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
		
		private void btnBuscarZona_Click(object sender, EventArgs e)
        {
			frmBuscarZona formBusquedaZona = new frmBuscarZona();
			if(formBusquedaZona.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			//castear objetos y mostrar valor determinado
			EmpleadoWS.empleado empleado = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as EmpleadoWS.empleado;

			dataGridView1.Rows[e.RowIndex].Cells["ZONA"].Value = empleado.zona.idZona;
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			ZonaWS.zona zonaSeleccionada = new ZonaWS.zona();
			zonaSeleccionada = (ZonaWS.zona)cboZona.SelectedItem;

			if (zonaSeleccionada.idZona == 0)
			{
				EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text);
				dataGridView1.DataSource = misEmpleados;
				dataGridView1.Refresh();
			}
            else
            {
				EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentasYZona(Program.empleado.idEmpleado, txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text,zonaSeleccionada.idZona);
				dataGridView1.DataSource = misEmpleados;
				dataGridView1.Refresh();
			}
		}
    }
}
