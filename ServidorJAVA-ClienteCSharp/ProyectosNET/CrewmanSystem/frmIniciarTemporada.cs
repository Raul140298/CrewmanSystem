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
    public partial class frmIniciarTemporada : Form
    {
        ClienteWS.ClienteWSClient daoCliente = new ClienteWS.ClienteWSClient();
        public frmIniciarTemporada()
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
                    MessageBox.Show("Nueva temporada iniciada exitosamente", "Mensaje de resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFecha.Text = DateTime.Now.ToString("d");
                }
                else MessageBox.Show("Error en el inicio de una nueva temporada", "Mensaje de resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
