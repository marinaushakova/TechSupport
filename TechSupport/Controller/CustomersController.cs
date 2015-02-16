using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.DAL;
using TechSupportData.Model;

namespace TechSupport.Controller
{
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
