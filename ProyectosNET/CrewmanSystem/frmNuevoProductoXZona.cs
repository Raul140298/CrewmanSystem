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
    public partial class frmNuevoProductoXZona : Form
    {
        public frmNuevoProductoXZona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            frmBuscarProducto formBusquedaProducto = new frmBuscarProducto();
            if (formBusquedaProducto.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscarZona_Click_1(object sender, EventArgs e)
        {
            frmBuscarZona formBusquedaZona = new frmBuscarZona();
            if (formBusquedaZona.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
