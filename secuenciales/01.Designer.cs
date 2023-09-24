namespace proyecto01.secuenciales
{
    partial class _01
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
            lblvarones = new Label();
            txtVarones = new TextBox();
            lblPVarones = new Label();
            label3 = new Label();
            txtMujeres = new TextBox();
            lblPMujeres = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(105, 142);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lblvarones
            // 
            lblvarones.AutoSize = true;
            lblvarones.Location = new Point(54, 46);
            lblvarones.Name = "lblvarones";
            lblvarones.Size = new Size(48, 15);
            lblvarones.TabIndex = 1;
            lblvarones.Text = "Varones";
            // 
            // txtVarones
            // 
            txtVarones.Location = new Point(117, 43);
            txtVarones.Name = "txtVarones";
            txtVarones.Size = new Size(80, 23);
            txtVarones.TabIndex = 1;
            txtVarones.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPVarones
            // 
            lblPVarones.AutoSize = true;
            lblPVarones.Location = new Point(203, 51);
            lblPVarones.Name = "lblPVarones";
            lblPVarones.Size = new Size(17, 15);
            lblPVarones.TabIndex = 3;
            lblPVarones.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 75);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Mujeres";
            // 
            // txtMujeres
            // 
            txtMujeres.Location = new Point(117, 72);
            txtMujeres.Name = "txtMujeres";
            txtMujeres.Size = new Size(80, 23);
            txtMujeres.TabIndex = 2;
            txtMujeres.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPMujeres
            // 
            lblPMujeres.AutoSize = true;
            lblPMujeres.Location = new Point(203, 80);
            lblPMujeres.Name = "lblPMujeres";
            lblPMujeres.Size = new Size(17, 15);
            lblPMujeres.TabIndex = 3;
            lblPMujeres.Text = "%";
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 184);
            Controls.Add(lblPMujeres);
            Controls.Add(lblPVarones);
            Controls.Add(txtMujeres);
            Controls.Add(label3);
            Controls.Add(txtVarones);
            Controls.Add(lblvarones);
            Controls.Add(btncalcular);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Label lblvarones;
        private TextBox txtVarones;
        private Label lblPVarones;
        private Label label3;
        private TextBox txtMujeres;
        private Label lblPMujeres;
    }
}