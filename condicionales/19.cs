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
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            String sexo = txtsexo.Text;
            int edad = int.Parse(txtedad.Text);
            String categoria = "No definido";
            txtres.Text = "";

            if (sexo.Equals("femenino") && edad < 23) categoria = "FA";
            else if (sexo.Equals("femenino") && edad >= 23) categoria = "FB";
            else
            {
                if (sexo.Equals("masculino") && edad < 25) categoria = "FA";
                else if (sexo.Equals("masculino") && edad >= 25) categoria = "FB";
                else txtres.Text = "Los valores ingresados no son validos \n";
            }

            txtres.AppendText("Categoria: " + categoria + "\n");
        }
    }
}
