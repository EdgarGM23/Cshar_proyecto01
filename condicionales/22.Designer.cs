namespace proyecto01.condicionales
{
    partial class _22
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
            txtb = new TextBox();
            label1 = new Label();
            txta = new TextBox();
            txtnum = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(22, 80);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 140;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(101, 267);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 137;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtb
            // 
            txtb.Location = new Point(144, 41);
            txtb.Name = "txtb";
            txtb.Size = new Size(80, 23);
            txtb.TabIndex = 136;
            txtb.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 44);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 138;
            label1.Text = "B:";
            // 
            // txta
            // 
            txta.Location = new Point(144, 12);
            txta.Name = "txta";
            txta.Size = new Size(80, 23);
            txta.TabIndex = 135;
            txta.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnum
            // 
            txtnum.AutoSize = true;
            txtnum.Location = new Point(70, 15);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(18, 15);
            txtnum.TabIndex = 139;
            txtnum.Text = "A:";
            // 
            // _22
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 307);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtb);
            Controls.Add(label1);
            Controls.Add(txta);
            Controls.Add(txtnum);
            Name = "_22";
            Text = "_22";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtb;
        private Label label1;
        private TextBox txta;
        private Label txtnum;
    }
}