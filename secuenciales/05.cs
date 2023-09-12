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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int giga = int.Parse(txtgiga.Text);
            double mega = giga * 1024.0;
            double kilo = mega * 1024.0;
            double bytes = kilo * 1024.0;

            txtmega.Text = mega.ToString("##.00");
            txtkilo.Text = kilo.ToString("##.00");
            txtbyte.Text = bytes.ToString("##.00");
        }
    }
}
