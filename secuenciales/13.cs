using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.secuenciales
{
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double catetoA = Double.Parse(txtcatetoA.Text);
            double catetoO = Double.Parse(txtcatetoO.Text);

            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoO, 2));

            txthipotenusa.Text = hipotenusa.ToString("##.00");
        }
    }
}
