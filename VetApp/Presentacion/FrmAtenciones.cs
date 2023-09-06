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

namespace VetApp.Vistas
{
    public partial class FrmAtenciones : Form
    {
        DbHelper Gestor=null; 
        Cliente cliente=null;

        public FrmAtenciones()
        {
            InitializeComponent();
            Gestor= new DbHelper();
            cliente= new Cliente();
        }

        private void FrmAtenciones_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Today.ToShortDateString();
            TxtFecha.Enabled = false;
            cargarTipo();
            cargarClientes();
            //LblNroAtencion.Text = LblNroAtencion.Text + " " + Gestor.ProximaAtencion().ToString();
        }

        private void cargarTipo()
        {
            DataTable tabla = Gestor.Consultar("sp_tipo_mascota");
            cboTipo.DataSource = tabla;
            cboTipo.ValueMember = tabla.Columns[0].ColumnName;
            cboTipo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void cargarClientes()
        {
            DataTable tabla = Gestor.Consultar("sp_cliente");
            CboCliente.DataSource = tabla;
            CboCliente.ValueMember = tabla.Columns[0].ColumnName;
            CboCliente.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente para la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CboCliente.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TxtTratamiento.Text))
            {
                MessageBox.Show("Ingrese un tratamiento..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtTratamiento.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtFecha.Text))
            {
                MessageBox.Show("Ingrese el nombre de la mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtFecha.Focus();
                return;
            }
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de mascota..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipo.Focus();
                return;
            }

           
        }
    }
}
