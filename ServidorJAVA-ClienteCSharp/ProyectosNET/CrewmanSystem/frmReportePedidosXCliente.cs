using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewmanSystem
{
    public partial class frmReportePedidosXCliente : Form
    {
        private ReporteWS.ReporteWSClient daoReporte;
        private String[] tipos = {"CUALQUIERA","ALTO","MEDIO","BAJO"};
        public frmReportePedidosXCliente()
        {
            daoReporte = new ReporteWS.ReporteWSClient();
            InitializeComponent();
            cboTipoCliente.DataSource = tipos;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            sfdReporte.ShowDialog();
            byte[] arreglo;
            if (cboTipoCliente.SelectedItem.ToString() == "CUALQUIERA")
            {
                arreglo = daoReporte.generarReportePedidosXCliente("");
            }
            else
            {
                arreglo = daoReporte.generarReportePedidosXCliente(cboTipoCliente.SelectedItem.ToString());
            }
            File.WriteAllBytes(sfdReporte.FileName,arreglo);
            MessageBox.Show("Se ha guardado correctamente", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sfdReporte.ShowDialog();
            byte[] arreglo;

            arreglo = daoReporte.generarReportePedidos();
            File.WriteAllBytes(sfdReporte.FileName, arreglo);
            MessageBox.Show("Se ha guardado correctamente", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
