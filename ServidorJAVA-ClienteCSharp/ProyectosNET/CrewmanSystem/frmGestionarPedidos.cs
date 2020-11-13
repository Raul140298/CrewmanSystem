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
		private PedidoWS.PedidoWSClient daoPedido;
		private ClienteWS.ClienteWSClient daoCliente;
		
		public frmGestionarPedidos()
		{
			daoPedido = new PedidoWS.PedidoWSClient();
			daoCliente = new ClienteWS.ClienteWSClient();

			InitializeComponent();

			dgvPedidos.AutoGenerateColumns = false;
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
				dgvPedidos.DataSource = new BindingList<PedidoWS.pedido>(misPedidos.ToArray());
			}
			else
			{
				dgvPedidos.DataSource = new BindingList<PedidoWS.pedido>();

			}

			#region colores de seleccion
			dgvPedidos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPedidos.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvPedidos.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPedidos.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvPedidos.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPedidos.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			PedidoWS.pedido pedido = dgvPedidos.Rows[e.RowIndex].DataBoundItem
			as PedidoWS.pedido;

			dgvPedidos.Rows[e.RowIndex].Cells["CLIENTE"].Value = pedido.cliente.razonSocial;
		}
	}
}
