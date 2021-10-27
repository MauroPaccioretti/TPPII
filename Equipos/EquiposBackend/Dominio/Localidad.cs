using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class Localidad
    {
        public int IDLocalidad { get; set; }
        public string Nombre { get; set; }
        public Provincia Provincia { get; set; }

        public Localidad()
        {
            Provincia = new Provincia();
        }

        public Localidad(int idProvincia)
        {
            Provincia = new Provincia(idProvincia);
        }

    }
}
