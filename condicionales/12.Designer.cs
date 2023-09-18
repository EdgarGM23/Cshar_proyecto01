namespace appFP_CSharp.condicionales
{
    partial class _12
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(47, 27);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(54, 15);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Numero:";
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(47, 61);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(27, 15);
            this.lbldia.TabIndex = 0;
            this.lbldia.Text = "Dia:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(109, 24);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(73, 23);
            this.txtnumero.TabIndex = 1;
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(109, 58);
            this.txtdia.Name = "txtdia";
            this.txtdia.ReadOnly = true;
            this.txtdia.Size = new System.Drawing.Size(73, 23);
            this.txtdia.TabIndex = 0;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(74, 110);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(82, 29);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // _12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.lblnumero);
            this.Name = "_12";
            this.Text = "_12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblnumero;
        private Label lbldia;
        private TextBox txtnumero;
        private TextBox txtdia;
        private Button btncalcular;
    }
}