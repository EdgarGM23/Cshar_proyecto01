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
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int dividendo = int.Parse(txtdividendo.Text);
            int divisor = int.Parse(txtdivisor.Text);
            int cociente = 0;


            while (dividendo >= divisor)
            {
                dividendo -= divisor;
                cociente += 1;
            }

            txtres.Text = "";
            txtres.AppendText("Conciente: " + cociente + "\n");
            txtres.AppendText("Residuo: " + dividendo + "\n");
        }
    }
}
