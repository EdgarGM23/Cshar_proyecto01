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
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtn1.Text);
            int num2 = int.Parse(txtn2.Text);
            int num3 = int.Parse(txtn3.Text);
            int num4 = int.Parse(txtn4.Text);
            int num5 = int.Parse(txtn5.Text);
            int num6 = int.Parse(txtn6.Text);
            int num7 = int.Parse(txtn7.Text);
            int num8 = int.Parse(txtn8.Text);
            int num9 = int.Parse(txtn9.Text);
            int num10 = int.Parse(txtn10.Text);

            int[] lista = { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10 };

            Array.Sort(lista);

            double promedio = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10) / 10;

            txtres.Text = "";
            txtres.AppendText("Mayor: " + lista[9] + "\n");
            txtres.AppendText("Menor: " + lista[0] + "\n");
            txtres.AppendText("Promedio: " + promedio.ToString("##.00") + "\n");
        }
    }
}
