namespace proyecto01.secuenciales
{
    partial class _13
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
            btncalcular = new Button();
            txthipotenusa = new TextBox();
            txtcatetoO = new TextBox();
            lblnum2 = new Label();
            txtcatetoA = new TextBox();
            lblcatA = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(91, 182);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txthipotenusa
            // 
            txthipotenusa.Location = new Point(146, 123);
            txthipotenusa.Name = "txthipotenusa";
            txthipotenusa.ReadOnly = true;
            txthipotenusa.Size = new Size(80, 23);
            txthipotenusa.TabIndex = 0;
            txthipotenusa.TextAlign = HorizontalAlignment.Right;
            // 
            // txtcatetoO
            // 
            txtcatetoO.Location = new Point(146, 54);
            txtcatetoO.Name = "txtcatetoO";
            txtcatetoO.Size = new Size(80, 23);
            txtcatetoO.TabIndex = 2;
            txtcatetoO.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.Location = new Point(37, 57);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(93, 15);
            lblnum2.TabIndex = 48;
            lblnum2.Text = "Cateto Opuesto:";
            // 
            // txtcatetoA
            // 
            txtcatetoA.Location = new Point(146, 25);
            txtcatetoA.Name = "txtcatetoA";
            txtcatetoA.Size = new Size(80, 23);
            txtcatetoA.TabIndex = 1;
            txtcatetoA.TextAlign = HorizontalAlignment.Right;
            // 
            // lblcatA
            // 
            lblcatA.AutoSize = true;
            lblcatA.Location = new Point(37, 28);
            lblcatA.Name = "lblcatA";
            lblcatA.Size = new Size(103, 15);
            lblcatA.TabIndex = 49;
            lblcatA.Text = "Cateto Adyasente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 126);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 51;
            label4.Text = "Hipotenusa:";
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 250);
            Controls.Add(label4);
            Controls.Add(btncalcular);
            Controls.Add(txthipotenusa);
            Controls.Add(txtcatetoO);
            Controls.Add(lblnum2);
            Controls.Add(txtcatetoA);
            Controls.Add(lblcatA);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txthipotenusa;
        private TextBox txtcatetoO;
        private Label lblnum2;
        private TextBox txtcatetoA;
        private Label lblcatA;
        private Label label4;
    }
}