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
    public partial class frmBuscarProducto_V2 : Form
    {
        private static ProductoWS.ProductoWSClient daoProducto;
        public static ProductoWS.producto productoSeleccionado;

        public frmBuscarProducto_V2()
        {
			daoProducto = new ProductoWS.ProductoWSClient();
			InitializeComponent();
			completarTabla();
			#region colores de seleccion
			dgvProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductos.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductos.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		public ProductoWS.producto ProductoSeleccionado
		{ get => productoSeleccionado; set => productoSeleccionado = value; }

		private void completarTabla()
		{
			dgvProductos.AutoGenerateColumns = false;
			ProductoWS.producto[] listaProductos = daoProducto.listarProductos(txtNombre.Text, txtFamilia.Text, txtSubfamilia.Text, txtMarca.Text);
			BindingList<ProductoWS.producto> misProductos = new BindingList<ProductoWS.producto>();
			if (listaProductos != null)
				misProductos = new BindingList<ProductoWS.producto>(listaProductos.ToArray());
			dgvProductos.DataSource = misProductos;
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
			if (dgvProductos.CurrentRow.Index < 0)
			{
				return;
			}
			productoSeleccionado = (ProductoWS.producto)dgvProductos.CurrentRow.DataBoundItem;
			this.DialogResult = DialogResult.OK;
		}

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			//Castear objetos y mostrar valor determinado
			ProductoWS.producto producto = dgvProductos.Rows[e.RowIndex].DataBoundItem
											as ProductoWS.producto;

			dgvProductos.Rows[e.RowIndex].Cells["SUBFAMILIA"].Value = producto.subFamilia.descripcionSubFamilia;

			dgvProductos.Rows[e.RowIndex].Cells["FAMILIA"].Value = producto.subFamilia.familia.descripcion;

			dgvProductos.Rows[e.RowIndex].Cells["MARCA"].Value = producto.marca.nombre;
		}
    }
}
