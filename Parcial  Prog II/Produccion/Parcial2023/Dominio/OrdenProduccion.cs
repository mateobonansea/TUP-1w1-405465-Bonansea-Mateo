using Parcial2023.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Produccion.Domino
{
    public class OrdenProduccion
    {
        private int nro;
        private DateTime fecha;
        private string modelo;
        private int cantidad;
        private string estado;
        List<DetalleOrden> listadetalles;

        public OrdenProduccion(int nro, DateTime fecha, string modelo, int cantidad, string estado, List<DetalleOrden> listadetalles)
        {
            this.nro = nro;
            this.fecha = fecha;
            this.modelo = modelo;
            this.cantidad = cantidad;
            this.estado = estado;
            this.Listadetalles = listadetalles;
        }
        public OrdenProduccion()
        {
            this.nro = 0;
            this.fecha = DateTime.Now;
            this.modelo = "";
            this.cantidad = 0;
            this.estado = "";
            this.Listadetalles = new List<DetalleOrden>();
        }
        public int Nro { get => nro; set => nro = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Estado { get => estado; set => estado = value; }
        internal List<DetalleOrden> Listadetalles { get => listadetalles; set => listadetalles = value; }




        public void AgregarDetalle(DetalleOrden detalle)
        {

            listadetalles.Add(detalle);
        }

        internal void QuitarDetalle(int index)
        {
            listadetalles.RemoveAt(index); ;
        }
    }
}
