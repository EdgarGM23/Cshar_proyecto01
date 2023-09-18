namespace proyecto01.condicionales
{
    partial class _34
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
            txtestatura = new TextBox();
            label1 = new Label();
            txtpeso = new TextBox();
            lblpeso = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 170;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(91, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 167;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtestatura
            // 
            txtestatura.Location = new Point(129, 41);
            txtestatura.Name = "txtestatura";
            txtestatura.Size = new Size(80, 23);
            txtestatura.TabIndex = 166;
            txtestatura.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 44);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 168;
            label1.Text = "Estatura:";
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(129, 12);
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new Size(80, 23);
            txtpeso.TabIndex = 165;
            txtpeso.TextAlign = HorizontalAlignment.Right;
            // 
            // lblpeso
            // 
            lblpeso.AutoSize = true;
            lblpeso.Location = new Point(55, 15);
            lblpeso.Name = "lblpeso";
            lblpeso.Size = new Size(35, 15);
            lblpeso.TabIndex = 169;
            lblpeso.Text = "Peso:";
            // 
            // _34
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 295);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtestatura);
            Controls.Add(label1);
            Controls.Add(txtpeso);
            Controls.Add(lblpeso);
            Name = "_34";
            Text = "_34";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtestatura;
        private Label label1;
        private TextBox txtpeso;
        private Label lblpeso;
    }
}