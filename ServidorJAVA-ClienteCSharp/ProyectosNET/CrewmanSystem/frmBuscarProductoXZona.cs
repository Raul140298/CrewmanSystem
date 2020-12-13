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
		private ProductoXZonaWS.productoXZona[] misProductoXZonas;
		public frmBuscarProductoXZona()
		{
			daoProductosXZona = new ProductoXZonaWS.ProductoXZonaWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			ZonaWS.zona[] misZonas = daoZona.listarZonas();
			ZonaWS.zona vacio = new ZonaWS.zona();
			vacio.idZona = 0;
			vacio.nombre = "Cualquiera";
			ZonaWS.zona[] vacioA = { vacio };
			BindingList<ZonaWS.zona> listaZonas;
			if (misZonas != null) listaZonas = new BindingList<ZonaWS.zona>(vacioA.Concat(misZonas).ToArray());
			else listaZonas = new BindingList<ZonaWS.zona>(vacioA);
		
			cboZona.DataSource = listaZonas;
			cboZona.ValueMember = "idZona";
			cboZona.DisplayMember = "nombre";

            if (Program.empleado.cargo.nombre == "VENDEDOR") 
			{
				cboZona.SelectedValue = Program.empleado.zona.idZona;
				cboZona.Enabled = false;
			}
			else
				cboZona.SelectedItem = vacio;
			
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

		public void completarTabla()
        {
			dgvProductoXZona.AutoGenerateColumns = false;
			int idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;

			misProductoXZonas = daoProductosXZona.listarProductosXZonas(txtNombre.Text,txtFamilia.Text,txtSubfamilia.Text,txtMarca.Text,idZona);

			if (misProductoXZonas != null)
			{
				dgvProductoXZona.DataSource = new BindingList<ProductoXZonaWS.productoXZona>(misProductoXZonas);
				lblNotFound.Visible = false;
			}
			else
			{
				dgvProductoXZona.DataSource = new BindingList<ProductoXZonaWS.productoXZona>();
				lblNotFound.Visible = true;
			}
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
