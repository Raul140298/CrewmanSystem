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
	public partial class frmGestionarBorradores : Form
	{
		public static PedidoWS.PedidoWSClient daoPedido;
		public static PedidoWS.pedido pedidoSeleccionado;
		public static DataGridView dgv;
		private ClienteWS.ClienteWSClient daoCliente;
		PedidoWS.pedido[] misPedidos;
		public frmGestionarBorradores()
		{
			daoPedido = new PedidoWS.PedidoWSClient();
			daoCliente = new ClienteWS.ClienteWSClient();

			InitializeComponent();
			
			dgv = dgvBorradores;

			if (Program.empleado.cargo.nombre == "VENDEDOR")
			{
				dgvBorradores.Columns["NOMBRE"].Visible = false;
				dgvBorradores.Columns["APELLIDO_PATERNO"].Visible = false;
				dgvBorradores.Columns["APELLIDO_MATERNO"].Visible = false;
			}

			recargarDGV();
			#region colores de seleccion
			dgvBorradores.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvBorradores.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvBorradores.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvBorradores.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvBorradores.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvBorradores.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
        private void dgvBorradores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			try
			{
				PedidoWS.pedido pedido = dgvBorradores.Rows[e.RowIndex].DataBoundItem
				as PedidoWS.pedido;
				dgvBorradores.Rows[e.RowIndex].Cells["RUC"].Value = pedido.cliente.ruc;
				dgvBorradores.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = pedido.cliente.razonSocial;
				dgvBorradores.Rows[e.RowIndex].Cells["GRUPO"].Value = pedido.cliente.grupo;
				dgvBorradores.Rows[e.RowIndex].Cells["TIPO_CLIENTE"].Value = pedido.cliente.tipoEmpresa;
				dgvBorradores.Rows[e.RowIndex].Cells["NOMBRE"].Value = pedido.empleado.nombre;
				dgvBorradores.Rows[e.RowIndex].Cells["APELLIDO_PATERNO"].Value = pedido.empleado.apellidoPaterno;
				dgvBorradores.Rows[e.RowIndex].Cells["APELLIDO_MATERNO"].Value = pedido.empleado.apellidoMaterno;
				dgvBorradores.Rows[e.RowIndex].Cells["FECHA_REGISTRO"].Value = pedido.fechaRegistro.ToString("dd/MM/yyyy");
			}
			catch (Exception) { }
		}
		private void dgvBorradores_SelectionChanged(object sender, EventArgs e)
		{
			if (((PedidoWS.pedido)dgvBorradores.CurrentRow.DataBoundItem).estadoPedido == PedidoWS.estadoPedido.ESPERANDO && dgvBorradores.SelectedCells.Count != 1 && dgvBorradores.SelectedCells.Count != 0)
			{
				frmVentanaPrincipal.act.Enabled = true;
				frmVentanaPrincipal.elim.Enabled = true;
				return;
			}
			else
			{
				frmVentanaPrincipal.act.Enabled = false;
				frmVentanaPrincipal.elim.Enabled = false;
			}
		}

        public static void eliminar()
		{
			pedidoSeleccionado = (PedidoWS.pedido)dgv.CurrentRow.DataBoundItem;
			daoPedido.eliminarPedido(pedidoSeleccionado.idPedido);
		}
		public void recargarDGV()
		{
			dgvBorradores.AutoGenerateColumns = false;
			misPedidos = daoPedido.listarPedidos(Program.empleado.idEmpleado, "", "", DateTime.MinValue, DateTime.MaxValue, "BORRADOR", "AMBOS");

			if (misPedidos != null)
			{
				dgvBorradores.DataSource = new BindingList<PedidoWS.pedido>(misPedidos.ToArray());
				lblNotFound.Visible = false;
			}
			else
			{
				dgvBorradores.DataSource = new BindingList<PedidoWS.pedido>();
				lblNotFound.Visible = true;
			}
		}
	}
}
