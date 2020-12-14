using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace CrewmanSystem
{
	public partial class frmGestionarZonas : Form
	{
		public static ZonaWS.ZonaWSClient daoZona;
		public static ZonaWS.zona zonaSeleccionada;
		public static DataGridView dgv;
		public ZonaWS.zona[] misZonas;
		public ZonaWS.zona[] misZonasPruebaThread;
		public frmGestionarZonas()
		{

			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			dgv = dgvZonas;
			dgvZonas.AutoGenerateColumns = false;
			recargarDGV();
			#region colores de seleccion
			dgvZonas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvZonas.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvZonas.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvZonas.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvZonas.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvZonas.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
		private void dgvZonas_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvZonas.SelectedCells.Count != 1 && dgvZonas.SelectedCells.Count != 0)
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
			zonaSeleccionada = (ZonaWS.zona)dgv.CurrentRow.DataBoundItem;
			daoZona.eliminarZona(zonaSeleccionada.idZona);
		}
		public void recargarDGV()
		{
			misZonas = daoZona.listarZonas();
			if (misZonas != null)
			{
				dgvZonas.DataSource = new BindingList<ZonaWS.zona>(misZonas.ToArray());
				lblNotFound.Visible = false;
			}
			else
			{
				dgvZonas.DataSource = new BindingList<ZonaWS.zona>();
				lblNotFound.Visible = true;
			}
		}
	}
}
