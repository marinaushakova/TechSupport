using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData.Model
{
    public class Incident
    {
        private string productCode;
        private DateTime dateOpened;
        private string customerName;
        private string techName;
        private string title;

        public Incident()
        {
        }

        //the code used auto implemented properties of C#
        public string CustomerName { get; set; }
        public string ProductCode { get; set; }
        public string TechName { get; set; }
        public DateTime DateOpened { get; set; }
        public string Title { get; set; }
    }
}
