namespace proyecto01.condicionales
{
    partial class _29
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
            txthoras = new TextBox();
            lblhora = new Label();
            label1 = new Label();
            txttarifa = new TextBox();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(21, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 158;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(100, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txthoras
            // 
            txthoras.Location = new Point(138, 12);
            txthoras.Name = "txthoras";
            txthoras.Size = new Size(80, 23);
            txthoras.TabIndex = 1;
            txthoras.TextAlign = HorizontalAlignment.Right;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(64, 15);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(36, 15);
            lblhora.TabIndex = 157;
            lblhora.Text = "Hora:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 157;
            label1.Text = "Tarifa:";
            // 
            // txttarifa
            // 
            txttarifa.Location = new Point(138, 41);
            txttarifa.Name = "txttarifa";
            txttarifa.Size = new Size(80, 23);
            txttarifa.TabIndex = 2;
            txttarifa.TextAlign = HorizontalAlignment.Right;
            // 
            // _29
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 294);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txttarifa);
            Controls.Add(label1);
            Controls.Add(txthoras);
            Controls.Add(lblhora);
            Name = "_29";
            Text = "_29";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txthoras;
        private Label lblhora;
        private Label label1;
        private TextBox txttarifa;
    }
}