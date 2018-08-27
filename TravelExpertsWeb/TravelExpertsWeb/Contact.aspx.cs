using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*********************************************************************************
 *Author: Sneha Patel(000783907)
 * Date: 29-July-2018
 * Purpose: contact page Inquiry-Form Data send to travel experts's Admin E-mail
 ********************************************************************************/
namespace TravelExpertsWeb
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // submit button event       
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid) //check if valid when page loads
                {
                    MailMessage mailMessage = new MailMessage(); // new empty message
                    mailMessage.From = new MailAddress("travelexpert072018@gmail.com"); // mail address
                    mailMessage.To.Add("travelexpert072018@gmail.com");
                    mailMessage.Subject = txtSubject.Text; // subject goes to subject-line of Mail

                    mailMessage.Body = "<b>Sender Name : </b>" + txtName.Text + "<br/>"
                                     + "<b>Sender Email : </b>" + txtEmail.Text + "<br/>"
                                     + "<b>Comments : </b>" + txtComments.Text; // displays message in mail-body
                    mailMessage.IsBodyHtml = true;

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587); // smtp-client for gmail and port number is 587
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential("travelexpert072018@gmail.com", "TExpert2018"); //Mail-address and password of receiver's here Travel-Experts
                    smtpClient.Send(mailMessage);

                    Label1.ForeColor = System.Drawing.Color.Blue;
                    Label1.Text = "Thank You For Contacting Us !!!"; // display message when successfully send

                    txtName.Enabled = false;
                    txtEmail.Enabled = false;
                    txtSubject.Enabled = false;
                    txtComments.Enabled = false;
                    btnSubmit.Enabled = false;
                }
            }
            catch (Exception)
            {
                // log - event viewer or table
                Label1.ForeColor = System.Drawing.Color.Blue;
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "There is an unknown problem. Please try later"; // display message when not submited message
            }

        }
    }
}