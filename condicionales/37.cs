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
    public partial class _37 : Form
    {
        public _37()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int Pamela = int.Parse(txtpamela.Text);
            int Carol = int.Parse(txtcarol.Text);
            int Fanny = int.Parse(txtfanny.Text);
            String mensaje = "";

            int mitad = (Pamela + Carol + Fanny) / 2;
            txtres.Text = "";

            if (Pamela > mitad) mensaje = "Ganó Pamela";
            else if (Carol > mitad) mensaje = "Ganó karol";
            else if (Fanny > mitad) mensaje = "Ganó Fany";

            else if (Pamela < Carol && Pamela < Fanny) mensaje = "Pasan a la segunda vuelta: Karol y Fany";
            else if (Carol < Pamela && Carol < Fanny) mensaje = "Pasan a la segunda vuelta: Pamela y Fany";
            else if (Fanny < Carol && Fanny < Pamela) mensaje = "Pasan a la segunda vuelta: Karol y Pamela";

            else if (Pamela == Carol && Pamela == Fanny && Carol == Fanny) mensaje = "Elecciones anuladas";
            else if (Pamela > Carol && Pamela > Fanny && Carol == Fanny) mensaje = "Elecciones anuladas";
            else if (Carol > Pamela && Carol > Fanny && Pamela == Fanny) mensaje = "Elecciones anuladas";
            else if (Fanny > Pamela && Fanny > Carol && Pamela == Carol) mensaje = "Elecciones anuladas";

            txtres.AppendText(mensaje + "\n");

            if (Pamela > Carol && Carol > Fanny)
            {
                txtres.AppendText("1° Puesto: Pamela: " + Pamela + " \n");
                txtres.AppendText("2° Puesto: Carol: " + Carol + " \n");
                txtres.AppendText("3° Puesto: Fanny: " + Fanny + " \n");
            }
            else if (Pamela > Fanny && Fanny > Carol)
            {
                txtres.AppendText("1° Puesto: Pamela: " + Pamela + " \n");
                txtres.AppendText("2° Puesto: Fanny: " + Fanny + " \n");
                txtres.AppendText("3° Puesto: Carol: " + Carol + " \n");
            }
            else if (Carol > Pamela && Pamela > Fanny)
            {
                txtres.AppendText("1° Puesto: Carol: " + Carol + " \n");
                txtres.AppendText("2° Puesto: Pamela: " + Pamela + " \n");
                txtres.AppendText("3° Puesto: Fanny: " + Fanny + " \n");
            }
            else if (Carol > Fanny && Fanny > Pamela)
            {
                txtres.AppendText("1° Puesto: Carol: " + Carol + " \n");
                txtres.AppendText("2° Puesto: Fanny: " + Fanny + " \n");
                txtres.AppendText("3° Puesto: Pamela: " + Pamela + " \n");
            }
            else if (Fanny > Pamela && Pamela > Carol)
            {
                txtres.AppendText("1° Puesto: Fanny: " + Fanny + " \n");
                txtres.AppendText("2° Puesto: Pamela: " + Pamela + " \n");
                txtres.AppendText("3° Puesto: Carol: " + Carol + " \n");
            }
            else if (Fanny > Carol && Carol > Pamela)
            {
                txtres.AppendText("1° Puesto: Fanny" + Fanny + "\n");
                txtres.AppendText("2° Puesto: Carol" + Carol + "\n");
                txtres.AppendText("3° Puesto: Pamela" + Pamela + "\n");
            }
        }
    }
}
