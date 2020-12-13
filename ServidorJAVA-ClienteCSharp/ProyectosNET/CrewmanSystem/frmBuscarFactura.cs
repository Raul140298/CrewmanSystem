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
    public partial class frmBuscarFactura : Form
    {
        public static FacturaWS.FacturaWSClient daoFactura;
        public static FacturaWS.factura facturaSeleccionada;
        public static DataGridView dgv;
        private int idTipo;

        public frmBuscarFactura(int idTipo)
        {
            //idTipo 0 = BUSCAR SIMPLE SIN SELECCIONAR
            //idTipo 1 = CON SELECCIONAR
            this.idTipo = idTipo;
            daoFactura = new FacturaWS.FacturaWSClient();
            InitializeComponent();
            dgv = dgvFacturas;
            dtpFechaEmisionIni.Value = DateTime.Today.AddMonths(-3);
            dtpFechaEmisionFinal.Value = DateTime.Today.AddMonths(3);
            dtpFechaVencimientoIni.Value = DateTime.Today.AddMonths(-3);
            dtpFechaVencimientoFinal.Value = DateTime.Today.AddMonths(3);
            rbEmisionAmbos.Checked = true;
            rbPagadoAmbos.Checked = true;

            if (idTipo == 0) btnSeleccionar.Visible = false;

            if (Program.empleado.cargo.nombre == "VENDEDOR")
            {
                dgvFacturas.Columns["NOMBRE"].Visible = false;
                dgvFacturas.Columns["APELLIDO_PATERNO"].Visible = false;
                dgvFacturas.Columns["APELLIDO_MATERNO"].Visible = false;
            }
            completarTabla();
            #region colores de seleccion
            dgvFacturas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvFacturas.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvFacturas.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvFacturas.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvFacturas.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvFacturas.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
            #endregion
        }

        private void completarTabla()
        {
            int numAnulado;
            if (rbEmisionAmbos.Checked) numAnulado = 2;
            else if (rbAnuladoSi.Checked) numAnulado = 1;
            else numAnulado = 0;

            int numPagado;
            if (rbPagadoAmbos.Checked) numPagado = 2;
            else if (rbPagadoSi.Checked) numPagado = 1;
            else numPagado = 0;

            FacturaWS.factura[] misFacturas = daoFactura.listarFacturas(Program.empleado.idEmpleado, txtRazonSocial.Text, txtGrupo.Text,
                                                                        dtpFechaEmisionIni.Value, dtpFechaEmisionFinal.Value,
                                                                        dtpFechaVencimientoIni.Value, dtpFechaVencimientoFinal.Value, 
                                                                        numAnulado, numPagado);
            dgvFacturas.AutoGenerateColumns = false;
            if (misFacturas != null)
            {
                dgvFacturas.DataSource = new BindingList<FacturaWS.factura>(misFacturas.ToArray());
                lblNotFound.Visible = false;
            }
            else {
                dgvFacturas.DataSource = new BindingList<FacturaWS.factura>();
                lblNotFound.Visible = true;
            } 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            completarTabla();
        }

        private void dgvFacturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                FacturaWS.factura factura = dgvFacturas.Rows[e.RowIndex].DataBoundItem
                as FacturaWS.factura;

                dgvFacturas.Rows[e.RowIndex].Cells["ID_PEDIDO"].Value = factura.pedido.idPedido;
                dgvFacturas.Rows[e.RowIndex].Cells["RUC"].Value = factura.pedido.cliente.ruc;
                dgvFacturas.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = factura.pedido.cliente.razonSocial;
                dgvFacturas.Rows[e.RowIndex].Cells["GRUPO"].Value = factura.pedido.cliente.grupo;
                dgvFacturas.Rows[e.RowIndex].Cells["TIPO_CLIENTE"].Value = factura.pedido.cliente.tipoEmpresa;
                dgvFacturas.Rows[e.RowIndex].Cells["NOMBRE"].Value = factura.pedido.empleado.nombre;
                dgvFacturas.Rows[e.RowIndex].Cells["APELLIDO_PATERNO"].Value = factura.pedido.empleado.apellidoPaterno;
                dgvFacturas.Rows[e.RowIndex].Cells["APELLIDO_MATERNO"].Value = factura.pedido.empleado.apellidoMaterno;

                String anulado = "";
                if (factura.anulado) anulado = "SI";
                else anulado = "NO";

                String estadoPagar = "";
                if (factura.estadoPagar) estadoPagar = "SI";
                else estadoPagar = "NO";

                dgvFacturas.Rows[e.RowIndex].Cells["ANULADO"].Value = anulado;
                dgvFacturas.Rows[e.RowIndex].Cells["ESTADO_PAGAR"].Value = estadoPagar;

            }
            catch (Exception) { }
        }
    }
}
