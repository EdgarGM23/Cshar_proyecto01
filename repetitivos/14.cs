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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnum.Text);

            txtres.Text = "";

            if (numero % 2 != 0 && numero % 3 != 0 && numero % 5 != 0) txtres.AppendText("El numero es primo");
            else if (numero == 2 || numero == 3 || numero == 5) txtres.AppendText("El numero es primo");
            else txtres.AppendText("El numero no es primo");
        }
    }
}
