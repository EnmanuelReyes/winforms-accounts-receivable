namespace CuentasPorCobrar
{
    partial class FrmTipoDocumento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label cuentaContableLabel;
            System.Windows.Forms.Label idEstadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoDocumento));
            this.cuentaPorCobtrarDBDataSet = new CuentasPorCobrar.CuentaPorCobtrarDBDataSet();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDocumentoTableAdapter = new CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.TipoDocumentoTableAdapter();
            this.tableAdapterManager = new CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.TableAdapterManager();
            this.estadoTableAdapter = new CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.EstadoTableAdapter();
            this.tipoDocumentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tipoDocumentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.cuentaContableTextBox = new System.Windows.Forms.TextBox();
            this.idEstadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descripcionLabel = new System.Windows.Forms.Label();
            cuentaContableLabel = new System.Windows.Forms.Label();
            idEstadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaPorCobtrarDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingNavigator)).BeginInit();
            this.tipoDocumentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(49, 75);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion:";
            // 
            // cuentaContableLabel
            // 
            cuentaContableLabel.AutoSize = true;
            cuentaContableLabel.Location = new System.Drawing.Point(49, 101);
            cuentaContableLabel.Name = "cuentaContableLabel";
            cuentaContableLabel.Size = new System.Drawing.Size(89, 13);
            cuentaContableLabel.TabIndex = 3;
            cuentaContableLabel.Text = "Cuenta Contable:";
            // 
            // idEstadoLabel
            // 
            idEstadoLabel.AutoSize = true;
            idEstadoLabel.Location = new System.Drawing.Point(49, 127);
            idEstadoLabel.Name = "idEstadoLabel";
            idEstadoLabel.Size = new System.Drawing.Size(43, 13);
            idEstadoLabel.TabIndex = 5;
            idEstadoLabel.Text = "Estado:";
            // 
            // cuentaPorCobtrarDBDataSet
            // 
            this.cuentaPorCobtrarDBDataSet.DataSetName = "CuentaPorCobtrarDBDataSet";
            this.cuentaPorCobtrarDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.cuentaPorCobtrarDBDataSet;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = this.estadoTableAdapter;
            this.tableAdapterManager.TipoDocumentoTableAdapter = this.tipoDocumentoTableAdapter;
            this.tableAdapterManager.TipoMovimientoTableAdapter = null;
            this.tableAdapterManager.TransaccionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDocumentoBindingNavigator
            // 
            this.tipoDocumentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipoDocumentoBindingNavigator.BindingSource = this.tipoDocumentoBindingSource;
            this.tipoDocumentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipoDocumentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tipoDocumentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tipoDocumentoBindingNavigatorSaveItem});
            this.tipoDocumentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipoDocumentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipoDocumentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipoDocumentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipoDocumentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipoDocumentoBindingNavigator.Name = "tipoDocumentoBindingNavigator";
            this.tipoDocumentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipoDocumentoBindingNavigator.Size = new System.Drawing.Size(322, 25);
            this.tipoDocumentoBindingNavigator.TabIndex = 0;
            this.tipoDocumentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tipoDocumentoBindingNavigatorSaveItem
            // 
            this.tipoDocumentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipoDocumentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoDocumentoBindingNavigatorSaveItem.Image")));
            this.tipoDocumentoBindingNavigatorSaveItem.Name = "tipoDocumentoBindingNavigatorSaveItem";
            this.tipoDocumentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tipoDocumentoBindingNavigatorSaveItem.Text = "Save Data";
            this.tipoDocumentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tipoDocumentoBindingNavigatorSaveItem_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoDocumentoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(144, 72);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(166, 20);
            this.descripcionTextBox.TabIndex = 2;
            // 
            // cuentaContableTextBox
            // 
            this.cuentaContableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoDocumentoBindingSource, "CuentaContable", true));
            this.cuentaContableTextBox.Location = new System.Drawing.Point(144, 98);
            this.cuentaContableTextBox.Name = "cuentaContableTextBox";
            this.cuentaContableTextBox.Size = new System.Drawing.Size(166, 20);
            this.cuentaContableTextBox.TabIndex = 4;
            // 
            // idEstadoComboBox
            // 
            this.idEstadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoDocumentoBindingSource, "IdEstado", true));
            this.idEstadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cuentaPorCobtrarDBDataSet, "TipoDocumento.IdEstado", true));
            this.idEstadoComboBox.DataSource = this.estadoBindingSource;
            this.idEstadoComboBox.DisplayMember = "Id";
            this.idEstadoComboBox.FormattingEnabled = true;
            this.idEstadoComboBox.Location = new System.Drawing.Point(144, 124);
            this.idEstadoComboBox.Name = "idEstadoComboBox";
            this.idEstadoComboBox.Size = new System.Drawing.Size(166, 21);
            this.idEstadoComboBox.TabIndex = 6;
            this.idEstadoComboBox.ValueMember = "Id";
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.cuentaPorCobtrarDBDataSet;
            // 
            // FrmTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(cuentaContableLabel);
            this.Controls.Add(this.cuentaContableTextBox);
            this.Controls.Add(idEstadoLabel);
            this.Controls.Add(this.idEstadoComboBox);
            this.Controls.Add(this.tipoDocumentoBindingNavigator);
            this.Name = "FrmTipoDocumento";
            this.Text = "FrmTipoDocumento";
            this.Load += new System.EventHandler(this.FrmTipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuentaPorCobtrarDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingNavigator)).EndInit();
            this.tipoDocumentoBindingNavigator.ResumeLayout(false);
            this.tipoDocumentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuentaPorCobtrarDBDataSet cuentaPorCobtrarDBDataSet;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private CuentaPorCobtrarDBDataSetTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private CuentaPorCobtrarDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tipoDocumentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tipoDocumentoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox cuentaContableTextBox;
        private System.Windows.Forms.ComboBox idEstadoComboBox;
        private CuentaPorCobtrarDBDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.BindingSource estadoBindingSource;
    }
}