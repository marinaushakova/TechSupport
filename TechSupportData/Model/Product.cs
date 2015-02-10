using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData.Model
{
    /// <summary>
    /// Class that models product table
    /// </summary>
    public class Product
    {
        private string productCode;
        private string name;

        public Product()
        { 

        }

        /// <summary>
        /// Getter and Setters methods of instance variables
        /// </summary>
        public string ProductCode
        {
            get
            {
                return productCode;
            }
            set
            {
                productCode = value;
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
