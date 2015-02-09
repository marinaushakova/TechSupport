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


namespace TechSupport
{
    public partial class OpenIncidentForm : Form
    {
        private IncidentsController inController;

        public OpenIncidentForm()
        {
            InitializeComponent();
            inController = new IncidentsController();
        }

        private void OpenIncidentForm_Load(object sender, EventArgs e)
        {
            lvIncidents.Items.Clear();
            List<Incident> incidentList;
            try
            {
                incidentList = this.inController.GetOpenIncidents();
                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        lvIncidents.Items.Add(incident.ProductCode);
                        lvIncidents.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        lvIncidents.Items[i].SubItems.Add(incident.CustomerName);
                        if (incident.TechName != null)
                        {
                            lvIncidents.Items[i].SubItems.Add(incident.TechName.ToString());
                        }
                        else
                        {
                            lvIncidents.Items[i].SubItems.Add("");
                        }
                        lvIncidents.Items[i].SubItems.Add(incident.Title);
                    }
                }
                else
                {
                    MessageBox.Show("There is no open incidents.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }
    }
}
