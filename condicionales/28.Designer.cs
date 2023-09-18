namespace proyecto01.condicionales
{
    partial class _28
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
            txtres = new RichTextBox();
            btncalcular = new Button();
            txthora = new TextBox();
            lblhora = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(14, 61);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 154;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(93, 248);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txthora
            // 
            txthora.Location = new Point(136, 12);
            txthora.Name = "txthora";
            txthora.Size = new Size(80, 23);
            txthora.TabIndex = 1;
            txthora.TextAlign = HorizontalAlignment.Right;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(62, 15);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(36, 15);
            lblhora.TabIndex = 153;
            lblhora.Text = "Hora:";
            // 
            // _28
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 288);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txthora);
            Controls.Add(lblhora);
            Name = "_28";
            Text = "_28";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txthora;
        private Label lblhora;
    }
}