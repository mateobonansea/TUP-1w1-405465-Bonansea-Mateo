using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Pack : Productos
    {
        public int Cantidad { get; set; }

        public Pack(int codigo, string nombre, double precio, int cantidad) : base(codigo, nombre, precio)
        {

            Cantidad = cantidad;
        }

        public override double CalcularPrecio()
        {
            return Cantidad * Precio;
        }

        public override string ToString()
        {
            return base.ToString() + " - Pack - Cantidad: " + Cantidad + " . ";
        }
    }
}
