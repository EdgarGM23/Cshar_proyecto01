namespace proyecto01.condicionales
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
            txtresultado = new RichTextBox();
            btncalcular = new Button();
            txtexamen3 = new TextBox();
            label2 = new Label();
            txtexamen2 = new TextBox();
            label1 = new Label();
            txtexamen1 = new TextBox();
            lblexa1 = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(21, 122);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 171);
            txtresultado.TabIndex = 108;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(100, 309);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 104;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtexamen3
            // 
            txtexamen3.Location = new Point(123, 80);
            txtexamen3.Name = "txtexamen3";
            txtexamen3.Size = new Size(80, 23);
            txtexamen3.TabIndex = 103;
            txtexamen3.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 83);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 105;
            label2.Text = "Examen 3:";
            // 
            // txtexamen2
            // 
            txtexamen2.Location = new Point(123, 51);
            txtexamen2.Name = "txtexamen2";
            txtexamen2.Size = new Size(80, 23);
            txtexamen2.TabIndex = 102;
            txtexamen2.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 54);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 106;
            label1.Text = "Examen 2:";
            // 
            // txtexamen1
            // 
            txtexamen1.Location = new Point(123, 22);
            txtexamen1.Name = "txtexamen1";
            txtexamen1.Size = new Size(80, 23);
            txtexamen1.TabIndex = 101;
            txtexamen1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblexa1
            // 
            lblexa1.AutoSize = true;
            lblexa1.Location = new Point(49, 25);
            lblexa1.Name = "lblexa1";
            lblexa1.Size = new Size(61, 15);
            lblexa1.TabIndex = 107;
            lblexa1.Text = "Examen 1:";
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 350);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtexamen3);
            Controls.Add(label2);
            Controls.Add(txtexamen2);
            Controls.Add(label1);
            Controls.Add(txtexamen1);
            Controls.Add(lblexa1);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtexamen3;
        private Label label2;
        private TextBox txtexamen2;
        private Label label1;
        private TextBox txtexamen1;
        private Label lblexa1;
    }
}