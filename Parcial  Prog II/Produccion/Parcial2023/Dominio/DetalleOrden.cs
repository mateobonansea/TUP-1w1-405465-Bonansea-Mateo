using Produccion.Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2023.Dominio
{
    public class DetalleOrden
    {
        private int id;
        Componente componente;
        private int cantidad;

        public DetalleOrden( Componente componente, int cantidad)
        {
            
            this.Componente = componente;
            this.Cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public Componente Componente { get => componente; set => componente = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }


        public int calcularSubTotal()
        {
            int subtotal;

            subtotal = cantidad * 100;

            return subtotal;
        }
    }
}
