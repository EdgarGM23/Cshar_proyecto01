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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double practica1 = int.Parse(txtexamen1.Text);
            double practica2 = int.Parse(txtexamen2.Text);
            double practica3 = int.Parse(txtexamen3.Text);

            int propina = 20;

            if (practica1 >= 11) propina += 5;
            if (practica2 >= 11) propina += 5;
            if (practica3 >= 11) propina += 5;

            txtresultado.Text = "";
            txtresultado.AppendText("Propina: " + propina + "\n");
        }
    }
}
