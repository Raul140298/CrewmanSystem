using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private byte[] foto = null;
        private string ruta;

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
            if (empleado.genero == 'M')
            {
                rbFemenino.Checked = false;
                rbMasculino.Checked = true;
            }
            else
            {
                rbFemenino.Checked = true;
                rbMasculino.Checked = false;
            }
            txtTelefono1.Text = empleado.telefono1.ToString();
            txtTelefono2.Text = empleado.telefono2.ToString();
            txtCorreo.Text = empleado.correo;
            try
            {
                MemoryStream ms = new MemoryStream(empleado.foto);
                pbFoto.Image = new Bitmap(ms);
            }
            catch (Exception) { }
            if(empleado.cargo.nombre == "VENDEDOR")
            {
                txtSumaVentas.Text = empleado.sumVentas.ToString("N2");
                txtObjetivoVentas.Text = empleado.objetivoVentas.ToString("N2");
                txtZona.Text = empleado.zona.nombre;
                foreach (Control c in groupBox1.Controls) c.Enabled = false;
                foreach (Control c in groupBox2.Controls) c.Enabled = false;
                foreach (Control c in groupBox4.Controls) c.Enabled = false;

                pnlJefeVentas.Visible = false;
                btnAgregarImagen.Visible = false;
                btnActualizar.Visible = false;
            }
            else
            {
                txtZonaJefe.Text = empleado.zona.nombre;
                txtZonaJefe.Enabled = false;
                pnlVendedor.Visible = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            foreach(Control c in groupBox1.Controls)
            {
                if(c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if(textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if(textBox == txtNombre || textBox == txtApellidoPaterno || textBox == txtApellidoMaterno)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.Trim().All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " + textBox.Name.Substring(3) + " solo pueden contener letras",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
            }

            foreach(Control c in groupBox2.Controls)
            {
                if(c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtTelefono2")
                    {
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (textBox == txtTelefono1)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " +
                                textBox.Name.Substring(3) + " solo pueden contener dígitos",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        if (textBox == txtTelefono2 && txtTelefono2.Text != "")
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("El numero de teléfono solo puede contener dígitos",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
            }

            EmpleadoWS.EmpleadoWSClient daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
            empleado.nombre = txtNombre.Text;
            empleado.apellidoPaterno = txtApellidoPaterno.Text;
            empleado.apellidoMaterno = txtApellidoMaterno.Text;
            if (rbMasculino.Checked) empleado.genero = 'M';
            else empleado.genero = 'F';
            empleado.telefono1 = txtTelefono1.Text;
            empleado.telefono2 = txtTelefono2.Text;
            empleado.correo = txtCorreo.Text;
            empleado.foto = foto;
            int resultado = daoEmpleado.actualizarEmpleado(empleado);
            if(resultado == 0)
            {
                MessageBox.Show("Los datos no se actualizaron correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Los datos se actualizaron correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.empleado = empleado;
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    ruta = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(ruta);
                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    this.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Debe indicar una contraseña",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtContraseña.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener más de 8 caracteres de longitud",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtContraseña.Text.Contains(" "))
            {
                MessageBox.Show("La contraseña no debe tener espacioes en blanco",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int resultado = daoEmpleado.cambiarContraseña(Program.empleado.idEmpleado, txtContraseña.Text);
                if (resultado == 0)
                {
                    MessageBox.Show("No se actualizó la contraseña correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se actualizó la contraseña correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empleado.contraseña = txtContraseña.Text;
                }
                txtContraseña.Text = "";
            }
        }
    }
}
