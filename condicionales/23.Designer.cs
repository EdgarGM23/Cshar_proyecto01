namespace proyecto01.condicionales
{
    partial class _23
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
            txtfis = new TextBox();
            label1 = new Label();
            txtmat = new TextBox();
            lblmat = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(32, 80);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 146;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(111, 267);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 143;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtfis
            // 
            txtfis.Location = new Point(154, 41);
            txtfis.Name = "txtfis";
            txtfis.Size = new Size(80, 23);
            txtfis.TabIndex = 142;
            txtfis.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 44);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 144;
            label1.Text = "Fisica:";
            // 
            // txtmat
            // 
            txtmat.Location = new Point(154, 12);
            txtmat.Name = "txtmat";
            txtmat.Size = new Size(80, 23);
            txtmat.TabIndex = 141;
            txtmat.TextAlign = HorizontalAlignment.Right;
            // 
            // lblmat
            // 
            lblmat.AutoSize = true;
            lblmat.Location = new Point(80, 15);
            lblmat.Name = "lblmat";
            lblmat.Size = new Size(73, 15);
            lblmat.TabIndex = 145;
            lblmat.Text = "Matematica:";
            // 
            // _23
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 309);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtfis);
            Controls.Add(label1);
            Controls.Add(txtmat);
            Controls.Add(lblmat);
            Name = "_23";
            Text = "_23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtfis;
        private Label label1;
        private TextBox txtmat;
        private Label lblmat;
    }
}