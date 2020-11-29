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
            cboCargo.SelectedIndex = 0;
            cboCargo.Enabled = false;

            ZonaWS.zona[] auxZonas = daoZona.listarZonas();
            ZonaWS.zona[] miLista = new ZonaWS.zona[auxZonas.Length + 1];
            ZonaWS.zona zonaPorDefecto = new ZonaWS.zona();
            zonaPorDefecto.idZona = 0;
            zonaPorDefecto.nombre = "Ninguno";
            miLista[0] = zonaPorDefecto;
            for (int i = 0; i < auxZonas.Length; i++) miLista[i+1] = auxZonas[i];

            BindingList<ZonaWS.zona> listaZonas = new BindingList<ZonaWS.zona>(miLista.ToArray());
            cboZona.DataSource= listaZonas;
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";
            cboZona.Enabled = false;
            txtSumaVentas.Text = "0.00";
            txtSumaVentas.Enabled = false;

            if (frmVentanaPrincipal.nBtn == 1)
            {   //OBTNER DATOS DE FILA SELECCIONADA
                EmpleadoWS.empleado miEmpleado;
                if (Program.pantallas[Program.pantallas.Count - 1].Formulario.Name == "frmGestionarEmpleados")
                {
                    frmGestionarEmpleados.empleadoSeleccionado = (EmpleadoWS.empleado)frmGestionarEmpleados.dgv.CurrentRow.DataBoundItem;
                    miEmpleado = frmGestionarEmpleados.empleadoSeleccionado;
                }
                else
                {
                    frmBuscarEmpleado.empleadoSeleccionado = (EmpleadoWS.empleado)frmBuscarEmpleado.dgv.CurrentRow.DataBoundItem;
                    miEmpleado = frmBuscarEmpleado.empleadoSeleccionado;
                }
                txtID.Text = miEmpleado.idEmpleado.ToString();
                txtDNI.Text = miEmpleado.dni.ToString();
                txtNombre.Text = miEmpleado.nombre;
                txtApMaterno.Text = miEmpleado.apellidoMaterno;
                txtApPaterno.Text = miEmpleado.apellidoPaterno;
                txtTelefono1.Text = miEmpleado.telefono1;
                txtTelefono2.Text = miEmpleado.telefono2;
                txtCorreo.Text = miEmpleado.correo.ToString();
                txtObjetivoVentas.Text = miEmpleado.objetivoVentas.ToString();
                txtSumaVentas.Text = miEmpleado.sumVentas.ToString();
                txtDNI.Enabled = false;

                if(miEmpleado.cargo.idCargo == 1) cboCargo.DisplayMember = "EMPLEADO";
                else if (miEmpleado.cargo.idCargo == 2) cboCargo.DisplayMember = "JEFE DE VENTAS";
                cboCargo.Enabled = false;

                cboZona.SelectedValue = miEmpleado.zona.idZona;
                cboZona.Enabled = true;

                if (miEmpleado.genero == 'M') rbMasculino.Checked = true;
                else rbFemenino.Checked = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtID" && textBox.Name != "txtTelefono2")
                    {
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (textBox == txtDNI | textBox == txtTelefono1)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " +
                                textBox.Name.Substring(3) + " solo pueden contener dígitos",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        if (textBox == txtTelefono2 && txtTelefono2.Text!="")
                        {
                            if(!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("El numero de teléfono solo puede contener dígitos",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        if (textBox == txtNombre | textBox == txtApPaterno | textBox == txtApMaterno)
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
                if (c is ComboBox)
                {
                    ComboBox cmbBox = c as ComboBox;
                    if (cmbBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Falta llenar los datos de " + cmbBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (rbMasculino.Checked) empleado.genero = 'M';
                else empleado.genero = 'F';

                empleado.jefe = new EmpleadoWS.empleado();
                empleado.jefe.idEmpleado = Program.empleado.idEmpleado;
                empleado.sumVentas = Convert.ToDouble(txtSumaVentas.Text);
                empleado.objetivoVentas = Convert.ToDouble(txtObjetivoVentas.Text);
                empleado.cargo = new EmpleadoWS.cargo();
                if (cboCargo.SelectedItem.ToString() == "VENDEDOR") empleado.cargo.idCargo = 1;
                else empleado.cargo.idCargo = 2;
                empleado.zona = new EmpleadoWS.zona();
                empleado.zona.idZona = ((ZonaWS.zona)cboZona.SelectedItem).idZona;

                string parte1 = txtNombre.Text;
                string firstLetter = parte1.Substring(0,1);
                string parte1New = firstLetter.ToLower()+parte1.Substring(1);

                string parte2 = txtApPaterno.Text.Substring(0, 3);
                firstLetter = parte2.Substring(0, 1);
                string parte2New = firstLetter.ToLower()+parte2.Substring(1);

                string parte3 = txtApMaterno.Text.Substring(0, 3);
                firstLetter = parte3.Substring(0, 1);
                string parte3New = firstLetter.ToLower() + parte3.Substring(1);

                string usuario_contra =  parte1New + parte2New + parte3New;
                empleado.usuario = usuario_contra;
                empleado.contraseña = usuario_contra;

                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoEmpleado.insertarEmpleado(empleado);
                    txtID.Text = resultado.ToString();
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
                    empleado.idEmpleado = Convert.ToInt32(txtID.Text);
                    empleado.idPersona = frmGestionarEmpleados.empleadoSeleccionado.idPersona;
                    int resultado = daoEmpleado.actualizarEmpleado(empleado);
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
