using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData.Model
{
    /// <summary>
    /// Class that models Customers table.
    /// </summary>
    public class Customer
    {
        private int customerID;
        private string name;


        public Customer()
        {
        }

        /// <summary>
        /// Getter and Setters methods of instance variables
        /// </summary>
        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
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
