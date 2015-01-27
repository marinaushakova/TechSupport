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
                //invoiceList = InvoiceDB.GetInvoicesDue();
                incidentList = this.inController.GetOpenIncidents();
                
                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        lvIncidents.Items.Add(incident.IncidentID.ToString("c"));
                        lvIncidents.Items[i].SubItems.Add(incident.CustomerID.ToString("c"));
                        lvIncidents.Items[i].SubItems.Add(incident.ProductCode);
                        lvIncidents.Items[i].SubItems.Add(incident.TechID.ToString());
                        lvIncidents.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        lvIncidents.Items[i].SubItems.Add(incident.DateClosed.ToShortDateString());
                        lvIncidents.Items[i].SubItems.Add(incident.Title);
                        lvIncidents.Items[i].SubItems.Add(incident.Description);
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
                this.Close();
            }
        }
    }
}
