using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.DAL;
using TechSupportData.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// The controller class deals with the customersDAL and delegates the work to DAL
    /// </summary>
    class CustomersController
    {
         public CustomersController()
        {

        }

        public  List<Customer> GetCustomers()
        {
            return CustomerDAL.GetCustomers();
        }
    }
}
