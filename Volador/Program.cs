using System;

namespace Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean vuelan = true;
            TorreControl torre = new TorreControl();
            do
            {
                torre.agregarVolador();
                torre.vuelanTodos();
                torre.resultados();
            } while (vuelan != false);
        }
    }
}
