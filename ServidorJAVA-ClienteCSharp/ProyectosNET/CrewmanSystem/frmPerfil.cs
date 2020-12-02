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
            lblNombre.Text = "Perfil de " + empleado.nombre;
            txtNombre.Text = empleado.nombre;
            txtApellidoPaterno.Text = empleado.apellidoPaterno;
            txtApellidoMaterno.Text = empleado.apellidoMaterno;
        }
    }
}
