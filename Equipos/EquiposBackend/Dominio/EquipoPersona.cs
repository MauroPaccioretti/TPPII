using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class EquipoPersona
    {
        public Persona persona { get; set; }
        public int codPosicion { get; set; }
        public int camiseta { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaBaja { get; set; }
    }
}
