namespace proyecto01.condicionales
{
    partial class _30
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
            txtdia = new TextBox();
            label1 = new Label();
            txtcuota = new TextBox();
            lblhora = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(13, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 164;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(92, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 161;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtdia
            // 
            txtdia.Location = new Point(130, 41);
            txtdia.Name = "txtdia";
            txtdia.Size = new Size(80, 23);
            txtdia.TabIndex = 160;
            txtdia.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 44);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 162;
            label1.Text = "Dia:";
            // 
            // txtcuota
            // 
            txtcuota.Location = new Point(130, 12);
            txtcuota.Name = "txtcuota";
            txtcuota.Size = new Size(80, 23);
            txtcuota.TabIndex = 159;
            txtcuota.TextAlign = HorizontalAlignment.Right;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(56, 15);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(42, 15);
            lblhora.TabIndex = 163;
            lblhora.Text = "Cuota:";
            // 
            // _30
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 295);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtdia);
            Controls.Add(label1);
            Controls.Add(txtcuota);
            Controls.Add(lblhora);
            Name = "_30";
            Text = "_30";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtdia;
        private Label label1;
        private TextBox txtcuota;
        private Label lblhora;
    }
}