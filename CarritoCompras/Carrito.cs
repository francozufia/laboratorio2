using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Carrito
    {
        private int precioUnitario;
        private int cantidad = 0;
        private bool sigue = true;
        private double precio = 0;
        private double precioDescuento = 0;
        private int tipoDescuento = 0 ,op ;
        private String decision;

        Queue productos = new Queue();
       
        public Carrito(int precioUnitario)
        {
            this.precioUnitario = precioUnitario;
        }
        
        public void menu()
        {
            while(sigue == true)
            {
                Console.WriteLine("MENU PRINCIPAL \n 1 : Añadir camisa al carro compras \n 2 : Eliminar camisa carro compras \n 3 : Salir");
                cantidad = productos.Count;
                Console.WriteLine("______________________________________________________________");
                Console.WriteLine("             Cantidad de camisas en el carrito de compras : " + this.cantidad);
                Console.WriteLine("             Precio unitario : " + this.precioUnitario);
                Console.WriteLine("             Precio total sin descuento  : $ " + this.precio);
                Console.WriteLine("             El tipo de descuento aplicado es " + this.tipoDescuento + " %");
                Console.WriteLine("             Precio final con descuento  : $ "  + this.precioDescuento);
                Console.WriteLine("_______________________________________________________________");
                Console.Write("Opcion : ");
                op = Int16.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (op)
                {
                    case 1:
                        productos.Enqueue(1);
                        precio = precio + 1000;
                        break;
                    case 2:
                        productos.Dequeue();
                        precio = precio - 1000;
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("¿Esta seguro que desea salir ? \n s/n : ");
                        decision = Console.ReadLine();
                        if(decision == "s" || decision =="S")
                        {
                            sigue = false;
                        }
                        else if (decision == "n" || decision == "N")
                        {
                            break;
                        }

                        break;      
                }

                if (this.cantidad < 2)
                {
                    this.precioDescuento = 0;
                    this.tipoDescuento = 0;
                }
                else if (this.cantidad > 4)
                {
                    this.tipoDescuento = 20;
                    this.precioDescuento = this.precio - (this.precio * 0.20);
                }
                else if ((this.cantidad > 3 || this.cantidad < 5) && (this.cantidad > 3 || this.cantidad < 5))
                {
                    this.tipoDescuento = 10;
                    this.precioDescuento = precio - (precio * 0.10);
                }
                
            }
        }
    }
}
