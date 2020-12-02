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
	public partial class frmBuscarPedido : Form
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

		public frmBuscarPedido(int idTipo)
		{
			//idTipo 0 = BUSCAR PEDIDO NORMAL
			//idTipo 1 = BUSCAR PEDIDO A PAGAR (SE USA EN NUEVA FACTURA)
			//idTipo 2 = BUSCAR PEDIDO A PAGAR (SE USA EN NUEVA GUIA)
			this.idTipo = idTipo;
			InitializeComponent();
			dtpRangoIni.Value = DateTime.Today.AddMonths(-1);
			dtpRangoFin.Value = DateTime.Today.AddMonths(1);
			dgv = dgvPedidos;
			clienteSeleccionado = new ClienteWS.cliente();
			clienteSeleccionado.idCliente = 0;
			txtRuc.Text = "";
			txtGrupo.Text = "";
			cboTipo.DataSource = tipos;
			cboEstado.DataSource = estados;
			if (idTipo == 0)
            {
				cboTipo.SelectedIndex = 0;
				cboEstado.SelectedIndex = 0;
				btnSeleccionar.Visible = false;
            }
            else if(idTipo == 1)
            {
				cboTipo.SelectedIndex = 2;
				cboEstado.SelectedIndex = 1;
				cboEstado.Enabled = false;
				cboTipo.Enabled = false;
            }
            else{
				cboEstado.SelectedIndex = 3;
				cboTipo.SelectedIndex = 2;
				cboEstado.Enabled = false;
				cboTipo.Enabled = false;
			}

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
			string miEstado = cboEstado.SelectedItem.ToString();
			string miTipo = cboTipo.SelectedItem.ToString();
			if(idTipo == 2)
            {
				//misPedidos = daoPedido.listarPedidosSinGuia(Program.empleado.idEmpleado, txtRuc.Text, txtGrupo.Text, dtpRangoIni.Value, dtpRangoFin.Value, miTipo, miEstado);
            }
			else
			{
				misPedidos =
				daoPedido.listarPedidos(Program.empleado.idEmpleado, txtRuc.Text, txtGrupo.Text, dtpRangoIni.Value, dtpRangoFin.Value, miTipo, miEstado);
			}

			dgvPedidos.AutoGenerateColumns = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
			if(dgvPedidos.DataSource !=null && dgvPedidos.CurrentRow.Index >= 0)
            {
				pedidoSeleccionado = (PedidoWS.pedido)dgv.CurrentRow.DataBoundItem;
				this.DialogResult = DialogResult.OK;
			}

        }
    }
}
