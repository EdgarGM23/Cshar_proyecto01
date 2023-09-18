namespace proyecto01.condicionales
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
            btncalcular = new Button();
            txtresultado = new TextBox();
            label1 = new Label();
            txtnumero = new TextBox();
            lblnum = new Label();
            txtresultado2 = new TextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(78, 170);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 121;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(103, 81);
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(103, 23);
            txtresultado.TabIndex = 122;
            txtresultado.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 84);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 123;
            label1.Text = "Resultado:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(103, 27);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 120;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(29, 30);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(54, 15);
            lblnum.TabIndex = 124;
            lblnum.Text = "Numero:";
            // 
            // txtresultado2
            // 
            txtresultado2.Location = new Point(103, 110);
            txtresultado2.Name = "txtresultado2";
            txtresultado2.ReadOnly = true;
            txtresultado2.Size = new Size(80, 23);
            txtresultado2.TabIndex = 122;
            txtresultado2.TextAlign = HorizontalAlignment.Right;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 210);
            Controls.Add(btncalcular);
            Controls.Add(txtresultado2);
            Controls.Add(txtresultado);
            Controls.Add(label1);
            Controls.Add(txtnumero);
            Controls.Add(lblnum);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtresultado;
        private Label label1;
        private TextBox txtnumero;
        private Label lblnum;
        private TextBox txtresultado2;
    }
}