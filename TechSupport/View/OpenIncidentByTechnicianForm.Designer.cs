namespace TechSupport.View
{
    partial class OpenIncidentByTechnicianForm
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
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblTechName;
            System.Windows.Forms.Label lblPhone;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenIncidentByTechnicianForm));
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicianBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.technicianBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.cmbTechName = new System.Windows.Forms.ComboBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblEmail = new System.Windows.Forms.Label();
            lblTechName = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingNavigator)).BeginInit();
            this.technicianBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(49, 49);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblTechName
            // 
            lblTechName.AutoSize = true;
            lblTechName.Location = new System.Drawing.Point(21, 22);
            lblTechName.Name = "lblTechName";
            lblTechName.Size = new System.Drawing.Size(63, 13);
            lblTechName.TabIndex = 3;
            lblTechName.Text = "Technician:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(43, 75);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(41, 13);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone:";
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataSource = typeof(TechSupportData.Model.Technician);
            // 
            // technicianBindingNavigator
            // 
            this.technicianBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.technicianBindingNavigator.BindingSource = this.technicianBindingSource;
            this.technicianBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.technicianBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.technicianBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.technicianBindingNavigatorSaveItem});
            this.technicianBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.technicianBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.technicianBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.technicianBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.technicianBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.technicianBindingNavigator.Name = "technicianBindingNavigator";
            this.technicianBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.technicianBindingNavigator.Size = new System.Drawing.Size(748, 25);
            this.technicianBindingNavigator.TabIndex = 0;
            this.technicianBindingNavigator.Text = "bindingNavigator1";
            this.technicianBindingNavigator.Visible = false;
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
            // technicianBindingNavigatorSaveItem
            // 
            this.technicianBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.technicianBindingNavigatorSaveItem.Enabled = false;
            this.technicianBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("technicianBindingNavigatorSaveItem.Image")));
            this.technicianBindingNavigatorSaveItem.Name = "technicianBindingNavigatorSaveItem";
            this.technicianBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.technicianBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // txbEmail
            // 
            this.txbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Email", true));
            this.txbEmail.Location = new System.Drawing.Point(90, 46);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(206, 20);
            this.txbEmail.TabIndex = 2;
            this.txbEmail.TabStop = false;
            // 
            // cmbTechName
            // 
            this.cmbTechName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Name", true));
            this.cmbTechName.DataSource = this.technicianBindingSource;
            this.cmbTechName.DisplayMember = "Name";
            this.cmbTechName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechName.FormattingEnabled = true;
            this.cmbTechName.Location = new System.Drawing.Point(90, 19);
            this.cmbTechName.Name = "cmbTechName";
            this.cmbTechName.Size = new System.Drawing.Size(206, 21);
            this.cmbTechName.TabIndex = 4;
            this.cmbTechName.SelectedIndexChanged += new System.EventHandler(this.cmbTechName_SelectedIndexChanged);
            // 
            // txbPhone
            // 
            this.txbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technicianBindingSource, "Phone", true));
            this.txbPhone.Location = new System.Drawing.Point(90, 72);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.ReadOnly = true;
            this.txbPhone.Size = new System.Drawing.Size(206, 20);
            this.txbPhone.TabIndex = 6;
            this.txbPhone.TabStop = false;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataSource = typeof(TechSupportData.Model.Incident);
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.AllowUserToOrderColumns = true;
            this.incidentDataGridView.AutoGenerateColumns = false;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10});
            this.incidentDataGridView.DataSource = this.incidentBindingSource;
            this.incidentDataGridView.Location = new System.Drawing.Point(12, 111);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            this.incidentDataGridView.Size = new System.Drawing.Size(724, 220);
            this.incidentDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateOpened";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date Opened";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn10.HeaderText = "Title";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 250;
            // 
            // OpenIncidentByTechnicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 351);
            this.Controls.Add(this.incidentDataGridView);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(lblTechName);
            this.Controls.Add(this.cmbTechName);
            this.Controls.Add(lblPhone);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.technicianBindingNavigator);
            this.Name = "OpenIncidentByTechnicianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenIncidentByTechnicianForm";
            this.Load += new System.EventHandler(this.OpenIncidentByTechnicianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingNavigator)).EndInit();
            this.technicianBindingNavigator.ResumeLayout(false);
            this.technicianBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.BindingNavigator technicianBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton technicianBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.ComboBox cmbTechName;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

    }
}