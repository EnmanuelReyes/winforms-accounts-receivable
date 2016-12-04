namespace CuentasPorCobrar
{
    partial class FrmBusquedaTransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaTransaccion));
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmdImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(12, 22);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(362, 20);
            this.TxtBuscar.TabIndex = 0;
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.Image = ((System.Drawing.Image)(resources.GetObject("CmdBuscar.Image")));
            this.CmdBuscar.Location = new System.Drawing.Point(396, 12);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(75, 47);
            this.CmdBuscar.TabIndex = 1;
            this.CmdBuscar.UseVisualStyleBackColor = true;
            this.CmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(785, 216);
            this.dataGridView1.TabIndex = 2;
            // 
            // CmdImprimir
            // 
            this.CmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("CmdImprimir.Image")));
            this.CmdImprimir.Location = new System.Drawing.Point(514, 12);
            this.CmdImprimir.Name = "CmdImprimir";
            this.CmdImprimir.Size = new System.Drawing.Size(75, 47);
            this.CmdImprimir.TabIndex = 3;
            this.CmdImprimir.UseVisualStyleBackColor = true;
            this.CmdImprimir.Click += new System.EventHandler(this.CmdImprimir_Click);
            // 
            // FrmBusquedaTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 293);
            this.Controls.Add(this.CmdImprimir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Name = "FrmBusquedaTransaccion";
            this.Text = "FrmBusquedaTransaccion";
            this.Load += new System.EventHandler(this.FrmBusquedaTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CmdImprimir;
    }
}