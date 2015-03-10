using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.Model;
using TechSupportData.DAL;

namespace TechSupport.Controller
{
    /// <summary>
    /// The controller class deals with the incidentsDAL and delegates the work to DAL
    /// </summary>
    public class IncidentsController
    {
        public IncidentsController()
        {

        }

        public  List<Incident> GetOpenIncidents()
        {
            return IncidentDAL.GetOpenIncidents();
        }

        public void AddIncident(Incident incident)
        {
            IncidentDAL.AddIncident(incident);
        }

        public Incident GetIncident(int incidentID)
        {
            return IncidentDAL.GetIncident(incidentID);
        }

        public bool UpdateIncident(Incident oldIncident, Incident newIncident)
        {
            return IncidentDAL.UpdateIncident(oldIncident, newIncident);
        }

        public bool CloseIncident(Incident oldIncident, Incident newIncident)
        {
            return IncidentDAL.CloseIncident(oldIncident, newIncident);
        }

        public List<Incident> GetOpenIncidentsByTechnician(int techID)
        {
            return IncidentDAL.GetOpenIncidentsByTechnician(techID);
        }
    }
}
