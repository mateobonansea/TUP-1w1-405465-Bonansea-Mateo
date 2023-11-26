using Parcial2023;
using Parcial2023.Datos;
using Parcial2023.Dominio;
using Produccion.Datos;
using Produccion.Domino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//COMPLETAR --> Curso: 1w1     Legajo: 405465         Apellido y Nombre: Bonansea, Mateo Ignacio

//CadenaDeConexion: "Data Source=172.16.10.196;Initial Catalog=Produccion;User ID=alumno1w1;Password=alumno1w1"

namespace Produccion.Presentacion
{
    public partial class FrmAlta : Form
    {
        IServicio servicio = null;
        OrdenProduccion nuevaOrden;

        public FrmAlta()
        {
            servicio= new Servicio();
            nuevaOrden = new OrdenProduccion();
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            dtpFecha.Value= DateTime.Now;
            cboComponente.DataSource = servicio.ObtenerComponentes();
            cboComponente.ValueMember = "codigo";
            cboComponente.DisplayMember = "nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (cboComponente.SelectedIndex < 0)
            {
                MessageBox.Show("Ingrese un componente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (nudCantidad.Value < 1)
            {
                MessageBox.Show("Ingrese una cantidad valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (nudCantidadDetalle.Value < 1)
            {
                MessageBox.Show("Ingrese una cantidad de componente valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColComponente"].Value.ToString() == cboComponente.Text)
                {

                    MessageBox.Show("Componente repetido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            
            Componente componente = cboComponente.SelectedItem as Componente;
            
            int cantidadDetalle = (int)nudCantidadDetalle.Value;
            int subtotal = cantidadDetalle * 100;

            DetalleOrden detalle = new DetalleOrden(componente, cantidadDetalle);
            nuevaOrden.AgregarDetalle(detalle);
           
            
            dgvDetalles.Rows.Add(new object[] { componente.Nombre, cantidadDetalle, subtotal, "Quitar" });
        }

            private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDT.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Modelo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (dgvDetalles.RowCount == 0)
            {
                MessageBox.Show("Ingrese un detalle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (dgvDetalles.RowCount<2)
            {
                MessageBox.Show("“El modelo debe tener como mínimo dos componentes", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            nuevaOrden.Cantidad = (int)nudCantidad.Value;
            nuevaOrden.Fecha = dtpFecha.Value;
            nuevaOrden.Modelo = txtDT.Text;
            nuevaOrden.Estado = "Creada";
            int nro_orden = servicio.CrearOrden(nuevaOrden);

            if (nro_orden != 0)
            {
                MessageBox.Show("Se registró con éxito la Orden de Produccion.\nNro: " + nro_orden.ToString(), "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                nuevaOrden = new OrdenProduccion();
                
            }
            else
            {
                MessageBox.Show("NO se pudo registrar la Orden de Produccion...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
            
        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDetalles.CurrentRow.Index;
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {

                nuevaOrden.QuitarDetalle(index);
                dgvDetalles.Rows.RemoveAt(index);

            } 
        }
    }
}
