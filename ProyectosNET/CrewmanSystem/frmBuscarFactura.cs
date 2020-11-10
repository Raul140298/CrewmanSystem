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
    public partial class frmBuscarFactura : Form
    {
        public frmBuscarFactura()
        {
            InitializeComponent();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            frmBuscarPedido formBusquedaPedido = new frmBuscarPedido();
            if(formBusquedaPedido.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
