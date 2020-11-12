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
        ZonaWS.ZonaWSClient daoZona = new ZonaWS.ZonaWSClient();
		public frmNuevoCliente()
		{
			InitializeComponent();
            cboZona.DataSource = new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToArray());
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";
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
                cliente.ruc = txtRuc.Text;
                cliente.razonSocial = txtRazonSocial.Text;
                cliente.fechaRegistro = DateTime.Now;
                cliente.grupo = txtGrupo.Text;
                cliente.zona = new ClienteWS.zona();
                cliente.zona.idZona = ((ZonaWS.zona) cboZona.SelectedItem).idZona;
                cliente.personaContacto = new ClienteWS.personaContacto();
                cliente.personaContacto.dni = txtDNI.Text;
                cliente.personaContacto.nombre = txtNombre.Text;
                cliente.personaContacto.apellidoPaterno = txtApPaterno.Text;
                cliente.personaContacto.apellidoMaterno = txtApMaterno.Text;
                cliente.personaContacto.telefono1 = txtTelefono1.Text;
                cliente.personaContacto.telefono2 = txtTelefono2.Text;
                cliente.personaContacto.correo = txtCorreo.Text;
                int resultado = daoCliente.insertarCliente(cliente);
                txtIdC.Text = cliente.idCliente.ToString();
                txtIdPC.Text = cliente.personaContacto.idPersonaContacto.ToString();
                //Usar resultado para ver si se inserto correctamente
            }
        }
	}
}
