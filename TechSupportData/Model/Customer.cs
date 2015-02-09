using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData.Model
{
    public class Customer
    {
        private int customerID;
        private string name;


        public Customer()
        {
        }

        /// <summary>
        /// the code used auto implemented properties of C#
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
