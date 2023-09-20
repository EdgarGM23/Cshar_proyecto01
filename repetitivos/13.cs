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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnum.Text);
            int suma = 0;

            txtres.Text = "";

            for (int i = 1; i <= numero; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    suma += i;
                }
            }
            txtres.AppendText("Suma: " + suma + "\n");
        }
    }
}
