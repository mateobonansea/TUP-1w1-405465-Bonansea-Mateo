using Parcial2023.Datos;
using Produccion.Datos;
using Produccion.Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2023
{
    public class Servicio : IServicio
    {
        IOrdenDao ordenDao;

        public Servicio()
        {
            ordenDao = new OrdenDAO() ;
        }

        public int CrearOrden(OrdenProduccion equipo)
        {
            return ordenDao.CrearOrden(equipo);
        }

        public List<Componente> ObtenerComponentes()
        {
            return ordenDao.ObtenerComponentes();
        }
    }
}
