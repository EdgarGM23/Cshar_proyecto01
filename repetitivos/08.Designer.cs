namespace proyecto01.repetitivos
{
    partial class _08
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
            txtpotencia = new TextBox();
            label1 = new Label();
            txtbase = new TextBox();
            lblbase = new Label();
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
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtpotencia
            // 
            txtpotencia.Location = new Point(144, 41);
            txtpotencia.Name = "txtpotencia";
            txtpotencia.Size = new Size(80, 23);
            txtpotencia.TabIndex = 2;
            txtpotencia.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 44);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 182;
            label1.Text = "Potencia:";
            // 
            // txtbase
            // 
            txtbase.Location = new Point(144, 12);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(80, 23);
            txtbase.TabIndex = 1;
            txtbase.TextAlign = HorizontalAlignment.Right;
            // 
            // lblbase
            // 
            lblbase.AutoSize = true;
            lblbase.Location = new Point(70, 15);
            lblbase.Name = "lblbase";
            lblbase.Size = new Size(34, 15);
            lblbase.TabIndex = 183;
            lblbase.Text = "Base:";
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 303);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtpotencia);
            Controls.Add(label1);
            Controls.Add(txtbase);
            Controls.Add(lblbase);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtpotencia;
        private Label label1;
        private TextBox txtbase;
        private Label lblbase;
    }
}