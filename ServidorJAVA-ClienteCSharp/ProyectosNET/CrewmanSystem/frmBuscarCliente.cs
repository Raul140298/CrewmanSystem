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
		public static ClienteWS.cliente clienteSeleccionado;
		public static DataGridView dgv;
		public static int evitarAct = 0;

		public frmBuscarCliente()
		{
			daoCliente = new ClienteWS.ClienteWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			dgv = dgvClientes;
			dgvClientes.AutoGenerateColumns = false;
			ClienteWS.cliente[] misClientes = daoCliente.listarClientes("", "",0);
			if (misClientes != null)
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
			else
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>();
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
			evitarAct = 0;

			#region colores de seleccion
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
		public frmBuscarCliente(int popup)
		{
			daoCliente = new ClienteWS.ClienteWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			dgv = dgvClientes;
			dgvClientes.AutoGenerateColumns = false;
			//Revisar el id que se pasa
			ClienteWS.cliente[] misClientes = daoCliente.listarClientes("", "",0);
			if (misClientes != null)
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
			else
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>();
			ZonaWS.zona vacio = new ZonaWS.zona();
			vacio.idZona = 0;
			vacio.nombre = "Cualquiera";
			ZonaWS.zona[] vacioA = { vacio };
			ZonaWS.zona[] misZonas = daoZona.listarZonas();
			if (misZonas == null || misZonas.Length < 1) cboZona.DataSource = new BindingList<ZonaWS.zona>(vacioA);
			else cboZona.DataSource = new BindingList<ZonaWS.zona>(vacioA.Concat(misZonas).ToArray());
			cboZona.ValueMember = "idZona";
			cboZona.DisplayMember = "nombre";
			btnSeleccionar.Visible = true;
			evitarAct = 1;
			#region colores de seleccion
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
		private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			int idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
			ClienteWS.cliente[] misClientes = daoCliente.listarClientes(txtRazonSocial.Text, txtGrupo.Text, idZona);
			if (misClientes != null)
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
			else
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>();
		}

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //castear objetos y mostrar valor determinado
            ClienteWS.cliente cliente = dgvClientes.Rows[e.RowIndex].DataBoundItem
                                        as ClienteWS.cliente;
			dgvClientes.Rows[e.RowIndex].Cells["ZONA"].Value = cliente.zona.nombre;
		}

		private void dgvClientes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
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
                if (evitarAct == 0)
                {
					frmVentanaPrincipal.act.Enabled = true;
					frmVentanaPrincipal.elim.Enabled = true;
				}
			}
		}

		public static void eliminar()
		{
			clienteSeleccionado = (ClienteWS.cliente)dgv.CurrentRow.DataBoundItem;
			daoCliente.eliminarCliente(clienteSeleccionado.idCliente);
		}

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
			clienteSeleccionado = (ClienteWS.cliente)dgv.CurrentRow.DataBoundItem;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
    }
}
