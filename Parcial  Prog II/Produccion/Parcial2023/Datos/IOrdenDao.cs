using Produccion.Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produccion.Datos
{
    public interface IOrdenDao
    {
        List<Componente> ObtenerComponentes();
        int CrearOrden(OrdenProduccion equipo);
    }
}
