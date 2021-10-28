using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class Provincia
    {
        public int IDProvincia { get; set; }
        public string Nombre { get; set; }
        public Pais Pais { get; set; }

        public Provincia()
        {
            Pais = new Pais();
        }
        //public Provincia(int idPais)
        //{
        //    Pais = new Pais(idPais);
        //}
    }
}
