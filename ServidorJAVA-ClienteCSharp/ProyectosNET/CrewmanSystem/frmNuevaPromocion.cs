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
        private ProductoXZonaWS.productoXZona miProductoXZona;
        private BindingList<PromocionXProductoWS.promocionXProducto> misPromocionXProducto;

        public frmNuevaPromocion()
		{
			InitializeComponent();
            #region colores de seleccion
            dgvPromocionXProducto.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvPromocionXProducto.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvPromocionXProducto.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvPromocionXProducto.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvPromocionXProducto.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvPromocionXProducto.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion

			daoPromocion = new PromocionWS.PromocionWSClient();
            daoPromocionXProducto = new PromocionXProductoWS.PromocionXProductoWSClient();
            daoZona = new ZonaWS.ZonaWSClient();
            cboZona.DataSource = new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToArray());
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";

            if (frmVentanaPrincipal.nBtn == 1)
            {   //OBTNER DATOS DE FILA SELECCIONADA
                PromocionWS.promocion miPromocion = new PromocionWS.promocion();

                if (Program.pantallas[Program.pantallas.Count - 1].Formulario.Name == "frmGestionarPromociones")
                {
                    frmGestionarPromociones.promocionSeleccionada = (PromocionWS.promocion)frmGestionarPromociones.dgv.CurrentRow.DataBoundItem;
                    miPromocion = frmGestionarPromociones.promocionSeleccionada;
                }
                else
                {
                    frmBuscarPromocion.promocionSeleccionada = (PromocionWS.promocion)frmBuscarPromocion.dgv.CurrentRow.DataBoundItem;
                    miPromocion = frmBuscarPromocion.promocionSeleccionada;
                }
                txtId.Text = miPromocion.idPromocion.ToString();
                txtNombre.Text = miPromocion.nombre;
                txtDescripcion.Text = miPromocion.descripcion;
                dtpFechaInicio.Value = miPromocion.fechaInicio;
                dtpFechaFin.Value = miPromocion.fechaFin;
                cboZona.SelectedValue = miPromocion.zona.idZona;
                //Listar los productos de la promoción.
                txtDescuento.Enabled = false;
                txtStock.Enabled = false;
                btnAddProducto.Enabled = false;
                btnRemoveProducto.Enabled = false;
                btnBuscarProducto.Enabled = false;
                cboZona.Enabled = false;
                int idPromocion = miPromocion.idPromocion;
                PromocionXProductoWS.promocionXProducto[] auxPromoXProd = daoPromocionXProducto.listarPromocionXProducto(idPromocion);
                if (auxPromoXProd.Length == 0) misPromocionXProducto = new BindingList<PromocionXProductoWS.promocionXProducto>();
                else misPromocionXProducto = new BindingList<PromocionXProductoWS.promocionXProducto>(auxPromoXProd.ToList());
                cargarTabla();
            }
            else
            {
                misPromocionXProducto = new BindingList<PromocionXProductoWS.promocionXProducto>();
                cargarTabla();
            }

            #region colores de seleccion
            dgvPromocionXProducto.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvPromocionXProducto.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvPromocionXProducto.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvPromocionXProducto.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvPromocionXProducto.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvPromocionXProducto.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
            #endregion
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            int idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
            frmBuscarProductoPorZona formBusquedaProductoPorZona = new frmBuscarProductoPorZona(1,idZona);
            if(formBusquedaProductoPorZona.ShowDialog() == DialogResult.OK)
            {
                miProductoXZona = frmBuscarProductoPorZona.productoXZonaSeleccionado;
                txtNombreProducto.Text = miProductoXZona.producto.nombre;
                txtPrecioReal.Text = miProductoXZona.precioReal.ToString();
                txtCantUnidades.Text = miProductoXZona.producto.cantUnidad.ToString();
                txtUnidades.Text = miProductoXZona.producto.unidades.ToString();
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
                        MessageBox.Show("Falta llenar los datos de " +textBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Falta llenar los datos de " + cmbBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (dtpFechaFin.Value < DateTime.Now)
            {
                MessageBox.Show("Fecha final de la promocion invalida", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("Rango de fechas invalido","Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (misPromocionXProducto == null || misPromocionXProducto.Count==0)
            {
                MessageBox.Show("Falta agregar los productos de la promocion",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
                    promocion.listaPromocionXProducto[cont].precioReal=
                        ((PromocionXProductoWS.promocionXProducto)misPromocionXProducto.ElementAt(cont)).precioReal;
                    promocion.listaPromocionXProducto[cont].descuento =
                        ((PromocionXProductoWS.promocionXProducto)misPromocionXProducto.ElementAt(cont)).descuento;
                    promocion.listaPromocionXProducto[cont].stock =
                        ((PromocionXProductoWS.promocionXProducto)misPromocionXProducto.ElementAt(cont)).stock;
                }
                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoPromocion.insertarPromocion(promocion);
                    txtId.Text = resultado.ToString();
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ((frmGestionarPromociones)Program.pantallas[Program.pantallas.Count - 2].Formulario).recargarDGV();
                        MessageBox.Show("Se insertó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (frmVentanaPrincipal.nBtn == 1)
                {
                    promocion.idPromocion = Int32.Parse(txtId.Text);
                    int resultado = daoPromocion.actualizarPromocion(promocion);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se actualizó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ((frmGestionarPromociones)Program.pantallas[Program.pantallas.Count - 2].Formulario).recargarDGV();
                        MessageBox.Show("Se actualizó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            if(txtNombreProducto.Text == "")
            {
                MessageBox.Show("Debe escoger un producto", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try{
                int descuento = Convert.ToInt32(txtDescuento.Text);
            }
            catch (Exception){
                MessageBox.Show("Los datos de " + txtDescuento.Name.Substring(3) + " solo pueden contener dígitos", 
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try{
                int stock = Convert.ToInt32(txtStock.Text);
            }
            catch (Exception){
                MessageBox.Show("Los datos de " +
                    txtStock.Name.Substring(3) + " solo pueden contener dígitos", 
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(txtDescuento) <= 0)
            {
                MessageBox.Show("Descuento invalido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(txtStock) <= 0)
            {
                MessageBox.Show("Stock invalido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            nuevoPromocionXProducto.producto.cantUnidad = miProductoXZona.producto.cantUnidad;
            nuevoPromocionXProducto.producto.unidades = miProductoXZona.producto.unidades;
            nuevoPromocionXProducto.precioReal = miProductoXZona.precioReal;
            nuevoPromocionXProducto.descuento = Convert.ToInt32(txtDescuento.Text);
            nuevoPromocionXProducto.stock = Convert.ToInt32(txtStock.Text);

            misPromocionXProducto.Add(nuevoPromocionXProducto);
            txtDescuento.Text = "";
            txtStock.Text = "";
            txtPrecioReal.Text = "";
            txtUnidades.Text = "";
            txtCantUnidades.Text = "";
            txtNombreProducto.Text = "";
        }

        private void btnRemoveProducto_Click(object sender, EventArgs e)
        {
            if (dgvPromocionXProducto.CurrentRow == null || dgvPromocionXProducto.CurrentRow.Index < 0)
            {
                return;
            }
            frmConfirmarEliminar formEliminar = new frmConfirmarEliminar();
            if (formEliminar.ShowDialog() == DialogResult.OK)
            {
                int indice = dgvPromocionXProducto.CurrentRow.Index;
                misPromocionXProducto.RemoveAt(indice);
            }
        }

        private void cargarTabla()
        {
            dgvPromocionXProducto.DataSource = null;
            dgvPromocionXProducto.AutoGenerateColumns = false;
            dgvPromocionXProducto.DataSource = misPromocionXProducto;
        }

        private void cboZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            misPromocionXProducto = new BindingList<PromocionXProductoWS.promocionXProducto>();
            cargarTabla();
        }

        private void dgvPromocionXProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                PromocionXProductoWS.promocionXProducto p = dgvPromocionXProducto.Rows[e.RowIndex].DataBoundItem
                as PromocionXProductoWS.promocionXProducto;

                dgvPromocionXProducto.Rows[e.RowIndex].Cells["NRO"].Value = e.RowIndex + 1;
                dgvPromocionXProducto.Rows[e.RowIndex].Cells["NOMBRE_PRODUCTO"].Value = p.producto.nombre;
                dgvPromocionXProducto.Rows[e.RowIndex].Cells["CANT_UNIDADES"].Value = p.producto.cantUnidad;
                dgvPromocionXProducto.Rows[e.RowIndex].Cells["UNIDADES"].Value = p.producto.unidades;
            }
            catch (Exception)
            {

            }
        }
    }
}
