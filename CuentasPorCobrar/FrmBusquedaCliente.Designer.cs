namespace CuentasPorCobrar
{
    partial class FrmBusquedaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaCliente));
            this.TxtBuscarCliente = new System.Windows.Forms.TextBox();
            this.CmdBuscarCliente = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TxtTotalizado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Location = new System.Drawing.Point(12, 22);
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.Size = new System.Drawing.Size(362, 20);
            this.TxtBuscarCliente.TabIndex = 0;
            // 
            // CmdBuscarCliente
            // 
            this.CmdBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("CmdBuscarCliente.Image")));
            this.CmdBuscarCliente.Location = new System.Drawing.Point(396, 12);
            this.CmdBuscarCliente.Name = "CmdBuscarCliente";
            this.CmdBuscarCliente.Size = new System.Drawing.Size(75, 47);
            this.CmdBuscarCliente.TabIndex = 1;
            this.CmdBuscarCliente.UseVisualStyleBackColor = true;
            this.CmdBuscarCliente.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(785, 216);
            this.dataGridView2.TabIndex = 2;
            // 
            // TxtTotalizado
            // 
            this.TxtTotalizado.Location = new System.Drawing.Point(697, 291);
            this.TxtTotalizado.Name = "TxtTotalizado";
            this.TxtTotalizado.ReadOnly = true;
            this.TxtTotalizado.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalizado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Balance totalizado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotalizado);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CmdBuscarCliente);
            this.Controls.Add(this.TxtBuscarCliente);
            this.Name = "FrmBusquedaCliente";
            this.Text = "Busqueda Clientes";
            this.Load += new System.EventHandler(this.FrmBusquedaTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarCliente;
        private System.Windows.Forms.Button CmdBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TxtTotalizado;
        private System.Windows.Forms.Label label1;
    }
}