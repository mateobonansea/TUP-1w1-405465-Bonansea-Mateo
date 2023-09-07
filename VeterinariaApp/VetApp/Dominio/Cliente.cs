using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Dominio
{
    public class Cliente
    {
     
        public string Nombre { get; set; }
        public int Sexo { get; set; }
        public int IdCliente { get; set; }

        public List<Mascota> lstMascotas { get; set; }

        public Cliente(int IdCliente, string Nombre, int Sexo )
        {
            this.IdCliente = IdCliente;
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            lstMascotas = new List<Mascota>();
        }

        public Cliente()
        {
            Nombre = string.Empty;
            Sexo = 0;
            IdCliente = 0;
            lstMascotas = new List<Mascota>();
        }
        
       
        public void AgregarMascota(Mascota mascota)
        {
            lstMascotas.Add(mascota);
        }
       

        public override string ToString()
        {
            return "Nombre del Cliente: " + Nombre;
        }

    }
}