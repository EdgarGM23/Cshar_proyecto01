namespace proyecto01.repetitivos
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
            txtres = new RichTextBox();
            btncalcular = new Button();
            txttexto = new TextBox();
            lbltexto = new Label();
            label1 = new Label();
            txtindex = new TextBox();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 204;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(91, 258);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txttexto
            // 
            txttexto.Location = new Point(136, 12);
            txttexto.Name = "txttexto";
            txttexto.Size = new Size(80, 23);
            txttexto.TabIndex = 1;
            txttexto.TextAlign = HorizontalAlignment.Right;
            // 
            // lbltexto
            // 
            lbltexto.AutoSize = true;
            lbltexto.Location = new Point(62, 15);
            lbltexto.Name = "lbltexto";
            lbltexto.Size = new Size(38, 15);
            lbltexto.TabIndex = 203;
            lbltexto.Text = "Texto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 44);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 203;
            label1.Text = "Buscar:";
            // 
            // txtindex
            // 
            txtindex.Location = new Point(136, 41);
            txtindex.Name = "txtindex";
            txtindex.Size = new Size(80, 23);
            txtindex.TabIndex = 2;
            txtindex.TextAlign = HorizontalAlignment.Right;
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 295);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtindex);
            Controls.Add(label1);
            Controls.Add(txttexto);
            Controls.Add(lbltexto);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txttexto;
        private Label lbltexto;
        private Label label1;
        private TextBox txtindex;
    }
}