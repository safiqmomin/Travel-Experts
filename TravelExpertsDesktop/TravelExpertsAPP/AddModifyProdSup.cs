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
/***************************************************************
* Author : Robert Clements
* Date : 23th July, 2018
* Purpose: allows user to add or modify product supplier table
***************************************************************/
namespace TravelExpertsAPP
{
    public partial class AddModifyProdSup : Form
    {
        public bool addPackageProdSup; //holds true or false value
        public Product_Supplier productSupplier;
        public Package package;
        public Product product;
        public Supplier supplier;
        public Packages_Products_Suppliers packProdSup;
        public AddModifyProdSup()
        {
            InitializeComponent();
        }

        private void AddModifyProdSup_Load(object sender, EventArgs e)
        {
            this.LoadComboBox(); //loads the combo boxs with the values from the product and supplier table
            if (addPackageProdSup) //if user pressed add button
            {
                this.Text = "Add Product Supplier";
                cbProdName.SelectedIndex = -1; //makes combo box value blank
                cbSupName.SelectedIndex = -1;
            }
            else // if user picks modify button on main form
            {
                cbProdName.SelectedValue = packProdSup.ProductID;
                cbSupName.SelectedValue = packProdSup.SupplierID;
                this.Text = "Modify Product Supplier";
            }
        }

        //method for filling combox box with values
        private void LoadComboBox()
        {
            List<Product> products = new List<Product>();
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                products = ProductDB.GetAllProduct(); //getting all products from database 
                cbProdName.DataSource = products;
                cbProdName.DisplayMember = "ProdName";
                cbProdName.ValueMember = "ProductID";

                suppliers = SupplierDB.GetAllSuppliers(); //getting all suppliers from database
                cbSupName.DataSource = suppliers;
                cbSupName.DisplayMember = "SupName";
                cbSupName.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
        /// <summary>
        /// 
        /// </summary>
   
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidData()) //making sure data is valid
            {
                if (addPackageProdSup) // if user clciked the add button
                {
                    productSupplier = new Product_Supplier();
                    this.ProductSupplierData(productSupplier);
                    try
                    {
                        productSupplier.ProductSupplierID = Product_SupplierDB.AddProduct_Supplier(productSupplier);
                        Packages_Products_SuppliersDB.Add(productSupplier, package);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else //if user clicks modify button
                {
                    Product_Supplier newProductSupplier = new Product_Supplier();
                    newProductSupplier.ProductSupplierID = packProdSup.ProductSupplerID;
                    this.ProductSupplierData(newProductSupplier);
                    try
                    {
                        if (!Product_SupplierDB.UpdateProduct_Supplier_Packages(packProdSup, newProductSupplier)) //if product update was unsuccessful
                        {
                            MessageBox.Show("Another user has updated or " +
                                    "deleted that customer.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        private bool ValidData()
        {
            //checks to see if value is accepted
            return
                Validator.IsPresent(cbSupName) &&
                Validator.IsPresent(cbProdName);
        }
        //sets the productSupplier value selected by user to the productSuppler object
        private void ProductSupplierData(Product_Supplier productSupplier)
        {
            productSupplier.ProductID = Convert.ToInt32(cbProdName.SelectedValue);
            productSupplier.SupplierID = Convert.ToInt32(cbSupName.SelectedValue);
        }
        //event for if the product combo box selection has changed
        //display the corresponding supplier for the product
        private void cbProdName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbSupName.SelectedValue = -1;
            List<Supplier> suppliers = new List<Supplier>();
            product = new Product();
            product.ProductID = (int)cbProdName.SelectedValue;
            suppliers = SupplierDB.GetSuppliersForProducts(product);
            cbSupName.DataSource = suppliers;
            cbSupName.DisplayMember = "SupName";
            cbSupName.ValueMember = "SupplierId";
        }
    }
}
