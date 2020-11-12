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
			//ClienteWS.cliente[] misClientes = daoCliente.listarClientes("", "");

			if (misPedidos != null)
			{		
				foreach (PedidoWS.pedido p in misPedidos)
				{
					ClienteWS.cliente c = new ClienteWS.cliente();

					c = daoCliente.obtenerCliente(p.cliente.idCliente);

					p.cliente.razonSocial = c.razonSocial;
				}
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

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			PedidoWS.pedido pedido = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as PedidoWS.pedido;

			dataGridView1.Rows[e.RowIndex].Cells["CLIENTE"].Value = pedido.cliente.razonSocial;
		}
	}
}
