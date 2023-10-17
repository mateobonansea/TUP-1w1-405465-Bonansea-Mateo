namespace PrimeraWebAPI.Models
{
    public class Moneda
    {

        public string Nombre { get; set; }
        public double ValorEnPesos { get; set; }
        public Moneda() {
        
            Nombre= string.Empty;
            ValorEnPesos= 0;
        }
    }
}
