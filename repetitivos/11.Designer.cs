namespace proyecto01.repetitivos
{
    partial class _11
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
            txtcumple = new TextBox();
            lblcum = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(12, 12);
            txtres.Name = "txtres";
            txtres.Size = new Size(191, 337);
            txtres.TabIndex = 196;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(71, 393);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 194;
            btncalcular.Text = "Mostrar";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtcumple
            // 
            txtcumple.Location = new Point(104, 355);
            txtcumple.Name = "txtcumple";
            txtcumple.ReadOnly = true;
            txtcumple.Size = new Size(80, 23);
            txtcumple.TabIndex = 193;
            txtcumple.TextAlign = HorizontalAlignment.Right;
            // 
            // lblcum
            // 
            lblcum.AutoSize = true;
            lblcum.Location = new Point(30, 358);
            lblcum.Name = "lblcum";
            lblcum.Size = new Size(59, 15);
            lblcum.TabIndex = 195;
            lblcum.Text = "Complen:";
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 428);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtcumple);
            Controls.Add(lblcum);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtcumple;
        private Label lblcum;
    }
}