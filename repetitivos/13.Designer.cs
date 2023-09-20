namespace proyecto01.repetitivos
{
    partial class _13
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
            txtnum = new TextBox();
            lblnum = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(13, 52);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 192;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(92, 239);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 190;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(148, 12);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(80, 23);
            txtnum.TabIndex = 189;
            txtnum.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(74, 15);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(54, 15);
            lblnum.TabIndex = 191;
            lblnum.Text = "Numero:";
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 274);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtnum);
            Controls.Add(lblnum);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtnum;
        private Label lblnum;
    }
}