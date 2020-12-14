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
			dgv = dgvPromociones;
			dgvPromociones.AutoGenerateColumns = false;
			recargarDGV();

			#region colores de seleccion
			dgvPromociones.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPromociones.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvPromociones.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPromociones.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvPromociones.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPromociones.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
        private void dgvPromociones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			PromocionWS.promocion promocion = dgvPromociones.Rows[e.RowIndex].DataBoundItem
			as PromocionWS.promocion;

			dgvPromociones.Rows[e.RowIndex].Cells["ZONA"].Value = promocion.zona.nombre;
		}
		private void dgvPromociones_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvPromociones.SelectedCells.Count != 1 && dgvPromociones.SelectedCells.Count != 0)
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
			promocionSeleccionada = (PromocionWS.promocion)dgv.CurrentRow.DataBoundItem;
			daoPromocion.eliminarPromocion(promocionSeleccionada.idPromocion);
		}
        private void dgvPromociones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			promocionSeleccionada = (PromocionWS.promocion)dgv.CurrentRow.DataBoundItem;
			frmMostrarPromocion formMostrarPromocion = new frmMostrarPromocion(promocionSeleccionada);
			if (formMostrarPromocion.ShowDialog() == DialogResult.OK)
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
				dgvPromociones.DataSource = new BindingList<PromocionWS.promocion>(misPromocions.ToArray());
				lblNotFound.Visible = false;
			}
			else
			{
				dgvPromociones.DataSource = new BindingList<PromocionWS.promocion>();
				lblNotFound.Visible = true;
			}
		}
	}
}
