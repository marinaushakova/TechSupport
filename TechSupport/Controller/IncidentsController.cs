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

        public void UpdateIncident(Incident incident)
        {
            IncidentDAL.UpdateIncident(incident);
        }

        public void CloseIncident(Incident incident)
        {
            IncidentDAL.CloseIncident(incident);
        }
    }
}
