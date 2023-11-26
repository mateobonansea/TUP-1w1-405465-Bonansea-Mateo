using Produccion.Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2023
{
    public interface IServicio
    {
        List<Componente> ObtenerComponentes();
        int CrearOrden(OrdenProduccion equipo);
    }
}
