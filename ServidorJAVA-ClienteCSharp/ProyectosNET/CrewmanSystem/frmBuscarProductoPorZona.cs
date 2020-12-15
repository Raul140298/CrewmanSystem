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
    public partial class frmBuscarProductoPorZona : Form
    {
        private ProductoXZonaWS.ProductoXZonaWSClient daoProductoXZona;
        private ProductoXZonaWS.productoXZona[] misProductoXZona;
        public static ProductoXZonaWS.productoXZona productoXZonaSeleccionado;
        private int idZona;
        private int idTipo;

        public frmBuscarProductoPorZona(int idTipoParam,int idZonaParam)
        {
            //idTipoParam 0 = buscar productos
            //idTipoParam 1 = buscar productos sin una promocion (solo es usa en nueva promocion)

            InitializeComponent();
            this.idZona = idZonaParam;
            this.idTipo = idTipoParam;
            daoProductoXZona = new ProductoXZonaWS.ProductoXZonaWSClient();
            dgvProductos.AutoGenerateColumns = false;
            cargarTabla();
            #region colores de seleccion
            dgvProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProductos.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvProductos.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProductos.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvProductos.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProductos.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
            #endregion
        }

        private void cargarTabla()
        {
            if (idTipo == 0)
                misProductoXZona = daoProductoXZona.listarProductosXZonas(txtNombre.Text, txtFamilia.Text, txtSubfamilia.Text, txtMarca.Text, idZona);
            else
                misProductoXZona = daoProductoXZona.listarProductosXZonasSinPromocion(txtNombre.Text, txtFamilia.Text, txtSubfamilia.Text, txtMarca.Text, idZona);


            if (misProductoXZona != null)
            {
                dgvProductos.DataSource = new BindingList<ProductoXZonaWS.productoXZona>(misProductoXZona.ToArray());
                lblNotFound.Visible = false;
            }
            else
            {
                dgvProductos.DataSource = new BindingList<ProductoXZonaWS.productoXZona>();
                lblNotFound.Visible = true;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount<1 || dgvProductos.CurrentRow.Index<0)
            {
                return;
            }
            productoXZonaSeleccionado = (ProductoXZonaWS.productoXZona)dgvProductos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        //public ProductoXZonaWS.productoXZona ProductoXZonaSeleccionado
        //{ get => productoXZonaSeleccionado; set => productoXZonaSeleccionado = value; }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //castear objetos y mostrar valor determinado
            ProductoXZonaWS.productoXZona productoXZona = dgvProductos.Rows[e.RowIndex].DataBoundItem
            as ProductoXZonaWS.productoXZona;

            dgvProductos.Rows[e.RowIndex].Cells["NOMBRE"].Value = productoXZona.producto.nombre;
            dgvProductos.Rows[e.RowIndex].Cells["SUBFAMILIA"].Value = productoXZona.producto.subFamilia.descripcionSubFamilia;
            dgvProductos.Rows[e.RowIndex].Cells["FAMILIA"].Value = productoXZona.producto.subFamilia.familia.descripcion;
            dgvProductos.Rows[e.RowIndex].Cells["MARCA"].Value = productoXZona.producto.marca.nombre;
            dgvProductos.Rows[e.RowIndex].Cells["CANT_UNIDADES"].Value = productoXZona.producto.cantUnidad;
            dgvProductos.Rows[e.RowIndex].Cells["UNIDADES"].Value = productoXZona.producto.unidades;
            dgvProductos.Rows[e.RowIndex].Cells["STOCK"].Value = productoXZona.producto.stock;
        }
    }
}