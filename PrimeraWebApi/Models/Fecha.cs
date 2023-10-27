namespace PrimeraWebAPI.Models
{
    public class Fecha
    {
        int dia;
        int mes;
        int año;
        string diaSemana;

        public Fecha(int dia, int mes, int año, string diaSemana)
        {
            
            this.Dia = dia;
            this.Mes = mes;
            this.Año = año;
            this.DiaSemana = diaSemana;
        }

        public Fecha() { 
        
            this.Dia = DateTime.Today.Day;
            this.Mes = DateTime.Today.Month;
            this.Año = DateTime.Today.Year;
            this.DiaSemana = DateTime.Today.DayOfWeek.ToString();
        
        }

   
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Año { get => año; set => año = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
    }

    
}
