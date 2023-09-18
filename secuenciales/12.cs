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
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            int c = int.Parse(txtc.Text);

            double raiz = Math.Sqrt((b * b) - (4 * a * c));
            double res1 = (-b - raiz) / (2 * a);
            double res2 = (-b + raiz) / (2 * a);

            txtres1.Text = res1.ToString("##.00");
            txtres2.Text = res2.ToString("##.00");
        }
    }
}
