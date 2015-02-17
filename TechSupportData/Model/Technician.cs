using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData.Model
{
    /// <summary>
    /// Class that models technician table
    /// </summary>
    public class Technician
    {
        private int techID;
        private string name;


        public Technician()
        {
        }

        /// <summary>
        /// Getter and Setters methods of instance variables
        /// </summary>
        public int TechID
        {
            get
            {
                return techID;
            }
            set
            {
                techID = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
