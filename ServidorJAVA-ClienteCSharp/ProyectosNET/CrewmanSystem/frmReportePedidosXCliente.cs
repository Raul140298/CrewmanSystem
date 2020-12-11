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
        private String[] estados = { "CUALQUIERA", "EN_PROCESO", "FINALIZADO", "CANCELADO" };

        public frmReportePedidosXCliente()
        {
            daoReporte = new ReporteWS.ReporteWSClient();
            InitializeComponent();
            cboTipoCliente.DataSource = tipos;
            cboEstado.DataSource = estados;
        }

        private void btnReportePedidos_Click(object sender, EventArgs e)
        {
            if (sfdReportePedidos.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] arreglo;
                    arreglo = daoReporte.generarReportePedidos();
                    File.WriteAllBytes(sfdReportePedidos.FileName, arreglo);
                    MessageBox.Show("El reporte fue generado con exito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo generar el reporte", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReportePedidosXCliente_Click(object sender, EventArgs e)
        {
            if (sfdReportePedidosXCliente.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] arreglo;
                    String tipo;
                    String estado;
                    if (cboTipoCliente.SelectedItem.ToString() == "CUALQUIERA")
                        tipo = "";
                    else
                        tipo = cboTipoCliente.SelectedItem.ToString();

                    if (cboEstado.SelectedItem.ToString() == "CUALQUIERA")
                        estado = "";
                    else
                        estado = cboEstado.SelectedItem.ToString();
                    arreglo = daoReporte.generarReportePedidosXCliente(tipo,estado);
                    File.WriteAllBytes(sfdReportePedidosXCliente.FileName, arreglo);
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
