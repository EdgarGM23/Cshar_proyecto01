using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.condicionales
{
    public partial class _39 : Form
    {
        public _39()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txthoras.Text);
            int malos = int.Parse(txtmalos.Text);
            int buenos = int.Parse(txtbuenos.Text);

            int categoria1 = 0;
            int categoria2 = 0;
            int categoria3 = 0;

            if (horas < 1.5) categoria1 = 1;
            if (malos < 300) categoria2 = 1;
            if (buenos > 10000) categoria3 = 1;

            txtres.Text = "Grado: ";

            if (categoria1 == 0 && categoria2 == 0 && categoria3 == 0) txtres.AppendText("5");
            else if (categoria1 == 1 && categoria2 == 0 && categoria3 == 0) txtres.AppendText("7");
            else if (categoria1 == 0 && categoria3 == 0 && categoria2 == 1) txtres.AppendText("8");
            else if (categoria1 == 0 && categoria2 == 0 && categoria3 == 1) txtres.AppendText("9");
            else if (categoria1 == 1 && categoria2 == 1 && categoria3 == 0) txtres.AppendText("12");
            else if (categoria1 == 1 && categoria3 == 1 && categoria2 == 0) txtres.AppendText("13");
            else if (categoria2 == 1 && categoria3 == 1 && categoria1 == 0) txtres.AppendText("15");
            else if (categoria1 == 1 && categoria2 == 1 && categoria3 == 1) txtres.AppendText("20");
        }
    }
}
