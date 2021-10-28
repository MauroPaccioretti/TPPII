using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class Equipo
    {
        public int CodEquipo { get; set; }
        public string Nombre { get; set; }
        public int CodLocalidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }

        public List<EquipoPersona> Jugadores { get; set; }

        public Equipo()
        {
            Jugadores = new List<EquipoPersona>();
        }



        /*

        private int nombreEquipo;
        private string directorTecnico;
        public int NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public string DirectorTecnico { get => directorTecnico; set => directorTecnico = value; }

        //ACA DIGO, QUE UN EQUIPO SE FORMA DE UNO O VARIOS JUGADORES
        //POR ESO CREO UNA LISTA DE JUGADORES.

        public List<Jugador> Jugadores { get; }

        public Equipo(int nombE, string DT)
        {
            NombreEquipo = nombE;
            DirectorTecnico = DT;
            Jugadores = new List<Jugador>();

        }


        public Equipo()
        {
            nombreEquipo = 0;
            directorTecnico = "";
        }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public void QuitarJugador(int nroJugador)
        {
            Jugadores.RemoveAt(nroJugador);
        }

        */
    }
}
