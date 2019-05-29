using System;

namespace libreriaObjetos
{
    public class Jugadores
    {
        private string jugadaJugador1;
        private string jugadaJugador2;
        private string[] jugadores = { "Jugador 1: ", "Jugador 2: " };
        public string Jugador1
        {
            get
            {
                return jugadaJugador1;
            }
            set
            {
                jugadaJugador1 = value;
            }
        }
        public string Jugador2
        {
            get
            {
                return jugadaJugador2;
            }
            set
            {
                jugadaJugador2 = value;
            }
        }
        public void Ganador()
        {
            logicaJuego.verQuienGana(jugadaJugador1,jugadaJugador2);
        }
        public void mostrarJugadasSeleccionadas()
        {
            Console.WriteLine(jugadores[0] + jugadaJugador1);
            Console.WriteLine(jugadores[1] + jugadaJugador2);
        }
    }
}