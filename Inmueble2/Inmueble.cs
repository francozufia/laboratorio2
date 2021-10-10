using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmueble2
{
    abstract class Inmueble
    {
        private String direccion;
        private float precioBase;
        private float metrosCuadrados;

        public Inmueble(String direccion, float precioBase, float metrosCuadrados)
        {
            this.Direccion = direccion;
            this.PrecioBase = precioBase;
            this.MetrosCuadrados = metrosCuadrados;
        }

        protected float MetrosCuadrados { get => metrosCuadrados; set => metrosCuadrados = value; }
        protected float PrecioBase { get => precioBase; set => precioBase = value; }
        protected string Direccion { get => direccion; set => direccion = value; }

        public abstract void calcularPrecio();
    }
}
