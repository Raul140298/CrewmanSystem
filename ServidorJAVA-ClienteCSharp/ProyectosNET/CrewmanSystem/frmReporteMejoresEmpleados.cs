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
	public partial class frmReporteMejoresEmpleados : Form
	{
        private ReporteWS.ReporteWSClient daoReporte;

        public frmReporteMejoresEmpleados()
		{
			InitializeComponent();
            daoReporte = new ReporteWS.ReporteWSClient();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            sfdReporte.ShowDialog();
            if (sfdReporte.FileName != null && sfdReporte.FileName != "")
            {
                byte[] arreglo = daoReporte.generarReporteMejoresEmpleados();
                File.WriteAllBytes(sfdReporte.FileName + ".pdf", arreglo);
            }
            MessageBox.Show("Se ha guardado correctamente", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
