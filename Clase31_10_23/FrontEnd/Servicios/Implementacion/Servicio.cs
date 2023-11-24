using BackEnd.Datos.Implementacion;
using BackEnd.Datos.Interfaz;
using BackEnd.Entidades;
using FrontEnd.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IPresupuestoDao dao;
        public Servicio()
        {
            dao = new PresupuestoDao();
        }
        public bool CrearPresupuesto(Presupuesto oPresupuesto)
        {
           return dao.Crear(oPresupuesto);
        }

        public List<Producto> TraerProductos()
        {
            return dao.ObtenerProductos();
        }

        public int TraerProximoPresupuesto()
        {
            return dao.ObtenerProximoPresupuesto(); 
        }
    }
}
