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
            
            if (frmVentanaPrincipal.nBtn == 1)
            {   //OBTNER DATOS DE FILA SELECCIONADA
                if (Program.pantallas[Program.pantallas.Count - 1].Formulario.Name == "frmGestionarClientes")
                {
                    frmGestionarClientes.clienteSeleccionado = (ClienteWS.cliente)frmGestionarClientes.dgv.CurrentRow.DataBoundItem;
                    txtIdC.Text = frmGestionarClientes.clienteSeleccionado.idCliente.ToString();
                    txtRuc.Text = frmGestionarClientes.clienteSeleccionado.ruc.ToString();
                    txtRazonSocial.Text = frmGestionarClientes.clienteSeleccionado.razonSocial;
                    txtGrupo.Text = frmGestionarClientes.clienteSeleccionado.grupo;
                    txtDireccion.Text = frmGestionarClientes.clienteSeleccionado.direccion;
                    cboZona.SelectedValue = frmGestionarClientes.clienteSeleccionado.zona.idZona;
                    dtpFechaInicio.Value = frmGestionarClientes.clienteSeleccionado.fechaRegistro;

                    //PERSONA CONTACTO
                    PersonaContactoWS.personaContacto personaC = new PersonaContactoWS.personaContacto();

                    personaC.idPersonaContacto = frmGestionarClientes.clienteSeleccionado.personaContacto.idPersonaContacto;
                    personaC = daoPersonaContacto.mostrarPersonaContacto(personaC.idPersonaContacto);

                    txtIdPC.Text = personaC.idPersonaContacto.ToString();
                    txtDNI.Text = personaC.dni.ToString();
                    txtNombre.Text = personaC.nombre;
                    txtApMaterno.Text = personaC.apellidoMaterno;
                    txtApPaterno.Text = personaC.apellidoPaterno;
                    txtTelefono1.Text = personaC.telefono1.ToString();
                    txtTelefono2.Text = personaC.telefono2.ToString();
                    txtCorreo.Text = personaC.correo.ToString();
                }
                else
                {
                    frmBuscarCliente.clienteSeleccionado = (ClienteWS.cliente)frmBuscarCliente.dgv.CurrentRow.DataBoundItem;
                    txtIdC.Text = frmBuscarCliente.clienteSeleccionado.idCliente.ToString();
                    txtRuc.Text = frmBuscarCliente.clienteSeleccionado.ruc.ToString();
                    txtRazonSocial.Text = frmBuscarCliente.clienteSeleccionado.razonSocial;
                    txtGrupo.Text = frmBuscarCliente.clienteSeleccionado.grupo;
                    txtDireccion.Text = frmBuscarCliente.clienteSeleccionado.direccion;
                    cboZona.SelectedValue = frmBuscarCliente.clienteSeleccionado.zona.idZona;
                    dtpFechaInicio.Value = frmBuscarCliente.clienteSeleccionado.fechaRegistro;

                    //PERSONA CONTACTO
                    PersonaContactoWS.personaContacto personaC = new PersonaContactoWS.personaContacto();

                    personaC.idPersonaContacto = frmBuscarCliente.clienteSeleccionado.personaContacto.idPersonaContacto;
                    personaC = daoPersonaContacto.mostrarPersonaContacto(personaC.idPersonaContacto);

                    txtIdPC.Text = personaC.idPersonaContacto.ToString();
                    txtDNI.Text = personaC.dni.ToString();
                    txtNombre.Text = personaC.nombre;
                    txtApMaterno.Text = personaC.apellidoMaterno;
                    txtApPaterno.Text = personaC.apellidoPaterno;
                    txtTelefono1.Text = personaC.telefono1.ToString();
                    txtTelefono2.Text = personaC.telefono2.ToString();
                    txtCorreo.Text = personaC.correo.ToString();
                }
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
                        MessageBox.Show("Falta llenar los datos de " +
                            textBox.Name.Substring(3));
                        return;
                    }
                    else
                    {
                        if (textBox == txtRuc)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " +
                                textBox.Name.Substring(3) + " solo pueden contener dígitos");
                                return;
                            }
                        }
                        if (textBox == txtGrupo)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.Trim().All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " solo pueden contener letras");
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

            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtIdPC")
                    {
                        MessageBox.Show("Falta llenar los datos de " +
                            textBox.Name.Substring(3));
                        return;
                    }
                    else
                    {
                        if (textBox == txtDNI | textBox == txtTelefono1 | textBox == txtTelefono2)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " +
                                textBox.Name.Substring(3) + " solo pueden contener dígitos");
                                return;
                            }
                        }
                        if (textBox == txtNombre | textBox == txtApPaterno | textBox == txtApMaterno)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.Trim().All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " solo pueden contener letras");
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
                PersonaContactoWS.personaContacto personaContacto = new PersonaContactoWS.personaContacto();

                cliente.ruc = txtRuc.Text;
                cliente.razonSocial = txtRazonSocial.Text;
                cliente.fechaRegistro = DateTime.Now;
                cliente.grupo = txtGrupo.Text;
                cliente.zona = new ClienteWS.zona();
                cliente.zona.idZona = ((ZonaWS.zona) cboZona.SelectedItem).idZona;
                cliente.direccion = txtDireccion.Text;

                personaContacto = new PersonaContactoWS.personaContacto();
                personaContacto.dni = txtDNI.Text;
                personaContacto.nombre = txtNombre.Text;
                personaContacto.apellidoPaterno = txtApPaterno.Text;
                personaContacto.apellidoMaterno = txtApMaterno.Text;
                personaContacto.telefono1 = txtTelefono1.Text;
                personaContacto.telefono2 = txtTelefono2.Text;
                personaContacto.correo = txtCorreo.Text;
                
                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoCliente.insertarCliente(cliente);
                    txtIdC.Text = cliente.idCliente.ToString();
                    txtIdPC.Text = cliente.personaContacto.idPersonaContacto.ToString();
                }
                else if (frmVentanaPrincipal.nBtn == 1)
                {
                    cliente.idCliente = Int32.Parse(txtIdC.Text);
                    cliente.personaContacto.idPersonaContacto = Int32.Parse(txtIdPC.Text);
                    daoCliente.actualizarCliente(cliente);
                    daoPersonaContacto.actualizarPersonaContacto(personaContacto);
                }
            }
        }
	}
}
