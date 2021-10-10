using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaDataGrid
{
    public partial class Form1 : Form
    {
        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            int n = dataGridViewProductos.Rows.Add();  //adicionamos renglon

            //colocamos la info 

            dataGridViewProductos.Rows[n].Cells[0].Value = textBoxCodigo.Text; 
            dataGridViewProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dataGridViewProductos.Rows[n].Cells[2].Value = txtPrecio.Text;

            //Limpiamos los textBox

            textBoxCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if(n != -1)
            {
                labelInformacion.Text = (String)dataGridViewProductos.Rows[n].Cells[1].Value;
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if(n != -1)
            {
                dataGridViewProductos.Rows.RemoveAt(n);
            }
        }
    }
}
