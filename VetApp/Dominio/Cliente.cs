using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Dominio
{
    public class Cliente
    {
<<<<<<< HEAD
     
        public string Nombre { get; set; }
        public int Sexo { get; set; }
        public int IdCliente { get; set; }

        public List<Mascota> lstMascotas { get; set; }
=======
        public string Nombre { get => Nombre; set => Nombre = value; }
        public int Sexo { get => Sexo; set => Sexo = value; }
        public int IdCliente { get => IdCliente; set => IdCliente = value; }
        public List<Mascota>lstMascotas { get; set; }
>>>>>>> 0050d59d0810a7c986642986272672392abaf514

        public Cliente(string Nombre, int Sexo, int IdCliente)
        {
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.IdCliente = IdCliente;
        }

        public Cliente()
        {
            Nombre = string.Empty;
            Sexo = 0;
            IdCliente = 0;
            lstMascotas = new List<Mascota>();
        }

      


        
    }
}