using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioIntegrador
{
     public static class AlertaError
    {
        public static void enviarAlerta(String mensaje)
        {
            MessageBox.Show("Ingrese Premium o Standard");
        }
    }
}
