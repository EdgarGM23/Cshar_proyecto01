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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double altura = int.Parse(txtaltura.Text);
            double radio = int.Parse(txtradio.Text);

            double areaB = Math.PI * Math.Pow(radio, 2);
            double areaL = 2 * Math.PI * radio * altura;
            double areaT = 2 * areaB * areaL;

            txtareabase.Text = areaB.ToString("##.00");
            txtarealateral.Text = areaL.ToString("##.00");
            txtareatotal.Text = areaT.ToString("##.00");
        }
    }
}
