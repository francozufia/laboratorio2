using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Lavadora : Electrodomestico
    {
        private double carga = 5;

        public double Carga { get => carga; set => carga = value; }

        public Lavadora(double precioBase, string color, char consumoEnergetico, double peso , double carga) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.Carga = carga;

        }

        public Lavadora()
        {
        }

        public Lavadora(double precioBase, double peso) : base(precioBase, peso)
        {
        }

        public override double PrecioFinal()
        {
            if (this.carga > 30)
            {
                base.PrecioBase = base.PrecioBase + 50;
            }
            return base.PrecioFinal();
        }
    }
}
