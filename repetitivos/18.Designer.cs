namespace proyecto01.repetitivos
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
            txttexto = new TextBox();
            lbltexto = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(16, 52);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 204;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(95, 239);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 202;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txttexto
            // 
            txttexto.Location = new Point(151, 12);
            txttexto.Name = "txttexto";
            txttexto.Size = new Size(80, 23);
            txttexto.TabIndex = 201;
            txttexto.TextAlign = HorizontalAlignment.Right;
            // 
            // lbltexto
            // 
            lbltexto.AutoSize = true;
            lbltexto.Location = new Point(77, 15);
            lbltexto.Name = "lbltexto";
            lbltexto.Size = new Size(38, 15);
            lbltexto.TabIndex = 203;
            lbltexto.Text = "Texto:";
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 280);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txttexto);
            Controls.Add(lbltexto);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txttexto;
        private Label lbltexto;
    }
}