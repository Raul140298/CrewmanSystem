using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CrewmanSystem
{
    public partial class frmGestionarVisitas : Form
    {
        private VisitaWS.VisitaWSClient daoVisita;
        private BindingList<VisitaWS.visita> misVisitas;
        private VisitaWS.visita[] misVisitasThread;
        public frmGestionarVisitas()
        {
            InitializeComponent();
            daoVisita = new VisitaWS.VisitaWSClient();
            completarVisita();

            #region colores de seleccion
            dgvVisitas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvVisitas.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvVisitas.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvVisitas.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvVisitas.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvVisitas.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
            #endregion
        }

        private void completarVisita()
        {
            VisitaWS.visita[] visitas = daoVisita.listarVisitas(Program.empleado.cartera.idCartera);
            if (visitas == null || visitas.Length < 1) misVisitas = new BindingList<VisitaWS.visita>();
            else misVisitas = new BindingList<VisitaWS.visita>(visitas);
            dgvVisitas.AutoGenerateColumns = false;
            dgvVisitas.DataSource = misVisitas;
        }

        private void dgvVisitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            VisitaWS.visita v = dgvVisitas.Rows[e.RowIndex].DataBoundItem as VisitaWS.visita;

            dgvVisitas.Rows[e.RowIndex].Cells["RUC"].Value = v.cliente.ruc;
            dgvVisitas.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = v.cliente.razonSocial;
            dgvVisitas.Rows[e.RowIndex].Cells["GRUPO"].Value = v.cliente.grupo;
            dgvVisitas.Rows[e.RowIndex].Cells["FECHA_REGISTRO"].Value = v.cliente.fechaRegistro.ToString("dd/MM/yyyy");

            DateTime ultCompra = v.cliente.fechaUltimaCompra;
            string fechaUltCompra;
            if (ultCompra.Year < 2000) fechaUltCompra = "";
            else fechaUltCompra = ultCompra.ToString("dd/MM/yyyy");
            dgvVisitas.Rows[e.RowIndex].Cells["FECHA_ULTIMA_COMPRA"].Value = fechaUltCompra;
            dgvVisitas.Rows[e.RowIndex].Cells["TIPO_CLIENTE"].Value = v.cliente.tipoEmpresa;
            dgvVisitas.Rows[e.RowIndex].Cells["ZONA"].Value = v.cliente.zona.nombre;
            dgvVisitas.Rows[e.RowIndex].Cells["DIRECCION"].Value = v.cliente.direccion;
            string estado;
            if (v.estado) estado = "VISITADO";
            else estado = "NO VISITADO";
            dgvVisitas.Rows[e.RowIndex].Cells["ESTADO"].Value = estado;
            dgvVisitas.Rows[e.RowIndex].Cells["CHECK"].Value = v.estado;
            DateTime visita = v.fechaRegistro;
            string fechaVisita;
            if (visita.Year < 2000) fechaVisita = "";
            else fechaVisita = visita.ToString("dd/MM/yyyy");
            dgvVisitas.Rows[e.RowIndex].Cells["FECHA_VISITA"].Value = fechaVisita;
        }

        private void dgvVisitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                bool estadoPrevio = (bool)dgvVisitas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!estadoPrevio)
                {
                    frmConfirmarVisita formConfirmarVisita = new frmConfirmarVisita();
                    if (formConfirmarVisita.ShowDialog() == DialogResult.OK)
                    {
                        int resultado = daoVisita.registrarVisita((int)dgvVisitas.Rows[e.RowIndex].Cells["ID"].Value);
                        if (resultado == 0)
                        {
                            MessageBox.Show("No se registró la visita correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Se registró la visita correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            completarVisita();
                        }
                    }
                }
            }
        }
        public void recargarDGV()
        {
            completarVisita();
        }

        public void revisarDGV(object source, ElapsedEventArgs e)
        {
            //int i = 0;
            if (dgvVisitas.InvokeRequired)
            {
                dgvVisitas.Invoke(new Action(() =>
                {
                    misVisitasThread = daoVisita.listarVisitas(Program.empleado.cartera.idCartera);
                    if (misVisitasThread!=null && misVisitasThread.Length != dgvVisitas.Rows.Count)
                    {
                        dgvVisitas.DataSource = new BindingList<VisitaWS.visita>(misVisitasThread);
                    }
                }));
            }
        }
    }
}
