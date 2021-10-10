using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimible
{
    class Contrato : Impresora , Imprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
