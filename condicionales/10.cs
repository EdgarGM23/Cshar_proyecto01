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
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1 = int.Parse(txtnota1.Text);
            double nota2 = int.Parse(txtnota2.Text);
            double nota3 = int.Parse(txtnota3.Text);
            double nota4 = int.Parse(txtnota4.Text);
            double nota5 = int.Parse(txtnota5.Text);

            Double[] lista = { nota1, nota2, nota3, nota4, nota5 };
            Array.Sort(lista);

            double promedio = (lista[1] + lista[2] + lista[3]) / 3;

            txtresultado.Text = "";
            txtresultado.AppendText("Promedio: " + promedio.ToString("##.00") + "\n");
            txtresultado.AppendText("Nota eliminada: " + lista[0] + "\n");
            txtresultado.AppendText("Nota eliminada: " + lista[4] + "\n");
        }
    }
}
