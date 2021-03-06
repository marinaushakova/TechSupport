﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.DAL;
using TechSupportData.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// The controller class deals with the productsDAL and delegates the work to DAL
    /// </summary>
    public class ProductsController
    {
         public ProductsController()
        {

        }

        public  List<Product> GetProductList()
        {
            return ProductDAL.GetProductList();
        }
    }
}
