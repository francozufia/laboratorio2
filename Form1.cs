using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPantalon.Checked == true)
            {
                radioButtonMangaCorta.Enabled = false;
                radioButtonBermuda.Enabled = true;
            }
        }

        private void radioButtonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonCamisa.Checked == true)
            {
                radioButtonBermuda.Enabled = false;
                radioButtonMangaCorta.Enabled = true;
            }
        }

        private void buttonCalcularPrecio_Click(object sender, EventArgs e)
        {
            Boolean calidadPremium = checkBoxPremium.Checked;
            Boolean calidadStandard = checkBoxStandard.Checked;
            try
            {
                int cantidad = Convert.ToByte(textBoxCantidad.Text);
                float precio = (float)Convert.ToDecimal(textBoxPrecio.Text);
                
                if (radioButtonPantalon.Checked == true)
                {
                    Pantalon pantalon = new Pantalon(precio, calidadStandard, calidadPremium, cantidad);
                    pantalon.calcularPrecio();
                }
                if(radioButtonCamisa.Checked == true)
                {
                    Camisa camisa = new Camisa(precio, calidadStandard, calidadPremium, cantidad);
                    camisa.calcularPrecio();
                }
                if (radioButtonBermuda.Checked == true)
                {
                    Bermuda bermuda = new Bermuda(precio, calidadStandard, calidadPremium, cantidad);
                    bermuda.calcularPrecio();
                }
                if(radioButtonMangaCorta.Checked == true)
                {
                    MangaCorta corta = new MangaCorta(precio, calidadStandard, calidadPremium, cantidad);
                    corta.calcularPrecio();
                }
            }
            catch (Exception) { }

        }  
    }
}
