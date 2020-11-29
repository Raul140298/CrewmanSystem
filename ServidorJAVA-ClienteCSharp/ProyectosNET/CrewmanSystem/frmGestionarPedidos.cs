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
		public static PedidoWS.PedidoWSClient daoPedido;
		public static PedidoWS.pedido pedidoSeleccionado;
		public static DataGridView dgv;
		private ClienteWS.ClienteWSClient daoCliente;
		
		public frmGestionarPedidos()
		{
			daoPedido = new PedidoWS.PedidoWSClient();
			daoCliente = new ClienteWS.ClienteWSClient();

			InitializeComponent();
			dgv = dgvPedidos;
			dgvPedidos.AutoGenerateColumns = false;
			int idBusqueda = 0;
			if (Program.empleado.cargo.nombre == "VENDEDOR") idBusqueda = Program.empleado.idEmpleado;
			PedidoWS.pedido[] misPedidos = daoPedido.listarPedidos(idBusqueda,"","", DateTime.MinValue, DateTime.MaxValue, "AMBOS","AMBOS");

			if (misPedidos != null)
			{		
				//foreach (PedidoWS.pedido p in misPedidos)
				//{
				//	ClienteWS.cliente c = new ClienteWS.cliente();

				//	c = daoCliente.obtenerCliente(p.cliente.idCliente);

				//	p.cliente.razonSocial = c.razonSocial;
				//}
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

		private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dgvPedidos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
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
			pedidoSeleccionado = (PedidoWS.pedido)dgv.CurrentRow.DataBoundItem;
			daoPedido.eliminarPedido(pedidoSeleccionado.idPedido);
		}
	}
}
