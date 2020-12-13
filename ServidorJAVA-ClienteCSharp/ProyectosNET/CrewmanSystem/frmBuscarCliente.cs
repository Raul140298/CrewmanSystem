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
	public partial class frmBuscarCliente : Form
	{
		private static ClienteWS.ClienteWSClient daoCliente;
		private static ZonaWS.ZonaWSClient daoZona;
		private static VisitaWS.VisitaWSClient daoVisita;
		public static ClienteWS.cliente clienteSeleccionado;
		public static DataGridView dgv;
		public static Boolean evitarAct = false;
		private int tipoFrmVendedor;
		private int idBusquedaVendedor;
		private ClienteWS.cliente[] misClientes;

		public frmBuscarCliente()
		{
			//tipoFrm 2 para cboZona habilitado idBusqueda = idZona	listarClientes
			tipoFrmVendedor = 2;
			daoCliente = new ClienteWS.ClienteWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			daoVisita = new VisitaWS.VisitaWSClient();
			InitializeComponent();
			dgv = dgvClientes;
			ZonaWS.zona vacio = new ZonaWS.zona();
			vacio.idZona = 0;
			vacio.nombre = "Cualquiera";
			ZonaWS.zona[] vacioA = { vacio };
			ZonaWS.zona[] misZonas = daoZona.listarZonas();
			if (misZonas == null || misZonas.Length < 1) cboZona.DataSource = new BindingList<ZonaWS.zona>(vacioA);
			else cboZona.DataSource = new BindingList<ZonaWS.zona>(vacioA.Concat(misZonas).ToArray());
			cboZona.ValueMember = "idZona";
			cboZona.DisplayMember = "nombre";
			btnSeleccionar.Visible = false;
			evitarAct = false;
			completarTabla();
			#region colores de seleccion
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

        private void completarTabla()
		{
			dgvClientes.AutoGenerateColumns = false;
			if (tipoFrmVendedor == 2)
            {
				int idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
				misClientes = daoCliente.listarClientes(txtRazonSocial.Text, txtGrupo.Text, idZona);
			}
			else if (tipoFrmVendedor == 1) misClientes = daoCliente.listarClientesConCartera(txtRazonSocial.Text, txtGrupo.Text, Program.empleado.cartera.idCartera);
			else if (tipoFrmVendedor == 0) misClientes = daoCliente.listarClientesSinCartera(txtRazonSocial.Text, txtGrupo.Text, idBusquedaVendedor);
			if (misClientes != null)
            {
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
				lblNotFound.Visible = false;
			}
            else
            {
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>();
				lblNotFound.Visible = true;
			}
		}

		public frmBuscarCliente(int tipoFrm,int idBusqueda)
		{
			//tipoFrm 1 para cboZona deshabilitado idBusqueda = idCartera	listarVisitas
			//tipoFrm 0 para cboZona deshabilitado idBusqueda = idZona	listarClientesSinCartera
			tipoFrmVendedor = tipoFrm;
			idBusquedaVendedor = idBusqueda;

			daoCliente = new ClienteWS.ClienteWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			dgv = dgvClientes;
			dgvClientes.AutoGenerateColumns = false;

			btnSeleccionar.Visible = true;
			evitarAct = true;
			lblZona.Visible = false;
			cboZona.Visible = false;
			completarTabla();
			#region colores de seleccion
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
		}

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //castear objetos y mostrar valor determinado
            ClienteWS.cliente cliente = dgvClientes.Rows[e.RowIndex].DataBoundItem
                                        as ClienteWS.cliente;
			dgvClientes.Rows[e.RowIndex].Cells["ZONA"].Value = cliente.zona.nombre;
		}

		private void dgvClientes_SelectionChanged(object sender, EventArgs e)
		{
			if (evitarAct) return;
			if (dgvClientes.SelectedCells.Count != 1 && dgvClientes.SelectedCells.Count != 0)
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
			clienteSeleccionado = (ClienteWS.cliente)dgv.CurrentRow.DataBoundItem;
			daoCliente.eliminarCliente(clienteSeleccionado.idCliente);
		}

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Index>=0)
            {
				clienteSeleccionado = (ClienteWS.cliente)dgv.CurrentRow.DataBoundItem;
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
    }
}
