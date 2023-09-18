namespace proyecto01.condicionales
{
    partial class _31
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
            txtcategoria = new TextBox();
            label1 = new Label();
            txthoras = new TextBox();
            lblhora = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(16, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 170;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(95, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 167;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(133, 41);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(80, 23);
            txtcategoria.TabIndex = 166;
            txtcategoria.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 168;
            label1.Text = "Categoria:";
            // 
            // txthoras
            // 
            txthoras.Location = new Point(133, 12);
            txthoras.Name = "txthoras";
            txthoras.Size = new Size(80, 23);
            txthoras.TabIndex = 165;
            txthoras.TextAlign = HorizontalAlignment.Right;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(59, 15);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(36, 15);
            lblhora.TabIndex = 169;
            lblhora.Text = "Hora:";
            // 
            // _31
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 297);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtcategoria);
            Controls.Add(label1);
            Controls.Add(txthoras);
            Controls.Add(lblhora);
            Name = "_31";
            Text = "_31";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtcategoria;
        private Label label1;
        private TextBox txthoras;
        private Label lblhora;
    }
}