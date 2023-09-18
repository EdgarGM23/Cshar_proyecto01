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
    public partial class _40 : Form
    {
        public _40()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double mat_PC1 = Double.Parse(txtmat_pc1.Text);
            double mat_PC2 = Double.Parse(txtmat_pc2.Text);
            double mat_PC3 = Double.Parse(txtmat_pc3.Text);
            double mat_EP = Double.Parse(txtmat_ep.Text);
            double mat_EF = Double.Parse(txtmat_ef.Text);

            double fis_PC1 = Double.Parse(txtfis_pc1.Text);
            double fis_PC2 = Double.Parse(txtfis_pc2.Text);
            double fis_PC3 = Double.Parse(txtfis_pc3.Text);
            double fis_EP = Double.Parse(txtfis_ep.Text);
            double fis_EF = Double.Parse(txtfis_ef.Text);

            double qui_PC1 = Double.Parse(txtqui_pc1.Text);
            double qui_PC2 = Double.Parse(txtqui_pc2.Text);
            double qui_PC3 = Double.Parse(txtqui_pc3.Text);
            double qui_EP = Double.Parse(txtqui_ep.Text);
            double qui_EF = Double.Parse(txtqui_ef.Text);

            txtres.Text = "";

            double mat_promedio = (mat_PC1 * 0.1) + (mat_PC2 * 0.2) + (mat_PC3 * 0.1) + (mat_EP * 0.3) + (mat_EF * 0.3);
            double fis_promedio = (fis_PC1 * 0.2) + (fis_PC2 * 0.2) + (fis_PC3 * 0.2) + (fis_EP * 0.2) + (fis_EF * 0.2);
            double qui_promedio = (qui_PC1 * 0.1) + (qui_PC2 * 0.3) + (qui_PC3 * 0.1) + (qui_EP * 0.25) + (qui_EF * 0.25);

            if (mat_promedio >= 13) txtres.AppendText("Aprobó Matematica con " + mat_promedio.ToString("##.00") + " de nota" + "\n");
            else txtres.AppendText("Desaprobó con " + mat_promedio.ToString("##.00") + " de nota");
            if (fis_promedio >= 13) txtres.AppendText("Aprobó Fisica con " + fis_promedio.ToString("##.00") + " de nota" + "\n");
            else txtres.AppendText("Desaprobó con " + fis_promedio.ToString("##.00") + " de nota");
            if (qui_promedio >= 13) txtres.AppendText("Aprobó Quimica con " + qui_promedio.ToString("##.00") + " de nota" + "\n");
            else txtres.AppendText("Desaprobó con " + qui_promedio.ToString("##.00") + " de nota");
        }
    }
}
