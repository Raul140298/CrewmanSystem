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
		private static ProductoXZonaWS.ProductoXZonaWSClient daoProductoXZona;
		private static ZonaWS.ZonaWSClient daoZona;
		public frmBuscarProductoXZona()
		{
			daoProductoXZona = new ProductoXZonaWS.ProductoXZonaWSClient();
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			ZonaWS.zona[] misZonas = daoZona.listarZonas();
			ZonaWS.zona vacio = new ZonaWS.zona();
			vacio.idZona = 0;
			vacio.nombre = "------";
			ZonaWS.zona[] vacioA = { vacio };
			BindingList<ZonaWS.zona> listaZonas;
			if (misZonas == null) listaZonas = new BindingList<ZonaWS.zona>();
			else listaZonas = new BindingList<ZonaWS.zona>(vacioA.Concat(misZonas).ToArray());
			cboZona.DataSource = listaZonas;
			cboZona.ValueMember = "idZona";
			cboZona.DisplayMember = "nombre";
			cboZona.SelectedItem = vacio;
			completarTabla();
			#region colores de seleccion
			dgvProductosXZona.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductosXZona.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductosXZona.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductosXZona.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductosXZona.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductosXZona.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
		private void completarTabla()
		{
			dgvProductosXZona.AutoGenerateColumns = false;
			ProductoXZonaWS.productoXZona[] misProductoXZonas = daoProductoXZona.listarProductosXZonas("", "", "", "", ((ZonaWS.zona)cboZona.SelectedItem).idZona);
			if (misProductoXZonas != null)
			{
				dgvProductosXZona.DataSource = new BindingList<ProductoXZonaWS.productoXZona>(misProductoXZonas.ToArray());
			}
			else
			{
				dgvProductosXZona.DataSource = new BindingList<ProductoXZonaWS.productoXZona>();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			completarTabla();
		}

		private void dgvProductosXZona_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			ProductoXZonaWS.productoXZona productoXZona = dgvProductosXZona.Rows[e.RowIndex].DataBoundItem
			as ProductoXZonaWS.productoXZona;

			dgvProductosXZona.Rows[e.RowIndex].Cells["PRODUCTO"].Value = productoXZona.producto.nombre;
			dgvProductosXZona.Rows[e.RowIndex].Cells["CANT_UNIDADES"].Value = productoXZona.producto.cantUnidad;
			dgvProductosXZona.Rows[e.RowIndex].Cells["UNIDADES"].Value = productoXZona.producto.unidades;
			dgvProductosXZona.Rows[e.RowIndex].Cells["ZONA"].Value = productoXZona.zona.nombre;
			dgvProductosXZona.Rows[e.RowIndex].Cells["SUBFAMILIA"].Value = productoXZona.producto.subFamilia.descripcionSubFamilia;
			dgvProductosXZona.Rows[e.RowIndex].Cells["FAMILIA"].Value = productoXZona.producto.subFamilia.familia.descripcion;
			dgvProductosXZona.Rows[e.RowIndex].Cells["MARCA"].Value = productoXZona.producto.marca.nombre;
		}
		private void dgvProductosXZona_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dgvProductosXZona_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{

        }
    }
}
