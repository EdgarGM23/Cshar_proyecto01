namespace proyecto01.condicionales
{
    partial class _37
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
            txtcarol = new TextBox();
            label1 = new Label();
            txtpamela = new TextBox();
            lblpam = new Label();
            label2 = new Label();
            txtfanny = new TextBox();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 99);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 170;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(91, 286);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtcarol
            // 
            txtcarol.Location = new Point(137, 41);
            txtcarol.Name = "txtcarol";
            txtcarol.Size = new Size(80, 23);
            txtcarol.TabIndex = 2;
            txtcarol.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 168;
            label1.Text = "Carol:";
            // 
            // txtpamela
            // 
            txtpamela.Location = new Point(137, 12);
            txtpamela.Name = "txtpamela";
            txtpamela.Size = new Size(80, 23);
            txtpamela.TabIndex = 1;
            txtpamela.TextAlign = HorizontalAlignment.Right;
            // 
            // lblpam
            // 
            lblpam.AutoSize = true;
            lblpam.Location = new Point(63, 15);
            lblpam.Name = "lblpam";
            lblpam.Size = new Size(49, 15);
            lblpam.TabIndex = 169;
            lblpam.Text = "Pamela:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 73);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 168;
            label2.Text = "Fanny:";
            // 
            // txtfanny
            // 
            txtfanny.Location = new Point(137, 70);
            txtfanny.Name = "txtfanny";
            txtfanny.Size = new Size(80, 23);
            txtfanny.TabIndex = 3;
            txtfanny.TextAlign = HorizontalAlignment.Right;
            // 
            // _37
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 328);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtfanny);
            Controls.Add(label2);
            Controls.Add(txtcarol);
            Controls.Add(label1);
            Controls.Add(txtpamela);
            Controls.Add(lblpam);
            Name = "_37";
            Text = "_37";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtcarol;
        private Label label1;
        private TextBox txtpamela;
        private Label lblpam;
        private Label label2;
        private TextBox txtfanny;
    }
}