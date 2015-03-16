using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Form that displays a report containing all open incidents 
    /// that have been assigned to technicians
    /// </summary>
    public partial class OpenedIncidentsReportForm : Form
    {
        public OpenedIncidentsReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method called when the form first opens.
        /// Fills report with data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenedIncidentsReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'techSupportDataSet.OpenIncidentsAssignedToTech' table. You can move, or remove it, as needed.
                this.openIncidentsAssignedToTechTableAdapter.Fill(this.techSupportDataSet.OpenIncidentsAssignedToTech);

                this.rvOpenIncidentsAssihgnedToTech.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
                
            }
        }

 
    }
}
