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

        public override string ToString()
        {
            return "Provincia: " + Provincia.Nombre + " - Localidad: " + Nombre;
        }
        //public Localidad(int idProvincia)
        //{
        //    Provincia = new Provincia(idProvincia);
        //}

    }
}
