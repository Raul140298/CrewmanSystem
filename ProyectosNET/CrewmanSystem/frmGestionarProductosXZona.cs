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
	public partial class frmGestionarProductosXZona : Form
	{
		ProductoXZonaWS.ProductoXZonaWSClient daoProductosXZona;
		public frmGestionarProductosXZona()
		{
			daoProductosXZona = new ProductoXZonaWS.ProductoXZonaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<ProductoXZonaWS.productoXZona>(daoProductosXZona.listarProductosXZonas("", "").ToArray());
		}
	}
}
