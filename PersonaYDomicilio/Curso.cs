using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaYDomicilio
{
    class Curso
    {
        private String nombre;
        private int numeroAlumnos;

        public Curso()
        {
        }

        public Curso(string nombre, int numeroAlumnos)
        {
            this.nombre = nombre;
            this.numeroAlumnos = numeroAlumnos;
        }


        public String getnombre()
        {
            return nombre;
        }

        public int getnumeroAlumnos()
        {
            return numeroAlumnos;
        }

        public void setnombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setnumeroAlumnos(int numeroAlumnos)
        {
            this.numeroAlumnos = numeroAlumnos;
        }




    }
}
