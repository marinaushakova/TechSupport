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
            this.openIncidentsAssignedToTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSet = new TechSupport.TechSupportDataSet();
            this.rvOpenIncidentsAssihgnedToTech = new Microsoft.Reporting.WinForms.ReportViewer();
            this.openIncidentsAssignedToTechTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.OpenIncidentsAssignedToTechTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsAssignedToTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // openIncidentsAssignedToTechBindingSource
            // 
            this.openIncidentsAssignedToTechBindingSource.DataMember = "OpenIncidentsAssignedToTech";
            this.openIncidentsAssignedToTechBindingSource.DataSource = this.techSupportDataSet;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvOpenIncidentsAssihgnedToTech
            // 
            this.rvOpenIncidentsAssihgnedToTech.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "OpenIncidentsAssignedToTechDataSet";
            reportDataSource2.Value = this.openIncidentsAssignedToTechBindingSource;
            this.rvOpenIncidentsAssihgnedToTech.LocalReport.DataSources.Add(reportDataSource2);
            this.rvOpenIncidentsAssihgnedToTech.LocalReport.ReportEmbeddedResource = "TechSupport.OpenIncidentsAssignedToTechReport.rdlc";
            this.rvOpenIncidentsAssihgnedToTech.Location = new System.Drawing.Point(0, 0);
            this.rvOpenIncidentsAssihgnedToTech.Name = "rvOpenIncidentsAssihgnedToTech";
            this.rvOpenIncidentsAssihgnedToTech.Size = new System.Drawing.Size(797, 438);
            this.rvOpenIncidentsAssihgnedToTech.TabIndex = 0;
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
            this.Controls.Add(this.rvOpenIncidentsAssihgnedToTech);
            this.Name = "OpenedIncidentsReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenedIncidentsReportForm";
            this.Load += new System.EventHandler(this.OpenedIncidentsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsAssignedToTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvOpenIncidentsAssihgnedToTech;
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource openIncidentsAssignedToTechBindingSource;
        private TechSupportDataSetTableAdapters.OpenIncidentsAssignedToTechTableAdapter openIncidentsAssignedToTechTableAdapter;
    }
}