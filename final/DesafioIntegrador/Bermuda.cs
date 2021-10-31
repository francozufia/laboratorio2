using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioIntegrador
{
    class Bermuda : Ropa
    {
        public Bermuda(float precio, bool std, bool prm, int cant) : base(precio, std, prm, cant)
        {
        }

        public override void calcularPrecio()
        {
            if (prm == true && std == true || prm == false && std == false)
                throw new Error("");
            if (std == true)
            {
                this.precio = (float)((this.precio - (this.precio * 0.20) ) * cant);
                MessageBox.Show("El precio de las Bermudas es de $ " + this.precio);
            }
            if (prm == true)
            {
                float aux = (float)(this.precio * 1.10);   // al Premium - descuento por ser bermuda
                this.precio = aux * cant;
                MessageBox.Show("El precio de las Bermudas es de $ " + this.precio);
            }
        }
    }
}
