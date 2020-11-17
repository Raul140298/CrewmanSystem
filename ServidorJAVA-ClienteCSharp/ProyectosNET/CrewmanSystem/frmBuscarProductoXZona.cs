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
	public partial class frmBuscarProductoXZona : Form
	{
		private ProductoXZonaWS.ProductoXZonaWSClient daoProductosXZona;
		private ZonaWS.ZonaWSClient daoZona;
		public frmBuscarProductoXZona()
		{
			daoProductosXZona = new ProductoXZonaWS.ProductoXZonaWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			ZonaWS.zona[] misZonas = daoZona.listarZonas();
			BindingList<ZonaWS.zona> listaZonas;
			if (misZonas != null) listaZonas = new BindingList<ZonaWS.zona>(misZonas);
			else listaZonas = new BindingList<ZonaWS.zona>();
		
			cboZona.DataSource = listaZonas;
			cboZona.ValueMember = "idZona";
			cboZona.DisplayMember = "nombre";

			cboZona.SelectedValue = Program.empleado.zona.idZona;
			completarTabla();
			#region colores de seleccion
			dgvProductoXZona.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductoXZona.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductoXZona.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductoXZona.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductoXZona.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductoXZona.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void completarTabla()
        {
			int idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
			ProductoXZonaWS.productoXZona[] productoXZonas = 
				daoProductosXZona.listarProductosXZonas(txtNombre.Text,txtFamilia.Text,txtSubfamilia.Text,txtMarca.Text,idZona);
			BindingList<ProductoXZonaWS.productoXZona> listaProductoXZona;

			if (productoXZonas == null || productoXZonas.Length < 1) listaProductoXZona =
					new BindingList<ProductoXZonaWS.productoXZona>();
			else listaProductoXZona = new BindingList<ProductoXZonaWS.productoXZona>(productoXZonas);

			dgvProductoXZona.AutoGenerateColumns = false;
			dgvProductoXZona.DataSource = listaProductoXZona;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			completarTabla();
		}

        private void dgvProductoXZona_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			ProductoXZonaWS.productoXZona productoXZona = dgvProductoXZona.Rows[e.RowIndex].DataBoundItem
			as ProductoXZonaWS.productoXZona;

			dgvProductoXZona.Rows[e.RowIndex].Cells["PRODUCTO"].Value = productoXZona.producto.nombre;
			dgvProductoXZona.Rows[e.RowIndex].Cells["CANT_UNIDADES"].Value = productoXZona.producto.cantUnidad;
			dgvProductoXZona.Rows[e.RowIndex].Cells["UNIDADES"].Value = productoXZona.producto.unidades;
			dgvProductoXZona.Rows[e.RowIndex].Cells["ZONA"].Value = productoXZona.zona.nombre;
			dgvProductoXZona.Rows[e.RowIndex].Cells["SUBFAMILIA"].Value = productoXZona.producto.subFamilia.descripcionSubFamilia;
			dgvProductoXZona.Rows[e.RowIndex].Cells["FAMILIA"].Value = productoXZona.producto.subFamilia.familia.descripcion;
			dgvProductoXZona.Rows[e.RowIndex].Cells["MARCA"].Value = productoXZona.producto.marca.nombre;
		}
    }
}
