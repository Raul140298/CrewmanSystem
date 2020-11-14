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
	public partial class frmNuevoEmpleado : Form
	{
        ZonaWS.ZonaWSClient daoZona;
        EmpleadoWS.EmpleadoWSClient daoEmpleado;
        string[] cargos = { "VENDEDOR", "JEFE DE VENTAS" };
        public frmNuevoEmpleado()
        {
            InitializeComponent();
            daoZona = new ZonaWS.ZonaWSClient();
            daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
            cboCargo.DataSource = cargos;
            cboZona.DataSource= new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToArray());
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";

            if (frmVentanaPrincipal.nBtn == 1)
            {   //OBTNER DATOS DE FILA SELECCIONADA
                frmGestionarEmpleados.empleadoSeleccionado = (EmpleadoWS.empleado)frmGestionarEmpleados.dgv.CurrentRow.DataBoundItem;
                txtID.Text = frmGestionarEmpleados.empleadoSeleccionado.idEmpleado.ToString();
                txtDNI.Text = frmGestionarEmpleados.empleadoSeleccionado.dni.ToString();
                txtNombre.Text = frmGestionarEmpleados.empleadoSeleccionado.nombre;
                txtApMaterno.Text = frmGestionarEmpleados.empleadoSeleccionado.apellidoMaterno;
                txtApPaterno.Text = frmGestionarEmpleados.empleadoSeleccionado.apellidoPaterno;
                txtTelefono1.Text = frmGestionarEmpleados.empleadoSeleccionado.telefono1.ToString();
                txtTelefono2.Text = frmGestionarEmpleados.empleadoSeleccionado.telefono2.ToString();
                txtCorreo.Text = frmGestionarEmpleados.empleadoSeleccionado.correo.ToString();
                if(frmGestionarEmpleados.empleadoSeleccionado.cargo.idCargo == 1)
				{
                    cboCargo.DisplayMember = "EMPLEADO";
				}
                else if (frmGestionarEmpleados.empleadoSeleccionado.cargo.idCargo == 2)
				{
                    cboCargo.DisplayMember = "JEFE DE VENTAS";
				}
                cboZona.SelectedValue = frmGestionarEmpleados.empleadoSeleccionado.zona.idZona;
                if(frmGestionarEmpleados.empleadoSeleccionado.genero == 'M')
				{
                    rbMasculino.Checked = true;
				}
				else
				{
                    rbFemenino.Checked = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtID")
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
            //AQUI VA EL INSERTAR
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                EmpleadoWS.empleado empleado = new EmpleadoWS.empleado();
                empleado.dni = txtDNI.Text;
                empleado.nombre = txtNombre.Text;
                empleado.apellidoPaterno = txtApPaterno.Text;
                empleado.apellidoMaterno = txtApMaterno.Text;
                empleado.telefono1 = txtTelefono1.Text;
                empleado.telefono2 = txtTelefono2.Text;
                empleado.correo = txtCorreo.Text;
                empleado.jefe = new EmpleadoWS.empleado();
                empleado.jefe.idEmpleado = Program.empleado.idEmpleado;
                empleado.cargo = new EmpleadoWS.cargo();
                if (cboCargo.SelectedItem.ToString() == "VENDEDOR")
                    empleado.cargo.idCargo = 1;
                else
                    empleado.cargo.idCargo = 2;
                empleado.zona = new EmpleadoWS.zona();
                empleado.zona.idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;
                if (rbMasculino.Checked)
                    empleado.genero = 'M';
                else
                    empleado.genero = 'F';

                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoEmpleado.insertarEmpleado(empleado);
                    txtID.Text = resultado.ToString();
                }
                else if (frmVentanaPrincipal.nBtn == 1)
                {
                    empleado.idEmpleado = Int32.Parse(txtID.Text);
                    daoEmpleado.actualizarEmpleado(empleado);
                }
            }
        }
    }
}
