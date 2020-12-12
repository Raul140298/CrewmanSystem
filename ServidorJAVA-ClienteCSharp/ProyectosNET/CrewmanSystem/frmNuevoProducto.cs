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
                cboFamilia.DataSource = new BindingList<FamiliaWS.familia>(misFamilias);
            else
                cboFamilia.DataSource = new BindingList<FamiliaWS.familia>();
            cboFamilia.ValueMember = "idFamilia";
            cboFamilia.DisplayMember = "descripcion";
            txtStockReservado.Text = 0.ToString();

            if (frmVentanaPrincipal.nBtn == 1)
            {   //OBTNER DATOS DE FILA SELECCIONADA
                ProductoWS.producto miProducto = new ProductoWS.producto();

                if (Program.pantallas[Program.pantallas.Count - 1].Formulario.Name == "frmGestionarProductos")
                {
                    frmGestionarProductos.productoSeleccionado = (ProductoWS.producto)frmGestionarProductos.dgv.CurrentRow.DataBoundItem;
                    miProducto = frmGestionarProductos.productoSeleccionado;
                }
                else
                {
                    frmBuscarProducto.productoSeleccionado = (ProductoWS.producto)frmBuscarProducto.dgv.CurrentRow.DataBoundItem;
                    miProducto = frmBuscarProducto.productoSeleccionado;
                }
                txtId.Text = miProducto.idProducto.ToString();
                txtNombre.Text = miProducto.nombre;
                cboFamilia.SelectedValue = miProducto.subFamilia.familia.idFamilia;
                cboSubfamilia.SelectedValue = miProducto.subFamilia.idSubFamilia;
                cboMarca.SelectedValue = miProducto.marca.idMarca;
                cboUnidades.SelectedItem = miProducto.unidades;
                txtCantidad.Text = miProducto.cantUnidad.ToString();
                txtPrecioSugerido.Text = miProducto.precioSugerido.ToString();
                txtStock.Text = miProducto.stock.ToString();
                txtStockReservado.Text = miProducto.stockReservado.ToString();

                cboFamilia.Enabled = false;
                cboSubfamilia.Enabled = false;
                cboMarca.Enabled = false;
                txtStockReservado.Enabled = false;
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
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3), 
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (textBox == txtNombre)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " + textBox.Name.Substring(3) + " solo pueden contener letras",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                MessageBox.Show("Los datos de " + textBox.Name.Substring(3) + " solo pueden contener dígitos",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        if(textBox == txtStock)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " + textBox.Name.Substring(3) + " solo pueden contener dígitos",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Falta llenar los datos de " + cmbBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
