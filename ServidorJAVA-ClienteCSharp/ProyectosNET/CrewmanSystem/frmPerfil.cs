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
    public partial class frmPerfil : Form
    {
        private EmpleadoWS.empleado empleado;
        public frmPerfil()
        {
            InitializeComponent();
            empleado = Program.empleado;
            llenarDatos();
        }

        private void llenarDatos()
        {
            txtNombre.Text = empleado.nombre;
            txtApellidoPaterno.Text = empleado.apellidoPaterno;
            txtApellidoMaterno.Text = empleado.apellidoMaterno;
            txtTelefono1.Text = empleado.telefono1.ToString();
            txtTelefono2.Text = empleado.telefono2.ToString();
            txtCorreo.Text = empleado.correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "") {
                MessageBox.Show("Debe indicar una contraseña",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

        }
    }
}
