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
	public partial class frmNuevoPedido : Form
	{
		public frmNuevoPedido()
		{
			InitializeComponent();
		}

        private void button4_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBusquedaCliente = new frmBuscarCliente();
            if (formBusquedaCliente.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscarProductoXZona_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Debe escoger un cliente","Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
