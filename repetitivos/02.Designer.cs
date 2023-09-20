namespace proyecto01.repetitivos
{
    partial class _02
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
            txtnum2 = new TextBox();
            label1 = new Label();
            txtnum1 = new TextBox();
            lblnum1 = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(19, 99);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 184;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(98, 286);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 181;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(144, 41);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(80, 23);
            txtnum2.TabIndex = 180;
            txtnum2.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 182;
            label1.Text = "Numero 2:";
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(144, 12);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(80, 23);
            txtnum1.TabIndex = 179;
            txtnum1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Location = new Point(70, 15);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(63, 15);
            lblnum1.TabIndex = 183;
            lblnum1.Text = "Numero 1:";
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 320);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtnum2);
            Controls.Add(label1);
            Controls.Add(txtnum1);
            Controls.Add(lblnum1);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtnum2;
        private Label label1;
        private TextBox txtnum1;
        private Label lblnum1;
    }
}