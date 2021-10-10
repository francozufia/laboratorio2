using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Boing747 : Avion , Volador
    {
        public void volador()
        {
            Console.WriteLine("Estoy volando cimo un avion");
        }
    }
}
