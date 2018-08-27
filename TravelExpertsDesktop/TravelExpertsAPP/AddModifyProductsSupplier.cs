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

namespace TravelExpertsAPP
{
    public partial class AddModifyProductsSupplier : Form
    {
        public bool addProductSupplier; //informs page if add or modify button was pressed 
        public Product_Supplier productSupplier;
        public AddModifyProductsSupplier()
        {
            InitializeComponent();
        }

        private void AddModifyProductsSupplier_Load(object sender, EventArgs e)
        {
            this.LoadComboBox(); //load combo boxs with values
            if (addProductSupplier)//if add was pressed
            {
                this.Text = "Add Product Supplier";
                //combo box has no selection
                cbProductId.SelectedIndex = -1;
                cbSupplierID.SelectedIndex = -1;
                txtProdSupplierID.Text = Product_SupplierDB.GetNextProductSupplierID().ToString();//get next id value
            }
            else//modify button was pressed
            {
                this.Text = "Modify Product Supplier";
                DisplayProductSuppliers();
            }
        }
        //fills text box with values passed from prvious form
        private void DisplayProductSuppliers()
        {
            txtProdSupplierID.Text = productSupplier.ProductSupplierID.ToString();
            cbProductId.SelectedValue = productSupplier.ProductID;
            cbSupplierID.SelectedValue = productSupplier.SupplierID;
        }
        //loads the combo boc and sets there display and value property
        private void LoadComboBox()
        {
            List<Product> products = new List<Product>();
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                products = ProductDB.GetAllProduct();
                cbProductId.DataSource = products;
                cbProductId.DisplayMember = "ProdName";
                cbProductId.ValueMember = "ProductID";

                suppliers = SupplierDB.GetAllSuppliers();
                cbSupplierID.DataSource = suppliers;
                cbSupplierID.DisplayMember = "SupName";
                cbSupplierID.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
        //user clicks accept button 
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                if (addProductSupplier) //add button was pressed
                {
                    productSupplier = new Product_Supplier();
                    this.ProductSupplierData(productSupplier); //set the product supplier data to the product supplier object
                    try
                    {
                        productSupplier.ProductSupplierID = Product_SupplierDB.AddProduct_Supplier(productSupplier);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else //modify button was pressed
                {
                    Product_Supplier newProductSupplier = new Product_Supplier();
                    newProductSupplier.ProductSupplierID = productSupplier.ProductSupplierID;
                    this.ProductSupplierData(newProductSupplier);
                    try
                    {
                        if (!Product_SupplierDB.UpdateProduct_Supplier(productSupplier, newProductSupplier))
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
        //checks if text boxs have entered values
        private bool ValidData()
        {
            return
                Validator.IsPresent(cbProductId) &&
                Validator.IsPresent(cbSupplierID);
        }
        //assign product supplier properties with values selected by user
        private void ProductSupplierData(Product_Supplier productSupplier)
        {
            productSupplier.ProductID = Convert.ToInt32(cbProductId.SelectedValue);
            productSupplier.SupplierID = Convert.ToInt32(cbSupplierID.SelectedValue);
        }
    }
}
