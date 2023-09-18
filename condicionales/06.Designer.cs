namespace proyecto01.condicionales
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
            txtresultado = new RichTextBox();
            btncalcular = new Button();
            txtedad3 = new TextBox();
            label2 = new Label();
            txtedad2 = new TextBox();
            label1 = new Label();
            txtedad1 = new TextBox();
            lbledad = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(21, 122);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 171);
            txtresultado.TabIndex = 100;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(100, 309);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtedad3
            // 
            txtedad3.Location = new Point(123, 80);
            txtedad3.Name = "txtedad3";
            txtedad3.Size = new Size(80, 23);
            txtedad3.TabIndex = 3;
            txtedad3.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 83);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 97;
            label2.Text = "Edad 3:";
            // 
            // txtedad2
            // 
            txtedad2.Location = new Point(123, 51);
            txtedad2.Name = "txtedad2";
            txtedad2.Size = new Size(80, 23);
            txtedad2.TabIndex = 2;
            txtedad2.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 54);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 98;
            label1.Text = "Edad 2:";
            // 
            // txtedad1
            // 
            txtedad1.Location = new Point(123, 22);
            txtedad1.Name = "txtedad1";
            txtedad1.Size = new Size(80, 23);
            txtedad1.TabIndex = 1;
            txtedad1.TextAlign = HorizontalAlignment.Right;
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(49, 25);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(45, 15);
            lbledad.TabIndex = 99;
            lbledad.Text = "Edad 1:";
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 349);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtedad3);
            Controls.Add(label2);
            Controls.Add(txtedad2);
            Controls.Add(label1);
            Controls.Add(txtedad1);
            Controls.Add(lbledad);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtedad3;
        private Label label2;
        private TextBox txtedad2;
        private Label label1;
        private TextBox txtedad1;
        private Label lbledad;
    }
}