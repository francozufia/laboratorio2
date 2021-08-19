using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio;
            Random numero = new Random();
            aleatorio = numero.Next(1, 101);
            Console.WriteLine("El numero aleatorio generado es : {0}", aleatorio);
        }
    }
}
