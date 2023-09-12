namespace proyecto01.secuenciales
{
    partial class _02
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
            txtcentimetros = new TextBox();
            label3 = new Label();
            txtmetros = new TextBox();
            lblmetros = new Label();
            btncalcular = new Button();
            label1 = new Label();
            txtpulgadas = new TextBox();
            label2 = new Label();
            txtpies = new TextBox();
            label4 = new Label();
            txtyardas = new TextBox();
            SuspendLayout();
            // 
            // txtcentimetros
            // 
            txtcentimetros.Location = new Point(117, 70);
            txtcentimetros.Name = "txtcentimetros";
            txtcentimetros.ReadOnly = true;
            txtcentimetros.Size = new Size(80, 23);
            txtcentimetros.TabIndex = 6;
            txtcentimetros.TextAlign = HorizontalAlignment.Right;
            txtcentimetros.TextChanged += txtMujeres_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 73);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Centimetros";
            label3.Click += label3_Click;
            // 
            // txtmetros
            // 
            txtmetros.Location = new Point(117, 41);
            txtmetros.Name = "txtmetros";
            txtmetros.Size = new Size(80, 23);
            txtmetros.TabIndex = 7;
            txtmetros.TextAlign = HorizontalAlignment.Right;
            txtmetros.TextChanged += txtVarones_TextChanged;
            // 
            // lblmetros
            // 
            lblmetros.AutoSize = true;
            lblmetros.Location = new Point(43, 44);
            lblmetros.Name = "lblmetros";
            lblmetros.Size = new Size(44, 15);
            lblmetros.TabIndex = 5;
            lblmetros.Text = "Metros";
            lblmetros.Click += lblvarones_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(80, 213);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 105);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Pulgadas";
            label1.Click += label1_Click;
            // 
            // txtpulgadas
            // 
            txtpulgadas.Location = new Point(117, 102);
            txtpulgadas.Name = "txtpulgadas";
            txtpulgadas.ReadOnly = true;
            txtpulgadas.Size = new Size(80, 23);
            txtpulgadas.TabIndex = 7;
            txtpulgadas.TextAlign = HorizontalAlignment.Right;
            txtpulgadas.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 134);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Pies";
            label2.Click += label2_Click;
            // 
            // txtpies
            // 
            txtpies.Location = new Point(117, 131);
            txtpies.Name = "txtpies";
            txtpies.ReadOnly = true;
            txtpies.Size = new Size(80, 23);
            txtpies.TabIndex = 6;
            txtpies.TextAlign = HorizontalAlignment.Right;
            txtpies.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 164);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "Yardas";
            label4.Click += label4_Click;
            // 
            // txtyardas
            // 
            txtyardas.Location = new Point(117, 161);
            txtyardas.Name = "txtyardas";
            txtyardas.ReadOnly = true;
            txtyardas.Size = new Size(80, 23);
            txtyardas.TabIndex = 7;
            txtyardas.TextAlign = HorizontalAlignment.Right;
            txtyardas.TextChanged += textBox3_TextChanged;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 272);
            Controls.Add(txtpies);
            Controls.Add(label2);
            Controls.Add(txtyardas);
            Controls.Add(txtcentimetros);
            Controls.Add(txtpulgadas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtmetros);
            Controls.Add(lblmetros);
            Controls.Add(btncalcular);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcentimetros;
        private Label label3;
        private TextBox txtmetros;
        private Label lblmetros;
        private Button btncalcular;
        private Label label1;
        private TextBox txtpulgadas;
        private Label label2;
        private TextBox txtpies;
        private Label label4;
        private TextBox txtyardas;
    }
}