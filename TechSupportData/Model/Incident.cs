using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData.Model
{
    public class Incident
    {
        private int incidentID;
        private int customerID;
        private string productCode;
        private int? techID;
        private DateTime dateOpened;
        private DateTime? dateClosed;
        private string title;
        private string description;

        public Incident()
        {
        }

        public int IncidentID { get; set; }
        public int CustomerID { get; set; }
        public string ProductCode { get; set; }
        public int? TechID { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
