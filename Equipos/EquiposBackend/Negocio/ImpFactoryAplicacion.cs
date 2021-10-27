using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Negocio
{
    public class ImpFactoryAplicacion : AbstractFactoryAplicacion
    {
        public override IAplicacion CrearService()
        {
            return new Aplicacion();
        }
    }
}
