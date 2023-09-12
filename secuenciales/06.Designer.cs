namespace proyecto01.secuenciales
{
    partial class _06
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
            txtarea = new TextBox();
            label4 = new Label();
            txtaltura = new TextBox();
            lblaltura = new Label();
            label1 = new Label();
            txtradio = new TextBox();
            label2 = new Label();
            txtvolumen = new TextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(61, 193);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 27;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtarea
            // 
            txtarea.Location = new Point(101, 110);
            txtarea.Name = "txtarea";
            txtarea.ReadOnly = true;
            txtarea.Size = new Size(80, 23);
            txtarea.TabIndex = 26;
            txtarea.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 112);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 25;
            label4.Text = "Area:";
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(101, 12);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(80, 23);
            txtaltura.TabIndex = 24;
            txtaltura.TextAlign = HorizontalAlignment.Right;
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(27, 15);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(42, 15);
            lblaltura.TabIndex = 23;
            lblaltura.Text = "Altura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 44);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 23;
            label1.Text = "Radio:";
            // 
            // txtradio
            // 
            txtradio.Location = new Point(101, 41);
            txtradio.Name = "txtradio";
            txtradio.Size = new Size(80, 23);
            txtradio.TabIndex = 24;
            txtradio.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 141);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 25;
            label2.Text = "Volumen:";
            // 
            // txtvolumen
            // 
            txtvolumen.Location = new Point(101, 139);
            txtvolumen.Name = "txtvolumen";
            txtvolumen.ReadOnly = true;
            txtvolumen.Size = new Size(80, 23);
            txtvolumen.TabIndex = 26;
            txtvolumen.TextAlign = HorizontalAlignment.Right;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 239);
            Controls.Add(btncalcular);
            Controls.Add(txtvolumen);
            Controls.Add(label2);
            Controls.Add(txtarea);
            Controls.Add(label4);
            Controls.Add(txtradio);
            Controls.Add(label1);
            Controls.Add(txtaltura);
            Controls.Add(lblaltura);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtarea;
        private Label label4;
        private TextBox txtaltura;
        private Label lblaltura;
        private Label label1;
        private TextBox txtradio;
        private Label label2;
        private TextBox txtvolumen;
    }
}