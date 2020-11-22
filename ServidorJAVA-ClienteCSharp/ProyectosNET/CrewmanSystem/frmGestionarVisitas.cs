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
    public partial class frmGestionarVisitas : Form
    {
        private VisitaWS.VisitaWSClient daoVisita;
        private BindingList<VisitaWS.visita> misVisitas;

        public frmGestionarVisitas()
        {
            InitializeComponent();
            daoVisita = new VisitaWS.VisitaWSClient();
            VisitaWS.visita[] visitas = daoVisita.listarVisitas(Program.empleado.cartera.idCartera);
            if (visitas == null || visitas.Length < 1) misVisitas = new BindingList<VisitaWS.visita>();
            else misVisitas = new BindingList<VisitaWS.visita>(visitas);
            dgvVisitas.AutoGenerateColumns = false;
            dgvVisitas.DataSource = misVisitas;
        }

        private void dgvVisitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            VisitaWS.visita v = dgvVisitas.Rows[e.RowIndex].DataBoundItem as VisitaWS.visita;

            dgvVisitas.Rows[e.RowIndex].Cells["RUC"].Value = v.cliente.ruc;
            dgvVisitas.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = v.cliente.razonSocial;
        }
    }
}
