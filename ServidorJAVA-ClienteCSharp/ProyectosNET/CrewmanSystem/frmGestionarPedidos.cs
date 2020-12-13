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

		private void dgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
				DateTime fechaAprobado = pedido.fechaAprobado;
				string fechaAprobadoStr = "";
				if (fechaAprobado.Year > 2000) fechaAprobadoStr = fechaAprobado.ToString("dd/MM/yyyy");
				dgvPedidos.Rows[e.RowIndex].Cells["FECHA_APROBADO"].Value = fechaAprobadoStr;
				DateTime fechaEstimada = pedido.fechaEstim;
				string fechaEstimadaStr = "";
				if (fechaEstimada.Year > 2000) fechaEstimadaStr = fechaEstimada.ToString("dd/MM/yyyy");
				dgvPedidos.Rows[e.RowIndex].Cells["FECHA_ESTIMADA"].Value = fechaEstimadaStr;
			}
			catch (Exception) { }
		}

		public static void eliminar()
		{
			pedidoSeleccionado = (PedidoWS.pedido)dgv.CurrentRow.DataBoundItem;
			daoPedido.eliminarPedidoEnProceso(pedidoSeleccionado.idPedido);
		}

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
			if (((PedidoWS.pedido)dgvPedidos.CurrentRow.DataBoundItem).estadoPedido == PedidoWS.estadoPedido.EN_PROCESO && dgvPedidos.SelectedCells.Count != 1)
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
		public void recargarDGV()
		{
			misPedidos = daoPedido.listarPedidos(Program.empleado.idEmpleado, "", "", DateTime.MinValue, DateTime.MaxValue, "PEDIDO", "AMBOS");

			if (misPedidos != null)
			{
				dgvPedidos.DataSource = new BindingList<PedidoWS.pedido>(misPedidos.ToArray());
				lblNotFound.Visible = false;
			}
			else
			{
				dgvPedidos.DataSource = new BindingList<PedidoWS.pedido>();
				lblNotFound.Visible = true;
			}
			if (Program.empleado.cargo.nombre == "VENDEDOR")
			{
				dgvPedidos.Columns["NOMBRE"].Visible = false;
				dgvPedidos.Columns["APELLIDO_PATERNO"].Visible = false;
				dgvPedidos.Columns["APELLIDO_MATERNO"].Visible = false;
			}
		}
	}
}
