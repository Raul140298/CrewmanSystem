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
		public static ClienteWS.ClienteWSClient daoCliente;
		public static ClienteWS.cliente clienteSeleccionado;
		public static DataGridView dgv;

		public frmBuscarCliente()
		{
			daoCliente = new ClienteWS.ClienteWSClient();
			InitializeComponent();
			dgv = dgvClientes;
			dgvClientes.AutoGenerateColumns = false;
			ClienteWS.cliente[] misClientes = daoCliente.listarClientes("", "");
			if (misClientes != null)
			{
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
			}
			else
			{
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>();

			}

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
			InitializeComponent();
			dgv = dgvClientes;
			dgvClientes.AutoGenerateColumns = false;
			ClienteWS.cliente[] misClientes = daoCliente.listarClientes("", "");
			if (misClientes != null)
			{
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
			}
			else
			{
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>();

			}

			btnSeleccionar.Visible = true;
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
			ClienteWS.cliente[] misClientes = daoCliente.listarClientes(txtRazonSocial.Text, txtGrupo.Text);
			if (misClientes != null)
			{
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
			}
			else
			{
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>();

			}
		}

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //castear objetos y mostrar valor determinado
            ClienteWS.cliente cliente = dgvClientes.Rows[e.RowIndex].DataBoundItem
                                        as ClienteWS.cliente;
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
				frmVentanaPrincipal.act.Enabled = true;
				frmVentanaPrincipal.elim.Enabled = true;
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
