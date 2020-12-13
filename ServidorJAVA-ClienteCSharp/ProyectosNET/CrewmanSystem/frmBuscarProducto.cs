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
	public partial class frmBuscarProducto : Form
	{
		private static ProductoWS.ProductoWSClient daoProducto;
		public static ProductoWS.producto productoSeleccionado;
		public static DataGridView dgv;
		
		public frmBuscarProducto(int tipo)
		{
			daoProducto = new ProductoWS.ProductoWSClient();
			InitializeComponent();
			dgv = dgvProductos;
			completarTabla();
			//TIPO 0 == BUSCAR
			//TIPO 1 == BUSCAR Y SELECCIONAR
			if (tipo == 0) btnSeleccionar.Visible = false;
			else if (tipo == 1) btnSeleccionar.Visible = true;
			#region colores de seleccion
			dgvProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductos.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductos.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		public void completarTabla()
        {
			dgvProductos.AutoGenerateColumns = false;
			ProductoWS.producto[] listaProductos = daoProducto.listarProductos(txtNombre.Text, txtFamilia.Text, txtSubfamilia.Text, txtMarca.Text);
			if (listaProductos != null)
			{
				dgvProductos.DataSource = new BindingList<ProductoWS.producto>(listaProductos.ToArray());
				lblNotFound.Visible = false;
            }
            else
            {
				dgvProductos.DataSource = new BindingList<ProductoWS.producto>();
				lblNotFound.Visible = true;
			}
		}

		private void dgvProductos_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvProductos.SelectedCells.Count != 1 && dgvProductos.SelectedCells.Count != 0)
			{
				frmVentanaPrincipal.act.Enabled = true;
				frmVentanaPrincipal.elim.Enabled = true;
				return;
			}
			else
			{
				frmVentanaPrincipal.act.Enabled = false;
				frmVentanaPrincipal.elim.Enabled = false;
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
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

        public static void eliminar()
		{
			productoSeleccionado = (ProductoWS.producto)dgv.CurrentRow.DataBoundItem;
			daoProducto.eliminarProducto(productoSeleccionado.idProducto);
		}

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
			if (dgvProductos.CurrentRow.Index < 0)
				return;
			productoSeleccionado = (ProductoWS.producto)dgvProductos.CurrentRow.DataBoundItem;
			this.DialogResult = DialogResult.OK;
		}
    }
}
