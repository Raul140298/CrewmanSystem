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
    public partial class frmRecursosEmpleado : Form
    {
        private PromocionWS.PromocionWSClient daoPromocion;
        private ReporteWS.ReporteWSClient daoReporte;
        private PromocionWS.promocion[] misPromocions;
        public frmRecursosEmpleado()
        {
            daoPromocion = new PromocionWS.PromocionWSClient();
            daoReporte = new ReporteWS.ReporteWSClient();
            InitializeComponent();
            misPromocions = daoPromocion.listarPromocionPorZona("", DateTime.MinValue, DateTime.MaxValue, Program.empleado.zona.idZona);
            if (misPromocions == null) pnlPromocion.Visible = false;
        }


        private void btnRutaClientes_Click(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombre = Program.empleado.nombre + " " + Program.empleado.apellidoPaterno + " " + Program.empleado.apellidoMaterno;
                    byte[] arreglo = daoReporte.generarReporteVisitas(nombre, Program.empleado.idEmpleado);
                    File.WriteAllBytes(sfdRuta.FileName, arreglo);
                    MessageBox.Show("El reporte fue generado con exito", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo generar el reporte", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDetallePromocion_Click(object sender, EventArgs e)
        {
            if (sfdPromocion.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombre = Program.empleado.nombre + " " + Program.empleado.apellidoPaterno + " " + Program.empleado.apellidoMaterno;
                    int idPromocion = misPromocions[0].idPromocion;
                    byte[] arreglo = daoReporte.generarReportePromocion(nombre,idPromocion);
                    File.WriteAllBytes(sfdPromocion.FileName, arreglo);
                    MessageBox.Show("El reporte fue generado con exito", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo generar el reporte", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
