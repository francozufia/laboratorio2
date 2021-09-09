using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioOperacion
{
    static class Operacion
    {
        private static int n1 , n2;
        static public void pedirDatos()
        {
            Console.Write("Ingrese el primer numero : ");
            n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero : ");
            n2 = Int32.Parse(Console.ReadLine());
        }
       static public int suma()
        {
            return n1 + n2;
        }

        static public int resta()
        {
            return n1 - n2;
        }
    }
}