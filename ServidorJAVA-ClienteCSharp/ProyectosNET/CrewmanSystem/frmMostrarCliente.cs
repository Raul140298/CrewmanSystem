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
    public partial class frmMostrarCliente : Form
    {
        public frmMostrarCliente(ClienteWS.cliente miCliente)
        {
            InitializeComponent();
            txtId.Text = miCliente.idCliente.ToString();
            txtRuc.Text = miCliente.ruc.ToString();
            txtRazon.Text = miCliente.razonSocial;
            dtpFechaInicio.Value = miCliente.fechaRegistro;
            txtGrupo.Text = miCliente.grupo;
            txtDireccion.Text = miCliente.direccion;
            txtZona.Text = miCliente.zona.nombre;
            txtIdContacto.Text = miCliente.personaContacto.idPersona.ToString();
            txtDNI.Text = miCliente.personaContacto.dni;
            txtNombre.Text = miCliente.personaContacto.nombre;
            txtApPaterno.Text = miCliente.personaContacto.apellidoPaterno;
            txtApMaterno.Text = miCliente.personaContacto.apellidoMaterno;
            txtTelefono1.Text = miCliente.personaContacto.telefono1;
            txtTelefono2.Text = miCliente.personaContacto.telefono2;
            txtCorreo.Text = miCliente.personaContacto.correo;
        }
    }
}
