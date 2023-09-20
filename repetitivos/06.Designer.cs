namespace proyecto01.repetitivos
{
    partial class _06
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
            txta = new TextBox();
            label2 = new Label();
            txtde = new TextBox();
            label1 = new Label();
            txtnumero = new TextBox();
            lblnum = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(14, 99);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 186;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(93, 286);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 182;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txta
            // 
            txta.Location = new Point(139, 70);
            txta.Name = "txta";
            txta.Size = new Size(80, 23);
            txta.TabIndex = 181;
            txta.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 73);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 183;
            label2.Text = "A:";
            // 
            // txtde
            // 
            txtde.Location = new Point(139, 41);
            txtde.Name = "txtde";
            txtde.Size = new Size(80, 23);
            txtde.TabIndex = 180;
            txtde.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 44);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 184;
            label1.Text = "De:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(139, 12);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 179;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(65, 15);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(54, 15);
            lblnum.TabIndex = 185;
            lblnum.Text = "Numero:";
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 322);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txta);
            Controls.Add(label2);
            Controls.Add(txtde);
            Controls.Add(label1);
            Controls.Add(txtnumero);
            Controls.Add(lblnum);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txta;
        private Label label2;
        private TextBox txtde;
        private Label label1;
        private TextBox txtnumero;
        private Label lblnum;
    }
}