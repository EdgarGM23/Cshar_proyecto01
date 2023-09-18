namespace proyecto01.condicionales
{
    partial class _21
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
            txtnum = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(22, 61);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 138;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(101, 248);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 136;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(144, 12);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 135;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnum
            // 
            txtnum.AutoSize = true;
            txtnum.Location = new Point(70, 15);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(54, 15);
            txtnum.TabIndex = 137;
            txtnum.Text = "Numero:";
            // 
            // _21
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 289);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtnumero);
            Controls.Add(txtnum);
            Name = "_21";
            Text = "_21";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtnumero;
        private Label txtnum;
    }
}