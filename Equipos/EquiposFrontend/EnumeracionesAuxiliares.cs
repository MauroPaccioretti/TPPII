using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposFrontend
{
   

        public enum TablasSoporte
        {
            paises,
            provincias,
            localidades,
            tipoDocumentos,
            tipoCompromisos
        }

        public enum Accion
        {
            Agregar,
            Modificar,
            Eliminar
        }

        public enum Posiciones
        {
            [Description("Arquero")] Arquero = 1,
            [Description("Defensa Central")] DefensaCentral = 2,
            [Description("Lateral")] Lateral = 3,
            [Description("Mediocampista")] Mediocampista = 4,
            [Description("Delantero")] Delantero = 5
        }

}
