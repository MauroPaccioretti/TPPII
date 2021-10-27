using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Dominio
{
    public class Equipo
    {
        public int codEquipo { get; set; }
        public string nombre { get; set; }
        public int codLocalidad { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaBaja { get; set; }

        List<EquipoPersona> jugadores;

        public Equipo()
        {
            jugadores = new List<EquipoPersona>();
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
