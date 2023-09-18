namespace proyecto01.condicionales
{
    partial class _20
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
            txtres = new RichTextBox();
            btncalcular = new Button();
            txtn2 = new TextBox();
            label1 = new Label();
            txtn1 = new TextBox();
            txtnum = new Label();
            label2 = new Label();
            txtn3 = new TextBox();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 111);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 134;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(91, 298);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtn2
            // 
            txtn2.Location = new Point(133, 53);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(80, 23);
            txtn2.TabIndex = 2;
            txtn2.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 56);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 132;
            label1.Text = "Numero 2:";
            // 
            // txtn1
            // 
            txtn1.Location = new Point(133, 24);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(80, 23);
            txtn1.TabIndex = 1;
            txtn1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnum
            // 
            txtnum.AutoSize = true;
            txtnum.Location = new Point(59, 27);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(63, 15);
            txtnum.TabIndex = 133;
            txtnum.Text = "Numero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 85);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 132;
            label2.Text = "Numero 3:";
            // 
            // txtn3
            // 
            txtn3.Location = new Point(133, 82);
            txtn3.Name = "txtn3";
            txtn3.Size = new Size(80, 23);
            txtn3.TabIndex = 3;
            txtn3.TextAlign = HorizontalAlignment.Right;
            // 
            // _20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 344);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtn3);
            Controls.Add(label2);
            Controls.Add(txtn2);
            Controls.Add(label1);
            Controls.Add(txtn1);
            Controls.Add(txtnum);
            Name = "_20";
            Text = "_20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtn2;
        private Label label1;
        private TextBox txtn1;
        private Label txtnum;
        private Label label2;
        private TextBox txtn3;
    }
}