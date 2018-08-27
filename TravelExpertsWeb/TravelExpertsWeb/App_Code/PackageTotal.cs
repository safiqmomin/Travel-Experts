using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*******************************************************
 * Author: Brian Liang
 * Date: July-2018
 * Purpose: Prop for PackageTotal
 *******************************************************/
namespace TravelExpertsWeb.App_Code
{
    public class PackageTotal
    {
        public int CustomerId { get; set; }
        public decimal BasePrice { get; set; }
    }
}