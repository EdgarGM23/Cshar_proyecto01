using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.repetitivos
{
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int contador = 0;
            String numeros = "";

            txtres.Text = "";
            for (int i = 1; i <= 100; i++)
            {
                contador += 1;
                numeros += i.ToString() + (contador % 10 == 0 && contador != 100 ? ",\n" : contador != 100 ? ", " : "");
            }

            txtres.AppendText(numeros);
        }
    }
}
