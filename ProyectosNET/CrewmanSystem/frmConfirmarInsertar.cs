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
    public partial class frmConfirmarInsertar : Form
    {
        private bool _decision = false;
        public frmConfirmarInsertar()
        {
            InitializeComponent();
        }

        public bool Decision { get => _decision; set => _decision = value; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            _decision = true;
            this.Hide();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _decision = false;
            this.Hide();
            this.Close();
        }
    }
}
