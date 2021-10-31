using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioIntegrador
{
    public class Error : Exception
    {
        public Error(String mensaje) : base(mensaje)
        {
            AlertaError.enviarAlerta(mensaje);
        }

        public Error(DialogResult dialogResult)
        {
        }
    }
}
