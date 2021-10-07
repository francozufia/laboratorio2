using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaHerencia
{
    
        class Profesor : Persona
        {
            private String titulo;
            public Profesor(String nombre, String apellido, String titulo) : base(nombre, apellido)
            {
                this.titulo = titulo;
                this.nombre = nombre;
                this.apellido = apellido;
            }
            public String getTitulo()
            {
                return titulo;
            }
            public void setTitulo(String titulo)
            {
                this.titulo = titulo;
            }
        }


    }



