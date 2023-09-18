namespace proyecto01.condicionales
{
    partial class _26
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
            txtmonto = new TextBox();
            lblsueldo = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(19, 61);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 146;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(98, 248);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 144;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtmonto
            // 
            txtmonto.Location = new Point(141, 12);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(80, 23);
            txtmonto.TabIndex = 143;
            txtmonto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblsueldo
            // 
            lblsueldo.AutoSize = true;
            lblsueldo.Location = new Point(67, 15);
            lblsueldo.Name = "lblsueldo";
            lblsueldo.Size = new Size(46, 15);
            lblsueldo.TabIndex = 145;
            lblsueldo.Text = "Monto:";
            // 
            // _26
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 291);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtmonto);
            Controls.Add(lblsueldo);
            Name = "_26";
            Text = "_26";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtmonto;
        private Label lblsueldo;
    }
}