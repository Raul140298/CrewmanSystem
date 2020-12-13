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
    public partial class frmCambiarContraseña : Form
    {
        private EmpleadoWS.EmpleadoWSClient daoEmpleado;

        public frmCambiarContraseña()
        {
            daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
            InitializeComponent();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == "")
            {
                MessageBox.Show("Debe indicar una contraseña",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtContraseña1.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener más de 8 caracteres de longitud",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtContraseña1.Text.Contains(" "))
            {
                MessageBox.Show("La contraseña no debe tener espacios en blanco",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(txtContraseña1 != txtContraseña2)
                {
                    MessageBox.Show("Las contraseñas no coinciden",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int resultado = daoEmpleado.cambiarContraseña(Program.empleado.idEmpleado, txtContraseña1.Text);
                if (resultado == 0)
                {
                    MessageBox.Show("Contraseña actual incorrecta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se actualizó la contraseña correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.empleado.contraseña = txtContraseña1.Text;
                    this.Hide();
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                    return;
                }
                txtContraseña1.Text = "";
            }
        }
    }
}
