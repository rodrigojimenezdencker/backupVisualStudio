using System;
using libreriaObjetos;

namespace consolaPiedraPapelTijera2
{
    class Inicio
    {
        static void Main(string[] args)
        {
            Jugadas.mostrarJugadas();
            Console.WriteLine();
            Jugadores jugadorActual = new Jugadores();
            jugadorActual.Jugador1 = "PIEDRA";
            jugadorActual.Jugador2 = "PAPEL";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "TIJERA";
            jugadorActual.Jugador2 = "PAPEL";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "PIEDRA";
            jugadorActual.Jugador2 = "TIJERA";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "PIEDRA";
            jugadorActual.Jugador2 = "PIEDRA";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "PAPEL";
            jugadorActual.Jugador2 = "TIJERA";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "PAPEL";
            jugadorActual.Jugador2 = "PAPEL";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "TIJERA";
            jugadorActual.Jugador2 = "PAPEL";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "TIJERA";
            jugadorActual.Jugador2 = "PIEDRA";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "PIEDRA";
            jugadorActual.Jugador2 = "PAPEL";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();

            Console.WriteLine();
            jugadorActual.Jugador1 = "TIJERA";
            jugadorActual.Jugador2 = "PIEDRA";
            jugadorActual.mostrarJugadasSeleccionadas();
            jugadorActual.Ganador();
        }
    }
}
