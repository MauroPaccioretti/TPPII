using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class Pais
    {
        public int IDPais { get; set; }
        public string Nombre { get; set; }

        public Pais()
        {

        }

        public override string ToString()
        {
            return Nombre;
        }
        //public Pais(int idPais)
        //{
        //    this.IDPais = idPais;
        //}
    }
}
