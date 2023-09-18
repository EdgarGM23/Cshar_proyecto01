namespace proyecto01.condicionales
{
    partial class _09
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
            txtcodigo = new TextBox();
            label1 = new Label();
            txtcantidad = new TextBox();
            txtcant = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(19, 112);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 171);
            txtresultado.TabIndex = 114;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(98, 299);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 111;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(121, 41);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(80, 23);
            txtcodigo.TabIndex = 110;
            txtcodigo.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 112;
            label1.Text = "Codigo: ";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(121, 12);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(80, 23);
            txtcantidad.TabIndex = 109;
            txtcantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtcant
            // 
            txtcant.AutoSize = true;
            txtcant.Location = new Point(47, 15);
            txtcant.Name = "txtcant";
            txtcant.Size = new Size(58, 15);
            txtcant.TabIndex = 113;
            txtcant.Text = "Cantidad:";
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 343);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtcodigo);
            Controls.Add(label1);
            Controls.Add(txtcantidad);
            Controls.Add(txtcant);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtcodigo;
        private Label label1;
        private TextBox txtcantidad;
        private Label txtcant;
    }
}