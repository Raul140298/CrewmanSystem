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
		FamiliaWS.familia[] misFamilias;

		public frmGestionarFamilias()
		{
			daoFamilia = new FamiliaWS.FamiliaWSClient();
			InitializeComponent();
			dgv = dataGridView1;
			dataGridView1.AutoGenerateColumns = false;
			misFamilias = daoFamilia.listarFamilias();
			if (misFamilias != null)
			{
				dataGridView1.DataSource = new BindingList<FamiliaWS.familia>(misFamilias.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<FamiliaWS.familia>();
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

		private void dgvFamilias_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
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
			familiaSeleccionada = (FamiliaWS.familia)dgv.CurrentRow.DataBoundItem;
			daoFamilia.eliminarFamilia(familiaSeleccionada.idFamilia);
		}

		private void dgvFamilias_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		public void recargarDGV()
		{
			misFamilias = daoFamilia.listarFamilias();
			if (misFamilias != null)
			{
				dataGridView1.DataSource = new BindingList<FamiliaWS.familia>(misFamilias.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<FamiliaWS.familia>();
			}
		}
	}
}
