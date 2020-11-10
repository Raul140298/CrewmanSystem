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
		ClienteWS.ClienteWSClient daoCliente;
		public frmGestionarClientes()
		{
			daoCliente = new ClienteWS.ClienteWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<ClienteWS.cliente>(daoCliente.listarClientes().ToArray());
		}
	}
}
