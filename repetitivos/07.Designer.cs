namespace proyecto01.repetitivos
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
            txtres = new RichTextBox();
            btncalcular = new Button();
            txtnum = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(23, 52);
            txtres.Name = "txtres";
            txtres.Size = new Size(172, 89);
            txtres.TabIndex = 192;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(64, 153);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 190;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(97, 12);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(80, 23);
            txtnum.TabIndex = 189;
            txtnum.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 191;
            label1.Text = "Numero:";
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 193);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtnum);
            Controls.Add(label1);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtnum;
        private Label label1;
    }
}