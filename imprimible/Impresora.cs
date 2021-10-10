using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimible
{
    class Impresora
    { 
        List <Imprimible> colaImpresion = new List<Imprimible>();
        public void imprimirTodo()
        {
           foreach(Imprimible i in colaImpresion)
           {
                i.Imprimir();
           }
        }

        public void agegarImprimible()
        {
            try
            {
                int opcion;
                Console.Write(" 1: Foto\n 2: Contrato\n 3: Documento\n Opcion : ");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Foto foto = new Foto();
                    colaImpresion.Add(foto);
                }
                if (opcion == 2)
                {
                    Contrato contrato = new Contrato();
                    colaImpresion.Add(contrato);
                }
                if (opcion == 3)
                {
                    Documento doc = new Documento();
                    colaImpresion.Add(doc);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Ingrese un numero del 1 al 3");
            }
        }
    }
}
