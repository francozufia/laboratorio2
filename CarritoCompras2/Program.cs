using System;
using System.Threading;

namespace CarritoCompras2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();
            Console.WriteLine("SHOPPING ONLINE DE CAMISAS - VENTAS MINORISTAS Y MAYORISTAS ");
            Thread.Sleep(2000);
            carrito.menu();
        }
    }
}
