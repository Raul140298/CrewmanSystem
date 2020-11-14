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
	public partial class frmBuscarPromocion : Form
	{
		private PromocionWS.PromocionWSClient daoPromocion;
		public frmBuscarPromocion()
		{
			daoPromocion = new PromocionWS.PromocionWSClient();
			InitializeComponent();
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
			PromocionWS.promocion[] misPromocions = daoPromocion.listarPromocions(txtNombre.Text, dtpFechaInicio.Value, dtpFechaFIn.Value);
			if (misPromocions != null)
			{
				dataGridView1.DataSource = new BindingList<PromocionWS.promocion>(misPromocions.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<PromocionWS.promocion>();
			}
		}

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			
			PromocionWS.promocion promocion = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as PromocionWS.promocion;

			dataGridView1.Rows[e.RowIndex].Cells["ZONA"].Value = promocion.zona.nombre;
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
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
	}
}
