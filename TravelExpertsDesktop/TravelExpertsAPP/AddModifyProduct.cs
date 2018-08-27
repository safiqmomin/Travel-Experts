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

/*
 * Author: Robert Clements
 * Date: July 24, 2018
 */

namespace TravelExpertsAPP
{
    public partial class AddModifyProduct : Form
    {
        public bool addProdcut; //holds boolean to show if add or modify button has been choosen
        public Product product; 
        public AddModifyProduct()
        {
            InitializeComponent();
        }

        private void AddModifyProduct_Load(object sender, EventArgs e)
        {
            if (addProdcut) //if addProduct is true then add button was picked
            {
                this.Text = "Add Product";//changed form title
                txtProdID.Text = ProductDB.GetNextProductID().ToString();
            }
            else //if modify button was picked
            {
                this.Text = "Modify Product";
                this.DisplayProduct();
            }
        }
        //display product information 
        private void DisplayProduct()
        {
            txtProdID.Text = product.ProductID.ToString();
            txtProdName.Text = product.ProdName.ToString();
        }

        //when accept button has been clicked
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                if (addProdcut) //if add button was picked from main form
                {
                    product = new Product();
                    this.ProductData(product); //setting new product name to the name typed by user
                    try
                    {
                        //calling method used to add product to database returing the auto incremented ProdcutID
                        product.ProductID = ProductDB.AddProduct(product);
                        this.DialogResult = DialogResult.OK; //setting dialog result to OK
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else // if modify button was selected from main form
                {
                    Product newProduct = new Product();
                    newProduct.ProductID = product.ProductID;
                    this.ProductData(newProduct);
                    try
                    {
                        if (!ProductDB.UpdateProduct(product, newProduct))
                        {
                            MessageBox.Show("Another user has updated or deleted " + product.ProdName, "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
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

        private bool ValidData()
        {
            return
                Validator.IsPresent(txtProdName);
        }

        //sets product name to product typed by user
        private void ProductData(Product product)
        {
            product.ProdName = txtProdName.Text;
        }
    }
}
