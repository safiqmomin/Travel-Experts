using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
* Author : Brain Lang
* Date : 21th July, 2018
* Purpose: sets properties of package class
***************************************************************/
namespace TravelExpertsLibrary

{
    public class Package
    {
        public Package() { }                        //Package constructor
        public int PackageId { get; set; }          //getter/setter for PackageID
        public string PkgName { get; set; }         //getter/setter for PkgName
        public DateTime PkgStartDate { get; set; }  //getter/setter for PkgStartDate
        public DateTime PkgEndDate { get; set; }    //getter/setter for PkgEndDate
        public string PkgDesc { get; set; }         //getter/setter for PkgDesc
        public double PkgBasePrice { get; set; }   //getter/setter for PkgBasePrice
        public double PkgAgencyCommission { get; set; }    //getter/setter for PkgAgencyCommission
    }
}
