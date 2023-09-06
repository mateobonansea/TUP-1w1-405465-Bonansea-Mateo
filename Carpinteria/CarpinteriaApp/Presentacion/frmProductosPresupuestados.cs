using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaApp.Presentacion
{
    public partial class frmProductosPresupuestados : Form
    {
        public frmProductosPresupuestados()
        {
            InitializeComponent();
        }

        private void frmProductosPresupuestados_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-7);
            dtpFechaHasta.Value = DateTime.Now;
            this.reportViewer1.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

           this.sP_REPORTE_PRODUCTOSTableAdapter.Fill(this.dSProductosPrersupuestados.SP_REPORTE_PRODUCTOS, dtpFechaDesde.Value, dtpFechaHasta.Value);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


        }
    }
}
