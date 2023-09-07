using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Dominio
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }

        public List<Atencion> lstAtenciones { get; set; }

        public Mascota(int IdMascota, int Edad, string Nombre, int Tipo)
        {
            this.IdMascota = IdMascota;
            this.Edad = Edad;
            this.Nombre = Nombre;
            this.Tipo = Tipo;
            lstAtenciones = new List<Atencion>();
        }
        public Mascota() 
        {
            IdMascota = 0;
            Edad = 0;
            Nombre = string.Empty;
            Tipo = 0;
            lstAtenciones = new List<Atencion>();
        }

        public override string ToString()
        {
            return Nombre + ", " + Tipo; ;
        }
        public void AgregarAtencion(Atencion atencion)
        {
            lstAtenciones.Add(atencion);
        }
        public void QuitarAtencion(int indice)
        {
            lstAtenciones.RemoveAt(indice);
        }

    }
}
