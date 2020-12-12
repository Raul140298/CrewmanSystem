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
    public partial class frmNuevoProductoXZona : Form
    {
        private ProductoXZonaWS.ProductoXZonaWSClient daoProductoXZona;
        private BindingList<ProductoXZonaWS.productoXZona> misProductoXZona;
        private ProductoWS.producto miProducto;
        private ZonaWS.ZonaWSClient daoZona;

        public frmNuevoProductoXZona()
        {
            daoProductoXZona = new ProductoXZonaWS.ProductoXZonaWSClient();
            daoZona = new ZonaWS.ZonaWSClient();
            InitializeComponent();
            ZonaWS.zona[] misZonas = daoZona.listarZonas();
            BindingList<ZonaWS.zona> listaZonas;
            if (misZonas == null) listaZonas = new BindingList<ZonaWS.zona>();
            else listaZonas = new BindingList<ZonaWS.zona>(misZonas.ToArray());
            cboZona.DataSource = listaZonas;
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";
            txtNombreProducto.Enabled = false;
            txtCantUnidades.Enabled = false;
            txtPrecioSugerido.Enabled = false;
            txtUnidades.Enabled = false;
            misProductoXZona = new BindingList<ProductoXZonaWS.productoXZona>();
            cargarTabla();

            #region colores de seleccion
            dgvProducto.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProducto.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvProducto.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProducto.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvProducto.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProducto.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
            #endregion
        }

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            frmBuscarProducto formBusquedaProducto = new frmBuscarProducto(1);
            if (formBusquedaProducto.ShowDialog() == DialogResult.OK)
            {
                miProducto = frmBuscarProducto.productoSeleccionado;
                txtNombreProducto.Text = miProducto.nombre;
                txtCantUnidades.Text = miProducto.cantUnidad.ToString();
                txtUnidades.Text = miProducto.unidades;
                txtPrecioSugerido.Text = miProducto.precioSugerido.ToString();
            }
        }

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            if (cboZona.SelectedIndex==-1)
            {
                MessageBox.Show("Falta escoger el dato de " + cboZona.Name.Substring(3),
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            if(misProductoXZona==null || misProductoXZona.Count == 0)
            {
                MessageBox.Show("Falta agregar los productos de la zona",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //COPIAR LNEAS 135 DE NUEVA PROMOCION
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                int numProductos = misProductoXZona.Count();
                for(int i = 0; i < numProductos; i++)
                {
                    ProductoXZonaWS.productoXZona pxz = new ProductoXZonaWS.productoXZona();
                    pxz.producto = new ProductoXZonaWS.producto();
                    pxz.producto.idProducto = ((ProductoXZonaWS.productoXZona)misProductoXZona.ElementAt(i)).producto.idProducto;
                    pxz.zona = new ProductoXZonaWS.zona();
                    pxz.zona.idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
                    pxz.precioReal = ((ProductoXZonaWS.productoXZona)misProductoXZona.ElementAt(i)).precioReal;

                    int resultado = daoProductoXZona.insertarProductoXZona(pxz);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                ((frmGestionarProductosXZona)Program.pantallas[Program.pantallas.Count - 2].Formulario).recargarDGV();
                MessageBox.Show("Se insertó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "")
            {
                MessageBox.Show("Debe escoger un producto", 
                    "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                double precio= Convert.ToDouble(txtPrecioReal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos de " + txtPrecioReal.Name.Substring(3) + " solo pueden contener dígitos",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            foreach (ProductoXZonaWS.productoXZona pXz in misProductoXZona)
            {
                if (pXz.producto.idProducto == miProducto.idProducto) return;
            }

            ProductoXZonaWS.productoXZona nuevoProductoXZona = new ProductoXZonaWS.productoXZona();
            nuevoProductoXZona.producto = new ProductoXZonaWS.producto();
            nuevoProductoXZona.producto.idProducto = miProducto.idProducto;
            nuevoProductoXZona.producto.nombre = miProducto.nombre;
            nuevoProductoXZona.producto.cantUnidad = miProducto.cantUnidad;
            nuevoProductoXZona.producto.unidades = miProducto.unidades;
            nuevoProductoXZona.precioReal = Convert.ToDouble(txtPrecioReal.Text); 

            misProductoXZona.Add(nuevoProductoXZona);
            txtNombreProducto.Text = "";
            txtPrecioReal.Text = "";
            txtUnidades.Text = "";
            txtCantUnidades.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioSugerido.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProducto.CurrentRow == null || dgvProducto.CurrentRow.Index < 0)
            {
                return;
            }
            frmConfirmarEliminar formEliminar = new frmConfirmarEliminar();
            if (formEliminar.ShowDialog() == DialogResult.OK)
            {
                int indice = dgvProducto.CurrentRow.Index;
                misProductoXZona.RemoveAt(indice);
            }
        }

        private void cargarTabla()
        {
            dgvProducto.AutoGenerateColumns = false;
            dgvProducto.DataSource = misProductoXZona;
        }

        private void dgvProductoXZona_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                ProductoXZonaWS.productoXZona pxz = dgvProducto.Rows[e.RowIndex].DataBoundItem
                as ProductoXZonaWS.productoXZona;

                dgvProducto.Rows[e.RowIndex].Cells["NRO"].Value = e.RowIndex + 1;
                dgvProducto.Rows[e.RowIndex].Cells["PRODUCTO"].Value = pxz.producto.nombre;
                dgvProducto.Rows[e.RowIndex].Cells["CANT_UNIDADES"].Value = pxz.producto.cantUnidad;
                dgvProducto.Rows[e.RowIndex].Cells["UNIDADES"].Value = pxz.producto.unidades;
            }
            catch (Exception)
            {

            }
        }
    }
}
