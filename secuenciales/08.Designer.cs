namespace proyecto01.secuenciales
{
    partial class _08
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
            txtarealateral = new TextBox();
            lblperimetro = new Label();
            txtareabase = new TextBox();
            label4 = new Label();
            txtradio = new TextBox();
            label1 = new Label();
            txtaltura = new TextBox();
            lblaltura = new Label();
            label2 = new Label();
            txtareatotal = new TextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(56, 211);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 45;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtarealateral
            // 
            txtarealateral.Location = new Point(99, 139);
            txtarealateral.Name = "txtarealateral";
            txtarealateral.ReadOnly = true;
            txtarealateral.Size = new Size(80, 23);
            txtarealateral.TabIndex = 43;
            txtarealateral.TextAlign = HorizontalAlignment.Right;
            // 
            // lblperimetro
            // 
            lblperimetro.AutoSize = true;
            lblperimetro.Location = new Point(25, 141);
            lblperimetro.Name = "lblperimetro";
            lblperimetro.Size = new Size(72, 15);
            lblperimetro.TabIndex = 41;
            lblperimetro.Text = "Area Lateral:";
            // 
            // txtareabase
            // 
            txtareabase.Location = new Point(99, 110);
            txtareabase.Name = "txtareabase";
            txtareabase.ReadOnly = true;
            txtareabase.Size = new Size(80, 23);
            txtareabase.TabIndex = 44;
            txtareabase.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 112);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 42;
            label4.Text = "Area base:";
            // 
            // txtradio
            // 
            txtradio.Location = new Point(99, 41);
            txtradio.Name = "txtradio";
            txtradio.Size = new Size(80, 23);
            txtradio.TabIndex = 39;
            txtradio.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 44);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 37;
            label1.Text = "Radio:";
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(99, 12);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(80, 23);
            txtaltura.TabIndex = 40;
            txtaltura.TextAlign = HorizontalAlignment.Right;
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(25, 15);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(42, 15);
            lblaltura.TabIndex = 38;
            lblaltura.Text = "Altura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 170);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 41;
            label2.Text = "Area Total:";
            // 
            // txtareatotal
            // 
            txtareatotal.Location = new Point(99, 168);
            txtareatotal.Name = "txtareatotal";
            txtareatotal.ReadOnly = true;
            txtareatotal.Size = new Size(80, 23);
            txtareatotal.TabIndex = 43;
            txtareatotal.TextAlign = HorizontalAlignment.Right;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 257);
            Controls.Add(btncalcular);
            Controls.Add(txtareatotal);
            Controls.Add(label2);
            Controls.Add(txtarealateral);
            Controls.Add(lblperimetro);
            Controls.Add(txtareabase);
            Controls.Add(label4);
            Controls.Add(txtradio);
            Controls.Add(label1);
            Controls.Add(txtaltura);
            Controls.Add(lblaltura);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtarealateral;
        private Label lblperimetro;
        private TextBox txtareabase;
        private Label label4;
        private TextBox txtradio;
        private Label label1;
        private TextBox txtaltura;
        private Label lblaltura;
        private Label label2;
        private TextBox txtareatotal;
    }
}