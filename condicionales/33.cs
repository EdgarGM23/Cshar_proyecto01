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
    public partial class _33 : Form
    {
        public _33()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int tardanza = int.Parse(txttardanza.Text);
            int rendimiento = int.Parse(txtrendi.Text);
            int puntajeT = 0;
            int puntajeR = 0;
            double bonificacion = 0;
            double pension = 0;

            txtres.Text = "";

            if (tardanza > 9) puntajeT = 0;
            else if (tardanza >= 6 && tardanza < 10) puntajeT = 4;
            else if (tardanza >= 3 && tardanza < 6) puntajeT = 6;
            else if (tardanza >= 1 && tardanza < 3) puntajeT = 8;
            else puntajeT = 10;

            if (rendimiento > 3) puntajeR = 0;
            else if (rendimiento == 3) puntajeR = 1;
            else if (rendimiento == 2) puntajeR = 5;
            else if (rendimiento == 1) puntajeR = 8;
            else puntajeR = 10;

            double total = puntajeR + puntajeT;

            if (total < 11) bonificacion = 2.5;
            else if (total >= 11 && total < 14) bonificacion = 5;
            else if (total >= 14 && total < 17) bonificacion = 7.5;
            else if (total >= 17 && total < 20) bonificacion = 10;
            else bonificacion = 12.5;

            txtres.AppendText("Puntaje: " + total + "\n");
            txtres.AppendText("Bonificacion: " + bonificacion);
        }
    }
}
