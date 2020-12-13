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
	public partial class frmGestionarMarcas : Form
	{
		public static MarcaWS.MarcaWSClient daoMarca;
		public static MarcaWS.marca marcaSeleccionada;
		public static DataGridView dgv;
		public MarcaWS.marca[] misMarcas;
		public MarcaWS.marca[] misMarcasPruebaThread;
		public frmGestionarMarcas()
		{
			daoMarca = new MarcaWS.MarcaWSClient();
			InitializeComponent();
			dgv = dgvMarcas;
			dgvMarcas.AutoGenerateColumns = false;
			recargarDGV();

			#region colores de seleccion
			dgvMarcas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvMarcas.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvMarcas.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvMarcas.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvMarcas.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvMarcas.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
		private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvMarcas.SelectedCells.Count != 1 && dgvMarcas.SelectedCells.Count != 0)
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
			marcaSeleccionada = (MarcaWS.marca)dgv.CurrentRow.DataBoundItem;
			daoMarca.eliminarMarca(marcaSeleccionada.idMarca);
		}

		public void recargarDGV()
		{
			misMarcas = daoMarca.listarMarcas();
			if (misMarcas != null)
			{
				dgvMarcas.DataSource = new BindingList<MarcaWS.marca>(misMarcas.ToArray());
			}
			else
			{
				dgvMarcas.DataSource = new BindingList<MarcaWS.marca>();

			}
		}
		
	}
}
