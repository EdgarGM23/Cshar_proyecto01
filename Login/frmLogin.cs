using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtpassword.Text = "";
            txtusuario.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes) Application.Exit();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" && txtpassword.Text == "") MessageBox.Show("Ingrese el Usuario y la Contraseña");
            else if (txtusuario.Text == "") MessageBox.Show("Ingrese el Usuario");
            else if (txtpassword.Text == "") MessageBox.Show("Ingrese la Contraseña");
            else if (txtusuario.Text.Length != 6 || txtpassword.Text.Length != 8) MessageBox.Show("Falta completar");
            else MessageBox.Show("Bienvenido");
        }

        private void btniniciar_Enter(object sender, EventArgs e)
        {

        }

        private void btniniciar_MouseEnter(object sender, EventArgs e)
        {
            btniniciar.BackColor = Color.Gray;
        }

        private void btniniciar_MouseLeave(object sender, EventArgs e)
        {
            btniniciar.BackColor = Color.Purple;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btncancelar.BackColor = Color.Gray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackColor = Color.Purple;
        }

        private void txtusuario_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            txtusuario.BackColor = Color.LightBlue;
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            txtusuario.BackColor = Color.White;
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            txtpassword.BackColor = Color.White;
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            txtpassword.BackColor = Color.LightBlue;
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) e.Handled = true;
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) e.Handled = true;
        }
    }
}
