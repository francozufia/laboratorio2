using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmueble2
{
    class Piso : Inmueble
    {
        private int numPiso , antiguedad;

        public Piso(String direccion, float precioBase, float metrosCuadrados, int numPiso , int antiguedad) : base(direccion, precioBase, metrosCuadrados)
        {
            this.NumPiso = numPiso;
            this.Antiguedad = antiguedad;
        }

        public int NumPiso { get => numPiso; set => numPiso = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }

        public override void calcularPrecio()
        {
            float precio = 0;
            if(this.Antiguedad <= 15 && this.NumPiso >= 3)
            {
                precio = (float)((this.PrecioBase * 1.03) - (this.PrecioBase * 0.01));
                MessageBox.Show("El precio del piso es : " + precio + " dolares");
            }
            else if(this.Antiguedad <= 15 && this.NumPiso < 3)
            {
                precio = (float)((this.PrecioBase *0.01) - (this.PrecioBase * 0.01));
                MessageBox.Show("El precio del piso es : " + precio + " dolares");
            }
            else if (this.Antiguedad > 15 && this.NumPiso >= 3)
            {
                precio = (float)((this.PrecioBase * 1.03) - (this.PrecioBase * 0.02));
                MessageBox.Show("El precio del piso es : " + precio + " dolares");
            }
            else if (this.Antiguedad > 15 && this.NumPiso < 3)
            {
                precio = (float)(this.PrecioBase  - (this.PrecioBase * 0.02));
                MessageBox.Show("El precio del piso es : " + precio + " dolares");
            }
        }
    }
}

