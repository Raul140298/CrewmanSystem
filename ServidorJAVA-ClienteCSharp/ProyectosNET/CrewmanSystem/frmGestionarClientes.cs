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
	public partial class frmGestionarClientes : Form
	{
		public static ClienteWS.ClienteWSClient daoCliente;
		public static PersonaContactoWS.PersonaContactoWSClient daoPersonaContacto;
		public static ClienteWS.cliente clienteSeleccionado;
		public static DataGridView dgv;

		public frmGestionarClientes()
		{
			daoCliente = new ClienteWS.ClienteWSClient();
			daoPersonaContacto = new PersonaContactoWS.PersonaContactoWSClient();
			InitializeComponent();
			dgv = dgvClientes;
			dgvClientes.AutoGenerateColumns = false;
			recargarDGV();

			#region colores de seleccion
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvClientes.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvClientes.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			ClienteWS.cliente cliente = dgvClientes.Rows[e.RowIndex].DataBoundItem
										as ClienteWS.cliente;
			dgvClientes.Rows[e.RowIndex].Cells["ZONA"].Value = cliente.zona.nombre;
		}

		private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
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

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			clienteSeleccionado = (ClienteWS.cliente)dgv.CurrentRow.DataBoundItem;
			PersonaContactoWS.personaContacto perCont = new PersonaContactoWS.personaContacto();
			perCont.idPersonaContacto = clienteSeleccionado.personaContacto.idPersonaContacto;
			perCont = daoPersonaContacto.mostrarPersonaContacto(perCont.idPersonaContacto);
			clienteSeleccionado.personaContacto = new ClienteWS.personaContacto();
			clienteSeleccionado.personaContacto.idPersonaContacto = perCont.idPersonaContacto;
			clienteSeleccionado.personaContacto.dni = perCont.dni;
			clienteSeleccionado.personaContacto.nombre = perCont.nombre;
			clienteSeleccionado.personaContacto.apellidoPaterno = perCont.apellidoPaterno;
			clienteSeleccionado.personaContacto.apellidoMaterno = perCont.apellidoMaterno;
			clienteSeleccionado.personaContacto.telefono1 = perCont.telefono1;
			clienteSeleccionado.personaContacto.telefono2 = perCont.telefono2;
			clienteSeleccionado.personaContacto.cargo = perCont.cargo;
			clienteSeleccionado.personaContacto.correo = perCont.correo;
			clienteSeleccionado.personaContacto.genero = perCont.genero;

			frmMostrarCliente formMostrarCliente = new frmMostrarCliente(clienteSeleccionado);
			if(formMostrarCliente.ShowDialog() == DialogResult.OK) { 
            }
        }
		public void recargarDGV()
		{
			ClienteWS.cliente[] misClientes = daoCliente.listarClientes("", "", 0);
			if (misClientes != null)
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
			else
				dgvClientes.DataSource = new BindingList<ClienteWS.cliente>();
		}
	}
}
