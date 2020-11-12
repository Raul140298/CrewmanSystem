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
		ClienteWS.ClienteWSClient daoCliente;

		public frmGestionarPedidos()
		{
			daoPedido = new PedidoWS.PedidoWSClient();
			daoCliente = new ClienteWS.ClienteWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			PedidoWS.pedido[] misPedidos = daoPedido.listarPedidos();
			//foreach(PedidoWS.pedido pedido in misPedidos)
   //         {
			//	ClienteWS.cliente cliente = new ClienteWS.cliente();
			//	cliente.idCliente = pedido.cliente.idCliente;
			//	int resultado = daoCliente.obtenerCliente(cliente);
			//	if (resultado != 0) pedido.cliente.razonSocial = cliente.razonSocial;
   //         }

			if (misPedidos != null)
			{
				dataGridView1.DataSource = new BindingList<PedidoWS.pedido>(misPedidos.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<PedidoWS.pedido>();

			}

			#region colores de seleccion
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
	}
}
