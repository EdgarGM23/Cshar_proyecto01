namespace proyecto01.condicionales
{
    partial class _33
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
            txtrendi = new TextBox();
            label1 = new Label();
            txttardanza = new TextBox();
            lbltardanza = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(15, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 170;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(94, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 167;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtrendi
            // 
            txtrendi.Location = new Point(132, 41);
            txtrendi.Name = "txtrendi";
            txtrendi.Size = new Size(80, 23);
            txtrendi.TabIndex = 166;
            txtrendi.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 44);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 168;
            label1.Text = "Rendimiento:";
            // 
            // txttardanza
            // 
            txttardanza.Location = new Point(132, 12);
            txttardanza.Name = "txttardanza";
            txttardanza.Size = new Size(80, 23);
            txttardanza.TabIndex = 165;
            txttardanza.TextAlign = HorizontalAlignment.Right;
            // 
            // lbltardanza
            // 
            lbltardanza.AutoSize = true;
            lbltardanza.Location = new Point(58, 15);
            lbltardanza.Name = "lbltardanza";
            lbltardanza.Size = new Size(56, 15);
            lbltardanza.TabIndex = 169;
            lbltardanza.Text = "Tardanza:";
            // 
            // _33
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 295);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtrendi);
            Controls.Add(label1);
            Controls.Add(txttardanza);
            Controls.Add(lbltardanza);
            Name = "_33";
            Text = "_33";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtrendi;
        private Label label1;
        private TextBox txttardanza;
        private Label lbltardanza;
    }
}