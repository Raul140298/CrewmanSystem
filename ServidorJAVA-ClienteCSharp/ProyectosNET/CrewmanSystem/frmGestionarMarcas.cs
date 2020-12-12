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
	public partial class frmGestionarMarcas : Form
	{
		public static MarcaWS.MarcaWSClient daoMarca;
		public static MarcaWS.marca marcaSeleccionada;
		public static DataGridView dgv;
		public MarcaWS.marca[] misMarcas;

		public frmGestionarMarcas()
		{
			daoMarca = new MarcaWS.MarcaWSClient();
			InitializeComponent();
			dgv = dataGridView1;
			dataGridView1.AutoGenerateColumns = false;
			recargarDGV();

			#region colores de seleccion
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
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
			marcaSeleccionada = (MarcaWS.marca)dgv.CurrentRow.DataBoundItem;
			daoMarca.eliminarMarca(marcaSeleccionada.idMarca);
		}

		public void recargarDGV()
		{
			misMarcas = daoMarca.listarMarcas();
			if (misMarcas != null)
			{
				dataGridView1.DataSource = new BindingList<MarcaWS.marca>(misMarcas.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<MarcaWS.marca>();

			}
		}
	}
}
