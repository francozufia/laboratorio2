using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    public class Electrodomestico
    {
        private double precioBase = 100;
        private String color = "blanco";
        private char consumoEnergetico = 'F';
        private double peso = 5;

        protected double PrecioBase { get => precioBase; set => precioBase = value; }
        protected string Color { get => color; set => color = value; }
        protected char ConsumoEnergetico { get => consumoEnergetico; set => consumoEnergetico = value; }
        protected double Peso { get => peso; set => peso = value; }

        public Electrodomestico(double precioBase , string color, char consumoEnergetico, double peso)
        {
            this.PrecioBase = precioBase;
            this.Color = color;
            this.ConsumoEnergetico = consumoEnergetico;
            this.Peso = peso;
        }

        public Electrodomestico()
        {
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.PrecioBase = precioBase;
            this.Peso = peso;
        }

        public virtual void comprobarConsumoEnergetico(char consumo)
        {
            if (ConsumoEnergetico == 'A' || ConsumoEnergetico == 'B' || ConsumoEnergetico == 'C' || ConsumoEnergetico == 'D' || ConsumoEnergetico == 'E' || ConsumoEnergetico == 'F')
                this.ConsumoEnergetico = consumo;         
        }

        public virtual void comprobarColor(String color)
        {
            if (color == "blanco" || color == "rojo" || color == "gris" || color == "azul" || color == "negro")
                this.Color = color;
            else
                this.Color = "blanco";
        }

        public virtual double precioFinal()
        {
            if (this.Peso >= 0 && this.Peso <= 19) this.PrecioBase += 10;
            else if (this.Peso >= 20 && this.Peso <= 49) this.PrecioBase += 50;
            else if (this.Peso >= 50 && this.Peso <= 79) this.PrecioBase += 80;
            else this.PrecioBase += 100;

            if (this.ConsumoEnergetico == 'A') this.PrecioBase += 100;
            else if (this.ConsumoEnergetico == 'C') this.PrecioBase += 80;
            else if (this.ConsumoEnergetico == 'D') this.PrecioBase += 60;
            else if (this.ConsumoEnergetico == 'E') this.PrecioBase += 50;
            else if (this.ConsumoEnergetico == 'F') this.PrecioBase += 30;
            else this.PrecioBase += 10;

 
            return this.precioBase;
        }
    }
}
