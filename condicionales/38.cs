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
    public partial class _38 : Form
    {
        public _38()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtdia.Text);
            int mes = int.Parse(txtmes.Text);
            int año = int.Parse(txtaño.Text);

            String[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int febrero = 28;
            int days = 0;
            int contador = 0;
            Boolean bisiesto = false;

            txtres.Text = "";

            if (año % 4 == 0 && año != 100 || año % 400 == 0) bisiesto = true;
            else bisiesto = false;


            int enero = 31;
            if (bisiesto) febrero = 29;
            int marzo = 31;
            int abril = 30;
            int mayo = 31;
            int junio = 30;
            int julio = 31;
            int agosto = 31;
            int septiembre = 30;
            int octubre = 31;
            int noviembre = 30;
            int diciembre = 31;

            if (mes == 1) days = enero;
            else if (mes == 2) days = febrero;
            else if (mes == 3) days = marzo;
            else if (mes == 4) days = abril;
            else if (mes == 5) days = mayo;
            else if (mes == 6) days = junio;
            else if (mes == 7) days = julio;
            else if (mes == 8) days = agosto;
            else if (mes == 9) days = septiembre;
            else if (mes == 10) days = octubre;
            else if (mes == 11) days = noviembre;
            else if (mes == 12) days = diciembre;

            if (mes == 1) contador = dia;
            else if (mes == 2) contador = enero + dia;
            else if (mes == 3) contador = enero + febrero + dia;
            else if (mes == 4) contador = enero + febrero + marzo + dia;
            else if (mes == 5) contador = enero + febrero + marzo + abril + dia;
            else if (mes == 6) contador = enero + febrero + marzo + abril + mayo + dia;
            else if (mes == 7) contador = enero + febrero + marzo + abril + mayo + junio + dia;
            else if (mes == 8) contador = enero + febrero + marzo + abril + mayo + junio + julio + dia;
            else if (mes == 9) contador = enero + febrero + marzo + abril + mayo + junio + julio + agosto + dia;
            else if (mes == 10) contador = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + dia;
            else if (mes == 11) contador = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + dia;
            else if (mes == 12) contador = enero + febrero + marzo + abril + mayo + junio + julio + agosto + septiembre + octubre + noviembre + dia;

            txtres.AppendText("Dias del mes: " + days + "\n");
            txtres.AppendText("Mes: " + meses[mes - 1] + "\n");
            txtres.AppendText("Dias desde Enero: " + contador + "\n");
        }
    }
}
