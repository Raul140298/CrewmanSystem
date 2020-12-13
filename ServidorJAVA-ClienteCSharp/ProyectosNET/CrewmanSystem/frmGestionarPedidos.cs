using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public partial class frmGestionarPedidos : Form
	{
		public static PedidoWS.PedidoWSClient daoPedido;
		public static PedidoWS.pedido pedidoSeleccionado;
		public static DataGridView dgv;
		private ClienteWS.ClienteWSClient daoCliente;
		PedidoWS.pedido[] misPedidos;
		public frmGestionarPedidos()
		{
			daoPedido = new PedidoWS.PedidoWSClient();
			daoCliente = new ClienteWS.ClienteWSClient();

			InitializeComponent();
			
			dgv = dgvPedidos;
			dgvPedidos.AutoGenerateColumns = false;

			recargarDGV();
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
            try
            {
				PedidoWS.pedido pedido = dgvPedidos.Rows[e.RowIndex].DataBoundItem
				as PedidoWS.pedido;
				dgvPedidos.Rows[e.RowIndex].Cells["RUC"].Value = pedido.cliente.ruc;
				dgvPedidos.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = pedido.cliente.razonSocial;
				dgvPedidos.Rows[e.RowIndex].Cells["GRUPO"].Value = pedido.cliente.grupo;
				dgvPedidos.Rows[e.RowIndex].Cells["TIPO_CLIENTE"].Value = pedido.cliente.tipoEmpresa;
				dgvPedidos.Rows[e.RowIndex].Cells["NOMBRE"].Value = pedido.empleado.nombre;
				dgvPedidos.Rows[e.RowIndex].Cells["APELLIDO_PATERNO"].Value = pedido.empleado.apellidoPaterno;
				dgvPedidos.Rows[e.RowIndex].Cells["APELLIDO_MATERNO"].Value = pedido.empleado.apellidoMaterno;
				dgvPedidos.Rows[e.RowIndex].Cells["FECHA_REGISTRO"].Value = pedido.fechaRegistro.ToString("dd/MM/yyyy");
			}
            catch (Exception){ }
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
		public void recargarDGV()
		{
			misPedidos = daoPedido.listarPedidos(Program.empleado.idEmpleado, "", "", DateTime.MinValue, DateTime.MaxValue, "BORRADOR", "AMBOS");

			if (misPedidos != null)
				dgvPedidos.DataSource = new BindingList<PedidoWS.pedido>(misPedidos.ToArray());
			else
				dgvPedidos.DataSource = new BindingList<PedidoWS.pedido>();
			if (Program.empleado.cargo.nombre == "VENDEDOR")
			{
				dgvPedidos.Columns["NOMBRE"].Visible = false;
				dgvPedidos.Columns["APELLIDO_PATERNO"].Visible = false;
				dgvPedidos.Columns["APELLIDO_MATERNO"].Visible = false;
			}
		}
		public void revisarDGV(object source, ElapsedEventArgs e)
		{

			if (dgvPedidos.InvokeRequired)
			{
				dgvPedidos.Invoke(new Action(() =>
				{
					if (dgvPedidos.Rows.Count > 0) { 
					int i = ((PedidoWS.pedido)dgvPedidos.CurrentRow.DataBoundItem).idPedido;
					int j = dgvPedidos.CurrentCell.ColumnIndex;

					recargarDGV();

					int k = 0;
					foreach (PedidoWS.pedido p in misPedidos)
					{
						if (p.idPedido == i)
						{
							i = k;
							break;
						}
						k++;
					}

					if (k != misPedidos.Length)
						dgvPedidos.CurrentCell = dgvPedidos[j, i];
				}
				}));
			}
		}
	}
}
