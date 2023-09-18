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
    public partial class _28 : Form
    {
        public _28()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int hora = int.Parse(txthora.Text);

            int[] horaplus = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            txtres.Text = "";

            if (hora > 12 && hora < 25) txtres.AppendText("Son las " + horaplus[hora - 13]);
            else if (hora > 24) txtres.AppendText("Esa hora no es valida");
            else txtres.AppendText("Son las " + hora);
        }
    }
}
