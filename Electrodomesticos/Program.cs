using System;
using System.Collections.Generic;

namespace Electrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0 , aux = 0;
            List<Electrodomestico> electro = new List<Electrodomestico>();
            Electrodomestico electrodomestico = new Electrodomestico(20000, "azul", 'E', 15);
            Lavadora lavaropa = new Lavadora(15000, "blanco", 'A', 50, 30);
            Televisor tele = new Televisor(10000, "negro", 'F', 3, 42, true);

            electro.Add(electrodomestico);
            electro.Add(lavaropa);
            electro.Add(tele);

            foreach(Electrodomestico producto in electro)
            {
               Console.WriteLine(producto.GetType().Name + " --> $ " + producto.precioFinal());
            }

 
        }
    }
}
