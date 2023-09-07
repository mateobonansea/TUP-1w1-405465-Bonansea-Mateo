using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetApp.Datos;
using VetApp.Dominio;
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
            WindowState = FormWindowState.Maximized;


        }
      

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtenciones atenciones = new FrmAtenciones();
            atenciones.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnAtencion_Click(object sender, EventArgs e)
        {

        }

        private void LstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consultarMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarMascotas mascotas = new FrmConsultarMascotas();
            mascotas.ShowDialog();
        }
    }
}
