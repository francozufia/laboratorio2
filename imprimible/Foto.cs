﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimible
{
    class Foto : Impresora , Imprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy una selfie pal Insta");
        }
    }
}
