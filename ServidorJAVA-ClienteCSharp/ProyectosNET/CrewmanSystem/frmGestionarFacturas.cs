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
	public partial class frmGestionarFacturas : Form
	{
		public static FacturaWS.FacturaWSClient daoFactura;
		public static FacturaWS.factura facturaSeleccionada;
		public static DataGridView dgv;

		public frmGestionarFacturas()
		{
			daoFactura = new FacturaWS.FacturaWSClient();
			InitializeComponent();
			dgv = dgvFacturas;
			dgvFacturas.AutoGenerateColumns = false;
			FacturaWS.factura[] misFacturas = daoFactura.listarFacturas(0);
			if (misFacturas != null)
			{
				dgvFacturas.DataSource = new BindingList<FacturaWS.factura>(misFacturas.ToArray());
			}
			else
			{
				dgvFacturas.DataSource = new BindingList<FacturaWS.factura>();

			}
			#region colores de seleccion
			dgvFacturas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvFacturas.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvFacturas.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvFacturas.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvFacturas.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvFacturas.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dgvFacturas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
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
			facturaSeleccionada = (FacturaWS.factura)dgv.CurrentRow.DataBoundItem;
			daoFactura.eliminarFactura(facturaSeleccionada);
		}
	}
}
