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
		public static PromocionWS.PromocionWSClient daoPromocion;
		public static PromocionWS.promocion promocionSeleccionada;
		public static DataGridView dgv;
		public frmBuscarPromocion()
		{
			daoPromocion = new PromocionWS.PromocionWSClient();
			InitializeComponent();
			dgv = dgvPromociones;
			dtpFechaInicio.Value = dtpFechaInicio.MinDate;
			dtpFechaFIn.Value = dtpFechaFIn.MaxDate;
			completarTabla();
			#region colores de seleccion
			dgvPromociones.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPromociones.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvPromociones.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPromociones.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvPromociones.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPromociones.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void completarTabla()
        {
			dgvPromociones.AutoGenerateColumns = false;
			PromocionWS.promocion[] misPromocions = daoPromocion.listarPromocions(txtNombre.Text, dtpFechaInicio.Value, dtpFechaFIn.Value);
			if (misPromocions != null)
			{
				dgvPromociones.DataSource = new BindingList<PromocionWS.promocion>(misPromocions.ToArray());
			}
			else
			{
				dgvPromociones.DataSource = new BindingList<PromocionWS.promocion>();
			}
		}

        private void dgvPromociones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PromocionWS.promocion promocion = dgvPromociones.Rows[e.RowIndex].DataBoundItem
                as PromocionWS.promocion;

            dgvPromociones.Rows[e.RowIndex].Cells["ZONA"].Value = promocion.zona.nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
        }

		private void dgvPromociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dgvPromociones_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
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
	}
}
