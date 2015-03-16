using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupportData.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Form that displays open incidents by technician
    /// </summary>
    public partial class OpenIncidentByTechnicianForm : Form
    {
        private TechniciansController techController;
        private IncidentsController incidentsController;
        private List<Technician> techList;
        private List<Incident> incidentList;

        public OpenIncidentByTechnicianForm()
        {
            InitializeComponent();
            techController = new TechniciansController();
            incidentsController = new IncidentsController();
        }

        /// <summary>
        /// Method called when form first opens.
        /// Fills cmbTechnician with data from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenIncidentByTechnicianForm_Load(object sender, EventArgs e)
        {
            try
            {
                techList = techController.GetTechniciansWithOpenIncidents();
                cmbTechName.DataSource = techList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        /// <summary>
        /// Gets called when cmbTechnician changes its selected value.
        /// Populates Phone and Email textBoxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTechName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTechName.SelectedIndex < 0)
                {
                    return;
                }
                Technician technician = techList[cmbTechName.SelectedIndex];
                technicianBindingSource.Clear();
                technicianBindingSource.Add(technician);

                incidentList = incidentsController.GetOpenIncidentsByTechnician(technician.TechID);
                incidentDataGridView.DataSource = incidentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }

        }
    }
}
