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
    public partial class OpenIncidentByTechnicianForm : Form
    {
        private TechniciansController techController;
        public OpenIncidentByTechnicianForm()
        {
            InitializeComponent();
            techController = new TechniciansController();
        }

        private void OpenIncidentByTechnicianForm_Load(object sender, EventArgs e)
        {
            List<Technician> techList = techController.GetTechniciansWithOpenIncidents();
            cmbTechName.DataSource = techList;
        }
    }
}
