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

namespace VetApp.Presentacion
{
    public partial class FrmConsultarMascotas : Form
    {
        DbHelper dbHelper;
        public FrmConsultarMascotas()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
        }

        private void dgvPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (txtMascota.Text.Equals(string.Empty))
            {
                MessageBox.Show("Ingrese el nombre de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMascota.Focus();

            }
            Parametro p = new Parametro("@nombre", txtMascota.Text);
            
            DataTable tabla = dbHelper.ConsultarMascota("SP_CONSULTAR_MASCOTAS",p );
            dgvPresupuestos.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvPresupuestos.Rows.Add(new object[]
                {
                    fila[0].ToString(),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    fila[3].ToString(),
                    fila[4].ToString(),
                });

            }

        }

        private void FrmConsultarAtenciones_Load(object sender, EventArgs e)
        {
         

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
