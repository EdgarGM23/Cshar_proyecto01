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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double Juan = Double.Parse(txtjuan.Text);
            double Rosa = Double.Parse(txtrosa.Text);
            double Daniel = Double.Parse(txtdaniel.Text);

            double total = Juan + Rosa + (Daniel * 3);

            txtdolars.Text = total.ToString("##.00");
            lblporjuan.Text = (Juan * 100.0 / total).ToString("##.00") + "%";
            lblporrosa.Text = (Rosa * 100.0 / total).ToString("##.00") + "%";
            lblpordaniel.Text = (Daniel * 3 * 100.0 / total).ToString("##.00") + "%";
        }
    }
}
