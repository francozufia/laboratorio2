using System;

namespace PersonaYDomicilio
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Franco", "Zufia");

            Persona persona2 = new Persona();

            persona2.setnombre("Pepe");

            persona2.setapellido("ruiz");

            Console.WriteLine("Me llamo : " + persona2.getnombre() + "mi appellido es : " + persona2.getapellido());

            Domicilio domicilio = new Domicilio("Catamarca", "147");

            persona1.setviveEn(domicilio);//crea la flecha del grafico

            Console.WriteLine("Me llamo : " + persona1.getnombre() + " mi appellido es : " + persona1.getapellido() + " vive en : " + persona1.getviveEn().getcalle() + persona1.getviveEn().getnumero());


            Console.Read();






        }
    }
}
