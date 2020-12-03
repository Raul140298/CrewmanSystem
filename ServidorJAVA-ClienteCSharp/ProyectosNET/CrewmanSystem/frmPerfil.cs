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
        private EmpleadoWS.EmpleadoWSClient daoEmpleado;
        public frmPerfil()
        {
            InitializeComponent();
            daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
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
            if(txtContraseña.Text.Length<8)
            {
                MessageBox.Show("La contraseña debe tener más de 8 caracteres de longitud",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ( txtContraseña.Text.Contains(" ") )
            {
                MessageBox.Show("La contraseña no debe tener espacioes en blanco",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int resultado = daoEmpleado.cambiarContraseña(Program.empleado.idEmpleado, txtContraseña.Text);
                if(resultado == 0)
                {
                    MessageBox.Show("No se actualizó la contraseña correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se actualizó la contraseña correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtContraseña.Text = "";

            }
        }
    }
}
