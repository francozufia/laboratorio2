using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    abstract class Inmueble
    {
        protected String direccion;
        protected float precioBase;
        protected int antiguedad;
        protected float metrosCuadrados;

        public Inmueble(String direccion , float precioBase , float metrosCuadrados , int antiguedad)
        {
            this.antiguedad = direccion;
            this.precioBase = precioBase;
            this.metrosCuadrados = metrosCuadrados;
            this.antiguedad = antiguedad;
        }

        
    }
}
