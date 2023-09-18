namespace proyecto01.condicionales
{
    partial class _17
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
            txtprecio = new TextBox();
            label1 = new Label();
            txtres = new RichTextBox();
            btncalcular = new Button();
            txtdocenas = new TextBox();
            txtimport = new Label();
            SuspendLayout();
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(135, 41);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(80, 23);
            txtprecio.TabIndex = 2;
            txtprecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 126;
            label1.Text = "Precio: ";
            // 
            // txtres
            // 
            txtres.Location = new Point(21, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 128;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(100, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtdocenas
            // 
            txtdocenas.Location = new Point(135, 12);
            txtdocenas.Name = "txtdocenas";
            txtdocenas.Size = new Size(80, 23);
            txtdocenas.TabIndex = 1;
            txtdocenas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtimport
            // 
            txtimport.AutoSize = true;
            txtimport.Location = new Point(61, 15);
            txtimport.Name = "txtimport";
            txtimport.Size = new Size(55, 15);
            txtimport.TabIndex = 127;
            txtimport.Text = "Docenas:";
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 298);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtprecio);
            Controls.Add(label1);
            Controls.Add(txtdocenas);
            Controls.Add(txtimport);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtprecio;
        private Label label1;
        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtdocenas;
        private Label txtimport;
    }
}