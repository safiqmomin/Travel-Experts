namespace TravelExpertsAPP
{
    partial class AddModifyProductsSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label supplierIdLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdSupplierID = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbProductId = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            productIDLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(36, 63);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 8;
            productIDLabel.Text = "Product ID:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(36, 90);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(62, 13);
            supplierIdLabel.TabIndex = 9;
            supplierIdLabel.Text = "Supplier ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Supplier ID:";
            // 
            // txtProdSupplierID
            // 
            this.txtProdSupplierID.Location = new System.Drawing.Point(158, 32);
            this.txtProdSupplierID.Name = "txtProdSupplierID";
            this.txtProdSupplierID.ReadOnly = true;
            this.txtProdSupplierID.Size = new System.Drawing.Size(75, 20);
            this.txtProdSupplierID.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(158, 140);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(249, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbProductId
            // 
            this.cbProductId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.cbProductId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductID", true));
            this.cbProductId.FormattingEnabled = true;
            this.cbProductId.Location = new System.Drawing.Point(158, 63);
            this.cbProductId.Name = "cbProductId";
            this.cbProductId.Size = new System.Drawing.Size(166, 21);
            this.cbProductId.TabIndex = 9;
            this.cbProductId.Tag = "Product ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TravelExpertsLibrary.Product);
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierId", true));
            this.cbSupplierID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "SupplierId", true));
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(158, 90);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(166, 21);
            this.cbSupplierID.TabIndex = 10;
            this.cbSupplierID.Tag = "Supplier ID";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TravelExpertsLibrary.Supplier);
            // 
            // AddModifyProductsSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(370, 200);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.cbSupplierID);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.cbProductId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtProdSupplierID);
            this.Controls.Add(this.label1);
            this.Name = "AddModifyProductsSupplier";
            this.Text = "AddModifyProductsSupplier";
            this.Load += new System.EventHandler(this.AddModifyProductsSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdSupplierID;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ComboBox cbProductId;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ComboBox cbSupplierID;
    }
}