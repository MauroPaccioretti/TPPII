namespace EquiposBackend.Dominio
{
    public class TipoCompromisos
    {
        public int CodCompromiso { get; set; }
        public string NombreCompromiso { get; set; }

        public override string ToString()
        {
            return NombreCompromiso;
        }
    }
}
