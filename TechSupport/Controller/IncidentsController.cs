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
    /// The controller class deals with the DAL and delegates the work to DAL
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
    }
}
