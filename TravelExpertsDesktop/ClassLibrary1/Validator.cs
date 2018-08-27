using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/******************************************************************
 * Author : Sneha Patel(000783907) & Robert
 * Date : 20th July, 2018
 * Purpose: Validator class to validate input fields and conditions.
 ******************************************************************/
namespace TravelExpertsLibrary
{
    /// <summary>
    /// Provides static methods for validating data.
    /// </summary>
    public static class Validator
    {

        /// <summary>
        /// The title for the dialog boxes.
        /// </summary>
        public static string Title { get; set; } = "Entry Error";

        /// <summary>
        /// Checks whether the user entered data into a text box and combo box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered data.</returns>
        public static bool IsPresent(Control control)
        {
            //if control is type textbox
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")//if no user input
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
            }
            //if control is type combo box
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)// if user has not made a selection
                {
                    MessageBox.Show(comboBox.Tag + " is a required field.", "Entry Error");
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks whether the user entered a decimal value into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered a decimal value.</returns>
        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number.", Title);
                textBox.Focus();
                return false;
            }

        }
        /// <summary>
        /// checks to see if textbox is a positve number
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns> true or false, false if number is less then 0 </returns>
        public static bool IsPostive(TextBox textBox)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < 0)
            {
                MessageBox.Show(textBox.Tag + " must be a postive number", Title);
                textBox.Focus();
                return false;
            }
            else
                return true;
    
        }


        /// <summary>
        /// Checks whether the user entered an int value into a text box.
        /// </summary>
        /// <param name="textBox">The text box control to be validated.</param>
        /// <returns>True if the user has entered an int value.</returns>
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// checks if user entered a end date that is past the start date
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>returns a true or false answer, false if start date is bigger than end date stopping it from being entered into the database</returns>
        public static bool EndAfterStart(DateTimePicker startDate, DateTimePicker endDate)
        {
            if (startDate.Value > endDate.Value)
            {
                MessageBox.Show("Package end date must be after package start date.", Title);
                endDate.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// checks if user entered in a larger amount for the agent commission price
        /// </summary>
        /// <param name="basePrice"></param>
        /// <param name="agentCommission"></param>
        /// <returns> returns a false value if agenct commission is larger thatn base price, this stops it from being entered into the database</returns>
        public static bool AgentCommissionLessBasePrice(TextBox basePrice, TextBox agentCommission)
        {
            double baseP = Convert.ToDouble(basePrice.Text);
            double agentC = Convert.ToDouble(agentCommission.Text);
            if (agentC > baseP)
            {
                MessageBox.Show("Agents commission must be less then the base price.", Title);
                agentCommission.Focus();
                return false;
            }
            return true;
        }
    }
}
