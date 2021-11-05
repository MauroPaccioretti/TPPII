namespace EquiposBackend.Negocio
{
    public class ImpFactoryAplicacion : AbstractFactoryAplicacion
    {
        public override IAplicacion CrearService()
        {
            return new Aplicacion();
        }
    }
}
