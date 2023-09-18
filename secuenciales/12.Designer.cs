namespace proyecto01.secuenciales
{
    partial class _12
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
            txtres2 = new TextBox();
            lblperimetro = new Label();
            txtres1 = new TextBox();
            label4 = new Label();
            txtb = new TextBox();
            lblnum2 = new Label();
            txta = new TextBox();
            lbla = new Label();
            label1 = new Label();
            txtc = new TextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(66, 225);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtres2
            // 
            txtres2.Location = new Point(103, 178);
            txtres2.Name = "txtres2";
            txtres2.ReadOnly = true;
            txtres2.Size = new Size(80, 23);
            txtres2.TabIndex = 52;
            txtres2.TextAlign = HorizontalAlignment.Right;
            // 
            // lblperimetro
            // 
            lblperimetro.AutoSize = true;
            lblperimetro.Location = new Point(29, 180);
            lblperimetro.Name = "lblperimetro";
            lblperimetro.Size = new Size(71, 15);
            lblperimetro.TabIndex = 50;
            lblperimetro.Text = "Resultado 2:";
            // 
            // txtres1
            // 
            txtres1.Location = new Point(103, 149);
            txtres1.Name = "txtres1";
            txtres1.ReadOnly = true;
            txtres1.Size = new Size(80, 23);
            txtres1.TabIndex = 53;
            txtres1.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 151);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 51;
            label4.Text = "Resultado 1:";
            // 
            // txtb
            // 
            txtb.Location = new Point(103, 53);
            txtb.Name = "txtb";
            txtb.Size = new Size(80, 23);
            txtb.TabIndex = 2;
            txtb.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.Location = new Point(29, 56);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(58, 15);
            lblnum2.TabIndex = 48;
            lblnum2.Text = "Ingrese b:";
            // 
            // txta
            // 
            txta.Location = new Point(103, 24);
            txta.Name = "txta";
            txta.Size = new Size(80, 23);
            txta.TabIndex = 1;
            txta.TextAlign = HorizontalAlignment.Right;
            // 
            // lbla
            // 
            lbla.AutoSize = true;
            lbla.Location = new Point(29, 27);
            lbla.Name = "lbla";
            lbla.Size = new Size(57, 15);
            lbla.TabIndex = 49;
            lbla.Text = "Ingrese a:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 85);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 48;
            label1.Text = "Ingrese c:";
            // 
            // txtc
            // 
            txtc.Location = new Point(103, 82);
            txtc.Name = "txtc";
            txtc.Size = new Size(80, 23);
            txtc.TabIndex = 3;
            txtc.TextAlign = HorizontalAlignment.Right;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(209, 273);
            Controls.Add(btncalcular);
            Controls.Add(txtres2);
            Controls.Add(lblperimetro);
            Controls.Add(txtres1);
            Controls.Add(label4);
            Controls.Add(txtc);
            Controls.Add(label1);
            Controls.Add(txtb);
            Controls.Add(lblnum2);
            Controls.Add(txta);
            Controls.Add(lbla);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtres2;
        private Label lblperimetro;
        private TextBox txtres1;
        private Label label4;
        private TextBox txtb;
        private Label lblnum2;
        private TextBox txta;
        private Label lbla;
        private Label label1;
        private TextBox txtc;
    }
}