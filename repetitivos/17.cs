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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }
        static String invertidor(String texto, String buscar)
        {

            if (texto.Equals("")) return "";
            String letra = buscar, posicion = "No existe";

            for (int j = 0; j <= texto.Length - 1; j++)
            {
                char k = texto[j];
                String letter = k.ToString();
                if (letter.Equals(letra))
                {
                    posicion = j.ToString();
                }
            }
            return posicion;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            String nombre = txttexto.Text;
            String indice = txtindex.Text;

            txtres.Text = invertidor(nombre, indice);
        }
    }
}
