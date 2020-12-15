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
	public partial class frmBuscarBorrador : Form
	{
		public static PedidoWS.pedido[] misPedidos;
		public static PedidoWS.PedidoWSClient daoPedido = new PedidoWS.PedidoWSClient();
		public static PedidoWS.pedido pedidoSeleccionado;
		public static ClienteWS.cliente clienteSeleccionado;
		public static DataGridView dgv;
		private ClienteWS.ClienteWSClient daoCliente = new ClienteWS.ClienteWSClient();
		private string[] tipos = { "AMBOS", "BORRADOR", "PEDIDO"};
		private string[] estados = { "AMBOS", "EN_PROCESO", "ESPERANDO", "FINALIZADO"};
		private int idTipo;

		public frmBuscarBorrador(int idTipo)
		{
			//idTipo 0 = BUSCAR PEDIDO NORMAL SOLO LISTA BORRADORES
			//idTipo 1 = BUSCAR PEDIDO A PAGAR (SE USA EN NUEVA FACTURA)
			//idTipo 2 = BUSCAR PEDIDO A PAGAR (SE USA EN NUEVA GUIA)
			this.idTipo = idTipo;
			InitializeComponent();
			dtpRangoIni.Value = DateTime.Today.AddMonths(-3);
			dtpRangoFin.Value = DateTime.Today.AddMonths(3);
			dgv = dgvBorradores;
			clienteSeleccionado = new ClienteWS.cliente();
			clienteSeleccionado.idCliente = 0;
			txtRuc.Text = "";
			txtGrupo.Text = "";
			cboTipo.DataSource = tipos;
			cboEstado.DataSource = estados;
			if (idTipo == 0)
            {
				cboTipo.SelectedIndex = 1;
				cboEstado.SelectedIndex = 0;
				cboTipo.Enabled = false;
				btnSeleccionar.Visible = false;
            }
            else if(idTipo == 1)
            {
				cboTipo.SelectedIndex = 2;
				cboEstado.SelectedIndex = 3;
				cboEstado.Enabled = false;
				cboTipo.Enabled = false;
            }
            else{
				cboTipo.SelectedIndex = 2;
				cboEstado.SelectedIndex = 3;
				cboEstado.Enabled = false;
				cboTipo.Enabled = false;
			}

			completarTabla();
			#region colores de seleccion
			dgvBorradores.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvBorradores.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvBorradores.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvBorradores.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvBorradores.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvBorradores.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

        public void completarTabla()
        {
			string miEstado = cboEstado.SelectedItem.ToString();
			string miTipo = cboTipo.SelectedItem.ToString();
			if(idTipo == 2)
            {
				misPedidos = daoPedido.listarPedidosSinGuia(Program.empleado.idEmpleado, txtRuc.Text, txtGrupo.Text, dtpRangoIni.Value, dtpRangoFin.Value, miTipo, miEstado);
            }
			else
			{
				misPedidos =
				daoPedido.listarPedidos(Program.empleado.idEmpleado, txtRuc.Text, txtGrupo.Text, dtpRangoIni.Value, dtpRangoFin.Value, miTipo, miEstado);
			}

			dgvBorradores.AutoGenerateColumns = false;
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
			if (Program.empleado.cargo.nombre == "VENDEDOR")
			{
				dgvBorradores.Columns["NOMBRE"].Visible = false;
				dgvBorradores.Columns["APELLIDO_PATERNO"].Visible = false;
				dgvBorradores.Columns["APELLIDO_MATERNO"].Visible = false;
			}
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

		public static void eliminar()
		{
			pedidoSeleccionado = (PedidoWS.pedido)dgv.CurrentRow.DataBoundItem;
			daoPedido.eliminarPedido(pedidoSeleccionado.idPedido);
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
			if(dgvBorradores.DataSource !=null && dgvBorradores.CurrentRow.Index >= 0)
            {
				pedidoSeleccionado = (PedidoWS.pedido)dgv.CurrentRow.DataBoundItem;
				this.DialogResult = DialogResult.OK;
			}

        }
    }
}
