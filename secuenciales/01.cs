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
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);
            int total = varones + mujeres;

            double pVarones = varones * 100.0 / total;
            double pMujeres = mujeres * 100.0 / total;
            
            lblPVarones.Text = "" + pVarones.ToString("##.00") + "%";
            lblPMujeres.Text = ("" + pMujeres.ToString("##.00") + "%");
        }
    }
}
