namespace proyecto01.condicionales
{
    partial class _36
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
            txtcuaderno = new TextBox();
            lblcuadernos = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(17, 70);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 170;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(96, 257);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 167;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtcuaderno
            // 
            txtcuaderno.Location = new Point(133, 26);
            txtcuaderno.Name = "txtcuaderno";
            txtcuaderno.Size = new Size(80, 23);
            txtcuaderno.TabIndex = 165;
            txtcuaderno.TextAlign = HorizontalAlignment.Right;
            // 
            // lblcuadernos
            // 
            lblcuadernos.AutoSize = true;
            lblcuadernos.Location = new Point(59, 29);
            lblcuadernos.Name = "lblcuadernos";
            lblcuadernos.Size = new Size(67, 15);
            lblcuadernos.TabIndex = 169;
            lblcuadernos.Text = "Cuadernos:";
            // 
            // _36
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 296);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtcuaderno);
            Controls.Add(lblcuadernos);
            Name = "_36";
            Text = "_36";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtcuaderno;
        private Label lblcuadernos;
    }
}