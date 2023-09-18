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
    public partial class _21 : Form
    {
        public _21()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double numero = Double.Parse(txtnumero.Text);
            String estado = "";
            String genero = "";

            int cifra1 = (int)(numero / 1000);
            int cifra_edad = (int)(numero / 10) % 100;
            int cifra4 = (int)(numero % 100) % 10;

            Boolean continuar_c1 = true;
            Boolean continuar_c4 = true;

            txtres.Text = "";

            if (cifra1 == 1) estado = "Soltero";
            else if (cifra1 == 2) estado = "Casado";
            else if (cifra1 == 3) estado = "Divorciado";
            else if (cifra1 == 4) estado = "Viudo";
            else
            {
                txtres.AppendText("El estado civil no existe \n");
                continuar_c1 = false;
            }

            if (cifra4 == 1) genero = "Masculino";
            else if (cifra4 == 2) genero = "Femenino";
            else
            {
                txtres.AppendText("El genero no existe \n");
                continuar_c4 = false;
            }

            if (continuar_c1 && continuar_c4)
            {
                txtres.AppendText("El estado civil es: " + estado + "\n");
                txtres.AppendText("La edad es: " + cifra_edad + "\n");
                txtres.AppendText("El genero es: " + genero + "\n");
            }
            else txtres.AppendText("No se pudo continuar por problemas en los datos ingresados \n");
        }
    }
}
