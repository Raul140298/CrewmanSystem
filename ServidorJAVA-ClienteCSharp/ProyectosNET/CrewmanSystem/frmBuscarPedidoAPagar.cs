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
    public partial class frmBuscarPedidoAPagar : Form
    {
        public static PedidoWS.pedido[] misPedidos;
        public static PedidoWS.PedidoWSClient daoPedido = new PedidoWS.PedidoWSClient();
        public static PedidoWS.pedido pedidoSeleccionado;
        public static ClienteWS.cliente clienteSeleccionado;
        public static DataGridView dgv;
        private ClienteWS.ClienteWSClient daoCliente = new ClienteWS.ClienteWSClient();
        public frmBuscarPedidoAPagar()
        {
			InitializeComponent();
			dtpRangoIni.Value = dtpRangoIni.MinDate;
			dtpRangoFin.Value = dtpRangoFin.MaxDate;
			dgv = dgvPedidos;
			clienteSeleccionado = new ClienteWS.cliente();
			clienteSeleccionado.idCliente = 0;
			completarTabla();
			#region colores de seleccion
			dgvPedidos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPedidos.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvPedidos.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPedidos.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvPedidos.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvPedidos.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void completarTabla()
		{
			dgvPedidos.AutoGenerateColumns = false;
			misPedidos = daoPedido.listarPedidos(clienteSeleccionado.idCliente, dtpRangoIni.Value, dtpRangoFin.Value, "PEDIDO", "EN_PROCESO");
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
		}
		private void dgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			PedidoWS.pedido pedido = dgvPedidos.Rows[e.RowIndex].DataBoundItem
			as PedidoWS.pedido;

			dgvPedidos.Rows[e.RowIndex].Cells["CLIENTE"].Value = pedido.cliente.razonSocial;
		}
		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			frmBuscarCliente formBusquedaCliente = new frmBuscarCliente(1);
			if (formBusquedaCliente.ShowDialog() == DialogResult.OK)
			{
				clienteSeleccionado = frmBuscarCliente.clienteSeleccionado;
				txtCliente.Text = clienteSeleccionado.razonSocial;
			}
		}
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			completarTabla();
		}

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
			pedidoSeleccionado = (PedidoWS.pedido)dgvPedidos.CurrentRow.DataBoundItem;
			this.DialogResult = DialogResult.OK;
			this.Close();
        }
    }
}
