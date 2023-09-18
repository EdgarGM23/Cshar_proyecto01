namespace proyecto01.secuenciales
{
    partial class _17
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
            txtmonto = new TextBox();
            lblmonto = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(25, 89);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 141);
            txtresultado.TabIndex = 70;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(113, 252);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtmonto
            // 
            txtmonto.Location = new Point(133, 31);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(80, 23);
            txtmonto.TabIndex = 1;
            txtmonto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Location = new Point(59, 34);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(46, 15);
            lblmonto.TabIndex = 69;
            lblmonto.Text = "Monto:";
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 313);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtmonto);
            Controls.Add(lblmonto);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtmonto;
        private Label lblmonto;
    }
}