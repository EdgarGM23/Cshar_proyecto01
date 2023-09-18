namespace proyecto01.condicionales
{
    partial class _05
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
            lvlresultado = new Label();
            txtnumero = new TextBox();
            lblnumero = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(58, 133);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(100, 87);
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(80, 23);
            txtresultado.TabIndex = 10;
            txtresultado.TextAlign = HorizontalAlignment.Right;
            txtresultado.TextChanged += txtpractica2_TextChanged;
            // 
            // lvlresultado
            // 
            lvlresultado.AutoSize = true;
            lvlresultado.Location = new Point(26, 90);
            lvlresultado.Name = "lvlresultado";
            lvlresultado.Size = new Size(62, 15);
            lvlresultado.TabIndex = 95;
            lvlresultado.Text = "Resultado:";
            lvlresultado.Click += label1_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(100, 25);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 1;
            txtnumero.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(26, 28);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(54, 15);
            lblnumero.TabIndex = 96;
            lblnumero.Text = "Numero:";
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 177);
            Controls.Add(btncalcular);
            Controls.Add(txtresultado);
            Controls.Add(lvlresultado);
            Controls.Add(txtnumero);
            Controls.Add(lblnumero);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtresultado;
        private Label lvlresultado;
        private TextBox txtnumero;
        private Label lblnumero;
    }
}