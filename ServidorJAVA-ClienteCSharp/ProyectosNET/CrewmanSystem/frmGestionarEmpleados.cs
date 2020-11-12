using CrewmanSystem.VisitaWS;
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
		ZonaWS.ZonaWSClient daoZona;
		public frmGestionarEmpleados()
		{
			daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			EmpleadoWS.empleado[] misEmpleados = daoEmpleado.listarPorJefeVentas(Program.empleado.idEmpleado, "", "", "");

			/*
            foreach (EmpleadoWS.empleado empleado in misEmpleados)
            {
				ZonaWS.empleado emp2 = new ZonaWS.empleado();
				emp2.zona = new ZonaWS.zona();
				emp2.idEmpleado = empleado.idEmpleado;

				int resultado = daoZona.mostrarZona(emp2);
				MessageBox.Show(resultado.ToString());
				if (resultado != 0) empleado.zona.nombre = emp2.zona.nombre;
			}
			*/

			if (misEmpleados != null)
            {
				dataGridView1.DataSource = new BindingList<EmpleadoWS.empleado>(misEmpleados.ToArray());
            }
            else
            {
				dataGridView1.DataSource = new BindingList<EmpleadoWS.empleado>();
			}
			#region colores de seleccion
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
    }
}
