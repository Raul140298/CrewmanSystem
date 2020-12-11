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
            if (sfdReporte.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombre = Program.empleado.nombre + " " + Program.empleado.apellidoPaterno + " " + Program.empleado.apellidoMaterno;
                    byte[] arreglo = daoReporte.generarReporteMejoresClientes(nombre);
                    File.WriteAllBytes(sfdReporte.FileName, arreglo);
                    MessageBox.Show("El reporte fue generado con exito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo generar el reporte", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
