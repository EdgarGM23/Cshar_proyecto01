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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }
        static int multi(int num1, int num2)
        {
            int resultado = 0;
            while (num2 >= 1)
            {
                resultado += num1;
                num2 -= 1;
            }
            return resultado;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtnum1.Text);
            int numero2 = int.Parse(txtnum2.Text);

            multi(numero1, numero2);

            txtres.Text = "";
            txtres.AppendText("El resultado es: " + (int)(multi(numero1, numero2)) + "\n");
        }
    }
}
