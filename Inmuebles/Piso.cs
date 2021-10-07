using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Piso : Inmueble
    {
        private int numeroPiso;

        public Piso(String direccion , float precioBase , float metrosCuadrados , int antiguedad , int numeroPiso) : base(direccion ,precioBase ,metrosCuadrados ,antiguedad)
        {
            this.numeroPiso = numeroPiso;            
        }

        public int NumeroPiso { get => numeroPiso; set => numeroPiso = value; }  
    }
}
