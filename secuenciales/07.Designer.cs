namespace proyecto01.secuenciales
{
    partial class _07
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
            txtperimetro = new TextBox();
            lblperimetro = new Label();
            txtarea = new TextBox();
            label4 = new Label();
            txtbase = new TextBox();
            label1 = new Label();
            txtaltura = new TextBox();
            lblaltura = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(66, 193);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 36;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtperimetro
            // 
            txtperimetro.Location = new Point(106, 139);
            txtperimetro.Name = "txtperimetro";
            txtperimetro.ReadOnly = true;
            txtperimetro.Size = new Size(80, 23);
            txtperimetro.TabIndex = 34;
            txtperimetro.TextAlign = HorizontalAlignment.Right;
            // 
            // lblperimetro
            // 
            lblperimetro.AutoSize = true;
            lblperimetro.Location = new Point(32, 141);
            lblperimetro.Name = "lblperimetro";
            lblperimetro.Size = new Size(62, 15);
            lblperimetro.TabIndex = 32;
            lblperimetro.Text = "Perimetro:";
            // 
            // txtarea
            // 
            txtarea.Location = new Point(106, 110);
            txtarea.Name = "txtarea";
            txtarea.ReadOnly = true;
            txtarea.Size = new Size(80, 23);
            txtarea.TabIndex = 35;
            txtarea.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 112);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 33;
            label4.Text = "Area:";
            // 
            // txtbase
            // 
            txtbase.Location = new Point(106, 41);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(80, 23);
            txtbase.TabIndex = 30;
            txtbase.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 28;
            label1.Text = "Base:";
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(106, 12);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(80, 23);
            txtaltura.TabIndex = 31;
            txtaltura.TextAlign = HorizontalAlignment.Right;
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(32, 15);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(42, 15);
            lblaltura.TabIndex = 29;
            lblaltura.Text = "Altura:";
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 238);
            Controls.Add(btncalcular);
            Controls.Add(txtperimetro);
            Controls.Add(lblperimetro);
            Controls.Add(txtarea);
            Controls.Add(label4);
            Controls.Add(txtbase);
            Controls.Add(label1);
            Controls.Add(txtaltura);
            Controls.Add(lblaltura);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtperimetro;
        private Label lblperimetro;
        private TextBox txtarea;
        private Label label4;
        private TextBox txtbase;
        private Label label1;
        private TextBox txtaltura;
        private Label lblaltura;
    }
}