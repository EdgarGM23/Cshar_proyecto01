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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnum.Text);
            int resultado = 1;

            txtres.Text = "";

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            txtres.AppendText("" + resultado + "\n");
        }
    }
}
