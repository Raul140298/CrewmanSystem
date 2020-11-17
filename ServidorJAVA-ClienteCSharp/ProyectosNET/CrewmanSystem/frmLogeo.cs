using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public partial class frmLogeo : Form
	{
        private EmpleadoWS.EmpleadoWSClient daoEmpleado;
        private ZonaWS.ZonaWSClient daoZona;

        public frmLogeo()
        {
            daoEmpleado = new EmpleadoWS.EmpleadoWSClient();
            daoZona = new ZonaWS.ZonaWSClient();

            InitializeComponent();

            btnIngresar.BackColor = Program.colorR;
            btnIngresar.IconColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.5);
            btnSalir.IconColor = ThemeColor.ChangeColorBrightness(Color.FromArgb(199, 171, 124), -0.5);
            this.DoubleBuffered = true;

            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtContraseña.UseSystemPasswordChar = true;
            lblMensajeError.Visible = false;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ////COMO DEBERÍA SER:-----------------------------------------------
            Program.empleado = daoEmpleado.permitirAccesoEmpleado(txtUsuario.Text, txtContraseña.Text);

            if (Program.empleado != null)
			{
                Program.empleado.zona.idZona = daoZona.mostrarZona(Program.empleado.idEmpleado).idZona;
                Program.empleado.zona.nombre = daoZona.mostrarZona(Program.empleado.idEmpleado).nombre;
				this.Hide();
				datosValidos = true;
				Program.panel = new frmVentanaPrincipal();
				Program.panel.Closed += (s, args) => this.Close();
				Program.panel.Show();
			}
			else
			{
				datosValidos = false;
				txtUsuario.BackColor = Color.LightGray;
				txtContraseña.BackColor = Color.LightGray;
				lblMensajeError.Visible = true;
			}
			return;
		}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Deslizamiento de la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel0_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

		private void panel6_MouseDown(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

		private void panel5_MouseDown(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

		private void panel4_MouseDown(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

		private void panel7_MouseDown(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
		{
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
		#endregion

		private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
		{
            if(lblMensajeError.Visible ==true)
			{
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.BackColor = Color.White;
                txtContraseña.BackColor = Color.White;
                lblMensajeError.Visible = false;
            }
        }

		private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
			{
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnIngresar_Click(btnIngresar,null);
            }
        }

		private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (lblMensajeError.Visible == true)
            {
                txtContraseña.Text = "";
                txtUsuario.BackColor = Color.White;
                txtContraseña.BackColor = Color.White;
                lblMensajeError.Visible = false;
            }
        }
	}
}
