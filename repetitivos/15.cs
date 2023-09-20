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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }
        static String mayus(String texto)
        {
            String rpta = "";
            if (texto.Equals("")) return "";
            //charAt
            // a = 97
            // contains es booleano

            for (int j = 0; j <= texto.Length - 1; j++)
            {
                int k = texto[j];
                rpta += k >= 'a' && k <= 'z' ? (char)(k - 32) : (char)k;
            }
            return rpta;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            String nombre = txttexto.Text;

            txtres.Text = mayus(nombre);
        }
    }
}
