using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmueble2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonPiso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPiso.Checked == true)
            {
                textBoxNumeroVentana.BackColor = Color.Violet;
                textBoxNumeroVentana.Enabled = false;
            }
            if (radioButtonPiso.Checked == false)
            {
                textBoxNumeroVentana.BackColor = Color.White;
                textBoxNumeroVentana.Enabled = true;
            }
        }

        private void radioButtonLocal_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonLocal.Checked == true)
            {
                textBoxNumeroPiso.BackColor = Color.Violet;
                textBoxNumeroPiso.Enabled = false;
            }
            if (radioButtonLocal.Checked == false)
            {
                textBoxNumeroPiso.BackColor = Color.White;
                textBoxNumeroPiso.Enabled = true;
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double precioBase = Convert.ToDouble(textBoxPrecioBase.Text);
            string direccion = textBoxDireccion.Text;
            float metrosCuadrados = (float)Convert.ToDouble(textBoxSuperficie.Text);
            
            if (radioButtonPiso.Checked == true)
            {
                int numpiso = Convert.ToInt32(textBoxNumeroPiso.Text);
                int antiguedad = Convert.ToInt32(textBoxAntiguedad.Text);
                Piso piso = new Piso(direccion, (float)precioBase, metrosCuadrados, antiguedad, numpiso);
                piso.calcularPrecio(); 
            }

            if(radioButtonLocal.Checked == true)
            {
                int numVentanas = Convert.ToInt32(textBoxNumeroVentana.Text);
                Local local = new Local(direccion, (float)precioBase, metrosCuadrados , numVentanas );
                local.calcularPrecio();
            }
        }
    }
}
