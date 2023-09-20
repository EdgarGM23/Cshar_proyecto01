namespace proyecto01.repetitivos
{
    partial class _01
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
            txtdivisor = new TextBox();
            label1 = new Label();
            txtdividendo = new TextBox();
            lbldividendo = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(24, 99);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 184;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(103, 286);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 181;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtdivisor
            // 
            txtdivisor.Location = new Point(149, 41);
            txtdivisor.Name = "txtdivisor";
            txtdivisor.Size = new Size(80, 23);
            txtdivisor.TabIndex = 180;
            txtdivisor.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 182;
            label1.Text = "Divisor:";
            // 
            // txtdividendo
            // 
            txtdividendo.Location = new Point(149, 12);
            txtdividendo.Name = "txtdividendo";
            txtdividendo.Size = new Size(80, 23);
            txtdividendo.TabIndex = 179;
            txtdividendo.TextAlign = HorizontalAlignment.Right;
            // 
            // lbldividendo
            // 
            lbldividendo.AutoSize = true;
            lbldividendo.Location = new Point(75, 15);
            lbldividendo.Name = "lbldividendo";
            lbldividendo.Size = new Size(64, 15);
            lbldividendo.TabIndex = 183;
            lbldividendo.Text = "Dividendo:";
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 324);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtdivisor);
            Controls.Add(label1);
            Controls.Add(txtdividendo);
            Controls.Add(lbldividendo);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtdivisor;
        private Label label1;
        private TextBox txtdividendo;
        private Label lbldividendo;
    }
}