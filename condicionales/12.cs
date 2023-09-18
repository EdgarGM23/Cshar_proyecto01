using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.condicionales
{
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);

            /*
            if (numero == 1) txtdia.Text = "Lunes";
            else if (numero == 2) txtdia.Text = "Martes";
            else if (numero == 3) txtdia.Text = "Miercoles";
            else if (numero == 4) txtdia.Text = "Jueves";
            else if (numero == 5) txtdia.Text = "Viernes";
            else if (numero == 6) txtdia.Text = "Sabado";
            else if (numero == 7) txtdia.Text = "Domingo";
            else txtdia.Text = "Error";
            */

            string[] aDias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            txtdia.Text = numero >= 1 && numero <= 7 ? aDias[numero - 1] : "Error";
        }
    }
}
