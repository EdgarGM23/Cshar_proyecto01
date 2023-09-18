namespace proyecto01.condicionales
{
    partial class _16
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
            txtimporte = new TextBox();
            txtimport = new Label();
            label1 = new Label();
            txtcasa = new TextBox();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 122;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(91, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 120;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtimporte
            // 
            txtimporte.Location = new Point(126, 12);
            txtimporte.Name = "txtimporte";
            txtimporte.Size = new Size(80, 23);
            txtimporte.TabIndex = 119;
            txtimporte.TextAlign = HorizontalAlignment.Right;
            // 
            // txtimport
            // 
            txtimport.AutoSize = true;
            txtimport.Location = new Point(52, 15);
            txtimport.Name = "txtimport";
            txtimport.Size = new Size(52, 15);
            txtimport.TabIndex = 121;
            txtimport.Text = "Importe:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 44);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 121;
            label1.Text = "Casa:";
            // 
            // txtcasa
            // 
            txtcasa.Location = new Point(126, 41);
            txtcasa.Name = "txtcasa";
            txtcasa.Size = new Size(80, 23);
            txtcasa.TabIndex = 119;
            txtcasa.TextAlign = HorizontalAlignment.Right;
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 298);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtcasa);
            Controls.Add(label1);
            Controls.Add(txtimporte);
            Controls.Add(txtimport);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtimporte;
        private Label txtimport;
        private Label label1;
        private TextBox txtcasa;
    }
}