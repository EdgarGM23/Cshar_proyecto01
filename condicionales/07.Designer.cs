namespace proyecto01.condicionales
{
    partial class _07
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
            txtresultado = new RichTextBox();
            btncalcular = new Button();
            txtnumero3 = new TextBox();
            label2 = new Label();
            txtnumero2 = new TextBox();
            label1 = new Label();
            txtnumero1 = new TextBox();
            lblnum1 = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(25, 122);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 171);
            txtresultado.TabIndex = 108;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(104, 309);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 104;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnumero3
            // 
            txtnumero3.Location = new Point(127, 80);
            txtnumero3.Name = "txtnumero3";
            txtnumero3.Size = new Size(80, 23);
            txtnumero3.TabIndex = 103;
            txtnumero3.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 105;
            label2.Text = "Numero 3:";
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(127, 51);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(80, 23);
            txtnumero2.TabIndex = 102;
            txtnumero2.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 54);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 106;
            label1.Text = "Numero 2:";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(127, 22);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(80, 23);
            txtnumero1.TabIndex = 101;
            txtnumero1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Location = new Point(53, 25);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(63, 15);
            lblnum1.TabIndex = 107;
            lblnum1.Text = "Numero 1:";
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 351);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtnumero3);
            Controls.Add(label2);
            Controls.Add(txtnumero2);
            Controls.Add(label1);
            Controls.Add(txtnumero1);
            Controls.Add(lblnum1);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtnumero3;
        private Label label2;
        private TextBox txtnumero2;
        private Label label1;
        private TextBox txtnumero1;
        private Label lblnum1;
    }
}