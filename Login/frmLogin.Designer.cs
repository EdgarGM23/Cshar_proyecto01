namespace appFP_CSharp.Login
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btniniciar = new Button();
            lblusuario = new Label();
            lblpassword = new Label();
            txtusuario = new TextBox();
            txtpassword = new TextBox();
            pictureBox1 = new PictureBox();
            btncancelar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btniniciar
            // 
            btniniciar.BackColor = Color.Purple;
            btniniciar.Cursor = Cursors.Hand;
            btniniciar.ForeColor = SystemColors.ControlLightLight;
            btniniciar.Location = new Point(88, 166);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(75, 23);
            btniniciar.TabIndex = 3;
            btniniciar.Text = "Iniciar";
            btniniciar.UseVisualStyleBackColor = false;
            btniniciar.Click += btniniciar_Click;
            btniniciar.Enter += btniniciar_Enter;
            btniniciar.MouseEnter += btniniciar_MouseEnter;
            btniniciar.MouseLeave += btniniciar_MouseLeave;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(77, 89);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(50, 15);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuario:";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(77, 120);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(60, 15);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Password:";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(134, 86);
            txtusuario.MaxLength = 6;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(148, 23);
            txtusuario.TabIndex = 1;
            txtusuario.MouseClick += txtusuario_MouseClick;
            txtusuario.Enter += txtusuario_Enter;
            txtusuario.KeyPress += txtusuario_KeyPress;
            txtusuario.Leave += txtusuario_Leave;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(134, 115);
            txtpassword.MaxLength = 8;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(148, 23);
            txtpassword.TabIndex = 2;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.Enter += txtpassword_Enter;
            txtpassword.KeyPress += txtpassword_KeyPress;
            txtpassword.Leave += txtpassword_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Purple;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 44);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Purple;
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.ForeColor = SystemColors.ControlLightLight;
            btncancelar.Location = new Point(192, 166);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 4;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += button2_Click;
            btncancelar.MouseEnter += button2_MouseEnter;
            btncancelar.MouseLeave += button2_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Purple;
            pictureBox2.Image = proyecto01.Properties.Resources.logo;
            pictureBox2.Location = new Point(57, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 44);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Purple;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = proyecto01.Properties.Resources.salir;
            pictureBox3.Location = new Point(324, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 24);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 201);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(lblpassword);
            Controls.Add(lblusuario);
            Controls.Add(btncancelar);
            Controls.Add(btniniciar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btniniciar;
        private Label lblusuario;
        private Label lblpassword;
        private TextBox txtusuario;
        private TextBox txtpassword;
        private PictureBox pictureBox1;
        private Button btncancelar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}