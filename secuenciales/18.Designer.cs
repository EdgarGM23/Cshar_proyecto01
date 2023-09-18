namespace proyecto01.secuenciales
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
            txtresultado = new RichTextBox();
            btncalcular = new Button();
            txtprecio = new TextBox();
            lblprecioU = new Label();
            txtcantidad = new TextBox();
            lblcantidad = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(22, 102);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(244, 141);
            txtresultado.TabIndex = 72;
            txtresultado.Text = "";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(108, 249);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(128, 57);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(80, 23);
            txtprecio.TabIndex = 2;
            txtprecio.TextAlign = HorizontalAlignment.Right;
            // 
            // lblprecioU
            // 
            lblprecioU.AutoSize = true;
            lblprecioU.Location = new Point(54, 60);
            lblprecioU.Name = "lblprecioU";
            lblprecioU.Size = new Size(68, 15);
            lblprecioU.TabIndex = 70;
            lblprecioU.Text = "Precio Und:";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(128, 28);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(80, 23);
            txtcantidad.TabIndex = 1;
            txtcantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(54, 31);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(55, 15);
            lblcantidad.TabIndex = 71;
            lblcantidad.Text = "Cantidad";
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 303);
            Controls.Add(txtresultado);
            Controls.Add(btncalcular);
            Controls.Add(txtprecio);
            Controls.Add(lblprecioU);
            Controls.Add(txtcantidad);
            Controls.Add(lblcantidad);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtresultado;
        private Button btncalcular;
        private TextBox txtprecio;
        private Label lblprecioU;
        private TextBox txtcantidad;
        private Label lblcantidad;
    }
}