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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int La_base = int.Parse(txtbase.Text);
            int potencia = int.Parse(txtpotencia.Text);
            int resultado = 1;


            for (int i = 1; i <= potencia; i++)
            {
                resultado *= La_base;
            }
            txtres.Text = "";
            txtres.AppendText("Resultado: " + resultado + "\n");
        }
    }
}
