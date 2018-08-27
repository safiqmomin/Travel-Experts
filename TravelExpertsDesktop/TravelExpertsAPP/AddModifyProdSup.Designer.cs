namespace TravelExpertsAPP
{
    partial class AddModifyProdSup
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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            this.cbProdName = new System.Windows.Forms.ComboBox();
            this.packages_Products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSupName = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(21, 35);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(78, 13);
            prodNameLabel.TabIndex = 1;
            prodNameLabel.Text = "Product Name:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(20, 62);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(79, 13);
            supNameLabel.TabIndex = 3;
            supNameLabel.Text = "Supplier Name:";
            // 
            // cbProdName
            // 
            this.cbProdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packages_Products_SuppliersBindingSource, "ProdName", true));
            this.cbProdName.FormattingEnabled = true;
            this.cbProdName.Location = new System.Drawing.Point(106, 35);
            this.cbProdName.Name = "cbProdName";
            this.cbProdName.Size = new System.Drawing.Size(167, 21);
            this.cbProdName.TabIndex = 2;
            this.cbProdName.SelectionChangeCommitted += new System.EventHandler(this.cbProdName_SelectionChangeCommitted);
            // 
            // packages_Products_SuppliersBindingSource
            // 
            this.packages_Products_SuppliersBindingSource.DataSource = typeof(TravelExpertsLibrary.Packages_Products_Suppliers);
            // 
            // cbSupName
            // 
            this.cbSupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packages_Products_SuppliersBindingSource, "SupName", true));
            this.cbSupName.FormattingEnabled = true;
            this.cbSupName.Location = new System.Drawing.Point(106, 62);
            this.cbSupName.Name = "cbSupName";
            this.cbSupName.Size = new System.Drawing.Size(167, 21);
            this.cbSupName.TabIndex = 4;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(106, 105);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(198, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddModifyProdSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(285, 140);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.cbProdName);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.cbSupName);
            this.Name = "AddModifyProdSup";
            this.Text = "AddModifyProdSup";
            this.Load += new System.EventHandler(this.AddModifyProdSup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packages_Products_SuppliersBindingSource;
        private System.Windows.Forms.ComboBox cbProdName;
        private System.Windows.Forms.ComboBox cbSupName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}