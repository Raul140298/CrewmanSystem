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
		public frmBuscarPedido()
		{
			InitializeComponent();
		}

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
			frmBuscarCliente formBusquedaCliente = new frmBuscarCliente();
			if(formBusquedaCliente.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
