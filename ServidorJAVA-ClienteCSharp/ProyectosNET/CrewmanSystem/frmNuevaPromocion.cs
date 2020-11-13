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
	public partial class frmNuevaPromocion : Form
	{
        private ZonaWS.ZonaWSClient daoZona;
        private PromocionWS.PromocionWSClient daoPromocion;
        private PromocionXProductoWS.PromocionXProductoWSClient daoPromocionXProducto;
        private PromocionXZonaWS.PromocionXZonaWSClient daoPromocionXZona;
        private ProductoXZonaWS.productoXZona miProductoXZona;
        private BindingList<PromocionXProductoWS.promocionXProducto> misPromocionXProducto;

        public frmNuevaPromocion()
		{
			InitializeComponent();
            daoPromocion = new PromocionWS.PromocionWSClient();
            daoPromocionXProducto = new PromocionXProductoWS.PromocionXProductoWSClient();
            daoPromocionXZona = new PromocionXZonaWS.PromocionXZonaWSClient();
            daoZona = new ZonaWS.ZonaWSClient();
            cboZona.DataSource = new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToArray());
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";
            misPromocionXProducto = new BindingList<PromocionXProductoWS.promocionXProducto>();
            cargarTablaPromocionXProducto();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            int idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
            frmBuscarProductoPorZona formBusquedaProductoPorZona = new frmBuscarProductoPorZona(idZona);
            if(formBusquedaProductoPorZona.ShowDialog() == DialogResult.OK)
            {
                miProductoXZona = formBusquedaProductoPorZona.ProductoXZonaSeleccionado;
                txtNombreProducto.Text = miProductoXZona.producto.nombre;
                txtPrecioReal.Text = miProductoXZona.precioReal.ToString();
            }
        }

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtId")
                    {
                        MessageBox.Show("Falta llenar los datos de " +
                            textBox.Name.Substring(3) + " de " + groupBox1.Text);
                        return;
                    }
                }
            }

            foreach (Control c in groupBox2.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox cmbBox = c as ComboBox;
                    if (cmbBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Falta llenar los datos de " +
                            cmbBox.Name.Substring(3));
                        return;
                    }
                }
            }

            if (misPromocionXProducto == null)
            {
                MessageBox.Show("Falta agregar los productos de la promocion");
                return;
            }

            //Este foreach no se deberia usar
            //foreach (Control c in groupBox3.Controls)
            {
                //if (c is TextBox)
                //{
                //    TextBox textBox = c as TextBox;
                //    if (textBox.Text == string.Empty && textBox.Name != "txtId")
                //    {
                //        MessageBox.Show("Falta llenar los datos de " +
                //            textBox.Name.Substring(3) + " de " + groupBox3.Text);
                //        return;
                //    }
                //    else
                //    {
                //        if (textBox == txtDescuento)
                //        {
                //            try
                //            {
                //                double resultado = Convert.ToDouble(txtDescuento.Text);
                //            }
                //            catch (Exception)
                //            {
                //                return;
                //            }
                //        }
                //        if (textBox == txtStock)
                //        {
                //            try
                //            {
                //                int resultado = Convert.ToInt32(txtDescuento.Text);
                //            }
                //            catch (Exception)
                //            {
                //                return;
                //            }
                //        }

                //    }
                //}
            }

            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                PromocionWS.promocion promocion = new PromocionWS.promocion();
                promocion.zona = new PromocionWS.zona();
                promocion.zona.idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
                promocion.nombre = txtNombre.Text;
                promocion.descripcion = txtDescripcion.Text;
                promocion.fechaInicio = dtpFechaInicio.Value;
                promocion.fechaInicioSpecified = true;
                promocion.fechaFin = dtpFechaFin.Value;
                promocion.fechaFinSpecified = true;

                int numPromocionXProducto = misPromocionXProducto.Count;
                promocion.listaPromocionXProducto = new PromocionWS.promocionXProducto[numPromocionXProducto];
                for (int cont = 0; cont<numPromocionXProducto; cont++)
                {
                    promocion.listaPromocionXProducto[cont] = new PromocionWS.promocionXProducto(); 
                    promocion.listaPromocionXProducto[cont].producto = new PromocionWS.producto();
                    promocion.listaPromocionXProducto[cont].producto.idProducto =
                        ((PromocionXProductoWS.promocionXProducto)misPromocionXProducto.ElementAt(cont)).producto.idProducto;
                    promocion.listaPromocionXProducto[cont].descuento =
                        ((PromocionXProductoWS.promocionXProducto)misPromocionXProducto.ElementAt(cont)).descuento;
                    promocion.listaPromocionXProducto[cont].stock =
                        ((PromocionXProductoWS.promocionXProducto)misPromocionXProducto.ElementAt(cont)).stock;
                }
                int idPromocion = daoPromocion.insertarPromocion(promocion);
                txtId.Text = idPromocion.ToString();
            }
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            try{
                int descuento = Convert.ToInt32(txtDescuento.Text);
            }
            catch (Exception){
                MessageBox.Show("Los datos de " +
                    txtDescuento.Name.Substring(3) + " solo pueden contener dígitos");
                return;
            }
            try{
                int stock = Convert.ToInt32(txtStock.Text);
            }
            catch (Exception){
                MessageBox.Show("Los datos de " +
                    txtStock.Name.Substring(3) + " solo pueden contener dígitos");
                return;
            }

            foreach (PromocionXProductoWS.promocionXProducto pXp in misPromocionXProducto)
            {
                if (pXp.producto.idProducto == miProductoXZona.producto.idProducto) return;
            }

            PromocionXProductoWS.promocionXProducto nuevoPromocionXProducto = new PromocionXProductoWS.promocionXProducto();
            nuevoPromocionXProducto.producto = new PromocionXProductoWS.producto();
            nuevoPromocionXProducto.producto.idProducto = miProductoXZona.producto.idProducto;
            nuevoPromocionXProducto.producto.nombre = miProductoXZona.producto.nombre;
            nuevoPromocionXProducto.descuento = Convert.ToInt32(txtDescuento.Text);
            nuevoPromocionXProducto.stock = Convert.ToInt32(txtStock.Text);

            misPromocionXProducto.Add(nuevoPromocionXProducto);
            cargarTablaPromocionXProducto();
            txtDescuento.Text = "";
            txtStock.Text = "";
        }

        private void btnRemoveProducto_Click(object sender, EventArgs e)
        {
            int indice = dgvPromocionXProducto.CurrentRow.Index;
            misPromocionXProducto.RemoveAt(indice);
            cargarTablaPromocionXProducto();
        }

        private void cargarTablaPromocionXProducto()
        {
            if (misPromocionXProducto != null)
            {
                dgvPromocionXProducto.AutoGenerateColumns = false;
                dgvPromocionXProducto.DataSource = misPromocionXProducto;
            }
            else
            {
                dgvPromocionXProducto.AutoGenerateColumns = false;
                dgvPromocionXProducto.DataSource = new BindingList<ProductoXZonaWS.productoXZona>();
            }
        }

        private void cboZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            misPromocionXProducto = new BindingList<PromocionXProductoWS.promocionXProducto>();
            cargarTablaPromocionXProducto();
        }

        private void dgvPromocionXProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PromocionXProductoWS.promocionXProducto pxp = dgvPromocionXProducto.Rows[e.RowIndex].DataBoundItem
            as PromocionXProductoWS.promocionXProducto;

            dgvPromocionXProducto.Rows[e.RowIndex].Cells["NRO"].Value = e.RowIndex+1;
            dgvPromocionXProducto.Rows[e.RowIndex].Cells["NOMBRE_PRODUCTO"].Value = pxp.producto.nombre;
        }
    }
}
