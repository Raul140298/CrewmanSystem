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
	public partial class frmGestionarPedidos : Form
	{
		PedidoWS.PedidoWSClient daoPedido;
		
		public frmGestionarPedidos()
		{
			daoPedido = new PedidoWS.PedidoWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<PedidoWS.pedido>(daoPedido.listarPedidos().ToArray());
		}
	}
}
