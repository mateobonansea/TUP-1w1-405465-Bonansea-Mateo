using CarpinteriaApp.Servicios.Implementacion;
using CarpinteriaApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.Servicios
{
    internal class FabricaServicioslmp : FabricaServicios
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
