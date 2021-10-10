using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class TorreControl
    {
        List<Volador> listaVoladores = new List<Volador>();
        int opcion, cont1 = 0, cont2 = 0, cont3 = 0;
        public void agregarVolador()
        {
            try { 
                Console.Write("¿Quien volara?\n 1: Superman\n 2: Boing\n 3: Pato\n Opcion : ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("_____________________________________");

                switch (opcion)
                {
                    case 1:
                        Superman super = new Superman();
                        listaVoladores.Add(super);
                        cont1 = cont1 + 5;
                        break;
                    case 2:
                        Boing747 avion = new Boing747();
                        listaVoladores.Add(avion);
                        cont2 = cont2 + 13;
                        break;
                    case 3:
                        Pato pato = new Pato();
                        listaVoladores.Add(pato);
                        cont3 = cont3 + 3;
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese un numero");
            }
        }
        public void vuelanTodos()
        {
            foreach(Volador fligh in listaVoladores)
            {
                fligh.volador();
            }
        }
        public void resultados()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Superman : " + cont1 + " XP");
            Console.WriteLine("Avion : " + cont2 + " XP");
            Console.WriteLine("Pato : " + cont3 + " XP");
            Console.WriteLine("_____________________________________");
        }
    }
}
