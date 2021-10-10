using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaYDomicilio
{
    class Persona
    {
        private String nombre;
        private String apellido;
        private Domicilio viveEn;//relaciona persona con domicilio

        public Persona(String nombre , String apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public Persona()
        {

        }

        public String getnombre()
        {
            return nombre;
        }

        public String getapellido()
        {
            return apellido;
        }

        public void setnombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setapellido(String apellido)
        {
            this.apellido = apellido;
        }

        public Domicilio getviveEn()
        {
            return viveEn;
        }

        public void setviveEn(Domicilio viveEn)
        {
            this.viveEn = viveEn;
        }


    }
}
