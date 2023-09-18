namespace proyecto01.condicionales
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
            txtresultado = new RichTextBox();
            btncalcular = new Button();
            txtcantidad = new TextBox();
            lblcantidad = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(20, 70);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 171);
            txtresultado.TabIndex = 88;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(106, 247);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 86;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(126, 26);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(80, 23);
            txtcantidad.TabIndex = 85;
            txtcantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(52, 29);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(58, 15);
            lblcantidad.TabIndex = 87;
            lblcantidad.Text = "Cantidad:";
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 293);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtcantidad);
            Controls.Add(lblcantidad);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtcantidad;
        private Label lblcantidad;
    }
}