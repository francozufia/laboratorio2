using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacionform
{
    public partial class formPrincipal : Form
    {
        ArrayList personaLista = new ArrayList();
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void mostrarSaludo_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String dni = txtDni.Text;
            MessageBox.Show("Hola " + nombre + " " + apellido + " Bienvenido al programa");

            Persona persona = new Persona(nombre, apellido, dni);

             personaLista.Add(persona);
               
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            lista.Text = null;
            foreach(Persona persona in personaLista)
            {
                lista.Text = lista.Text + "\n Nombre : " + persona.Nombre;
                lista.Text = lista.Text + "\n Apellido : " + persona.Apellido;
                lista.Text = lista.Text + "\n DNI : " + persona.Dni;
                lista.Text = lista.Text + "\n_____________";
            }
        }  
    }
}
