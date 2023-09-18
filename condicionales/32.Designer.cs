namespace proyecto01.condicionales
{
    partial class _32
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
            txtcat = new TextBox();
            label1 = new Label();
            txtprom = new TextBox();
            lblprom = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(15, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 170;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(94, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 167;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtcat
            // 
            txtcat.Location = new Point(132, 41);
            txtcat.Name = "txtcat";
            txtcat.Size = new Size(80, 23);
            txtcat.TabIndex = 166;
            txtcat.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 168;
            label1.Text = "Categoria:";
            // 
            // txtprom
            // 
            txtprom.Location = new Point(132, 12);
            txtprom.Name = "txtprom";
            txtprom.Size = new Size(80, 23);
            txtprom.TabIndex = 165;
            txtprom.TextAlign = HorizontalAlignment.Right;
            // 
            // lblprom
            // 
            lblprom.AutoSize = true;
            lblprom.Location = new Point(58, 15);
            lblprom.Name = "lblprom";
            lblprom.Size = new Size(62, 15);
            lblprom.TabIndex = 169;
            lblprom.Text = "Promedio:";
            // 
            // _32
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 291);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtcat);
            Controls.Add(label1);
            Controls.Add(txtprom);
            Controls.Add(lblprom);
            Name = "_32";
            Text = "_32";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtcat;
        private Label label1;
        private TextBox txtprom;
        private Label lblprom;
    }
}