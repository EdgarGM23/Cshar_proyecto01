namespace proyecto01.condicionales
{
    partial class _38
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
            txtaño = new TextBox();
            label2 = new Label();
            txtmes = new TextBox();
            label1 = new Label();
            txtdia = new TextBox();
            lbldia = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(13, 99);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 178;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(92, 286);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 174;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtaño
            // 
            txtaño.Location = new Point(138, 70);
            txtaño.Name = "txtaño";
            txtaño.Size = new Size(80, 23);
            txtaño.TabIndex = 173;
            txtaño.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 73);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 175;
            label2.Text = "Año:";
            // 
            // txtmes
            // 
            txtmes.Location = new Point(138, 41);
            txtmes.Name = "txtmes";
            txtmes.Size = new Size(80, 23);
            txtmes.TabIndex = 172;
            txtmes.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 44);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 176;
            label1.Text = "Mes:";
            // 
            // txtdia
            // 
            txtdia.Location = new Point(138, 12);
            txtdia.Name = "txtdia";
            txtdia.Size = new Size(80, 23);
            txtdia.TabIndex = 171;
            txtdia.TextAlign = HorizontalAlignment.Right;
            // 
            // lbldia
            // 
            lbldia.AutoSize = true;
            lbldia.Location = new Point(64, 15);
            lbldia.Name = "lbldia";
            lbldia.Size = new Size(27, 15);
            lbldia.TabIndex = 177;
            lbldia.Text = "Dia:";
            // 
            // _38
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 327);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtaño);
            Controls.Add(label2);
            Controls.Add(txtmes);
            Controls.Add(label1);
            Controls.Add(txtdia);
            Controls.Add(lbldia);
            Name = "_38";
            Text = "_38";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtaño;
        private Label label2;
        private TextBox txtmes;
        private Label label1;
        private TextBox txtdia;
        private Label lbldia;
    }
}