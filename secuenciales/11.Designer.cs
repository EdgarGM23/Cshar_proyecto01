namespace proyecto01.secuenciales
{
    partial class _11
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
            txtsegundo = new TextBox();
            lblperimetro = new Label();
            txtprimero = new TextBox();
            label4 = new Label();
            txtnumero2 = new TextBox();
            lblnum2 = new Label();
            txtnumero1 = new TextBox();
            lblnum1 = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(70, 207);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtsegundo
            // 
            txtsegundo.Location = new Point(110, 153);
            txtsegundo.Name = "txtsegundo";
            txtsegundo.ReadOnly = true;
            txtsegundo.Size = new Size(80, 23);
            txtsegundo.TabIndex = 43;
            txtsegundo.TextAlign = HorizontalAlignment.Right;
            // 
            // lblperimetro
            // 
            lblperimetro.AutoSize = true;
            lblperimetro.Location = new Point(36, 155);
            lblperimetro.Name = "lblperimetro";
            lblperimetro.Size = new Size(69, 15);
            lblperimetro.TabIndex = 41;
            lblperimetro.Text = "Segundo N:";
            // 
            // txtprimero
            // 
            txtprimero.Location = new Point(110, 124);
            txtprimero.Name = "txtprimero";
            txtprimero.ReadOnly = true;
            txtprimero.Size = new Size(80, 23);
            txtprimero.TabIndex = 44;
            txtprimero.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 126);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 42;
            label4.Text = "Primer N:";
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(110, 55);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(80, 23);
            txtnumero2.TabIndex = 2;
            txtnumero2.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.Location = new Point(36, 58);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(60, 15);
            lblnum2.TabIndex = 37;
            lblnum2.Text = "Numero 2";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(110, 26);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(80, 23);
            txtnumero1.TabIndex = 1;
            txtnumero1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Location = new Point(36, 29);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(63, 15);
            lblnum1.TabIndex = 38;
            lblnum1.Text = "Numero 1:";
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 259);
            Controls.Add(btncalcular);
            Controls.Add(txtsegundo);
            Controls.Add(lblperimetro);
            Controls.Add(txtprimero);
            Controls.Add(label4);
            Controls.Add(txtnumero2);
            Controls.Add(lblnum2);
            Controls.Add(txtnumero1);
            Controls.Add(lblnum1);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtsegundo;
        private Label lblperimetro;
        private TextBox txtprimero;
        private Label label4;
        private TextBox txtnumero2;
        private Label lblnum2;
        private TextBox txtnumero1;
        private Label lblnum1;
    }
}