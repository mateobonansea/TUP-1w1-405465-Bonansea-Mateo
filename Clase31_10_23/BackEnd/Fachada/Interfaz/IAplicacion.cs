using BackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Fachada.Interfaz
{
    public interface IAplicacion
    {
        List<Producto>GetProductos();
        bool SavePresupuesto(Presupuesto p);
    }
}
