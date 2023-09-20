namespace proyecto01.repetitivos
{
    partial class _04
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
            txtnum = new TextBox();
            label1 = new Label();
            txtmultiplos = new TextBox();
            lblmul = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 81);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 184;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(91, 268);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 181;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(135, 41);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(80, 23);
            txtnum.TabIndex = 180;
            txtnum.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 182;
            label1.Text = "Numero:";
            // 
            // txtmultiplos
            // 
            txtmultiplos.Location = new Point(135, 12);
            txtmultiplos.Name = "txtmultiplos";
            txtmultiplos.Size = new Size(80, 23);
            txtmultiplos.TabIndex = 179;
            txtmultiplos.TextAlign = HorizontalAlignment.Right;
            // 
            // lblmul
            // 
            lblmul.AutoSize = true;
            lblmul.Location = new Point(61, 15);
            lblmul.Name = "lblmul";
            lblmul.Size = new Size(60, 15);
            lblmul.TabIndex = 183;
            lblmul.Text = "Multiplos:";
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 309);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtnum);
            Controls.Add(label1);
            Controls.Add(txtmultiplos);
            Controls.Add(lblmul);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtnum;
        private Label label1;
        private TextBox txtmultiplos;
        private Label lblmul;
    }
}