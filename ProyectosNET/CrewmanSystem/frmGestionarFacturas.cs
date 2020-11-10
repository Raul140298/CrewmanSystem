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
		FacturaWS.FacturaWSClient daoFactura;
		public frmGestionarFacturas()
		{
			daoFactura = new FacturaWS.FacturaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<FacturaWS.factura>(daoFactura.listarFacturas(0).ToArray());
		}
	}
}
