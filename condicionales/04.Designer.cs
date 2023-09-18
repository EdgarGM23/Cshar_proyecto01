namespace proyecto01.condicionales
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
            txtresultado = new RichTextBox();
            btncalcular = new Button();
            txtpractica1 = new TextBox();
            lblpractica = new Label();
            label1 = new Label();
            txtpractica2 = new TextBox();
            label2 = new Label();
            txtpractica3 = new TextBox();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(31, 112);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 171);
            txtresultado.TabIndex = 92;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(110, 299);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtpractica1
            // 
            txtpractica1.Location = new Point(133, 12);
            txtpractica1.Name = "txtpractica1";
            txtpractica1.Size = new Size(80, 23);
            txtpractica1.TabIndex = 1;
            txtpractica1.TextAlign = HorizontalAlignment.Right;
            txtpractica1.TextChanged += txtcantidad_TextChanged;
            // 
            // lblpractica
            // 
            lblpractica.AutoSize = true;
            lblpractica.Location = new Point(59, 15);
            lblpractica.Name = "lblpractica";
            lblpractica.Size = new Size(61, 15);
            lblpractica.TabIndex = 91;
            lblpractica.Text = "Practica 1:";
            lblpractica.Click += lblcantidad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 91;
            label1.Text = "Practica 2:";
            label1.Click += lblcantidad_Click;
            // 
            // txtpractica2
            // 
            txtpractica2.Location = new Point(133, 41);
            txtpractica2.Name = "txtpractica2";
            txtpractica2.Size = new Size(80, 23);
            txtpractica2.TabIndex = 2;
            txtpractica2.TextAlign = HorizontalAlignment.Right;
            txtpractica2.TextChanged += txtcantidad_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 73);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 91;
            label2.Text = "Practica 3:";
            label2.Click += lblcantidad_Click;
            // 
            // txtpractica3
            // 
            txtpractica3.Location = new Point(133, 70);
            txtpractica3.Name = "txtpractica3";
            txtpractica3.Size = new Size(80, 23);
            txtpractica3.TabIndex = 3;
            txtpractica3.TextAlign = HorizontalAlignment.Right;
            txtpractica3.TextChanged += txtcantidad_TextChanged;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 349);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtpractica3);
            Controls.Add(label2);
            Controls.Add(txtpractica2);
            Controls.Add(label1);
            Controls.Add(txtpractica1);
            Controls.Add(lblpractica);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtpractica1;
        private Label lblpractica;
        private Label label1;
        private TextBox txtpractica2;
        private Label label2;
        private TextBox txtpractica3;
    }
}