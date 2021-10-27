using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class Persona
    {
        public int codPersona { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int tipoDoc { get; set; }

        public int numeroDoc { get; set; }

        public DateTime fechaNac { get; set; }

        public int piernaHabil { get; set; }

        public double peso { get; set; }

        public double estatura { get; set; }

        public DateTime fechaAlta { get; set; }

        public DateTime fechaBaja { get; set; }
    }
}
