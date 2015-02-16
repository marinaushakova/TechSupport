using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{
    /// <summary>
    /// Main form of the application
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles event of clicking on File -> Exit menu item.
        /// Closes the Main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        OpenIncidentForm openIncidentsForm;
        CreateIncidentForm createIncidentForm;
        UpdateIncidentForm updateIncidentForm;

        /// <summary>
        /// Handles event of clicking on Incidents -> Display Open Incidents menu item.
        /// Opens OpenIncidentsForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayOpenIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openIncidentsForm == null) {
                openIncidentsForm = new OpenIncidentForm();
                openIncidentsForm.MdiParent = this;
                openIncidentsForm.FormClosed += new FormClosedEventHandler(openIncidentsForm_FormClosed);
                openIncidentsForm.Show();
            }
            else
            {
                openIncidentsForm.Activate();
            }
            
        }

        /// <summary>
        /// Handles event of closing OpenIncidentsForm.
        /// Closes open incidents form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void openIncidentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            openIncidentsForm = null;
        }

        /// <summary>
        /// Handles event of clicking on Incidents -> Create incident.
        /// Opens CreateIncidentForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createIncidentForm == null)
            {
                createIncidentForm = new CreateIncidentForm();
                createIncidentForm.MdiParent = this;
                createIncidentForm.FormClosed += new FormClosedEventHandler(createIncidentForm_FormClosed);
                createIncidentForm.Show();
            }
            else
            {
                createIncidentForm.Activate();
            }
        }

        /// <summary>
        /// Handles event of closing CreateIncidentForm.
        /// Closes create incident form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void createIncidentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createIncidentForm = null;
        }


        /// <summary>
        /// Handles event of clicking on Incidents -> Update incident.
        /// Opens UpdateIncidentForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (updateIncidentForm == null)
            {
                updateIncidentForm = new UpdateIncidentForm();
                updateIncidentForm.MdiParent = this;
                updateIncidentForm.FormClosed += new FormClosedEventHandler(updateIncidentForm_FormClosed);
                updateIncidentForm.Show();
            }
            else
            {
                updateIncidentForm.Activate();
            }
        }

        /// <summary>
        /// Handles event of closing UpdateIncidentForm.
        /// Closes update incident form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void updateIncidentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateIncidentForm = null;
        }
    }
}
