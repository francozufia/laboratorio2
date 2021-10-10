using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Superman : Superheroe , Volador
    {
        public void volador()
        {
            Console.WriteLine("Estoy volando como como un campeon");
        }
    }
}
