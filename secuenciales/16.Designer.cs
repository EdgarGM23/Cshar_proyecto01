namespace proyecto01.secuenciales
{
    partial class _16
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
            txttarifa = new TextBox();
            lbltarifa = new Label();
            txthoras = new TextBox();
            lblhoras = new Label();
            txtresultado = new RichTextBox();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(98, 258);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txttarifa
            // 
            txttarifa.Location = new Point(118, 66);
            txttarifa.Name = "txttarifa";
            txttarifa.Size = new Size(80, 23);
            txttarifa.TabIndex = 2;
            txttarifa.TextAlign = HorizontalAlignment.Right;
            // 
            // lbltarifa
            // 
            lbltarifa.AutoSize = true;
            lbltarifa.Location = new Point(44, 69);
            lbltarifa.Name = "lbltarifa";
            lbltarifa.Size = new Size(38, 15);
            lbltarifa.TabIndex = 64;
            lbltarifa.Text = "Tarifa:";
            // 
            // txthoras
            // 
            txthoras.Location = new Point(118, 37);
            txthoras.Name = "txthoras";
            txthoras.Size = new Size(80, 23);
            txthoras.TabIndex = 1;
            txthoras.TextAlign = HorizontalAlignment.Right;
            // 
            // lblhoras
            // 
            lblhoras.AutoSize = true;
            lblhoras.Location = new Point(44, 40);
            lblhoras.Name = "lblhoras";
            lblhoras.Size = new Size(41, 15);
            lblhoras.TabIndex = 65;
            lblhoras.Text = "Horas:";
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(12, 111);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 141);
            txtresultado.TabIndex = 66;
            txtresultado.Text = "";
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 301);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txttarifa);
            Controls.Add(lbltarifa);
            Controls.Add(txthoras);
            Controls.Add(lblhoras);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txttarifa;
        private Label lbltarifa;
        private TextBox txthoras;
        private Label lblhoras;
        private RichTextBox txtresultado;
    }
}