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
    public partial class frmSegmentarClientes : Form
    {
        ClienteWS.ClienteWSClient daoCliente = new ClienteWS.ClienteWSClient();
        public frmSegmentarClientes()
        {
            DateTime fecha = daoCliente.obtenerInfoSeg();
            dtpFecha.Value = fecha;
            InitializeComponent();
        }

        private void btnSegmentar_Click(object sender, EventArgs e)
        {
            daoCliente.segmentarClientes();
        }
    }
}
