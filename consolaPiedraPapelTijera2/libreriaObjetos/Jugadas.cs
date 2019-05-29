using System;
using System.Collections.Generic;
using System.Text;

namespace libreriaObjetos
{
    public class Jugadas
    {
        public static string[] jugadas = { "PIEDRA", "PAPEL", "TIJERA" };
        public static void mostrarJugadas()
        {
            Console.WriteLine("Jugadas posibles:");
            for (int i = 0; i < jugadas.Length; i++)
            {
                Console.Write(jugadas[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}