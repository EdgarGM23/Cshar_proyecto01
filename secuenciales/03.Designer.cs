namespace proyecto01.secuenciales
{
    partial class _03
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
            txtpies = new TextBox();
            lblpies = new Label();
            kilo = new Label();
            txtkilometros = new TextBox();
            lblmillas = new Label();
            txtmillas = new TextBox();
            txtyardasTotales = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtmetrosTotales = new TextBox();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // txtpies
            // 
            txtpies.Location = new Point(153, 74);
            txtpies.Name = "txtpies";
            txtpies.Size = new Size(80, 23);
            txtpies.TabIndex = 9;
            txtpies.TextAlign = HorizontalAlignment.Right;
            // 
            // lblpies
            // 
            lblpies.AutoSize = true;
            lblpies.Location = new Point(79, 77);
            lblpies.Name = "lblpies";
            lblpies.Size = new Size(28, 15);
            lblpies.TabIndex = 8;
            lblpies.Text = "Pies";
            // 
            // kilo
            // 
            kilo.AutoSize = true;
            kilo.Location = new Point(79, 48);
            kilo.Name = "kilo";
            kilo.Size = new Size(64, 15);
            kilo.TabIndex = 8;
            kilo.Text = "Kilometros";
            // 
            // txtkilometros
            // 
            txtkilometros.Location = new Point(153, 45);
            txtkilometros.Name = "txtkilometros";
            txtkilometros.Size = new Size(80, 23);
            txtkilometros.TabIndex = 9;
            txtkilometros.TextAlign = HorizontalAlignment.Right;
            // 
            // lblmillas
            // 
            lblmillas.AutoSize = true;
            lblmillas.Location = new Point(79, 106);
            lblmillas.Name = "lblmillas";
            lblmillas.Size = new Size(38, 15);
            lblmillas.TabIndex = 8;
            lblmillas.Text = "Millas";
            // 
            // txtmillas
            // 
            txtmillas.Location = new Point(153, 103);
            txtmillas.Name = "txtmillas";
            txtmillas.Size = new Size(80, 23);
            txtmillas.TabIndex = 9;
            txtmillas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtyardasTotales
            // 
            txtyardasTotales.Location = new Point(182, 194);
            txtyardasTotales.Name = "txtyardasTotales";
            txtyardasTotales.ReadOnly = true;
            txtyardasTotales.Size = new Size(80, 23);
            txtyardasTotales.TabIndex = 11;
            txtyardasTotales.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 176);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 10;
            label3.Text = "Yardas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 176);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Metros";
            // 
            // txtmetrosTotales
            // 
            txtmetrosTotales.Location = new Point(79, 194);
            txtmetrosTotales.Name = "txtmetrosTotales";
            txtmetrosTotales.ReadOnly = true;
            txtmetrosTotales.Size = new Size(80, 23);
            txtmetrosTotales.TabIndex = 11;
            txtmetrosTotales.TextAlign = HorizontalAlignment.Right;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(130, 245);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 12;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 327);
            Controls.Add(btncalcular);
            Controls.Add(txtmetrosTotales);
            Controls.Add(label4);
            Controls.Add(txtyardasTotales);
            Controls.Add(label3);
            Controls.Add(txtkilometros);
            Controls.Add(kilo);
            Controls.Add(txtmillas);
            Controls.Add(lblmillas);
            Controls.Add(txtpies);
            Controls.Add(lblpies);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpies;
        private Label lblpies;
        private Label kilo;
        private TextBox txtkilometros;
        private Label lblmillas;
        private TextBox txtmillas;
        private TextBox txtyardasTotales;
        private Label label3;
        private Label label4;
        private TextBox txtmetrosTotales;
        private Button btncalcular;
    }
}