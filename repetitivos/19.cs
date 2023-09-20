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
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            String linea = "";
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int numero = rnd.Next(100);
                linea += numero.ToString() + (i < 9 ? ", " : " ");
            }

            txtres.Text = "";
            txtres.AppendText(linea);
        }
    }
}
