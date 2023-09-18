namespace proyecto01.condicionales
{
    partial class _39
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
            txtbuenos = new TextBox();
            label2 = new Label();
            txtmalos = new TextBox();
            label1 = new Label();
            txthoras = new TextBox();
            lblhoras = new Label();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Location = new Point(16, 99);
            txtres.Name = "txtres";
            txtres.Size = new Size(244, 171);
            txtres.TabIndex = 178;
            txtres.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(95, 286);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 174;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtbuenos
            // 
            txtbuenos.Location = new Point(141, 70);
            txtbuenos.Name = "txtbuenos";
            txtbuenos.Size = new Size(80, 23);
            txtbuenos.TabIndex = 173;
            txtbuenos.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 73);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 175;
            label2.Text = "T. Buenos:";
            // 
            // txtmalos
            // 
            txtmalos.Location = new Point(141, 41);
            txtmalos.Name = "txtmalos";
            txtmalos.Size = new Size(80, 23);
            txtmalos.TabIndex = 172;
            txtmalos.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 176;
            label1.Text = "T. Malos:";
            // 
            // txthoras
            // 
            txthoras.Location = new Point(141, 12);
            txthoras.Name = "txthoras";
            txthoras.Size = new Size(80, 23);
            txthoras.TabIndex = 171;
            txthoras.TextAlign = HorizontalAlignment.Right;
            // 
            // lblhoras
            // 
            lblhoras.AutoSize = true;
            lblhoras.Location = new Point(67, 15);
            lblhoras.Name = "lblhoras";
            lblhoras.Size = new Size(41, 15);
            lblhoras.TabIndex = 177;
            lblhoras.Text = "Horas:";
            // 
            // _39
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 321);
            Controls.Add(txtres);
            Controls.Add(btncalcular);
            Controls.Add(txtbuenos);
            Controls.Add(label2);
            Controls.Add(txtmalos);
            Controls.Add(label1);
            Controls.Add(txthoras);
            Controls.Add(lblhoras);
            Name = "_39";
            Text = "_39";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtres;
        private Button btncalcular;
        private TextBox txtbuenos;
        private Label label2;
        private TextBox txtmalos;
        private Label label1;
        private TextBox txthoras;
        private Label lblhoras;
    }
}