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
    public partial class OpenedIncidentsReportForm : Form
    {
        public OpenedIncidentsReportForm()
        {
            InitializeComponent();
        }

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
