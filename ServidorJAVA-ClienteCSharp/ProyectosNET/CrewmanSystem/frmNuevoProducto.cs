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
	public partial class frmNuevoProducto : Form
	{
        ProductoWS.ProductoWSClient daoProducto;
        FamiliaWS.FamiliaWSClient daoFamilia;
        SubFamiliaWS.SubFamiliaWSClient daoSubfamilia;
        MarcaWS.MarcaWSClient daoMarca;
        string[] unidades = {"gr","ml"};
        public frmNuevoProducto()
		{
			InitializeComponent();

            daoFamilia = new FamiliaWS.FamiliaWSClient();
            daoSubfamilia = new SubFamiliaWS.SubFamiliaWSClient();
            daoProducto = new ProductoWS.ProductoWSClient();
            daoMarca = new MarcaWS.MarcaWSClient();
            cboMarca.DataSource = new BindingList<MarcaWS.marca>(daoMarca.listarMarcas().ToArray());
            cboMarca.ValueMember = "idMarca";
            cboMarca.DisplayMember = "nombre";
            FamiliaWS.familia[] misFamilias = daoFamilia.listarFamilias();
            cboUnidades.DataSource = unidades;
            if (misFamilias != null)
            {
                cboFamilia.DataSource = new BindingList<FamiliaWS.familia>(misFamilias.ToArray());
                cboFamilia.ValueMember = "idFamilia";
                cboFamilia.DisplayMember = "descripcion";
                
            }
            if (frmVentanaPrincipal.nBtn == 1)
            {   //OBTNER DATOS DE FILA SELECCIONADA
                if (Program.pantallas[Program.pantallas.Count-1].Formulario.Name == "frmGestionarProductos")
                {
                    frmGestionarProductos.productoSeleccionado = (ProductoWS.producto)frmGestionarProductos.dgv.CurrentRow.DataBoundItem;
                    txtId.Text = frmGestionarProductos.productoSeleccionado.idProducto.ToString();
                    txtNombre.Text = frmGestionarProductos.productoSeleccionado.nombre;
                    cboFamilia.SelectedValue = frmGestionarProductos.productoSeleccionado.subFamilia.familia.idFamilia;
                    cboSubfamilia.SelectedValue = frmGestionarProductos.productoSeleccionado.subFamilia.idSubFamilia;
                    cboMarca.SelectedValue = frmGestionarProductos.productoSeleccionado.marca.idMarca;
                    cboUnidades.SelectedItem = frmGestionarProductos.productoSeleccionado.unidades;
                    txtCantidad.Text = frmGestionarProductos.productoSeleccionado.cantUnidad.ToString();
                    txtPrecioSugerido.Text = frmGestionarProductos.productoSeleccionado.precioSugerido.ToString();
                    txtStock.Text = frmGestionarProductos.productoSeleccionado.stock.ToString();

                    cboFamilia.Enabled = false;
                    cboSubfamilia.Enabled = false;
                    cboMarca.Enabled = false;
                }
                else
                {
                    frmBuscarProducto.productoSeleccionado = (ProductoWS.producto)frmBuscarProducto.dgv.CurrentRow.DataBoundItem;
                    txtId.Text = frmBuscarProducto.productoSeleccionado.idProducto.ToString();
                    txtNombre.Text = frmBuscarProducto.productoSeleccionado.nombre;
                    cboFamilia.SelectedValue = frmBuscarProducto.productoSeleccionado.subFamilia.familia.idFamilia;
                    cboSubfamilia.SelectedValue = frmBuscarProducto.productoSeleccionado.subFamilia.idSubFamilia;
                    cboMarca.SelectedValue = frmBuscarProducto.productoSeleccionado.marca.idMarca;
                    txtCantidad.Text = frmBuscarProducto.productoSeleccionado.cantUnidad.ToString();
                    txtPrecioSugerido.Text = frmBuscarProducto.productoSeleccionado.precioSugerido.ToString();
                    txtStock.Text = frmBuscarProducto.productoSeleccionado.stock.ToString();
                }
            }
        }

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtId")
                    {
                        MessageBox.Show("Falta llenar los datos de " + 
                            textBox.Name.Substring(3));
                        return;
                    }
                    else
                    {
                        if (textBox == txtNombre)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " solo pueden contener letras");
                                return;
                            }
                        }
                        if (textBox == txtPrecioSugerido)
                        {
                            try{
                                double precio = Convert.ToDouble(textBox.Text);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " solo pueden contener dígitos");
                                return;
                            }
                        }
                        if(textBox == txtStock)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " solo pueden contener dígitos");
                                return;
                            }
                        }
                    }
                }
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
            //AQUI VA EL INSERTAR
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                ProductoWS.producto producto = new ProductoWS.producto();
                producto.nombre = txtNombre.Text;
                producto.precioSugerido = float.Parse(txtPrecioSugerido.Text);
                producto.subFamilia = new ProductoWS.subFamilia();
                producto.subFamilia.idSubFamilia = ((SubFamiliaWS.subFamilia)cboSubfamilia.SelectedItem).idSubFamilia;
                producto.marca = new ProductoWS.marca();
                producto.marca.idMarca = ((MarcaWS.marca)cboMarca.SelectedItem).idMarca;
                producto.unidades = cboUnidades.SelectedItem.ToString();
                producto.cantUnidad = Convert.ToDouble(txtCantidad.Text);
                producto.stock = Convert.ToInt32(txtStock.Text);
                //Usar resultado para ver si se inserto correctamente
                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoProducto.insertarProducto(producto);
                    txtId.Text = resultado.ToString();
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se insertó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (frmVentanaPrincipal.nBtn == 1)
                {
                    producto.idProducto = Int32.Parse(txtId.Text);
                    producto.stockReservado = frmGestionarProductos.productoSeleccionado.stockReservado;
                    int resultado = daoProducto.actualizarProducto(producto);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se actualizó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Se actualizó correctamente", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

		private void cboFamilia_SelectedIndexChanged(object sender, EventArgs e)
		{
            SubFamiliaWS.subFamilia[] misSubfamilias = daoSubfamilia.listarSubFamilias(((FamiliaWS.familia)cboFamilia.SelectedItem).descripcion);
            if (misSubfamilias != null)
            {
                cboSubfamilia.Enabled = true;
                btnGuardar.Enabled = true;
                cboSubfamilia.DataSource = new BindingList<SubFamiliaWS.subFamilia>(misSubfamilias.ToArray());
                cboSubfamilia.ValueMember = "idSubFamilia";
                cboSubfamilia.DisplayMember = "descripcionSubFamilia";
            }
            else
            {
                cboSubfamilia.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }
	}
}
