using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsWeb.App_Code;

namespace TravelExpertsWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //create an object of CustomerRegistration
        CustomerRegistration cr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData(); 
            }          
        }

        //function fires when clicked on save button
        protected void Register_Click(object sender, EventArgs e)
        {
            //cr = new CustomerRegistration();
            GettingCustomerID();
            //create 2 objects of CustomerRegistration
            CustomerRegistration oldCust = new CustomerRegistration();
            CustomerRegistration newCust = new CustomerRegistration();

            //get data from the fields
                oldCust.CustomerID = Convert.ToInt32(Session["UserID"]);
                newCust.CustFirstName = txtFirstName.Text;
                newCust.CustLastName = txtLastName.Text;
                newCust.CustAddress = txtAddress.Text;
                newCust.CustCity = txtCity.Text;
                newCust.CustProv = txtProv.Text;
                newCust.CustPostal = txtPostal.Text;
                newCust.CustCountry = txtCountry.Text;
                newCust.CustBusPhone = txtBusPhone.Text;
                newCust.CustHomePhone = txtHomePhone.Text;
                newCust.CustEmail = txtEmailID.Text;
  
            try
            {
                //call the function to update the Customer
                if (!CustomerRegistrationDB.updateCustomer(oldCust, newCust))
                {
                    lblSuccess.Text = "PLease enter a valid data";
                }
                else
                {
                    cr = newCust;
                    lblSuccess.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblSuccess.Text = "PLease enter a valid data";
            }           
        }

        //the functio is used to fill data in the object of CustomerRegistration
        protected void FillData()
        {
            cr = new CustomerRegistration();
            GettingCustomerID();
            cr = CustomerRegistrationDB.GetCustomers(Convert.ToInt32(Session["UserID"]));
            txtFirstName.Text = cr.CustFirstName;
            txtLastName.Text = cr.CustLastName;
            txtAddress.Text = cr.CustAddress;
            txtCity.Text = cr.CustCity;
            txtCountry.Text = cr.CustCountry;
            txtProv.Text = cr.CustProv;           
            txtPostal.Text = cr.CustPostal;
            txtBusPhone.Text = cr.CustBusPhone;
            txtHomePhone.Text = cr.CustHomePhone;
            txtEmailID.Text = cr.CustEmail;
        }    
        

        /// <summary>
        /// the function is used to create a session of UserID
        /// </summary>
        protected void GettingCustomerID()
        {
            string userEmail = User.Identity.Name;
            Session["UserID"] = Convert.ToString(CustomerDB.GetCustomerID(userEmail).CustomerId);
        }

        //function gets fired when clicked on reset button
        protected void btnClear_Click(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            FillData();
        }
    }
}