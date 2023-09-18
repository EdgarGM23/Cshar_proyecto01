namespace proyecto01.condicionales
{
    partial class _25
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
            txthijos = new TextBox();
            label1 = new Label();
            txtsueldo = new TextBox();
            lblsueldo = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(17, 80);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 152;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(96, 267);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 149;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txthijos
            // 
            txthijos.Location = new Point(139, 41);
            txthijos.Name = "txthijos";
            txthijos.Size = new Size(80, 23);
            txthijos.TabIndex = 148;
            txthijos.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 44);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 150;
            label1.Text = "Hijos:";
            // 
            // txtsueldo
            // 
            txtsueldo.Location = new Point(139, 12);
            txtsueldo.Name = "txtsueldo";
            txtsueldo.Size = new Size(80, 23);
            txtsueldo.TabIndex = 147;
            txtsueldo.TextAlign = HorizontalAlignment.Right;
            // 
            // lblsueldo
            // 
            lblsueldo.AutoSize = true;
            lblsueldo.Location = new Point(65, 15);
            lblsueldo.Name = "lblsueldo";
            lblsueldo.Size = new Size(46, 15);
            lblsueldo.TabIndex = 151;
            lblsueldo.Text = "Sueldo:";
            // 
            // _25
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 307);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txthijos);
            Controls.Add(label1);
            Controls.Add(txtsueldo);
            Controls.Add(lblsueldo);
            Name = "_25";
            Text = "_25";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txthijos;
        private Label label1;
        private TextBox txtsueldo;
        private Label lblsueldo;
    }
}