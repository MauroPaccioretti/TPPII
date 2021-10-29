using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class EquipoPersona
    {
        public int CodEP { get; set; }
        public int CodEquipo { get; set; }

        public Persona Persona { get; set; }
        public int CodPosicion { get; set; }
        public string Camiseta { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
