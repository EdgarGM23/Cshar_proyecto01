namespace proyecto01.secuenciales
{
    partial class _04
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
            txtmillas = new TextBox();
            lblmillas = new Label();
            txtpies = new TextBox();
            lblpies = new Label();
            txtmetrosTotales = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(88, 200);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 17;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // txtmillas
            // 
            txtmillas.Location = new Point(123, 61);
            txtmillas.Name = "txtmillas";
            txtmillas.Size = new Size(80, 23);
            txtmillas.TabIndex = 15;
            txtmillas.TextAlign = HorizontalAlignment.Right;
            // 
            // lblmillas
            // 
            lblmillas.AutoSize = true;
            lblmillas.Location = new Point(49, 64);
            lblmillas.Name = "lblmillas";
            lblmillas.Size = new Size(38, 15);
            lblmillas.TabIndex = 13;
            lblmillas.Text = "Millas";
            // 
            // txtpies
            // 
            txtpies.Location = new Point(123, 32);
            txtpies.Name = "txtpies";
            txtpies.Size = new Size(80, 23);
            txtpies.TabIndex = 16;
            txtpies.TextAlign = HorizontalAlignment.Right;
            // 
            // lblpies
            // 
            lblpies.AutoSize = true;
            lblpies.Location = new Point(49, 35);
            lblpies.Name = "lblpies";
            lblpies.Size = new Size(28, 15);
            lblpies.TabIndex = 14;
            lblpies.Text = "Pies";
            // 
            // txtmetrosTotales
            // 
            txtmetrosTotales.Location = new Point(83, 146);
            txtmetrosTotales.Name = "txtmetrosTotales";
            txtmetrosTotales.ReadOnly = true;
            txtmetrosTotales.Size = new Size(80, 23);
            txtmetrosTotales.TabIndex = 19;
            txtmetrosTotales.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 128);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 18;
            label4.Text = "Metros";
            label4.Click += label4_Click;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 251);
            Controls.Add(txtmetrosTotales);
            Controls.Add(label4);
            Controls.Add(btncalcular);
            Controls.Add(txtmillas);
            Controls.Add(lblmillas);
            Controls.Add(txtpies);
            Controls.Add(lblpies);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtmillas;
        private Label lblmillas;
        private TextBox txtpies;
        private Label lblpies;
        private TextBox txtmetrosTotales;
        private Label label4;
    }
}