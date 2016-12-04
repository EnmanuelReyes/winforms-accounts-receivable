namespace CuentasPorCobrar
{
    partial class FrmTransaccion
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
            System.Windows.Forms.Label idTipoDocumentoLabel;
            System.Windows.Forms.Label numeroDocumentoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label idTipoMovimientoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransaccion));
            this.cuentaPorCobtrarDBDataSet = new CuentasPorCobrar.CuentaPorCobtrarDBDataSet();
            this.transaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionTableAdapter = new CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.TransaccionTableAdapter();
            this.tableAdapterManager = new CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.ClienteTableAdapter();
            this.tipoDocumentoTableAdapter = new CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.TipoDocumentoTableAdapter();
            this.transaccionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.transaccionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.idTipoMovimientoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoMovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDocumentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipoMovimientoTableAdapter = new CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.TipoMovimientoTableAdapter();
            this.fKTransaccionTipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idTipoDocumentoLabel = new System.Windows.Forms.Label();
            numeroDocumentoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            idTipoMovimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaPorCobtrarDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingNavigator)).BeginInit();
            this.transaccionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTransaccionTipoDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idTipoDocumentoLabel
            // 
            idTipoDocumentoLabel.AutoSize = true;
            idTipoDocumentoLabel.Location = new System.Drawing.Point(39, 92);
            idTipoDocumentoLabel.Name = "idTipoDocumentoLabel";
            idTipoDocumentoLabel.Size = new System.Drawing.Size(101, 13);
            idTipoDocumentoLabel.TabIndex = 1;
            idTipoDocumentoLabel.Text = "Id Tipo Documento:";
            // 
            // numeroDocumentoLabel
            // 
            numeroDocumentoLabel.AutoSize = true;
            numeroDocumentoLabel.Location = new System.Drawing.Point(39, 119);
            numeroDocumentoLabel.Name = "numeroDocumentoLabel";
            numeroDocumentoLabel.Size = new System.Drawing.Size(105, 13);
            numeroDocumentoLabel.TabIndex = 3;
            numeroDocumentoLabel.Text = "Numero Documento:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(39, 146);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(39, 171);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 7;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(39, 198);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(40, 13);
            montoLabel.TabIndex = 9;
            montoLabel.Text = "Monto:";
            // 
            // idTipoMovimientoLabel
            // 
            idTipoMovimientoLabel.AutoSize = true;
            idTipoMovimientoLabel.Location = new System.Drawing.Point(39, 224);
            idTipoMovimientoLabel.Name = "idTipoMovimientoLabel";
            idTipoMovimientoLabel.Size = new System.Drawing.Size(100, 13);
            idTipoMovimientoLabel.TabIndex = 11;
            idTipoMovimientoLabel.Text = "Id Tipo Movimiento:";
            idTipoMovimientoLabel.Click += new System.EventHandler(this.idTipoMovimientoLabel_Click);
            // 
            // cuentaPorCobtrarDBDataSet
            // 
            this.cuentaPorCobtrarDBDataSet.DataSetName = "CuentaPorCobtrarDBDataSet";
            this.cuentaPorCobtrarDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaccionBindingSource
            // 
            this.transaccionBindingSource.DataMember = "Transaccion";
            this.transaccionBindingSource.DataSource = this.cuentaPorCobtrarDBDataSet;
            // 
            // transaccionTableAdapter
            // 
            this.transaccionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = this.tipoDocumentoTableAdapter;
            this.tableAdapterManager.TipoMovimientoTableAdapter = null;
            this.tableAdapterManager.TransaccionTableAdapter = this.transaccionTableAdapter;
            this.tableAdapterManager.UpdateOrder = CuentasPorCobrar.CuentaPorCobtrarDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // transaccionBindingNavigator
            // 
            this.transaccionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transaccionBindingNavigator.BindingSource = this.transaccionBindingSource;
            this.transaccionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transaccionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transaccionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.transaccionBindingNavigatorSaveItem});
            this.transaccionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transaccionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transaccionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transaccionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transaccionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transaccionBindingNavigator.Name = "transaccionBindingNavigator";
            this.transaccionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transaccionBindingNavigator.Size = new System.Drawing.Size(502, 25);
            this.transaccionBindingNavigator.TabIndex = 0;
            this.transaccionBindingNavigator.Text = "bindingNavigator1";
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
            // transaccionBindingNavigatorSaveItem
            // 
            this.transaccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transaccionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transaccionBindingNavigatorSaveItem.Image")));
            this.transaccionBindingNavigatorSaveItem.Name = "transaccionBindingNavigatorSaveItem";
            this.transaccionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.transaccionBindingNavigatorSaveItem.Text = "Save Data";
            this.transaccionBindingNavigatorSaveItem.Click += new System.EventHandler(this.transaccionBindingNavigatorSaveItem_Click);
            // 
            // idTipoDocumentoComboBox
            // 
            this.idTipoDocumentoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idTipoDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionBindingSource, "IdTipoDocumento", true));
            this.idTipoDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cuentaPorCobtrarDBDataSet, "Transaccion.IdTipoDocumento", true));
            this.idTipoDocumentoComboBox.DataSource = this.tipoDocumentoBindingSource;
            this.idTipoDocumentoComboBox.DisplayMember = "IdTipoDocumento";
            this.idTipoDocumentoComboBox.FormattingEnabled = true;
            this.idTipoDocumentoComboBox.Location = new System.Drawing.Point(150, 89);
            this.idTipoDocumentoComboBox.Name = "idTipoDocumentoComboBox";
            this.idTipoDocumentoComboBox.Size = new System.Drawing.Size(267, 21);
            this.idTipoDocumentoComboBox.TabIndex = 2;
            this.idTipoDocumentoComboBox.ValueMember = "IdTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.cuentaPorCobtrarDBDataSet;
            // 
            // numeroDocumentoTextBox
            // 
            this.numeroDocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionBindingSource, "NumeroDocumento", true));
            this.numeroDocumentoTextBox.Location = new System.Drawing.Point(150, 116);
            this.numeroDocumentoTextBox.Name = "numeroDocumentoTextBox";
            this.numeroDocumentoTextBox.Size = new System.Drawing.Size(267, 20);
            this.numeroDocumentoTextBox.TabIndex = 4;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transaccionBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(150, 142);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(267, 20);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cuentaPorCobtrarDBDataSet, "Transaccion.IdCliente", true));
            this.idClienteComboBox.DataSource = this.clienteBindingSource;
            this.idClienteComboBox.DisplayMember = "IdCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(150, 168);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(267, 21);
            this.idClienteComboBox.TabIndex = 8;
            this.idClienteComboBox.ValueMember = "IdCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.cuentaPorCobtrarDBDataSet;
            // 
            // montoTextBox
            // 
            this.montoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionBindingSource, "Monto", true));
            this.montoTextBox.Location = new System.Drawing.Point(150, 195);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(267, 20);
            this.montoTextBox.TabIndex = 10;
            // 
            // idTipoMovimientoComboBox
            // 
            this.idTipoMovimientoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transaccionBindingSource, "IdTipoMovimiento", true));
            this.idTipoMovimientoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cuentaPorCobtrarDBDataSet, "Transaccion.IdTipoMovimiento", true));
            this.idTipoMovimientoComboBox.DataSource = this.tipoMovimientoBindingSource;
            this.idTipoMovimientoComboBox.DisplayMember = "IdTipoMovimiento";
            this.idTipoMovimientoComboBox.FormattingEnabled = true;
            this.idTipoMovimientoComboBox.Location = new System.Drawing.Point(150, 221);
            this.idTipoMovimientoComboBox.Name = "idTipoMovimientoComboBox";
            this.idTipoMovimientoComboBox.Size = new System.Drawing.Size(267, 21);
            this.idTipoMovimientoComboBox.TabIndex = 12;
            this.idTipoMovimientoComboBox.ValueMember = "IdTipoMovimiento";
            // 
            // tipoMovimientoBindingSource
            // 
            this.tipoMovimientoBindingSource.DataMember = "TipoMovimiento";
            this.tipoMovimientoBindingSource.DataSource = this.cuentaPorCobtrarDBDataSet;
            // 
            // tipoDocumentoBindingSource1
            // 
            this.tipoDocumentoBindingSource1.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource1.DataSource = this.cuentaPorCobtrarDBDataSet;
            // 
            // transaccionBindingSource1
            // 
            this.transaccionBindingSource1.DataMember = "Transaccion";
            this.transaccionBindingSource1.DataSource = this.cuentaPorCobtrarDBDataSet;
            // 
            // tipoMovimientoTableAdapter
            // 
            this.tipoMovimientoTableAdapter.ClearBeforeFill = true;
            // 
            // fKTransaccionTipoDocumentoBindingSource
            // 
            this.fKTransaccionTipoDocumentoBindingSource.DataMember = "FK_Transaccion_TipoDocumento";
            this.fKTransaccionTipoDocumentoBindingSource.DataSource = this.tipoDocumentoBindingSource;
            // 
            // FrmTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 262);
            this.Controls.Add(idTipoDocumentoLabel);
            this.Controls.Add(this.idTipoDocumentoComboBox);
            this.Controls.Add(numeroDocumentoLabel);
            this.Controls.Add(this.numeroDocumentoTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(montoLabel);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(idTipoMovimientoLabel);
            this.Controls.Add(this.idTipoMovimientoComboBox);
            this.Controls.Add(this.transaccionBindingNavigator);
            this.Name = "FrmTransaccion";
            this.Text = "FrmTransaccion";
            this.Load += new System.EventHandler(this.FrmTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuentaPorCobtrarDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingNavigator)).EndInit();
            this.transaccionBindingNavigator.ResumeLayout(false);
            this.transaccionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTransaccionTipoDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuentaPorCobtrarDBDataSet cuentaPorCobtrarDBDataSet;
        private System.Windows.Forms.BindingSource transaccionBindingSource;
        private CuentaPorCobtrarDBDataSetTableAdapters.TransaccionTableAdapter transaccionTableAdapter;
        private CuentaPorCobtrarDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transaccionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton transaccionBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox idTipoDocumentoComboBox;
        private System.Windows.Forms.TextBox numeroDocumentoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.ComboBox idTipoMovimientoComboBox;
        private CuentaPorCobtrarDBDataSetTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private CuentaPorCobtrarDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource transaccionBindingSource1;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource tipoMovimientoBindingSource;
        private CuentaPorCobtrarDBDataSetTableAdapters.TipoMovimientoTableAdapter tipoMovimientoTableAdapter;
        private System.Windows.Forms.BindingSource fKTransaccionTipoDocumentoBindingSource;
    }
}