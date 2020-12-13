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
	public partial class frmGestionarPromociones : Form
	{
		public static PromocionWS.PromocionWSClient daoPromocion;
		public static PromocionWS.promocion promocionSeleccionada;
		public static DataGridView dgv;
		public PromocionWS.promocion[] misPromocions;

		public frmGestionarPromociones()
		{
			daoPromocion = new PromocionWS.PromocionWSClient();
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			PromocionWS.promocion promocion = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as PromocionWS.promocion;

			dataGridView1.Rows[e.RowIndex].Cells["ZONA"].Value = promocion.zona.nombre;
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
			promocionSeleccionada = (PromocionWS.promocion)dgv.CurrentRow.DataBoundItem;
			daoPromocion.eliminarPromocion(promocionSeleccionada.idPromocion);
		}

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			promocionSeleccionada = (PromocionWS.promocion)dgv.CurrentRow.DataBoundItem;
			frmMostrarPromocion formMostrarPromocion = new frmMostrarPromocion(promocionSeleccionada);
			if(formMostrarPromocion.ShowDialog() == DialogResult.OK)
            {
            }
        }

		public void recargarDGV()
		{
			if (Program.empleado.cargo.nombre == "VENDEDOR")
				misPromocions = daoPromocion.listarPromocionPorZona("", DateTime.MinValue, DateTime.MaxValue, Program.empleado.zona.idZona);
			else
				misPromocions = daoPromocion.listarPromocions("", DateTime.MinValue, DateTime.MaxValue);
			if (misPromocions != null)
			{
				dataGridView1.DataSource = new BindingList<PromocionWS.promocion>(misPromocions.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<PromocionWS.promocion>();
			}
		}
		public void revisarDGV(object source, ElapsedEventArgs e)
		{

			if (dataGridView1.InvokeRequired)
			{
				dataGridView1.Invoke(new Action(() =>
				{
					if (dataGridView1.Rows.Count > 0)
					{
						int i = ((PromocionWS.promocion)dataGridView1.CurrentRow.DataBoundItem).idPromocion;
						int j = dataGridView1.CurrentCell.ColumnIndex;

						recargarDGV();

						int k = 0;
						foreach (PromocionWS.promocion p in misPromocions)
						{
							if (p.idPromocion == i)
							{
								i = k;
								break;
							}
							k++;
						}

						if (k != misPromocions.Length)
							dataGridView1.CurrentCell = dgv[j, i];
					}
				}));
			}
		}
	}
}
