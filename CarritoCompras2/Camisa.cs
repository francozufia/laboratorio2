using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras2
{
    class Camisa 
    {
        private static int cantidad = 0, tipoDescuento = 0;
        private static double precio = 0, precioDescuento = 0;
        private int precioUnitario;

        Queue camisas = new Queue();

        public Camisa (int precioUnitario)
        {
            this.precioUnitario = precioUnitario;
        }

        public int getprecioUnitario()
        {
            return precioUnitario;
        }

        public int getcantidad()
        {
            cantidad = camisas.Count;
            return cantidad;
        }

        public int gettipoDescuento()
        {
            return tipoDescuento;
        }

        public double getprecio()
        {
            return precio;
        }

        public double getprecioDescuento()
        {
            return precioDescuento;
        }
        public void agregarCamisa()
        {
            camisas.Enqueue(1);
            precio = precio + precioUnitario;
            Camisa.descuentos();
        }
        public void sacarCamisa()
        {
            if (cantidad >= 1)
            {
                camisas.Dequeue();
                precio = precio - precioUnitario;
                Camisa.descuentos();
            }
        }

        public static void descuentos()
        {
            if (cantidad < 2)
            {
                precioDescuento = 0;
                tipoDescuento = 0;
            }
            else if (cantidad > 4)
            {
                tipoDescuento = 20;
                precioDescuento = precio - (precio * 0.20);
            }
            else if ((cantidad > 3 || cantidad < 5) && (cantidad > 3 || cantidad < 5))
            {
                tipoDescuento = 10;
                precioDescuento = precio - (precio * 0.10);
            }
        }
    }
}
