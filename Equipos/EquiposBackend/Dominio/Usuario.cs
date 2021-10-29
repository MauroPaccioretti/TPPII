using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class Usuario
    {
        public int CodUser { get; set; }

        public string User { get; set; }

        public string Pass { get; set; }

        public DateTime FechaBaja { get; set; }

        public string Email { get; set; }
    }
}
