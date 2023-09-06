using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Dominio
{
    public class Atencion
    {
        public int IdAtencion { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }
        public DateTime Fecha { get; set; }

        

        public Atencion()
        {
            IdAtencion = 0;
            Descripcion = string.Empty;
            Importe = 0;   
            Fecha = DateTime.Today;
            
        }



    }
}
