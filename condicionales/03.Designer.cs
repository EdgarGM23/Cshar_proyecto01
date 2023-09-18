namespace proyecto01.condicionales
{
    partial class _03
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
            txtangulo = new TextBox();
            lblangulo = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(23, 70);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 171);
            txtresultado.TabIndex = 92;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(109, 247);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtangulo
            // 
            txtangulo.Location = new Point(129, 26);
            txtangulo.Name = "txtangulo";
            txtangulo.Size = new Size(80, 23);
            txtangulo.TabIndex = 1;
            txtangulo.TextAlign = HorizontalAlignment.Right;
            // 
            // lblangulo
            // 
            lblangulo.AutoSize = true;
            lblangulo.Location = new Point(55, 29);
            lblangulo.Name = "lblangulo";
            lblangulo.Size = new Size(49, 15);
            lblangulo.TabIndex = 91;
            lblangulo.Text = "Angulo:";
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 288);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtangulo);
            Controls.Add(lblangulo);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtangulo;
        private Label lblangulo;
    }
}