using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Negocio
{
    public abstract class AbstractFactoryAplicacion
    {
        public abstract IAplicacion CrearService();
    }
}
