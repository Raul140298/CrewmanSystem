using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public partial class frmVentanaPrincipal : Form
	{
		private CrewPantalla padre;
		private Form child;
		private BTNestado estado;
		private int nMaxAnt;
		private int nHojaDGV;
		private Size anterior;
		public static IconButton act;
		public static IconButton elim;
		public static int nBtn;
		public static int antBtn;

		public frmVentanaPrincipal()
		{
			//INICIALIZACION DE LA VENTANA
			InitializeComponent();
			//COMIENZO DEL CODIGO
			customizeDesign();
			estado = BTNestado.vacio;
			nMaxAnt = 7;
			nHojaDGV = 1;
			act = btnActualizar;
			elim = btnEliminar;
			//logeoExitoso
			logeoExitoso(Program.empleado.cargo.idCargo);

		}

		protected override CreateParams CreateParams
		{//Sobreescritura para eliminar el parpadeo blanco y poder arrastrar
			get
			{
				int WS_DLGFRAME = 0x00400000;
				CreateParams parameters = base.CreateParams;
				parameters.Style = parameters.Style & ~WS_DLGFRAME;
				parameters.ExStyle |= 0x2000000;
				return parameters;
			}
		}

		private void logeoExitoso(int cargo)
		{
			CrewPantalla home = new CrewPantalla();
			home.Boton = btnHome;
			home.Tipo = BTNtipo.vacio;
			pnlLateralIzquierdo.Visible = true;
			if (cargo == 1)
			{
				btnHome.Text = "  VENDEDOR";
				pnlJefeDeVentas.Visible = false;
				home.Formulario = new frmHomeVendedor();
				
			}
			else if (cargo == 2)
			{
				btnHome.Text = "  JEFE DE VENTAS";
				pnlEmpleado.Visible = false;	
				home.Formulario = new frmHomeJefe();	
			}
			else
			{
				MessageBox.Show("ERROR!!!!!!!!");
			}
			Program.pantallas.Add(home);
			llamarFormulario(home.Formulario);
		}

		#region ESTETICA, BOTONES Y OCULTAMIENTO

		private void customizeDesign()
		{
			pnlLateralIzquierdo.Visible = false;
			pnlGestionProducto.Visible = false;
			pnlGestionZonas.Visible = false;
			pnlGestionEmpleados.Visible = false;
			pnlGestionClientes.Visible = false;
			pnlEmpGestionProductos.Visible = false;
			pnlEmpGestionPedidos.Visible = false;

			ocultaBotonesCabecera(false, false, false, false, false);

			pnlControlBox.BackColor = Program.colorR;
			pnlLateralIzquierdo.AutoScroll = false;

			lblControlName.ForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.5);

			btnMinimizar.BackColor = Program.colorR;
			btnMinimizar.IconColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.5);
			btnMaximizar.BackColor = Program.colorR;
			btnMaximizar.IconColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.5);
			btnSalir.BackColor = Program.colorR;
			btnSalir.IconColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.5);

			#region Autosizable
			//this.SizeGripStyle = SizeGripStyle.Show;
			//this.FormBorderStyle = FormBorderStyle.None;
			//this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			//this.FormBorderStyle = FormBorderStyle.FixedSingle;
			//this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//QUITA EL BLANCO, PERO NO SE PUEDE AGRANDAR POR LOS LADOS
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;//MANTIENE EL BLANCO, PERO SE PUEDE HACER DE TODO

			this.ControlBox = false;
			this.DoubleBuffered = true;
			//this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			#endregion
		}

		private void hideSubMenu(Panel subMenu)
		{
			if (subMenu != null)
			{
				subMenu.Visible = false;
			}
		}

		private void showSubMenu(Panel subMenu)
		{
			if(subMenu != null)
			{
				subMenu.Visible = true;
			}
		}

		private void estadoBotones()
		{
			switch (estado)
			{
				case BTNestado.vacio:
					btnNuevo.BackColor = Program.color0;
					btnActualizar.BackColor = Program.color0;
					btnEliminar.BackColor = Program.color0;
					btnBuscar.BackColor = Program.color0;
					desactivaBotonesCabecera(true, false, false, true, true);
					break;
				case BTNestado.nuevo:
					btnNuevo.BackColor = Program.colorR;
					btnActualizar.BackColor = Program.color0;
					btnEliminar.BackColor = Program.color0;
					btnBuscar.BackColor = Program.color0;
					desactivaBotonesCabecera(false, false, false, false, false);
					break;
				case BTNestado.actualizar:
					btnActualizar.BackColor = Program.colorR;
					btnNuevo.BackColor = Program.color0;
					btnEliminar.BackColor = Program.color0;
					btnBuscar.BackColor = Program.color0;
					desactivaBotonesCabecera(false, false, false, false, false);
					break;
				case BTNestado.eliminar:
					btnEliminar.BackColor = Program.colorR;
					btnNuevo.BackColor = Program.color0;
					btnActualizar.BackColor = Program.color0;
					btnBuscar.BackColor = Program.color0;
					break;
				case BTNestado.buscar:
					btnBuscar.BackColor = Program.colorR;
					btnNuevo.BackColor = Program.color0;
					btnActualizar.BackColor = Program.color0;
					btnEliminar.BackColor = Program.color0;
					desactivaBotonesCabecera(false, false, false, false, false);
					break;
				default:
					MessageBox.Show("Error: El formulario no existe");
					break;
			}
		}

		private void desactivaBotonesCabecera(bool n,bool a,bool e,bool b,bool f)
		{
			btnNuevo.Enabled = n;
			btnActualizar.Enabled = a;
			btnEliminar.Enabled = e;
			btnBuscar.Enabled = b;
			btnLeft.Enabled = f;
			btnRight.Enabled = f;
		}

		private void ocultaBotonesCabecera(bool n, bool a, bool e, bool b, bool f)
		{
			//REINICIO LOS BOTONES
			btnLeft.Visible = false;
			btnRight.Visible = false;
			btnBuscar.Visible = false;
			btnEliminar.Visible = false;
			btnActualizar.Visible = false;
			btnNuevo.Visible = false;

			btnBuscar.Visible = b;
			btnEliminar.Visible = e;
			btnActualizar.Visible = a;
			btnNuevo.Visible = n;

			btnLeft.Visible = f;
			btnRight.Visible = f;			
			if(f == false) lblCountRows.Text = "";
		}

		private void pintaBoton(IconButton senderBtn, Color color)
		{
			if (senderBtn != null)
			{
				IconButton currentBtn = senderBtn;
				currentBtn.BackColor = Color.FromArgb(37, 36, 81);//COLOR QUE SE CAMBIA
				currentBtn.ForeColor = color;
				currentBtn.IconColor = color;
				//currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.Padding = new Padding(35, 0, 15, 0);//SE PUEDE IR
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
			}
		}

		private void despintaBoton(IconButton button)
		{
			if (button != null)
			{
				button.BackColor = Program.color0;
				button.ForeColor = Color.Gainsboro;
				button.IconColor = Color.Gainsboro;
				button.TextAlign = ContentAlignment.MiddleLeft;
				button.ImageAlign = ContentAlignment.MiddleLeft;
				button.TextImageRelation = TextImageRelation.ImageBeforeText;
				button.Padding = new Padding(15, 0, 15, 0);//SE PUEDE IR
			}
		}

		private void ClickBoton(IconButton sender, CrewPantalla padreb, Panel panel, Color color, BTNtipo tipo, Form formulario, bool n, bool a, bool e, bool b, bool f)
		{
			if (sender != null)//si el boton existe
			{
				//BOTON DE CABECERA
				if (Program.pantallas.Last().Tipo == BTNtipo.cabecera)
				{
					Program.pantallas.Last().Formulario.Hide();
					Program.pantallas.Last().Formulario.Close();
					Program.pantallas.RemoveAt(Program.pantallas.Count - 1);
				}
				//BOTON NUEVO
				if (Program.pantallas.Last().Boton != sender)
				{
					if (tipo != BTNtipo.btnDePanel)//SI EL NUEVO NO ES DE PANEL
					{
						if (padre != null && padre.Boton == sender)//SI ME HAGO CLICK SIENDO PADRE ACTIVO
						{
							DesactivaBoton(padre);
							ActivaBoton(Program.pantallas.First());
							return;
						}
						DesactivaBoton(Program.pantallas.Last());//Desactivamos el anterior
						DesactivaBoton(Program.pantallas.Last().Padre);//y su padre por si acaso
					}
					else//SI ES DE PANEL
					{
						frmVentanaPrincipal.antBtn = 0;
						if (Program.pantallas.Last().Tipo == BTNtipo.btnDePanel) DesactivaBoton(Program.pantallas.Last());//Desactivamos el anterior que sea de panel
					}
	
					CreaPantalla(sender, padreb, panel, color, tipo, formulario);
					Program.pantallas.Last().SetCabecera(n, a, e, b, f);
					
					//Activo lo que tiene que hacer ese botón y muestro su cabecera respectiva
					ActivaBoton(Program.pantallas.Last());
					ocultaBotonesCabecera(n, a, e, b, f);
				}
				else //MISMO BOTON
				{
					DesactivaBoton(Program.pantallas.Last());
					Program.pantallas.RemoveAt(Program.pantallas.Count - 1);
					ActivaBoton(Program.pantallas.First());
				}
			}
		}

		private void CreaPantalla(IconButton sender, CrewPantalla padreb, Panel panel, Color color, BTNtipo tipo, Form formulario)
		{
			Program.pantallas.Add(new CrewPantalla(sender, padreb, panel, color, formulario, tipo));
			if (Program.pantallas.Count > nMaxAnt)
			{//NUMERO COMO MAXIMO DE FORMULARIOS EN LA COLA
				Program.pantallas.RemoveAt(1);
			}
		}

		private void ActivaBoton(CrewPantalla sender)
		{
			if(sender != null)
			{
				switch (sender.Tipo)
				{
					case BTNtipo.btnConPanel:
						padre = sender;
						pintaBoton(sender.Boton, Program.colorR);
						showSubMenu(sender.Panel);
						break;
					case BTNtipo.btnDePanel:
						//desactivaBotonesCabecera(true, true, true, true, true);
						sender.Boton.ForeColor = Program.colorR;
						llamarFormulario(sender.Formulario);
						break;
					case BTNtipo.btnSinPanel:
						pintaBoton(sender.Boton, Program.colorR);
						llamarFormulario(sender.Formulario);
						break;
					case BTNtipo.cabecera:
						llamarFormulario(sender.Formulario);
						break;
					case BTNtipo.vacio:
						lblCountRows.Text = "";
						Program.pantallas.First().Formulario.BringToFront();
						Program.pantallas.First().Formulario.Show();
						ocultaBotonesCabecera(false, false, false, false, false);
						break;
					default:
						MessageBox.Show("BTNtipo aun no declarado");
						break;
				}
			}
		}

		private void DesactivaBoton(CrewPantalla sender)
		{
			if(sender != null)
			{
				//MessageBox.Show(sender.Boton.Name + " " + sender.Tipo);
				switch (sender.Tipo)
				{	
					case BTNtipo.btnConPanel:
						hideSubMenu(sender.Panel);
						despintaBoton(sender.Boton);
						padre = null;
						break;
					case BTNtipo.btnDePanel:
						sender.Formulario.Visible = false;
						sender.Boton.ForeColor = Color.Gainsboro;
						break;
					case BTNtipo.btnSinPanel:
						sender.Formulario.Visible = false;
						despintaBoton(sender.Boton);
						break;
					case BTNtipo.cabecera:
						sender.Formulario.Visible = false;
						break;
					case BTNtipo.vacio:
						ocultaBotonesCabecera(false, false, false, false, false);
						break;
					default:
						break;
				}
				estado = BTNestado.vacio;
				estadoBotones();
			}
		}

		private void modificaPagina()
		{
			lblCountRows.Text = nHojaDGV.ToString() + " de " + "10";
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			frmSalir panel = new frmSalir();
			if (panel.ShowDialog() == DialogResult.OK)
			{
			}
		}

		private void btnMaximizar_Click(object sender, EventArgs e)
		{
			if(this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
				this.Size = anterior;
			}
			else
			{
				anterior = this.Size;
				this.WindowState = FormWindowState.Maximized;
			}	
			
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		#region Deslizamiento de la ventana

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

		private void lblControlName_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pnlChildForm_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void frmPanel_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pnlContenedor_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pnlLateralIzquierdo_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pnlJefeDeVentas_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pnlEmpleado_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion
		#endregion

		#region MANEJO DE PANELES Y FORMULARIOS

		private void llamarFormulario(Form formulario)
		{
			child = formulario;

			child.TopLevel = false;
			child.FormBorderStyle = FormBorderStyle.None;
			child.Dock = DockStyle.Fill;

			pnlChildForm.Controls.Add(child);
			pnlChildForm.Tag = child;
			child.BringToFront();
			child.Show();
		}

		private void llamarMetodosDAO(IconButton sender, int boton)
		{
			string formulario = "";
			if (Program.pantallas.Count < 1) return;
			if(Program.pantallas.Last().Formulario != null) formulario = Program.pantallas.Last().Formulario.GetType().Name;
			nBtn = boton;
			switch (formulario)
			{		
				case "frmGestionarZonas":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevaZona());
					if(boton == 2 ) frmGestionarZonas.eliminar();
					if (boton == 3) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmBuscarZona());
					break;
				case "frmGestionarVisitas":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevaVisita());
					break;
				case "frmGestionarSubfamilias":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevaSubfamilia());
					if (boton == 2) frmGestionarSubfamilias.eliminar();
					break;
				case "frmGestionarRutas":
					break;
				case "frmGestionarQuejas":
					break;
				case "frmGestionarPromocionesXZona":
					break;
				case "frmGestionarPromociones":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevaPromocion());
					if (boton == 2) frmGestionarPromociones.eliminar();
					if (boton == 3) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmBuscarPromocion());
					break;
				case "frmGestionarProductosXZona":
					if (boton == 0) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevoProductoXZona());
					if (boton == 3) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmBuscarProductoXZona());
					break;
				case "frmGestionarProductos":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevoProducto());
					if (boton == 2) frmGestionarProductos.eliminar();
					if (boton == 3) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmBuscarProducto());
					break;
				case "frmBuscarProducto":
					if (boton == 1) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevoProducto());
					if (boton == 2) frmBuscarProducto.eliminar();
					break;
				case "frmGestionarPedidos":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevoPedido());
					if (boton == 2) frmGestionarPedidos.eliminar();
					if (boton == 3) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmBuscarPedido());
					break;
				case "frmGestionarMarcas":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevaMarca());
					if (boton == 2) frmGestionarMarcas.eliminar();
					break;
				case "frmGestionarGuiasRemision":
					break;
				case "frmGestionarFamilias":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevaFamilia());
					if (boton == 2) frmGestionarFamilias.eliminar();
					break;
				case "frmGestionarFacturas":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevaFactura());
					if (boton == 2) frmGestionarFacturas.eliminar();
					if (boton == 3) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmBuscarFactura());
					break;
				case "frmGestionarEmpleadosXZona":
					break;
				case "frmGestionarEmpleados":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevoEmpleado());
					if (boton == 2) frmGestionarEmpleados.eliminar();
					if (boton == 3) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmBuscarEmpleado());
					break;
				case "frmGestionarCarteras":
					break;
				case "frmGestionarClientes":
					if (boton < 2) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmNuevoCliente());
					if (boton == 2) frmGestionarClientes.eliminar();
					if (boton == 3) CreaPantalla(sender, null, null, Program.colorR, BTNtipo.cabecera, new frmBuscarCliente());
					break;
				default:
					MessageBox.Show("Error: El formulario aún no existe");
					break;
			}
			ActivaBoton(Program.pantallas.Last());
		}
		#endregion

		#region JEFEDE VENTAS
		#region GESTIONPRODUCTOS
		private void btnGestionProducto_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, pnlGestionProducto, Program.colorR, BTNtipo.btnConPanel, null,false, false, false, false, false);
		}

		private void btnFamilia_Click(object sender, EventArgs e)
		{			
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarFamilias(),true, true, true, false, false);
		}

		private void btnSubfamilia_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarSubfamilias(),true, true, true, false, false);
		}

		private void btnProducto_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarProductos(),true, true, true, true, true);
		}

		private void btnPromocion_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarPromociones(),true, true, true, true, true);
		}

		private void btnMarca_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarMarcas(), true, true, true, false, false);
		}
		#endregion

		#region GESTIONZONAS
		private void btnGestionarZonas_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, pnlGestionZonas, Program.colorR, BTNtipo.btnConPanel, null,false, false, false, false, false);
		}

		private void btnZona_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarZonas(),true, true, true, false, false);
		}

		private void btnProductoXZona_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarProductosXZona(),true, false, false, true, true);
		}

		//private void btnPromocionXZona_Click(object sender, EventArgs e)
		//{
		//	ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarPromocionesXZona(), false, false, false, true, true);
		//}
		#endregion

		#region GESTIONEMPLEADOS
		private void btnGestionEmpleados_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, pnlGestionEmpleados, Program.colorR, BTNtipo.btnConPanel, null, false, false, false, false, false);
		}

		private void btnEmpleados_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarEmpleados(), true, true, true, true, true);
		}

		private void btnRutas_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarRutas(), false, false, false, false, false);
		}

		private void btnCarteras_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarCarteras(), false, false, false, false, false);
		}

		private void btnSeguimientoYControl_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmSeguimientoYControl(), false, false, false, false, true);
		}
		#endregion

		#region GESTIONCLIENTES
		private void btnGestionClientes_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, pnlGestionClientes, Program.colorR, BTNtipo.btnConPanel, null, false, false, false, false, false);
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarClientes(),true, true, true, true, true);
		}

		private void btnClientesXZona_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarClientesXZona(),false, false, false, true, true);
		}

		//private void btnPersonaDeContacto_Click(object sender, EventArgs e)
		//{
		//	ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarPersonaContacto(),true, true, false, true, true);
		//}
		#endregion

		#region BOTONESSINDESPEGABLES
		private void btnCumplimientoDeMetas_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, null, Program.color0, BTNtipo.btnSinPanel, new frmListarCumplimientoDeMetas(), false, false, false, false, false);
		}

		private void btnReportePedidos_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, null, Program.color0, BTNtipo.btnSinPanel, new frmReportePedidos(), false, false, false, false, false);
		}
		#endregion

		#endregion

		#region VENDEDOR
		#region GESTIONPRODUCTOS
		private void btnEmpGestionProductos_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, pnlEmpGestionProductos, Program.colorR, BTNtipo.btnConPanel, null,false, false, false, false, false);
		}

		private void btnEmpProducto_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarProductos(),false, false, false, true, true);
		}

		private void btnEmpProductoXZona_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarProductosXZona(),false, false, false, true, true);
		}
		#endregion

		#region GESTIONPEDIDOS
		private void btnEmpGestionPedidos_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, pnlEmpGestionPedidos, Program.colorR, BTNtipo.btnConPanel, null,false, false, false, false, false);
		}

		private void btnEmpPedidos_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarPedidos(),true, true, true, true, true);
		}

		private void btnEmpGestionFacturas_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarFacturas(), true, true, true, true, true);
		}

		private void btnEmpGestionGuiasRemision_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarGuiasRemision(),false, false, false, true, true);
		}

		private void btnEmpQuejas_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, padre, null, Program.color0, BTNtipo.btnDePanel, new frmGestionarQuejas(),false, true, false, true, true);
		}
		#endregion

		#region BOTONESSINDESPLEGABLES
		private void btnPromociones_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, null, Program.color0, BTNtipo.btnSinPanel, new frmGestionarPromociones(),false, false, false, true, true);
		}

		private void btnVisitas_Click(object sender, EventArgs e)
		{
			ClickBoton((IconButton)sender, null, null, Program.color0, BTNtipo.btnSinPanel, new frmGestionarVisitas(),false, false, false, false, true);
		}
		#endregion

		#endregion

		#region CABECERA
		private void btnHome_Click(object sender, EventArgs e)
		{
			if (Program.pantallas.Last().Tipo == BTNtipo.cabecera)
			{
				Program.pantallas.Last().Formulario.Hide();
				Program.pantallas.Last().Formulario.Close();
				Program.pantallas.RemoveAt(Program.pantallas.Count - 1);
			}
			
			DesactivaBoton(Program.pantallas.Last());
			DesactivaBoton(Program.pantallas.Last().Padre);

			ActivaBoton(Program.pantallas.First());
		}

		private void btnAtras_Click(object sender, EventArgs e)
		{
			int count = Program.pantallas.Count;
			if (count > 1 && count <= nMaxAnt)
			{
				//Si el botón tiene un formulario, lo desactivo, lo cierro y lo elimino
				DesactivaBoton(Program.pantallas.Last());
				if (Program.pantallas.Last().Formulario != null) 
				{ 
					Program.pantallas.Last().Formulario.Close();					
				}
				Program.pantallas.RemoveAt(count - 1);
				//Activo el último botón ( el formulario que quedó después de sacar uno)
				ActivaBoton(Program.pantallas.Last());
				ActivaBoton(Program.pantallas.Last().Padre);
				ocultaBotonesCabecera(Program.pantallas.Last().N,
									  Program.pantallas.Last().A,
									  Program.pantallas.Last().E,
									  Program.pantallas.Last().B,
									  Program.pantallas.Last().F);
			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			estado = BTNestado.nuevo;
			estadoBotones();
			llamarMetodosDAO((IconButton)sender, 0);
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			estado = BTNestado.actualizar;
			estadoBotones();
			llamarMetodosDAO((IconButton)sender, 1);
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			estado = BTNestado.eliminar;
			estadoBotones();
			frmConfirmarEliminar confirma = new frmConfirmarEliminar();
			if(confirma.ShowDialog() == DialogResult.OK)
            {
				llamarMetodosDAO((IconButton)sender, 2);
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			//antBtn = 1;
			estado = BTNestado.buscar;
			estadoBotones();
			llamarMetodosDAO((IconButton)sender, 3);
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			nHojaDGV++;
			modificaPagina();
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			if(nHojaDGV>0)
			{
				nHojaDGV--;
			}
			modificaPagina();
		}
        #endregion

    }
}
