using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsWeb.App_Code
{
    public class CustomerRegistration
    {
        public CustomerRegistration() { }
        public int CustomerID { get; set; }

        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustProv { get; set; }
        public string CustPostal { get; set; }
        public string CustCountry { get; set; }
        public string CustHomePhone { get; set; }
        public string CustBusPhone { get; set; }
        public string CustEmail { get; set; }
    }
}