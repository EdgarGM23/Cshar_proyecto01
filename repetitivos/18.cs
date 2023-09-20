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
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }
        //Para borrar espacios de la izquierda----------------------------------------------
        static String izquierda(String texto)
        {

            if (texto.Equals("")) return "";
            String finale = "";

            for (int i = 0; i <= texto.Length - 1; i++)
            {
                String completo = ((char)texto[i]).ToString();
                if (!completo.Equals(" "))
                {
                    finale = texto.Substring(i, texto.Length - 1);
                    break;
                }
            }
            return finale;
        }
        //Para borrar espacios de la derecha------------------------------------------------
        static String derecha(String texto)
        {

            if (texto.Equals("")) return "";
            String finale = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                String completo = ((char)texto[i]).ToString();
                if (!completo.Equals(" "))
                {
                    finale = texto.Substring(0, i + 1);
                    break;
                }
            }
            return finale;
        }
        //Para borrar todos los espacios---------------------------------------------------
        static String sinEspacios(String texto)
        {

            if (texto.Equals("")) return "";
            String finale = "";
            for (int i = 0; i <= texto.Length - 1; i++)
            {
                String completo = ((char)texto[i]).ToString();
                if (!completo.Equals(" "))
                {
                    finale += texto[i];
                }
            }
            return finale;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            String nombre = txttexto.Text;

            txtres.Text = sinEspacios(nombre);
        }
    }
}
