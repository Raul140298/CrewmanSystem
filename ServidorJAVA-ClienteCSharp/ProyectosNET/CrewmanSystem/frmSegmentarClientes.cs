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
            InitializeComponent();
            DateTime fecha = daoCliente.obtenerInfoSeg();
            txtFecha.Text = fecha.ToString("d");
        }

        private void btnSegmentar_Click(object sender, EventArgs e)
        {
            frmConfirmarSegmentar formSegmentar = new frmConfirmarSegmentar();
            if (formSegmentar.ShowDialog() == DialogResult.OK)
            {
                if (daoCliente.segmentarClientes() != 0)
                {
                    MessageBox.Show("Clientes segmentados exitosamente", "Mensaje de resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFecha.Text = DateTime.Now.ToString("d");
                }
                else MessageBox.Show("Error en la segmentación de clientes", "Mensaje de resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
