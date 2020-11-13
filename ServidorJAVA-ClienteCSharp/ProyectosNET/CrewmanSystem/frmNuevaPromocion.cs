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
        private ProductoXZonaWS.productoXZona miProductoXZona;
        private BindingList<PromocionXProductoWS.promocionXProducto> misPromocionXProducto;

        public frmNuevaPromocion()
		{
			InitializeComponent();
            daoPromocion = new PromocionWS.PromocionWSClient();
            daoZona = new ZonaWS.ZonaWSClient();
            cboZona.DataSource = new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToArray());
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";
            misPromocionXProducto = new BindingList<PromocionXProductoWS.promocionXProducto>();
            dgvPromocionXProducto.AutoGenerateColumns = false;
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

            //Chambon llenar los datos tmr
            //Llenalo no seas flojo tmr oe
            PromocionWS.promocion promocion = new PromocionWS.promocion();
            promocion.nombre = txtNombre.Text;
            promocion.descripcion = txtDescripcion.Text;
            promocion.fechaInicio = dtpFechaInicio.Value;
            promocion.fechaInicioSpecified = true;
            promocion.fechaFin = dtpFechaFin.Value;
            promocion.fechaFinSpecified = true;

            //int idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
            //promocion.zona = cbo
            //promocion.
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            foreach(PromocionXProductoWS.promocionXProducto pXp in misPromocionXProducto)
            {
                if (pXp.producto.idProducto == miProductoXZona.producto.idProducto) return;
            }

            PromocionXProductoWS.promocionXProducto nuevoPromocionXProducto = new PromocionXProductoWS.promocionXProducto();
            nuevoPromocionXProducto.producto = new PromocionXProductoWS.producto();
            nuevoPromocionXProducto.producto.idProducto = miProductoXZona.producto.idProducto;
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
                dgvPromocionXProducto.DataSource = misPromocionXProducto;
            }
            else
            {
                dgvPromocionXProducto.DataSource = new BindingList<ProductoXZonaWS.productoXZona>();
            }
        }

        private void cboZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            misPromocionXProducto = null;
            cargarTablaPromocionXProducto();
        }
    }
}
