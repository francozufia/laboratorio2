using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Random dado1 = new Random();
            Random dado2 = new Random();

            num1 = dado1.Next(1, 12);
            num2 = dado2.Next(11, 21);

            Console.WriteLine("En el primer dado salio el numero : {0} ",num1);
            Console.WriteLine("En el segundo dado salio el numero : {0} ", num2);

        }
    }
}
