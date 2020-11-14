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
	public partial class frmGestionarFamilias : Form
	{
		public static FamiliaWS.FamiliaWSClient daoFamilia;
		public static FamiliaWS.familia familiaSeleccionada;
		public static DataGridView dgv;

		public frmGestionarFamilias()
		{
			daoFamilia = new FamiliaWS.FamiliaWSClient();
			InitializeComponent();
			dgv = dgvFamilias;
			dgvFamilias.AutoGenerateColumns = false;
			FamiliaWS.familia[] misFamilias = daoFamilia.listarFamilias();
			if (misFamilias != null)
			{
				dgvFamilias.DataSource = new BindingList<FamiliaWS.familia>(misFamilias.ToArray());
			}
			else
			{
				dgvFamilias.DataSource = new BindingList<FamiliaWS.familia>();
			}
			#region colores de seleccion
			dgvFamilias.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvFamilias.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvFamilias.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvFamilias.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvFamilias.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvFamilias.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dgvFamilias_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			//Preguntar al profe
			if (e.StateChanged != DataGridViewElementStates.Selected)
			{
				frmVentanaPrincipal.act.Enabled = false;
				frmVentanaPrincipal.elim.Enabled = false;
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
			familiaSeleccionada = (FamiliaWS.familia)dgv.CurrentRow.DataBoundItem;
			daoFamilia.eliminarFamilia(familiaSeleccionada.idFamilia);
		}
    }
}
