using System;

namespace EquiposBackend.Dominio
{
    public class Persona
    {
        public int CodPersona { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int TipoDoc { get; set; }

        public int NumeroDoc { get; set; }

        public DateTime FechaNac { get; set; }

        public int PiernaHabil { get; set; }

        public double Peso { get; set; }

        public double Estatura { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime? FechaBaja { get; set; }

        /*public string GetFechaBajaFormato()
        {
            string aux = FechaBaja.ToString("dd/MM/yyyy");
            return aux.Equals("01/01/0001") ? "" : aux;
        }*/
    }
}
