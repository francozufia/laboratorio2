using System;

namespace ejercicioOperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion.pedirDatos();
            Console.WriteLine("La suma es : " + Operacion.suma());
            Console.WriteLine("La resta es : " + Operacion.resta());
        }
    }
}
