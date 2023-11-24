using BackEnd.Datos.Implementacion;
using BackEnd.Datos.Interfaz;
using BackEnd.Entidades;
using BackEnd.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IPresupuestoDao presupuestoDao;
        public Aplicacion()
        {
                presupuestoDao= new PresupuestoDao();
        }
        public List<Producto> GetProductos()
        {
            return presupuestoDao.ObtenerProductos();
        }

        public bool SavePresupuesto(Presupuesto p)
        {
           return presupuestoDao.Crear(p);
        }
    }
}
