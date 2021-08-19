using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio;
            int apuesta;
            int intentos = 3;

            do
            {
                Random dado = new Random();
                aleatorio = dado.Next(1, 7);

                Console.Write("Se tiro el dado,¿ a que numero le apostas ? : ");
                do
                {
                    apuesta = Convert.ToInt32(Console.ReadLine());

                    if (apuesta < 1 || apuesta > 6)
                    {
                        Console.WriteLine("Ingrese un numero del 1 al 6 \n");
                    }

                } while (apuesta < 1 || apuesta > 6);

                if (apuesta == aleatorio)
                {
                    Console.WriteLine("¡ Felicidades acertaste al numero ! \n");
                }
                else
                {
                    Console.WriteLine("Fallaste el numero era : {0} \n", aleatorio);
                    intentos = intentos - 1;
                    Console.WriteLine("Quedan {0} intentos \n ", intentos);
                }

            } while (intentos > 0);

            Console.ReadKey();

        }
    }
}
