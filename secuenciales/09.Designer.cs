namespace proyecto01.secuenciales
{
    partial class _09
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
            txtsuma = new TextBox();
            label4 = new Label();
            txtnumero = new TextBox();
            lblaltura = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(53, 139);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 55;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtsuma
            // 
            txtsuma.Location = new Point(99, 85);
            txtsuma.Name = "txtsuma";
            txtsuma.ReadOnly = true;
            txtsuma.Size = new Size(80, 23);
            txtsuma.TabIndex = 54;
            txtsuma.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 87);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 53;
            label4.Text = "Suma:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(99, 12);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 52;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(25, 15);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(54, 15);
            lblaltura.TabIndex = 51;
            lblaltura.Text = "Numero:";
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 196);
            Controls.Add(btncalcular);
            Controls.Add(txtsuma);
            Controls.Add(label4);
            Controls.Add(txtnumero);
            Controls.Add(lblaltura);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtsuma;
        private Label label4;
        private TextBox txtnumero;
        private Label lblaltura;
    }
}