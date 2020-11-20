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
	public partial class frmNuevoCliente : Form
	{
        ClienteWS.ClienteWSClient daoCliente = new ClienteWS.ClienteWSClient();
        PersonaContactoWS.PersonaContactoWSClient daoPersonaContacto = new PersonaContactoWS.PersonaContactoWSClient();
        ZonaWS.ZonaWSClient daoZona = new ZonaWS.ZonaWSClient();
        

		public frmNuevoCliente()
		{
			InitializeComponent();
            cboZona.DataSource = new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToArray());
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";

            ClienteWS.cliente miCliente = new ClienteWS.cliente();
            if (frmVentanaPrincipal.nBtn == 1)
            {
                //OBTNER DATOS DE FILA SELECCIONADA
                if (Program.pantallas[Program.pantallas.Count - 1].Formulario.Name == "frmGestionarClientes")
                {
                    frmGestionarClientes.clienteSeleccionado = (ClienteWS.cliente)frmGestionarClientes.dgv.CurrentRow.DataBoundItem;
                    miCliente = frmGestionarClientes.clienteSeleccionado;
                }
                else
                {
                    frmBuscarCliente.clienteSeleccionado = (ClienteWS.cliente)frmBuscarCliente.dgv.CurrentRow.DataBoundItem;
                    miCliente = frmBuscarCliente.clienteSeleccionado;
                }

                txtIdC.Text = miCliente.idCliente.ToString();
                txtRuc.Text = miCliente.ruc.ToString();
                txtRazonSocial.Text = miCliente.razonSocial;
                txtGrupo.Text = miCliente.grupo;
                txtDireccion.Text = miCliente.direccion;
                cboZona.SelectedValue = miCliente.zona.idZona;
                dtpFechaInicio.Value = miCliente.fechaRegistro;

                //PERSONA CONTACTO
                PersonaContactoWS.personaContacto personaC = new PersonaContactoWS.personaContacto();

                personaC.idPersonaContacto = miCliente.personaContacto.idPersonaContacto;
                personaC = daoPersonaContacto.mostrarPersonaContacto(personaC.idPersonaContacto);

                txtIdPC.Text = personaC.idPersonaContacto.ToString();
                txtDNI.Text = personaC.dni.ToString();
                txtNombre.Text = personaC.nombre;
                txtApMaterno.Text = personaC.apellidoMaterno;
                txtApPaterno.Text = personaC.apellidoPaterno;
                txtTelefono1.Text = personaC.telefono1.ToString();
                txtTelefono2.Text = personaC.telefono2.ToString();
                txtCorreo.Text = personaC.correo.ToString();
                txtRuc.Enabled = false;
                txtDNI.Enabled = false;
            }
        }

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtIdC")
                    {
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (textBox == txtRuc)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " + textBox.Name.Substring(3) + " solo pueden contener dígitos",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        if (textBox == txtGrupo)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.Trim().All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " +textBox.Name.Substring(3) + " solo pueden contener letras",
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
                        MessageBox.Show("Falta llenar los datos de " +cmbBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtIdPC")
                    {
                        MessageBox.Show("Falta llenar los datos de " +textBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (textBox == txtDNI | textBox == txtTelefono1 | textBox == txtTelefono2)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " +textBox.Name.Substring(3) + " solo pueden contener dígitos",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        if (textBox == txtNombre | textBox == txtApPaterno | textBox == txtApMaterno)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.Trim().All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " +textBox.Name.Substring(3) + " solo pueden contener letras",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
            }
            //AQUI VA EL INSERTAR
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                ClienteWS.cliente cliente = new ClienteWS.cliente();
                //PersonaContactoWS.personaContacto personaContacto = new PersonaContactoWS.personaContacto();

                cliente.ruc = txtRuc.Text;
                cliente.razonSocial = txtRazonSocial.Text;
                cliente.fechaRegistro = DateTime.Now;
                cliente.grupo = txtGrupo.Text;
                cliente.zona = new ClienteWS.zona();
                cliente.zona.idZona = ((ZonaWS.zona) cboZona.SelectedItem).idZona;
                cliente.direccion = txtDireccion.Text;

                cliente.personaContacto = new ClienteWS.personaContacto();
                cliente.personaContacto.dni = txtDNI.Text;
                cliente.personaContacto.nombre = txtNombre.Text;
                cliente.personaContacto.apellidoPaterno = txtApPaterno.Text;
                cliente.personaContacto.apellidoMaterno = txtApMaterno.Text;
                cliente.personaContacto.telefono1 = txtTelefono1.Text;
                cliente.personaContacto.telefono2 = txtTelefono2.Text;
                cliente.personaContacto.correo = txtCorreo.Text;
                
                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoCliente.insertarCliente(cliente);
                    txtIdC.Text = cliente.idCliente.ToString();
                    txtIdPC.Text = cliente.personaContacto.idPersonaContacto.ToString();
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
                    cliente.idCliente = Int32.Parse(txtIdC.Text);
                    cliente.personaContacto.idPersonaContacto = Int32.Parse(txtIdPC.Text);
                    int resultado = daoCliente.actualizarCliente(cliente);
                    //int resultado = daoPersonaContacto.actualizarPersonaContacto(personaContacto);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se actualizó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se actualizó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
	}
}
