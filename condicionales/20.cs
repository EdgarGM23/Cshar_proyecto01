using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.condicionales
{
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtn1.Text);
            int numero2 = int.Parse(txtn2.Text);
            int numero3 = int.Parse(txtn3.Text);

            txtres.Text = "";
            if (numero1 > numero2 && numero2 > numero3) txtres.Text = "Los numero fueron agregados \n de forma descendente";
            else if (numero1 < numero2 && numero2 < numero3) txtres.Text = "Los numero fueron agregados \n de forma ascendente";
            else txtres.Text = "Los numeros fueron agregados \n en desorden";
        }
    }
}
