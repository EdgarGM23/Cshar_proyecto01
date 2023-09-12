namespace proyecto01.secuenciales
{
    partial class _04
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
            txtpulgadas = new TextBox();
            lblpulgadas = new Label();
            txtpies = new TextBox();
            lblpies = new Label();
            txtmetros = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(88, 200);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 17;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtpulgadas
            // 
            txtpulgadas.Location = new Point(123, 61);
            txtpulgadas.Name = "txtpulgadas";
            txtpulgadas.Size = new Size(80, 23);
            txtpulgadas.TabIndex = 15;
            txtpulgadas.TextAlign = HorizontalAlignment.Right;
            // 
            // lblpulgadas
            // 
            lblpulgadas.AutoSize = true;
            lblpulgadas.Location = new Point(49, 64);
            lblpulgadas.Name = "lblpulgadas";
            lblpulgadas.Size = new Size(55, 15);
            lblpulgadas.TabIndex = 13;
            lblpulgadas.Text = "Pulgadas";
            // 
            // txtpies
            // 
            txtpies.Location = new Point(123, 32);
            txtpies.Name = "txtpies";
            txtpies.Size = new Size(80, 23);
            txtpies.TabIndex = 16;
            txtpies.TextAlign = HorizontalAlignment.Right;
            // 
            // lblpies
            // 
            lblpies.AutoSize = true;
            lblpies.Location = new Point(49, 35);
            lblpies.Name = "lblpies";
            lblpies.Size = new Size(28, 15);
            lblpies.TabIndex = 14;
            lblpies.Text = "Pies";
            // 
            // txtmetros
            // 
            txtmetros.Location = new Point(83, 146);
            txtmetros.Name = "txtmetros";
            txtmetros.ReadOnly = true;
            txtmetros.Size = new Size(80, 23);
            txtmetros.TabIndex = 19;
            txtmetros.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 128);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 18;
            label4.Text = "Metros";
            label4.Click += label4_Click;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 251);
            Controls.Add(txtmetros);
            Controls.Add(label4);
            Controls.Add(btncalcular);
            Controls.Add(txtpulgadas);
            Controls.Add(lblpulgadas);
            Controls.Add(txtpies);
            Controls.Add(lblpies);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtpulgadas;
        private Label lblpulgadas;
        private TextBox txtpies;
        private Label lblpies;
        private TextBox txtmetros;
        private Label label4;
    }
}