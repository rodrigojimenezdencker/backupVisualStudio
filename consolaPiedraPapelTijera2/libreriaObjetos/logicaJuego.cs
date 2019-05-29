using System;
using System.Collections.Generic;
using System.Text;

namespace libreriaObjetos
{
    public class logicaJuego
    {
        public static void verQuienGana(string jugada1, string jugada2)
        {
            const string uno = "PIEDRA";
            const string dos = "PAPEL";
            const string tres = "TIJERA";
            if (jugada1 == jugada2)
            {
                Console.WriteLine("---- EMPATAN ----");
            } else
            {
                switch (jugada1)
                {
                    case uno:
                        switch (jugada2)
                        {
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
}