namespace proyecto01.secuenciales
{
    partial class _15
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
            txtdolars = new TextBox();
            label4 = new Label();
            txtdaniel = new TextBox();
            label1 = new Label();
            txtrosa = new TextBox();
            lblrosa = new Label();
            txtjuan = new TextBox();
            lblJuan = new Label();
            lblpordaniel = new Label();
            lblporjuan = new Label();
            lblporrosa = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(85, 211);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(79, 28);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtdolars
            // 
            txtdolars.Location = new Point(103, 147);
            txtdolars.Name = "txtdolars";
            txtdolars.ReadOnly = true;
            txtdolars.Size = new Size(80, 23);
            txtdolars.TabIndex = 62;
            txtdolars.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 149);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 61;
            label4.Text = "Total dolares:";
            // 
            // txtdaniel
            // 
            txtdaniel.Location = new Point(103, 80);
            txtdaniel.Name = "txtdaniel";
            txtdaniel.Size = new Size(80, 23);
            txtdaniel.TabIndex = 3;
            txtdaniel.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 83);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 58;
            label1.Text = "Daniel:";
            // 
            // txtrosa
            // 
            txtrosa.Location = new Point(103, 51);
            txtrosa.Name = "txtrosa";
            txtrosa.Size = new Size(80, 23);
            txtrosa.TabIndex = 2;
            txtrosa.TextAlign = HorizontalAlignment.Right;
            // 
            // lblrosa
            // 
            lblrosa.AutoSize = true;
            lblrosa.Location = new Point(29, 54);
            lblrosa.Name = "lblrosa";
            lblrosa.Size = new Size(35, 15);
            lblrosa.TabIndex = 59;
            lblrosa.Text = "Rosa:";
            // 
            // txtjuan
            // 
            txtjuan.Location = new Point(103, 22);
            txtjuan.Name = "txtjuan";
            txtjuan.Size = new Size(80, 23);
            txtjuan.TabIndex = 1;
            txtjuan.TextAlign = HorizontalAlignment.Right;
            // 
            // lblJuan
            // 
            lblJuan.AutoSize = true;
            lblJuan.Location = new Point(29, 25);
            lblJuan.Name = "lblJuan";
            lblJuan.Size = new Size(34, 15);
            lblJuan.TabIndex = 60;
            lblJuan.Text = "Juan:";
            // 
            // lblpordaniel
            // 
            lblpordaniel.AutoSize = true;
            lblpordaniel.Location = new Point(189, 83);
            lblpordaniel.Name = "lblpordaniel";
            lblpordaniel.Size = new Size(16, 15);
            lblpordaniel.TabIndex = 63;
            lblpordaniel.Text = "...";
            // 
            // lblporjuan
            // 
            lblporjuan.AutoSize = true;
            lblporjuan.Location = new Point(189, 25);
            lblporjuan.Name = "lblporjuan";
            lblporjuan.Size = new Size(16, 15);
            lblporjuan.TabIndex = 65;
            lblporjuan.Text = "...";
            // 
            // lblporrosa
            // 
            lblporrosa.AutoSize = true;
            lblporrosa.Location = new Point(189, 54);
            lblporrosa.Name = "lblporrosa";
            lblporrosa.Size = new Size(16, 15);
            lblporrosa.TabIndex = 64;
            lblporrosa.Text = "...";
            lblporrosa.Click += label3_Click;
            // 
            // _15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 264);
            Controls.Add(lblpordaniel);
            Controls.Add(lblporrosa);
            Controls.Add(lblporjuan);
            Controls.Add(btncalcular);
            Controls.Add(txtdolars);
            Controls.Add(label4);
            Controls.Add(txtdaniel);
            Controls.Add(label1);
            Controls.Add(txtrosa);
            Controls.Add(lblrosa);
            Controls.Add(txtjuan);
            Controls.Add(lblJuan);
            Name = "_15";
            Text = "_15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private TextBox txtdolars;
        private Label label4;
        private TextBox txtdaniel;
        private Label label1;
        private TextBox txtrosa;
        private Label lblrosa;
        private TextBox txtjuan;
        private Label lblJuan;
        private Label lblpordaniel;
        private Label lblporjuan;
        private Label lblporrosa;
    }
}