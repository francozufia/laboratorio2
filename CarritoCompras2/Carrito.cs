using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarritoCompras2
{
    class Carrito
    {
        private bool sigue = true;
        private String decision;
        private int op;
        Camisa camisa = new Camisa(1000);
       
        public void menu()
        {
            while (sigue == true)
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL \n 1 : Añadir camisa al carro compras \n 2 : Eliminar camisa carro compras \n 3 : Salir");
                Console.WriteLine("______________________________________________________________");
                Console.WriteLine("             Cantidad de camisas en el carrito de compras : " + camisa.getcantidad());
                Console.WriteLine("             Precio unitario : " + camisa.getprecioUnitario());
                Console.WriteLine("             Precio total sin descuento  : $ " + camisa.getprecio() );
                Console.WriteLine("             El tipo de descuento aplicado es " + this.camisa.gettipoDescuento() + " %");
                Console.WriteLine("             Precio final con descuento  : $ " + this.camisa.getprecioDescuento());
                Console.WriteLine("_______________________________________________________________");
                do
                {
                    Console.Write("Opcion : ");
                    op = Convert.ToInt32(Console.ReadLine());
                } while (op < 1 || op > 3);
                Console.WriteLine("");

                switch (op)
                {
                    case 1:
                        camisa.agregarCamisa();
                        break;
                    case 2:
                        camisa.sacarCamisa(); 
                        break;
                    case 3:
                        Console.Clear();
                        do
                        {
                            Console.Write("¿Esta seguro que desea salir ? \n s/n : ");
                            decision = Console.ReadLine();
                        } while (decision != "S" && decision != "s" && decision != "N" && decision != "n");

                        if (decision == "s" || decision == "S")
                        {
                            sigue = false;
                        }
                        else if (decision == "n" || decision == "N")
                        {
                            break;
                        }
                        break;   
                }
            }
        }
    }
}
    

