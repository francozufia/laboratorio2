using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaYDomicilio
{
    class Domicilio
    {
        private String calle;
        private String numero;

        public Domicilio()
        {
        }

        public Domicilio(string calle, string numero)
        {
            this.calle = calle;
            this.numero = numero;
        }

        public String getcalle()
        {
            return calle;
        }

        public String getnumero()
        {
            return numero;
        }

        public void setcalle(String calle)
        {
            this.calle = calle;
        }

        public void setnumero(String numero)
        {
            this.numero = numero;
        }



    }
}
