using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Presentacion
{
    public partial class FrmDetallesPresupuesto : Form
    {
        public FrmDetallesPresupuesto(int presupuestoNro)
        {
            InitializeComponent();
            this.Text += presupuestoNro.ToString();
        }
        public int presupuestoNro { get; set; }

        private void FrmDetallesPresupuesto_Load(object sender, EventArgs e)
        {

        }


        private void FrmDetallesPresupuesto_Load_1(object sender, EventArgs e)
        {

        }
    }
}
