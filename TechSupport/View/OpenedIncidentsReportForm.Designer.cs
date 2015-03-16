namespace TechSupport.View
{
    partial class OpenedIncidentsReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.techSupportDataSet = new TechSupport.TechSupportDataSet();
            this.openIncidentsAssignedToTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openIncidentsAssignedToTechTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.OpenIncidentsAssignedToTechTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsAssignedToTechBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "OpenIncidentsAssignedToTechDataSet";
            reportDataSource2.Value = this.openIncidentsAssignedToTechBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TechSupport.OpenIncidentsAssignedToTechReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(797, 438);
            this.reportViewer1.TabIndex = 0;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openIncidentsAssignedToTechBindingSource
            // 
            this.openIncidentsAssignedToTechBindingSource.DataMember = "OpenIncidentsAssignedToTech";
            this.openIncidentsAssignedToTechBindingSource.DataSource = this.techSupportDataSet;
            // 
            // openIncidentsAssignedToTechTableAdapter
            // 
            this.openIncidentsAssignedToTechTableAdapter.ClearBeforeFill = true;
            // 
            // OpenedIncidentsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 438);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OpenedIncidentsReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenedIncidentsReportForm";
            this.Load += new System.EventHandler(this.OpenedIncidentsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsAssignedToTechBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource openIncidentsAssignedToTechBindingSource;
        private TechSupportDataSetTableAdapters.OpenIncidentsAssignedToTechTableAdapter openIncidentsAssignedToTechTableAdapter;
    }
}