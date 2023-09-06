using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetApp.Presentacion;
using VetApp.Vistas;

namespace VetApp
{
    public partial class FrmVeterinaria : Form
    {
        public FrmVeterinaria()
        {
            InitializeComponent();
        
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void nuevaAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtenciones atenciones = new FrmAtenciones();
            atenciones.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmVeterinaria_Load(object sender, EventArgs e)
        {

        }

        private void mascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
