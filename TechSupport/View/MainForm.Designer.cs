﻿namespace TechSupport
{
    partial class MainForm
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
            this.mainFormMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOpenIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOpenIncidentsByTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayIncidentsByProductsAndTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenu
            // 
            this.mainFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.incidentsToolStripMenuItem});
            this.mainFormMenu.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenu.Name = "mainFormMenu";
            this.mainFormMenu.Size = new System.Drawing.Size(818, 24);
            this.mainFormMenu.TabIndex = 1;
            this.mainFormMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // incidentsToolStripMenuItem
            // 
            this.incidentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayOpenIncidentsToolStripMenuItem,
            this.createIncidentToolStripMenuItem,
            this.updateIncidentToolStripMenuItem,
            this.viewOpenIncidentsByTechnicianToolStripMenuItem,
            this.displayIncidentsByProductsAndTechnicianToolStripMenuItem});
            this.incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            this.incidentsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.incidentsToolStripMenuItem.Text = "Incidents";
            // 
            // displayOpenIncidentsToolStripMenuItem
            // 
            this.displayOpenIncidentsToolStripMenuItem.Name = "displayOpenIncidentsToolStripMenuItem";
            this.displayOpenIncidentsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.displayOpenIncidentsToolStripMenuItem.Text = "Display Open Incidents";
            this.displayOpenIncidentsToolStripMenuItem.Click += new System.EventHandler(this.displayOpenIncidentsToolStripMenuItem_Click);
            // 
            // createIncidentToolStripMenuItem
            // 
            this.createIncidentToolStripMenuItem.Name = "createIncidentToolStripMenuItem";
            this.createIncidentToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.createIncidentToolStripMenuItem.Text = "Create Incident";
            this.createIncidentToolStripMenuItem.Click += new System.EventHandler(this.createIncidentToolStripMenuItem_Click);
            // 
            // updateIncidentToolStripMenuItem
            // 
            this.updateIncidentToolStripMenuItem.Name = "updateIncidentToolStripMenuItem";
            this.updateIncidentToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.updateIncidentToolStripMenuItem.Text = "Update Incident";
            this.updateIncidentToolStripMenuItem.Click += new System.EventHandler(this.updateIncidentToolStripMenuItem_Click);
            // 
            // viewOpenIncidentsByTechnicianToolStripMenuItem
            // 
            this.viewOpenIncidentsByTechnicianToolStripMenuItem.Name = "viewOpenIncidentsByTechnicianToolStripMenuItem";
            this.viewOpenIncidentsByTechnicianToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.viewOpenIncidentsByTechnicianToolStripMenuItem.Text = "View Open Incidents by Technician";
            this.viewOpenIncidentsByTechnicianToolStripMenuItem.Click += new System.EventHandler(this.viewOpenIncidentsByTechnicianToolStripMenuItem_Click);
            // 
            // displayIncidentsByProductsAndTechnicianToolStripMenuItem
            // 
            this.displayIncidentsByProductsAndTechnicianToolStripMenuItem.Name = "displayIncidentsByProductsAndTechnicianToolStripMenuItem";
            this.displayIncidentsByProductsAndTechnicianToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.displayIncidentsByProductsAndTechnicianToolStripMenuItem.Text = "Display Incidents by Products and Technician";
            this.displayIncidentsByProductsAndTechnicianToolStripMenuItem.Click += new System.EventHandler(this.displayIncidentsByProductsAndTechnicianToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 509);
            this.Controls.Add(this.mainFormMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechSupport";
            this.mainFormMenu.ResumeLayout(false);
            this.mainFormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOpenIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOpenIncidentsByTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayIncidentsByProductsAndTechnicianToolStripMenuItem;
    }
}

