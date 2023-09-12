namespace proyecto01.secuenciales
{
    partial class _10
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
            btncalcular = new Button();
            txtreverso = new TextBox();
            label4 = new Label();
            txtnumero = new TextBox();
            lblaltura = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(56, 139);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 50;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtreverso
            // 
            txtreverso.Location = new Point(102, 85);
            txtreverso.Name = "txtreverso";
            txtreverso.ReadOnly = true;
            txtreverso.Size = new Size(80, 23);
            txtreverso.TabIndex = 49;
            txtreverso.TextAlign = HorizontalAlignment.Right;
            txtreverso.TextChanged += txtareabase_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 87);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 48;
            label4.Text = "Reverso:";
            label4.Click += label4_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(102, 12);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 47;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(28, 15);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(54, 15);
            lblaltura.TabIndex = 46;
            lblaltura.Text = "Numero:";
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 191);
            Controls.Add(btncalcular);
            Controls.Add(txtreverso);
            Controls.Add(label4);
            Controls.Add(txtnumero);
            Controls.Add(lblaltura);
            Name = "_10";
            Text = "_10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtreverso;
        private Label label4;
        private TextBox txtnumero;
        private Label lblaltura;
    }
}