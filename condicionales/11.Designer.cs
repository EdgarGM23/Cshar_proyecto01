namespace proyecto01.condicionales
{
    partial class _11
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
            btncalcular = new Button();
            txtnumero = new TextBox();
            lblnum = new Label();
            label1 = new Label();
            txtrpta = new TextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(93, 125);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(120, 12);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 1;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            txtnumero.TextChanged += txtnota1_TextChanged;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(46, 15);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(54, 15);
            lblnum.TabIndex = 119;
            lblnum.Text = "Numero:";
            lblnum.Click += lblnota1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 69);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 119;
            label1.Text = "Respuesta:";
            label1.Click += lblnota1_Click;
            // 
            // txtrpta
            // 
            txtrpta.Location = new Point(120, 66);
            txtrpta.Name = "txtrpta";
            txtrpta.ReadOnly = true;
            txtrpta.Size = new Size(80, 23);
            txtrpta.TabIndex = 117;
            txtrpta.TextAlign = HorizontalAlignment.Right;
            txtrpta.TextChanged += txtnota1_TextChanged;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 167);
            Controls.Add(btncalcular);
            Controls.Add(txtrpta);
            Controls.Add(label1);
            Controls.Add(txtnumero);
            Controls.Add(lblnum);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btncalcular;
        private TextBox txtnumero;
        private Label lblnum;
        private Label label1;
        private TextBox txtrpta;
    }
}