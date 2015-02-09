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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        OpenIncidentForm openIncidentsForm;
        CreateIncidentForm createIncidentForm;

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

        void openIncidentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            openIncidentsForm = null;
        }

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

        void createIncidentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createIncidentForm = null;
        }
    }
}
