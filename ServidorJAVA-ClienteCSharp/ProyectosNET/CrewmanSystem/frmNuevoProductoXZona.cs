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
        }

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            frmBuscarProducto formBusquedaProducto = new frmBuscarProducto();
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
                    "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cargarTabla();
            txtNombreProducto.Text = "";
            txtPrecioReal.Text = "";
            txtUnidades.Text = "";
            txtCantUnidades.Text = "";
            txtNombreProducto.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProductoXZona.CurrentRow == null || dgvProductoXZona.CurrentRow.Index < 0)
            {
                return;
            }
            int indice = dgvProductoXZona.CurrentRow.Index;
            misProductoXZona.RemoveAt(indice);
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvProductoXZona.AutoGenerateColumns = false;
            dgvProductoXZona.DataSource = misProductoXZona;
        }

        private void cboZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            misProductoXZona = new BindingList<ProductoXZonaWS.productoXZona>();
            cargarTabla();
        }

        private void dgvProductoXZona_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProductoXZonaWS.productoXZona pxz = dgvProductoXZona.Rows[e.RowIndex].DataBoundItem
                as ProductoXZonaWS.productoXZona;

            dgvProductoXZona.Rows[e.RowIndex].Cells["NRO"].Value = e.RowIndex + 1;
            dgvProductoXZona.Rows[e.RowIndex].Cells["ZONA"].Value = pxz.zona.nombre;
        }
    }
}
