using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Televisor : Electrodomestico
    {
        private int resolucion = 20;
        private Boolean tdt = false;

        public Televisor()
        {
        }

        public Televisor(double precioBase , string color, char consumoEnergetico, double peso , int resolucion , Boolean tdt) : base(precioBase, color , consumoEnergetico, peso)
        {
            this.Resolucion = resolucion;
            this.Tdt = tdt;
        }

        public int Resolucion { get => resolucion; set => resolucion = value; }
        public bool Tdt { get => tdt; set => tdt = value; }

        public override double PrecioFinal()
        {
            if (resolucion > 40)
            {
                base.PrecioBase = base.PrecioBase * 1.3;
            }
            if(tdt == true)
            {
                base.PrecioBase = base.PrecioBase * 1.5;
            }
            return base.PrecioFinal();
        }
    }
}
