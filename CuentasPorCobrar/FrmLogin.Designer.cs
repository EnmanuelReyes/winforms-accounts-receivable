namespace CuentasPorCobrar
{
    partial class FrmLogin
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
            this.CmbLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbLogin
            // 
            this.CmbLogin.Location = new System.Drawing.Point(67, 141);
            this.CmbLogin.Name = "CmbLogin";
            this.CmbLogin.Size = new System.Drawing.Size(75, 23);
            this.CmbLogin.TabIndex = 0;
            this.CmbLogin.Text = "Entrar";
            this.CmbLogin.UseVisualStyleBackColor = true;
            this.CmbLogin.Click += new System.EventHandler(this.CmbLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 265);
            this.Controls.Add(this.CmbLogin);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmbLogin;
    }
}