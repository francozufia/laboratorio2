using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmuebles
{
    public partial class Form1 : Form
    {
        Piso piso = new Piso();
        Local local = new Local();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonPiso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPiso.Checked == true)
            {
                textBoxNumeroVentanas.BackColor = Color.Violet;
                textBoxNumeroVentanas.Enabled = false;
            }
            if (radioButtonPiso.Checked == false)
            {
                textBoxNumeroVentanas.BackColor = Color.White;
                textBoxNumeroVentanas.Enabled = true;
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

        private void buttonCalcularPrecio_Click(object sender, EventArgs e)
        {
            double precio;
            if (radioButtonPiso.Checked == true)
            {
                int piso = Convert.ToInt32(textBoxNumeroPiso.Text);
                int antiguedadPiso = Convert.ToInt32(textBoxAntiguedad.Text);
                double precioBasePiso = Convert.ToDouble(textBoxPrecioBase.Text);


                if (antiguedadPiso <= 15 && piso >= 3)
                {
                    precio = (precioBasePiso * 1.03) - (precioBasePiso * 0.01);
                    MessageBox.Show("El precio del piso es : " + precio + " dolares");
                }
                else if (antiguedadPiso <= 15 && piso < 3)
                {
                    precio = precioBasePiso - (precioBasePiso * 0.01);
                    MessageBox.Show("El precio del piso es : " + precio + " dolares");
                }
                else if (antiguedadPiso > 15 && piso >= 3)
                {
                    precio = ((precioBasePiso * 1.03) - (precioBasePiso * 0.02));
                    MessageBox.Show("El precio del piso es : " + precio + " dolares");
                }
                else if (antiguedadPiso > 15 && piso < 3)
                {
                    precio = precioBasePiso - (precioBasePiso * 0.02);
                    MessageBox.Show("El precio del piso es : " + precio + " dolares");
                }
            }

            if (radioButtonLocal.Checked == true)
            {
                int metrosCuadrados = Convert.ToInt32(textBoxSuperficie.Text);
                int numeroVentanas = Convert.ToInt32(textBoxNumeroVentanas.Text);
                double precioBaseLocal = Convert.ToDouble(textBoxPrecioBase.Text);

                if (metrosCuadrados < 50 && numeroVentanas <= 1 )
                {
                    precio = precioBaseLocal - (precioBaseLocal * 0.02);
                    MessageBox.Show("El precio del local es de : " + precio + " dolares");
                }
                else if (metrosCuadrados < 50 && numeroVentanas >= 1)
                {
                    precio = (precioBaseLocal * 1.01) - (precioBaseLocal * 0.02);
                    MessageBox.Show("El precio del local es de : " + precio + " dolares");
                }
                else if(metrosCuadrados >= 50 && numeroVentanas <= 1)
                {
                    precio = (precioBaseLocal * 1.01) - (precioBaseLocal * 0.02) ;
                    MessageBox.Show("El precio del local es de : " + precio + " dolares");
                }
                else if(metrosCuadrados >= 50 && numeroVentanas >= 4)
                {
                    precio = precioBaseLocal * 1.03;
                    MessageBox.Show("El precio del local es de : " + precio + " dolares");
                }
            }
        }
    }
}
