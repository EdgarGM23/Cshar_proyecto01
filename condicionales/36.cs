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
    public partial class _36 : Form
    {
        public _36()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int cuadernos = int.Parse(txtcuaderno.Text);
            int lucas = 0;
            int faber = 0;
            int pilot = 0;
            Boolean lapiceros = true;

            if (cuadernos < 12) lapiceros = false;
            else if (cuadernos >= 12 && cuadernos < 24) lucas = (cuadernos / 4);
            else if (cuadernos >= 24 && cuadernos < 36) faber = 2 * (cuadernos / 4);
            else if (cuadernos >= 36)
            {
                pilot = 2 * (cuadernos / 4);
                faber = cuadernos / 6;
                lucas = cuadernos / 12;
            }
            txtres.Text = "";

            txtres.AppendText("Lucas: " + (int)(lucas) + "\n");
            txtres.AppendText("Faber: " + (int)(faber) + "\n");
            txtres.AppendText("Pilot: " + (int)(pilot) + "\n");
        }
    }
}
