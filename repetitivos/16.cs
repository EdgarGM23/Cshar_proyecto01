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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }
        static String invertidor(String texto)
        {
            String inverso = "";
            if (texto.Equals("")) return "";
            //charAt
            // a = 97
            // contains es booleano

            for (int j = 0; j <= texto.Length - 1; j++)
            {
                int k = texto[j];
                inverso = (char)k + inverso;
            }
            return inverso;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            String nombre = txttexto.Text;

            txtres.Text = invertidor(nombre);
        }
    }
}
