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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            frmBuscarProductoPorZona formBusquedaProductoPorZona = new frmBuscarProductoPorZona();
            if(formBusquedaProductoPorZona.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
