using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
* Author : Safiq
* Date : 26th July, 2018
* Purpose: sets property for the product supplier class
***************************************************************/
namespace TravelExpertsLibrary
{
    public class Product_Supplier
    {
        public Product_Supplier() { }
        public int ProductSupplierID { get; set; }
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public string ProdName { get; set; }
        public string SupName { get; set; }
    }
}
