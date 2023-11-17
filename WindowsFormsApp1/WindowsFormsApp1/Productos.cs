using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Productos: IProductos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public double Precio { get; set; }
        public Productos(int codigo, string nombre, double precio)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            
           
        }
        public Productos()
        {
            this.Codigo = 0;
            this.Nombre = "";
            this.Precio = 0;
          
        }
        
        public abstract double CalcularPrecio();


    public override string ToString()
    {


        return  Codigo +  " - " + Nombre + " - $" + CalcularPrecio();
    }
}
}
