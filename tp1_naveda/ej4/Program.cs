using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio;
            int apuesta;
            int intentos = 13;

            Random dado = new Random();
            aleatorio = dado.Next(1, 10001);
            do
            {

                Console.Write("Se tiro el dado,¿ a que numero le apostas ? : ");
                do
                {
                    apuesta = Convert.ToInt32(Console.ReadLine());

                    if (apuesta < 1 || apuesta > 10000)
                    {
                        Console.WriteLine("Ingrese un numero del 1 al 10000 \n");
                    }

                } while (apuesta < 1 || apuesta > 10000);

                if (apuesta == aleatorio)
                {
                    Console.WriteLine("¡ Felicidades acertaste al numero({0})! \n",aleatorio);
                }
                else if(aleatorio<apuesta)
                {
                    Console.WriteLine("Te pasaste \n", aleatorio);
                    intentos = intentos - 1;
                    Console.WriteLine("Quedan {0} intentos \n ", intentos);
                }
                else if (aleatorio > apuesta)
                {
                    Console.WriteLine("Te quedaste corto \n", aleatorio);
                    intentos = intentos - 1;
                    Console.WriteLine("Quedan {0} intentos \n ", intentos);
                }

            } while (intentos > 0);
            
            Console.WriteLine("El numero era : {0} ", aleatorio);

            Console.ReadKey();

        }
    }
}
