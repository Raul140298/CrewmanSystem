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
	public partial class frmNuevaFactura : Form
	{
		public frmNuevaFactura()
		{
			InitializeComponent();
		}

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarProductoXZona_Click(object sender, EventArgs e)
        {
            frmBuscarPedido formBusquedaPedido = new frmBuscarPedido();
            if(formBusquedaPedido.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
