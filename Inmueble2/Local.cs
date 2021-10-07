using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmueble2
{
    class Local : Inmueble
    {
        private int numVentanas;

         public Local(String direccion, float precioBase, float metrosCuadrados, int numVentanas) : base(direccion, precioBase, metrosCuadrados)
         {
            this.NumVentanas = numVentanas;
         }

        public int NumVentanas { get => numVentanas; set => numVentanas = value; }

        public override void calcularPrecio()
        {
            float precio;
            if(this.MetrosCuadrados < 50 && this.numVentanas <= 1)
            {
                precio = (float)(this.PrecioBase - (this.PrecioBase * 0.02));
                MessageBox.Show("El precio del local es de : " + precio + " dolares");
            }
            else if (this.MetrosCuadrados < 50 && this.numVentanas >= 4)
            {
                precio = (float)(this.PrecioBase + (this.PrecioBase * 0.02));
                MessageBox.Show("El precio del local es de : " + precio + " dolares");
            }
            else if (this.MetrosCuadrados >= 50 && this.numVentanas <= 1)
            {
                precio = (float)((this.PrecioBase * 1.01) - (this.PrecioBase * 0.02));
                MessageBox.Show("El precio del local es de : " + precio + " dolares");
            }
            else if (this.MetrosCuadrados >= 50 && this.numVentanas >= 1)
            {
                precio = (float)((this.PrecioBase * 1.01) + (this.PrecioBase * 0.02));
                MessageBox.Show("El precio del local es de : " + precio + " dolares");
            }
        }

    }
}
