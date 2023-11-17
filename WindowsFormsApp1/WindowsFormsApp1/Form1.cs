using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<IProductos> lista; 

        enum Tipo
            {
            Suelto,
            Pack
            
        }
        Tipo miTipo; 
        public Form1()
        {
            InitializeComponent();
            lista= new List<IProductos>();
            miTipo = Tipo.Suelto;
        }

        private void rbtnSuelto_CheckedChanged(object sender, EventArgs e)
        {
            miTipo = Tipo.Suelto;
            label3.Text = "Medida";
        }

        private void rbtnPack_CheckedChanged(object sender, EventArgs e)
        {
            miTipo = Tipo.Pack;
            label3.Text = "Cantidad";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Focus();
                return;
  
            }
            if (txtMedida.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una medida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMedida.Focus();
                return;

            }
            if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;

            }
            if (txtPrecio.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un precio", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return;

            }
            if (rbtnPack.Checked == false && rbtnSuelto.Checked == false )
            {
                MessageBox.Show("Debe ingresar un TIPO", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Focus();
                return;

            }
            int codigo = int.Parse(txtCodigo.Text);
            double precio = double.Parse(txtPrecio.Text);
            string nombre= txtNombre.Text;
            int unidad = int.Parse(txtMedida.Text);

            if (miTipo==Tipo.Pack)
            {
                Pack pack = new Pack(codigo,nombre,precio,unidad);
                lista.Add(pack);
                
            }
            if (miTipo == Tipo.Suelto)
            {
                Suelto suelto = new Suelto(codigo, nombre, precio, unidad);
                lista.Add(suelto);
            }

            lstProductos.Items.Clear();
            lstProductos.Items.AddRange(lista.ToArray());
           

            txtCodigo.Text = String.Empty;
            txtMedida.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            rbtnPack.Checked = false;
            rbtnSuelto.Checked = false;
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (IProductos p in lstProductos.Items)
            {
                total += p.CalcularPrecio();
                txtTotal.Text = total.ToString();


            }
        }
    }
}
