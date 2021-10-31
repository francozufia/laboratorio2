using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIntegrador
{
    public abstract class Ropa
    {
        protected float precio;
        protected Boolean std, prm;
        protected int cant;

        protected Ropa(float precio, bool std, bool prm, int cant)
        {
            this.precio = precio;
            this.std = std;
            this.prm = prm;
            this.cant = cant;
        }

        public virtual void calcularPrecio() { }
    }
}
