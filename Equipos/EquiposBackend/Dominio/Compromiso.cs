using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class Compromiso
    {
        public int CodCompromiso { get; set; }
        public int CodEquipo { get; set; }
        public TipoCompromisos TipoCompromiso { get; set; }
        public string ComentariosCompromiso { get; set; }
        public DateTime FechaCompromiso { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

    }
}
