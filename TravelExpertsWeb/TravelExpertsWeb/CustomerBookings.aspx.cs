using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsWeb.App_Code;

/*******************************************************
 * Author: Brian Liang (Code)
 * Date: July-2018
 * Purpose: Prop for Customer
 *******************************************************/
/*******************************************************
* Author: Sneha Patel (Styling)
* Date: July-2018
* Purpose: Prop for Customer
*******************************************************/

namespace TravelExpertsWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)                      //check to see if the user is logged in
            {
                string userEmail = User.Identity.Name;              //variable to store the value of the user email from authenication
                lblUserEmail.Text = userEmail;

                if(CustomerDB.GetCustomerID(userEmail) == null)     //if the email does not match up with a customer email in Travel Experts database
                {
                    Session["UserID"] = 0;                                              // set the session to zero
                    lblSession.Text = "No Customer Number, please update your account to start booking package";    // notify use there is no associated User ID
                    lblPackageTotal.Text = "$0.00";
                }
                else
                {
                    Session["UserID"] = Convert.ToString(CustomerDB.GetCustomerID(userEmail).CustomerId);

                    lblSession.Text = Convert.ToString(Session["UserID"]);

                    //Total for all the packages for that customer
                    List<PackageTotal> details = PackageTotalDB.GetPackageTotal(Convert.ToString(Session["UserID"])); //list which gets all the information for customerID in the combobox
                    decimal total = 0;              //empty holder for the total
                    foreach (var tot in details)    //for each to go though the details list
                    {
                        total += tot.BasePrice;         //add all of the totals
                    }
                    lblPackageTotal.Text = total.ToString("c");       //converts to string and displays in text box
                }

            }
            else
            {
                Response.Redirect("Account/Login.aspx");            //if not logged in, redirect the user to login page
            }

            
        }
    }
}