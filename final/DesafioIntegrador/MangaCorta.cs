using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioIntegrador
{
    class MangaCorta : Ropa
    {
        public MangaCorta(float precio, bool std, bool prm, int cant) : base(precio, std, prm, cant)
        {
        }
        public override void calcularPrecio()
        {
            if (prm == true && std == true || prm == false && std == false)
                throw new Error("");
            if (std == true)
            {
                this.precio = (float)((this.precio - (this.precio * 0.10)) * cant);
                MessageBox.Show("El precio de las camisas es de $ " + this.precio);
            }
            if (prm == true)
            {
                float aux = (float)(this.precio * 1.20);
                this.precio = aux * cant;
                MessageBox.Show("El precio de las camisas es de $ " + this.precio);
            }
        }
    }
}
