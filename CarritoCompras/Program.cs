using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito(1000);
            Console.Write("SHOPPING ONLINE DE CAMISAS - VENTAS MINORISTAS Y MAYORISTAS \n ___________________________________________________________ \n");
            carrito.menu();
        }
    }
}
