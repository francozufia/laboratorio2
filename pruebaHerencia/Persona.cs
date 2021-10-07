using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaHerencia
{
    abstract class Persona
    {
        protected String nombre;
        protected String apellido;

        public Persona(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        public String getnombre()
        {
            return nombre;
        }

        public void setnombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getapellido()
        {
            return apellido;
        }

        public void setapellido(String apellido)
        {
            this.apellido = apellido;  
        }


    }
}
