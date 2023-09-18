namespace proyecto01.condicionales
{
    partial class _19
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
            txtedad = new TextBox();
            label1 = new Label();
            txtsexo = new TextBox();
            txtimport = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(18, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 134;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(97, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 131;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(132, 41);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(80, 23);
            txtedad.TabIndex = 130;
            txtedad.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 44);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 132;
            label1.Text = "Edad:";
            // 
            // txtsexo
            // 
            txtsexo.Location = new Point(132, 12);
            txtsexo.Name = "txtsexo";
            txtsexo.Size = new Size(80, 23);
            txtsexo.TabIndex = 129;
            txtsexo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtimport
            // 
            txtimport.AutoSize = true;
            txtimport.Location = new Point(58, 15);
            txtimport.Name = "txtimport";
            txtimport.Size = new Size(35, 15);
            txtimport.TabIndex = 133;
            txtimport.Text = "Sexo:";
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 300);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtedad);
            Controls.Add(label1);
            Controls.Add(txtsexo);
            Controls.Add(txtimport);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtedad;
        private Label label1;
        private TextBox txtsexo;
        private Label txtimport;
    }
}