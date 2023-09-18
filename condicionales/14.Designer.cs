namespace proyecto01.condicionales
{
    partial class _14
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
            txtnumero = new TextBox();
            label1 = new Label();
            txtimporte = new TextBox();
            lblimporte = new Label();
            label2 = new Label();
            txtdesc = new TextBox();
            label3 = new Label();
            txttotal = new TextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(69, 175);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 126;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(103, 67);
            txtnumero.Name = "txtnumero";
            txtnumero.ReadOnly = true;
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 127;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 70);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 128;
            label1.Text = "Numero:";
            // 
            // txtimporte
            // 
            txtimporte.Location = new Point(103, 12);
            txtimporte.Name = "txtimporte";
            txtimporte.Size = new Size(80, 23);
            txtimporte.TabIndex = 125;
            txtimporte.TextAlign = HorizontalAlignment.Right;
            // 
            // lblimporte
            // 
            lblimporte.AutoSize = true;
            lblimporte.Location = new Point(29, 15);
            lblimporte.Name = "lblimporte";
            lblimporte.Size = new Size(52, 15);
            lblimporte.TabIndex = 129;
            lblimporte.Text = "Importe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 99);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 128;
            label2.Text = "Descuento:";
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(103, 96);
            txtdesc.Name = "txtdesc";
            txtdesc.ReadOnly = true;
            txtdesc.Size = new Size(80, 23);
            txtdesc.TabIndex = 127;
            txtdesc.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 128);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 128;
            label3.Text = "Total:";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(103, 125);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(80, 23);
            txttotal.TabIndex = 127;
            txttotal.TextAlign = HorizontalAlignment.Right;
            // 
            // _14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 224);
            Controls.Add(btncalcular);
            Controls.Add(txttotal);
            Controls.Add(label3);
            Controls.Add(txtdesc);
            Controls.Add(label2);
            Controls.Add(txtnumero);
            Controls.Add(label1);
            Controls.Add(txtimporte);
            Controls.Add(lblimporte);
            Name = "_14";
            Text = "_14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtnumero;
        private Label label1;
        private TextBox txtimporte;
        private Label lblimporte;
        private Label label2;
        private TextBox txtdesc;
        private Label label3;
        private TextBox txttotal;
    }
}