using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsLibrary;
/******************************************************************************************************
 * Author : Sneha Patel & Robert Clements
 * Date : 24th July, 2018
 * Purpose: Create Add-modify Form when user clicks ADD or MODIFY Button in main-form to make changes.
 *******************************************************************************************************/
namespace TravelExpertsAPP
{
    public partial class frmSupplierAddModify : Form
    {
        public bool addSupplier; //informs form if add or modify button was pressed
        public Supplier supplier; // current supplier
        
        public frmSupplierAddModify()
        {
            InitializeComponent();
        }

        private void frmSupplierAddModify_Load(object sender, EventArgs e)
        {
            if (addSupplier)//add button was pressed
            {
                this.Text = "Add Supplier";
                txtSupplierId.Text = SupplierDB.GetNextSupplierID().ToString();//get next supplier id
            }
            else // modify button was pressed
            {
                this.Text = "Modify Supplier";
                this.DisplaySupplier();
            }
        }
        // display the supplier values passed from the previous form
        private void DisplaySupplier()
        {
            txtSupplierId.Text = supplier.SupplierId.ToString();
            txtSupName.Text = supplier.SupName;
        }
        //user pressed accept button
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidData()) //method to validate information
            {
                if (addSupplier) //adding a new value
                {
                    supplier = new Supplier();
                    this.PutSupplierData(supplier);
                    try
                    {
                        if (SupplierDB.AddSupplier(supplier))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else //modify supplier
                {
                    Supplier newSupplier = new Supplier(); //new supplier
                    newSupplier.SupplierId = supplier.SupplierId;
                    this.PutSupplierData(newSupplier);
                    try
                    {
                        if (!SupplierDB.UpdateSupplier(supplier, newSupplier))
                        {
                            MessageBox.Show("Another user has updated or deleted " + supplier.SupName, "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            //supplier = newSupplier;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                } 
            }
        }
        // validating data
        private bool ValidData()
        {
            return
                Validator.IsPresent(txtSupName); //check if text box has entry
        }

        //take values from text box and assign to supplier class
        private void PutSupplierData(Supplier supplier)
        {
            supplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            supplier.SupName = txtSupName.Text;
        }
    }
}
