namespace proyecto01.condicionales
{
    partial class _35
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
            txtnumero = new TextBox();
            lblnumero = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(20, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 170;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(99, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 167;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(135, 23);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 165;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(61, 26);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(54, 15);
            lblnumero.TabIndex = 169;
            lblnumero.Text = "Numero:";
            // 
            // _35
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 296);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtnumero);
            Controls.Add(lblnumero);
            Name = "_35";
            Text = "_35";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtnumero;
        private Label lblnumero;
    }
}