using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
* Author : Brain Lang
* Date : 23th July, 2018
* Purpose: sets properties for packages products suppliers class
***************************************************************/
namespace TravelExpertsLibrary
{
    public class Packages_Products_Suppliers
    {
        public int ProductSupplerID { get; set; }
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public string ProdName { get; set; }
        public string SupName { get; set; }
    }
}
