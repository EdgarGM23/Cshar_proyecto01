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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double altura = int.Parse(txtaltura.Text);
            double la_base = int.Parse(txtbase.Text);

            double area = la_base * altura;
            double perimetro = 2 * (la_base + altura);

            txtarea.Text = area.ToString("##.00");
            txtperimetro.Text = perimetro.ToString("##.00");
        }
    }
}
