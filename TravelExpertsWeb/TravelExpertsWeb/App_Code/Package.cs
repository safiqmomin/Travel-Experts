using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*******************************************************
 * Author: Brian Liang
 * Date: July-2018
 * Purpose: Prop for Packages
 *******************************************************/

namespace TravelExpertsWeb.App_Code
{
    // getters/accessor for the package props 
    public class Package
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
    }
}