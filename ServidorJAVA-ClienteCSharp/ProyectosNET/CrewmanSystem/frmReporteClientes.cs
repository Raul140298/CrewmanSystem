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
    public partial class frmReporteClientes : Form
    {
        private ReporteWS.ReporteWSClient daoReporte;

        public frmReporteClientes()
        {
            InitializeComponent();
            daoReporte = new ReporteWS.ReporteWSClient();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            sfdReporte.ShowDialog();
            if (sfdReporte.FileName != null && sfdReporte.FileName != "")
            {
                byte[] arreglo = daoReporte.generarReporteMejoresClientes();
                File.WriteAllBytes(sfdReporte.FileName, arreglo);
            }
        }
    }
}
