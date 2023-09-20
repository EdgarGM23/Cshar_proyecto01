namespace proyecto01.repetitivos
{
    partial class _12
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
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 12);
            txtres.Name = "txtres";
            txtres.Size = new Size(191, 337);
            txtres.TabIndex = 194;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(66, 369);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 193;
            btncalcular.Text = "Mostrar";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 406);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
    }
}