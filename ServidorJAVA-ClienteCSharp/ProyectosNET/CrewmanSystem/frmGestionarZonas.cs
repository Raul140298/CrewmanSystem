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
			zonaSeleccionada = (ZonaWS.zona)dgv.CurrentRow.DataBoundItem;
			daoZona.eliminarZona(zonaSeleccionada.idZona);
		}
		public void recargarDGV()
		{
			misZonas = daoZona.listarZonas();
			if (misZonas != null)
			{
				dataGridView1.DataSource = new BindingList<ZonaWS.zona>(misZonas.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<ZonaWS.zona>();

			}
		}
		
		public void revisarDGV(object source, ElapsedEventArgs e)
		{

			if (dataGridView1.InvokeRequired)
			{
				dataGridView1.Invoke(new Action(() =>
				{
					int i = ((ZonaWS.zona)dataGridView1.CurrentRow.DataBoundItem).idZona;
					int j = dataGridView1.CurrentCell.ColumnIndex;

					recargarDGV();

					int k = 0;
					foreach (ZonaWS.zona z in misZonas)
					{
						if (z.idZona == i)
						{
							i = k;
							break;
						}
						k++;
					}
					
					if (k != misZonas.Length)
						dataGridView1.CurrentCell = dataGridView1[j, i];

				}));
            }
        }


	}
}
