using System;
using System.Collections.Generic;

namespace EquiposBackend.Dominio
{
    public class Equipo
    {
        public int CodEquipo { get; set; }
        public string Nombre { get; set; }
        public int CodLocalidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime ?  FechaBaja { get; set; }
        public List<EquipoPersona> Jugadores { get; set; }
        public List<Compromiso> Compromisos { get; set; }


        public Equipo()
        {
            Jugadores = new List<EquipoPersona>();
            Compromisos = new List<Compromiso>();
        }

        public void AgregarJugador(EquipoPersona jugador)
        {
            Jugadores.Add(jugador);
        }

        public void QuitarJugador(int nroJugador)
        {
            Jugadores.RemoveAt(nroJugador);
        }

        public void AgregarCompromiso(Compromiso oCompromiso)
        {
            Compromisos.Add(oCompromiso);
        }

        public void QuitarCompromiso(int codCompromiso)
        {
            Compromisos.RemoveAt(codCompromiso);
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
