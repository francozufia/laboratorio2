using System;
using System.Threading;
using System.Threading.Tasks;

namespace juego2
{
    class Program
    {
        static void Main(string[] args)
        {
            //POsiscion de las fichas
            ConsoleKeyInfo tecla;
            int x = 4, y = 10;
            int xo1 = 20, yo1 = 15; // Obstáculo 1
            int xo2 = 25, yo2 = 5; // Obstáculo 2
            int xo3 = 62, yo3 = 21; // Obstáculo 3
            int fin = 0; // 0 = no terminado, 1 = terminado
            float xe1 = 30, ye1 = 6;
            float incr1 = 0.5f;

            
            while (fin == 0)
            {
                // "Personaje"
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("*");

                // Obstáculos
                Console.SetCursorPosition(xo1, yo1); 
                Console.Write("o");
                Console.SetCursorPosition(xo2, yo2);
                Console.Write("o");
                Console.SetCursorPosition(xo3, yo3);
                Console.Write("o");

                // Enemigo
                Console.SetCursorPosition((int)xe1,(int) ye1); 
                Console.Write("<x>");

                //Moverte por el mapa
                tecla = Console.ReadKey(false);

                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                }
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    y--;
                }

                //Movimiento del enemigo
                xe1 = xe1 + incr1;
                ye1 = ye1 + 0.5f;
                xe1 = xe1 - (int)1;
                
                
                //verificar que no te salis del mapa
                if ((xe1 == 0) || (ye1 == 79))
                {
                    incr1 = -incr1;
                }

                //Verificar colisiones 

                if (((x == xo1) && (y == yo1))|| ((x == xo2) && (y == yo2))|| ((x == xo3) && (y == yo3)))
                {
                    Console.Clear();
                    Console.WriteLine("Perdiste colisionaste con un obstaculo");
                    fin = 1;
                }
                if((x == xe1) && (y == ye1)){
                    Console.Clear();
                    Console.WriteLine("Perdiste colisisonaste con el enemigo");
                    fin = 1;
                }
                //Thread.Sleep(2);
                Task.Delay(1);
            }
        }
    }
}
