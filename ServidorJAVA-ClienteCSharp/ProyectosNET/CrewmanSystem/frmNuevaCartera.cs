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
    public partial class frmNuevaCartera : Form
    {
        private ClienteWS.ClienteWSClient daoCliente;
        private VisitaWS.VisitaWSClient daoVisita;
        private ClienteWS.cliente miCliente;
        public frmNuevaCartera()
        {
            daoCliente = new ClienteWS.ClienteWSClient();
            daoVisita = new VisitaWS.VisitaWSClient();
            InitializeComponent();
            frmGestionarCarteras.empleadoSeleccionado = (EmpleadoWS.empleado)frmGestionarCarteras.dgv.CurrentRow.DataBoundItem;
            txtId.Text = frmGestionarCarteras.empleadoSeleccionado.idEmpleado.ToString();
            txtNombre.Text = frmGestionarCarteras.empleadoSeleccionado.nombre;
            txtApPaterno.Text = frmGestionarCarteras.empleadoSeleccionado.apellidoPaterno;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente(0, frmGestionarCarteras.empleadoSeleccionado.idEmpleado);
            if(formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                miCliente = frmBuscarCliente.clienteSeleccionado;
                txtRUC.Text = miCliente.ruc;
                txtRazonSocial.Text = miCliente.razonSocial;
            }
        }
    }
}
