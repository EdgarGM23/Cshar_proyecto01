namespace proyecto01.secuenciales
{
    partial class _05
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
            txtgiga = new TextBox();
            lblgigas = new Label();
            txtmega = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtkilo = new TextBox();
            label2 = new Label();
            txtbyte = new TextBox();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // txtgiga
            // 
            txtgiga.Location = new Point(108, 25);
            txtgiga.Name = "txtgiga";
            txtgiga.Size = new Size(80, 23);
            txtgiga.TabIndex = 18;
            txtgiga.TextAlign = HorizontalAlignment.Right;
            // 
            // lblgigas
            // 
            lblgigas.AutoSize = true;
            lblgigas.Location = new Point(34, 28);
            lblgigas.Name = "lblgigas";
            lblgigas.Size = new Size(59, 15);
            lblgigas.TabIndex = 17;
            lblgigas.Text = "Gigabytes";
            // 
            // txtmega
            // 
            txtmega.Location = new Point(108, 54);
            txtmega.Name = "txtmega";
            txtmega.ReadOnly = true;
            txtmega.Size = new Size(80, 23);
            txtmega.TabIndex = 21;
            txtmega.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 56);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 20;
            label4.Text = "Megabytes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 85);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 20;
            label1.Text = "Kilobytes";
            // 
            // txtkilo
            // 
            txtkilo.Location = new Point(108, 83);
            txtkilo.Name = "txtkilo";
            txtkilo.ReadOnly = true;
            txtkilo.Size = new Size(80, 23);
            txtkilo.TabIndex = 21;
            txtkilo.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 114);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 20;
            label2.Text = "bytes";
            // 
            // txtbyte
            // 
            txtbyte.Location = new Point(108, 112);
            txtbyte.Name = "txtbyte";
            txtbyte.ReadOnly = true;
            txtbyte.Size = new Size(80, 23);
            txtbyte.TabIndex = 21;
            txtbyte.TextAlign = HorizontalAlignment.Right;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(68, 153);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 22;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 199);
            Controls.Add(btncalcular);
            Controls.Add(txtbyte);
            Controls.Add(label2);
            Controls.Add(txtkilo);
            Controls.Add(label1);
            Controls.Add(txtmega);
            Controls.Add(label4);
            Controls.Add(txtgiga);
            Controls.Add(lblgigas);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtgiga;
        private Label lblgigas;
        private TextBox txtmega;
        private Label label4;
        private Label label1;
        private TextBox txtkilo;
        private Label label2;
        private TextBox txtbyte;
        private Button btncalcular;
    }
}