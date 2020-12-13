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
        private CarteraWS.CarteraWSClient daoCartera;
        private VisitaWS.VisitaWSClient daoVisita;
        private ClienteWS.cliente miCliente;
        private BindingList<VisitaWS.visita> misVisitas;

        public frmNuevaCartera()
        {
            daoCliente = new ClienteWS.ClienteWSClient();
            daoCartera = new CarteraWS.CarteraWSClient();
            daoVisita = new VisitaWS.VisitaWSClient();
            misVisitas = new BindingList<VisitaWS.visita>();
            InitializeComponent();
            frmGestionarCarteras.empleadoSeleccionado = (EmpleadoWS.empleado)frmGestionarCarteras.dgv.CurrentRow.DataBoundItem;
            txtId.Text = frmGestionarCarteras.empleadoSeleccionado.idEmpleado.ToString();
            txtNombre.Text = frmGestionarCarteras.empleadoSeleccionado.nombre;
            txtApPaterno.Text = frmGestionarCarteras.empleadoSeleccionado.apellidoPaterno;
            int idZona = frmGestionarCarteras.empleadoSeleccionado.zona.idZona;
            if (idZona < 1)
            {
                MessageBox.Show("Debe asignar una zona al vendedor previamente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAddCliente.Enabled = false;
                btnRemoveCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                VisitaWS.visita[] visitas = daoVisita.listarVisitas(frmGestionarCarteras.empleadoSeleccionado.cartera.idCartera);
                if (visitas == null || visitas.Length < 1) misVisitas = new BindingList<VisitaWS.visita>();
                else misVisitas = new BindingList<VisitaWS.visita>(visitas.ToArray());
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = misVisitas;
            }

            #region colores de seleccion
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
            #endregion
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente(0, frmGestionarCarteras.empleadoSeleccionado.zona.idZona);
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                miCliente = frmBuscarCliente.clienteSeleccionado;
                txtRUC.Text = miCliente.ruc;
                txtRazonSocial.Text = miCliente.razonSocial;
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            if (txtRUC.Text == "")
            {
                MessageBox.Show("Debe seleccionar a un cliente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (VisitaWS.visita v in misVisitas)
            {
                if (v.cliente.idCliente == miCliente.idCliente) return;
            }
            VisitaWS.visita nuevaVisita = new VisitaWS.visita();
            nuevaVisita.cliente = new VisitaWS.cliente();
            nuevaVisita.cliente.idCliente = miCliente.idCliente;
            nuevaVisita.cliente.ruc = miCliente.ruc;
            nuevaVisita.cliente.razonSocial = miCliente.razonSocial;
            nuevaVisita.cliente.grupo = miCliente.grupo;
            nuevaVisita.cliente.tipoEmpresa = miCliente.tipoEmpresa;
            nuevaVisita.cliente.direccion = miCliente.direccion;
            nuevaVisita.cliente.zona = new VisitaWS.zona();
            nuevaVisita.cliente.zona.nombre = miCliente.zona.nombre;
            nuevaVisita.empleado = new VisitaWS.empleado();
            nuevaVisita.empleado.idEmpleado = Program.empleado.idEmpleado;
            nuevaVisita.fechaRegistro = DateTime.Today.AddYears(-100);
            nuevaVisita.fechaRegistroSpecified = true;
            nuevaVisita.estado = false;

            VisitaWS.visita[] visitas = new VisitaWS.visita[misVisitas.Count + 1];
            for (int cont = 0; cont < misVisitas.Count; cont++) visitas[cont] = misVisitas.ElementAt(cont);
            visitas[misVisitas.Count] = nuevaVisita;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = new BindingList<VisitaWS.visita>();
            misVisitas = new BindingList<VisitaWS.visita>(visitas.ToArray());
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = misVisitas;
            txtRUC.Text = "";
            txtRazonSocial.Text = "";
        }

        private void btnRemoveCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                return;
            }
            frmConfirmarEliminar formEliminar = new frmConfirmarEliminar();
            if(formEliminar.ShowDialog() == DialogResult.OK)
            {
                int indice = dataGridView1.CurrentRow.Index;
                dataGridView1.DataSource = new BindingList<PromocionXProductoWS.promocionXProducto>();

                VisitaWS.visita[] visitas = new VisitaWS.visita[misVisitas.Count - 1];
                for (int cont = 0; cont < misVisitas.Count; cont++)
                {
                    if(cont!=indice) visitas[cont] = misVisitas.ElementAt(cont);
                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = new BindingList<VisitaWS.visita>();
                misVisitas = new BindingList<VisitaWS.visita>(visitas.ToArray());
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = misVisitas;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            VisitaWS.visita v = dataGridView1.Rows[e.RowIndex].DataBoundItem as VisitaWS.visita;

            dataGridView1.Rows[e.RowIndex].Cells["NRO"].Value = e.RowIndex + 1;
            dataGridView1.Rows[e.RowIndex].Cells["RUC"].Value = v.cliente.ruc;
            dataGridView1.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = v.cliente.razonSocial;
            dataGridView1.Rows[e.RowIndex].Cells["GRUPO"].Value = v.cliente.grupo;
            dataGridView1.Rows[e.RowIndex].Cells["TIPO_CLIENTE"].Value = v.cliente.tipoEmpresa;
            dataGridView1.Rows[e.RowIndex].Cells["ZONA"].Value = v.cliente.zona.nombre;
            dataGridView1.Rows[e.RowIndex].Cells["DIRECCION"].Value = v.cliente.direccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (misVisitas == null || misVisitas.Count == 0)
            {
                MessageBox.Show("Falta agregar los clientes a la cartera",
                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                CarteraWS.cartera cartera = new CarteraWS.cartera();
                cartera.idCartera = frmGestionarCarteras.empleadoSeleccionado.cartera.idCartera;
                cartera.empleado = new CarteraWS.empleado();
                cartera.empleado.idEmpleado = frmGestionarCarteras.empleadoSeleccionado.idEmpleado;
                int numVisitas = misVisitas.Count;
                cartera.listaVisita = new CarteraWS.visita[numVisitas];
                for (int cont = 0; cont < numVisitas; cont++)
                {
                    cartera.listaVisita[cont] = new CarteraWS.visita();
                    cartera.listaVisita[cont].cliente = new CarteraWS.cliente();
                    cartera.listaVisita[cont].cliente.idCliente = ((VisitaWS.visita)misVisitas.ElementAt(cont)).cliente.idCliente;
                    cartera.listaVisita[cont].fechaRegistro = ((VisitaWS.visita)misVisitas.ElementAt(cont)).fechaRegistro;
                    cartera.listaVisita[cont].fechaRegistroSpecified = true;
                    cartera.listaVisita[cont].estado = ((VisitaWS.visita)misVisitas.ElementAt(cont)).estado;
                }
                if (frmVentanaPrincipal.nBtn == 1)  
                {
                    int resultado = daoCartera.actualizarCartera(cartera);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se actualizó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ((frmGestionarCarteras)Program.pantallas[Program.pantallas.Count - 2].Formulario).recargarDGV();
                        MessageBox.Show("Se actualizó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}