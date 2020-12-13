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
	public partial class frmGestionarSubfamilias : Form
	{
		public static SubFamiliaWS.SubFamiliaWSClient daoSubFamilia;
		public static SubFamiliaWS.subFamilia subfamiliaSeleccionada;
		public static DataGridView dgv;
		public SubFamiliaWS.subFamilia[] misSubFamilias;
		public SubFamiliaWS.subFamilia[] misSubFamiliasThread;
		public frmGestionarSubfamilias()
		{
			daoSubFamilia = new SubFamiliaWS.SubFamiliaWSClient();
			InitializeComponent();
			dgv = dgvSubfamilias;
			dgvSubfamilias.AutoGenerateColumns = false;
			recargarDGV();

			#region colores de seleccion
			dgvSubfamilias.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvSubfamilias.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvSubfamilias.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvSubfamilias.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvSubfamilias.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvSubfamilias.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dgvSubfamilias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			SubFamiliaWS.subFamilia subfamilia = dgvSubfamilias.Rows[e.RowIndex].DataBoundItem
			as SubFamiliaWS.subFamilia;

			dgvSubfamilias.Rows[e.RowIndex].Cells["FAMILIA"].Value = subfamilia.familia.descripcion;
		}
		private void dgvSubfamilias_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvSubfamilias.SelectedCells.Count != 1 && dgvSubfamilias.SelectedCells.Count != 0)
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
			subfamiliaSeleccionada = (SubFamiliaWS.subFamilia)dgv.CurrentRow.DataBoundItem;
			daoSubFamilia.eliminarSubFamilia(subfamiliaSeleccionada.idSubFamilia);
		}

		public void recargarDGV()
		{
			misSubFamilias = daoSubFamilia.listarSubFamilias("");
			if (misSubFamilias != null)
			{
				dgvSubfamilias.DataSource = new BindingList<SubFamiliaWS.subFamilia>(misSubFamilias.ToArray());
				lblNotFound.Visible = false;
			}
			else
			{
				dgvSubfamilias.DataSource = new BindingList<SubFamiliaWS.subFamilia>();
				lblNotFound.Visible = true;
			}
		}
	}
}
