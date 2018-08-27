using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Author : Brain Lang
* Date : 24th July, 2018
* Purpose: sets properties for product class
***************************************************************/
namespace TravelExpertsLibrary
{
    /// <summary>
    /// class to create product object after accessing database
    /// </summary>
    public class Product
    {
        public Product() { }
        public int ProductID { get; set; }
        public string ProdName { get; set; }
    }
}
