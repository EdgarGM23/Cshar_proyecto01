namespace proyecto01.condicionales
{
    partial class _15
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
            txtimporte = new TextBox();
            txtimport = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(22, 58);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 171);
            txtresultado.TabIndex = 118;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(101, 245);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 116;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtimporte
            // 
            txtimporte.Location = new Point(127, 12);
            txtimporte.Name = "txtimporte";
            txtimporte.Size = new Size(80, 23);
            txtimporte.TabIndex = 115;
            txtimporte.TextAlign = HorizontalAlignment.Right;
            // 
            // txtimport
            // 
            txtimport.AutoSize = true;
            txtimport.Location = new Point(53, 15);
            txtimport.Name = "txtimport";
            txtimport.Size = new Size(52, 15);
            txtimport.TabIndex = 117;
            txtimport.Text = "Importe:";
            // 
            // _15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 285);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtimporte);
            Controls.Add(txtimport);
            Name = "_15";
            Text = "_15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtimporte;
        private Label txtimport;
    }
}