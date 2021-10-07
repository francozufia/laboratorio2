using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Local : Inmueble
    { 
        private int numeroVentana;

        public Local(String direccion , float precioBase , float metrosCuadrados , int antiguedad) : base(direccion ,precioBase ,metrosCuadrados, antiguedad)
        {
            this.numeroVentana = numeroVentana;
        }
        

        public int NumeroVentana { get => numeroVentana; set => numeroVentana = value; }
    }
}
