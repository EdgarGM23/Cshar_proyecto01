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
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int monto = int.Parse(txtmonto.Text);

            int docientos = 0;
            int cien = 0;
            int cincuenta = 0;
            int veinte = 0;
            int dies = 0;
            int cinco = 0;
            int dos = 0;
            int uno = 0;

            while (monto >= 200)
            {
                docientos += 1;
                monto -= 200;
            }
            while (monto >= 100)
            {
                cien += 1;
                monto -= 100;
            }
            while (monto >= 50)
            {
                cincuenta += 1;
                monto -= 50;
            }
            while (monto >= 20)
            {
                veinte += 1;
                monto -= 20;
            }
            while (monto >= 10)
            {
                dies += 1;
                monto -= 10;
            }
            while (monto >= 5)
            {
                cinco += 1;
                monto -= 5;
            }
            while (monto >= 2)
            {
                dos += 1;
                monto -= 2;
            }
            while (monto >= 1)
            {
                uno += 1;
                monto -= 1;
            }

            txtresultado.Text = "";
            txtresultado.AppendText("Hay " + docientos + " billetes de 200 \n");
            txtresultado.AppendText("Hay " + cien + " billetes de 100 \n");
            txtresultado.AppendText("Hay " + cincuenta + " billetes de 50 \n");
            txtresultado.AppendText("Hay " + veinte + " billetes de 20 \n");
            txtresultado.AppendText("Hay " + dies + " billetes de 10 \n");
            txtresultado.AppendText("Hay " + cinco + " moneda de 5 \n");
            txtresultado.AppendText("Hay " + dos + " monedas de 2 \n");
            txtresultado.AppendText("Hay " + uno + " moneda de 1 \n");
        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblmonto_Click(object sender, EventArgs e)
        {
        }
    }
}
