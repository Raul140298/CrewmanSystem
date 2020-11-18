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
    public partial class frmMostrarPromocion : Form
    {
        private PromocionXProductoWS.PromocionXProductoWSClient daoPromocionXProducto;
        private ZonaWS.ZonaWSClient daoZona;
        public frmMostrarPromocion(PromocionWS.promocion promocionSeleccionada)
        {
            daoPromocionXProducto = new PromocionXProductoWS.PromocionXProductoWSClient();
            daoZona = new ZonaWS.ZonaWSClient();
            InitializeComponent();
            txtId.Text = promocionSeleccionada.idPromocion.ToString();
            txtNombre.Text = promocionSeleccionada.nombre;
            txtDescripcion.Text = promocionSeleccionada.descripcion;
            dtpFechaInicio.Value = promocionSeleccionada.fechaInicio;
            dtpFechaFin.Value = promocionSeleccionada.fechaFin;
            ZonaWS.zona[] listaZonas = daoZona.listarZonas();
            if (listaZonas == null || listaZonas.Length < 1) cboZona.DataSource = new BindingList<ZonaWS.zona>();
            cboZona.DataSource = new BindingList<ZonaWS.zona>(listaZonas);
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";

            cboZona.SelectedValue = promocionSeleccionada.zona.idZona;

            PromocionXProductoWS.promocionXProducto[] listaPromocionXProducto = 
                daoPromocionXProducto.listarPromocionXProducto(promocionSeleccionada.idPromocion);
            dgvPromocionXProducto.AutoGenerateColumns = false;
            if (listaPromocionXProducto == null || listaPromocionXProducto.Length < 1)
                dgvPromocionXProducto.DataSource = new BindingList<PromocionXProductoWS.promocionXProducto>();
            else
                dgvPromocionXProducto.DataSource = new BindingList<PromocionXProductoWS.promocionXProducto>(listaPromocionXProducto);
        }

        private void dgvPromocionXProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PromocionXProductoWS.promocionXProducto p = dgvPromocionXProducto.Rows[e.RowIndex].DataBoundItem
                as PromocionXProductoWS.promocionXProducto;

            dgvPromocionXProducto.Rows[e.RowIndex].Cells["NRO"].Value = e.RowIndex + 1;
            dgvPromocionXProducto.Rows[e.RowIndex].Cells["NOMBRE_PRODUCTO"].Value = p.producto.nombre;
            dgvPromocionXProducto.Rows[e.RowIndex].Cells["CANT_UNIDADES"].Value = p.producto.cantUnidad;
            dgvPromocionXProducto.Rows[e.RowIndex].Cells["UNIDADES"].Value = p.producto.unidades;
        }
    }
}
