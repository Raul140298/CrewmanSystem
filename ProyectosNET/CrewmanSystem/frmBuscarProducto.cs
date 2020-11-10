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
	public partial class frmBuscarProducto : Form
	{
		ProductoWS.ProductoWSClient daoProducto;
		public frmBuscarProducto()
		{
			daoProducto = new ProductoWS.ProductoWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			//dataGridView1.DataSource = new BindingList<ProductoWS.producto>(daoProducto.listarProductos(txtNombre.Text, txtFamilia, txtSubfamilia, txtMarca).ToArray());
		}
	}
}
