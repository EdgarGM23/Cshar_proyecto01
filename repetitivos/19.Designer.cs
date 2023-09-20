namespace proyecto01.repetitivos
{
    partial class _19
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
            btngenerar = new Button();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 12);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 206;
            txtres.Text = "";
            // 
            // btngenerar
            // 
            btngenerar.Location = new Point(91, 199);
            btngenerar.Name = "btngenerar";
            btngenerar.Size = new Size(79, 28);
            btngenerar.TabIndex = 205;
            btngenerar.Text = "Generar";
            btngenerar.UseVisualStyleBackColor = true;
            btngenerar.Click += btngenerar_Click;
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 239);
            Controls.Add(txtres);
            Controls.Add(btngenerar);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtres;
        private Button btngenerar;
    }
}