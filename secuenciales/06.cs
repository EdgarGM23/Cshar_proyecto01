using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace proyecto01.secuenciales
{
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double altura = int.Parse(txtaltura.Text);
            double radio = int.Parse(txtradio.Text);

            double area = 2 * Math.PI * radio * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            txtarea.Text = area.ToString("##.00");
            txtvolumen.Text = volumen.ToString("##.00");
        }
    }
}
