namespace proyecto01.condicionales
{
    partial class _18
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
            txtdonacion = new TextBox();
            txtimport = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(22, 63);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 132;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(101, 250);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 130;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtdonacion
            // 
            txtdonacion.Location = new Point(137, 21);
            txtdonacion.Name = "txtdonacion";
            txtdonacion.Size = new Size(80, 23);
            txtdonacion.TabIndex = 129;
            txtdonacion.TextAlign = HorizontalAlignment.Right;
            // 
            // txtimport
            // 
            txtimport.AutoSize = true;
            txtimport.Location = new Point(63, 24);
            txtimport.Name = "txtimport";
            txtimport.Size = new Size(61, 15);
            txtimport.TabIndex = 131;
            txtimport.Text = "Donacion:";
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 288);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtdonacion);
            Controls.Add(txtimport);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtdonacion;
        private Label txtimport;
    }
}