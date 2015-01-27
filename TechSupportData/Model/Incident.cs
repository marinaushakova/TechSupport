using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData.Model
{
    class Incident
    {
        private int incidentID;
        private int customerID;
        private string productCode;
        private int? techID;
        private DateTime dateOpend;
        private DateTime? dateClosed;
        private string title;
        private string description;

        public Incident()
        {
        }

        public string incidentID { get; set; }
        public string customerID { get; set; }
        public string productCode { get; set; }
        public string techID { get; set; }
        public string dateOpend { get; set; }
        public string dateClosed { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
