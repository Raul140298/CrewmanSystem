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
	public partial class frmNuevaPromocion : Form
	{
		public frmNuevaPromocion()
		{
			InitializeComponent();
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProductoXZona_Click(object sender, EventArgs e)
        {
            frmBuscarZona formBusquedaZona = new frmBuscarZona();
            if(formBusquedaZona.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProductoXZona_Click_1(object sender, EventArgs e)
        {
            frmBuscarZona formBusquedaZona = new frmBuscarZona();
            if(formBusquedaZona.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProductoPorZona formBusquedaProductoPorZona = new frmBuscarProductoPorZona();
            if(formBusquedaProductoPorZona.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
