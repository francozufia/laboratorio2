using System;

namespace imprimible
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean sigue;
            Impresora impresora = new Impresora();

            do
            {
                sigue = true;
                Console.WriteLine("Agregar a la Cola\n");
                impresora.agegarImprimible();
                Console.WriteLine("________________________");
                Console.WriteLine("Impreso\n");
                impresora.imprimirTodo();
                Console.WriteLine("________________________\n");
            } while (sigue != false);
        }
    }
}
