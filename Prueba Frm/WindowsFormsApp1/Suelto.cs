using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Suelto : Productos
    {

        public int Medida { get;  set; }

        public Suelto(int codigo, string nombre, double precio, int medida):base(codigo,nombre,precio)
        {

            Medida = medida;
        }

        public override double CalcularPrecio()
        {
            return Medida * Precio;
        }

        public override string ToString()
        {
            return base.ToString()+ " - Suelto - Medida: " + Medida + " . " ;
        }
    }
}
