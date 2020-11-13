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
		private FacturaWS.FacturaWSClient daoFactura;
		public frmGestionarFacturas()
		{
			daoFactura = new FacturaWS.FacturaWSClient();
			InitializeComponent();
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
	}
}
