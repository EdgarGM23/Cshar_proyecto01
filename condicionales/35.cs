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
    public partial class _35 : Form
    {
        public _35()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtnumero.Text);

            Boolean bDiv2 = codigo % 2 == 0;
            Boolean bDiv3 = codigo % 3 == 0;
            Boolean bDiv5 = codigo % 5 == 0;

            txtres.Text = "Es de tipo: ";

            if (codigo > 99 && codigo < 1000)
            {
                if (bDiv2 && bDiv3 && bDiv5) txtres.AppendText("Administrativo");
                else if (!bDiv2 && bDiv3 && bDiv5) txtres.AppendText("Diretivo");
                else if (bDiv2 && !bDiv3 && !bDiv5) txtres.AppendText("Vendedor");
                else if (!bDiv2 && !bDiv3 && !bDiv5) txtres.AppendText("Seguridad");
                else txtres.AppendText("No hay tipo");
            }
            else txtres.AppendText("Error");
        }
    }
}
