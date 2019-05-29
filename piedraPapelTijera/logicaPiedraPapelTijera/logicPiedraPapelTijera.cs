using System;

namespace logicaPiedraPapelTijera
{
    public class logicPiedraPapelTijera
    {
        public static string[] jugadas = { "piedra", "papel", "tijera" };
        public static void jugar()
        {
            mostrarJugadas();
            Console.Write("\nOpción Jugador 1: ");
            string opcionj1 = Console.ReadLine().ToUpper();
            Console.Write("\nOpción Jugador 2: ");
            string opcionj2 = Console.ReadLine().ToUpper();
            partida(opcionj1, opcionj2);
        }
        public static void mostrarJugadas()
        {
            Console.WriteLine("\n\nEstas son las jugadas disponibles:");
            for (int i = 0; i < jugadas.Length; i++)
            {
                Console.WriteLine("- " + jugadas[i].ToUpper());
            }
        }
        public static void partida(string jugada1, string jugada2)
        {
            Console.WriteLine();
            const string uno = "PIEDRA";
            const string dos = "PAPEL";
            const string tres = "TIJERA";
            switch (jugada1)
            {
                case uno:
                    switch (jugada2)
                    {
                        case uno:
                            Console.WriteLine("---- EMPATAN ----");
                            break;
                        case dos:
                            Console.WriteLine("---- GANA EL JUGADOR 2 ----");
                            break;
                        case tres:
                            Console.WriteLine("---- GANA EL JUGADOR 1 ----");
                            break;
                        default:
                            Console.WriteLine("---- EL JUGADOR 2 NO HA INSERTADO UNA JUGADA CORRECTA ----");
                            break;
                    }
                    break;
                case dos:
                    switch (jugada2)
                    {
                        case uno:
                            Console.WriteLine("---- GANA EL JUGADOR 1 ----");
                            break;
                        case dos:
                            Console.WriteLine("---- EMPATAN ----");
                            break;
                        case tres:
                            Console.WriteLine("---- GANA EL JUGADOR 2 ----");
                            break;
                        default:
                            Console.WriteLine("---- EL JUGADOR 2 NO HA INSERTADO UNA JUGADA CORRECTA ----");
                            break;
                    }
                    break;
                case tres:
                    switch (jugada2)
                    {
                        case uno:
                            Console.WriteLine("---- GANA EL JUGADOR 2 ----");
                            break;
                        case dos:
                            Console.WriteLine("---- GANA EL JUGADOR 1 ----");
                            break;
                        case tres:
                            Console.WriteLine("---- EMPATAN ----");
                            break;
                        default:
                            Console.WriteLine("---- EL JUGADOR 2 NO HA INSERTADO UNA JUGADA CORRECTA ----");
                            break;
                    }
                    break;
                default:
                    Console.Write("---- EL JUGADOR 1 NO HA INSERTADO UNA JUGADA CORRECTA ----");
                    break;
            }
        }
    }

}