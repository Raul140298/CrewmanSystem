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
	public partial class frmReporteQuejas : Form
	{
        private ReporteWS.ReporteWSClient daoReporte;

        public frmReporteQuejas()
		{
			InitializeComponent();
            daoReporte = new ReporteWS.ReporteWSClient();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (sfdReporte.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] arreglo = daoReporte.generarReporteQuejas(Program.empleado.idEmpleado);
                    File.WriteAllBytes(sfdReporte.FileName, arreglo);
                    MessageBox.Show("El reporte fue generado con exito", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo generar el reporte", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmReporteQuejas_Load(object sender, EventArgs e)
        {

        }
    }
}
