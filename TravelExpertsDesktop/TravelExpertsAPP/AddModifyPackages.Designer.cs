namespace TravelExpertsAPP
{
    partial class AddModifyPackages
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
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPkgDescription = new System.Windows.Forms.TextBox();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.packages_Products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(38, 34);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(65, 13);
            packageIdLabel.TabIndex = 1;
            packageIdLabel.Text = "Package Id:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(38, 140);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(109, 13);
            pkgDescLabel.TabIndex = 7;
            pkgDescLabel.Text = "Package Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(38, 114);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(101, 13);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "Package End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(38, 58);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(84, 13);
            pkgNameLabel.TabIndex = 11;
            pkgNameLabel.Text = "Package Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(38, 84);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(104, 13);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Package Start Date:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(38, 170);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(107, 13);
            pkgBasePriceLabel.TabIndex = 19;
            pkgBasePriceLabel.Text = "Package Base Price:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(38, 199);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 17;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // txtPackageId
            // 
            this.txtPackageId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.txtPackageId.Location = new System.Drawing.Point(173, 31);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.ReadOnly = true;
            this.txtPackageId.Size = new System.Drawing.Size(200, 20);
            this.txtPackageId.TabIndex = 2;
            this.txtPackageId.Tag = "PackageID";
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertsLibrary.Package);
            // 
            // txtPkgDescription
            // 
            this.txtPkgDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.txtPkgDescription.Location = new System.Drawing.Point(173, 140);
            this.txtPkgDescription.Name = "txtPkgDescription";
            this.txtPkgDescription.Size = new System.Drawing.Size(200, 20);
            this.txtPkgDescription.TabIndex = 8;
            this.txtPkgDescription.Tag = "Package Description";
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Location = new System.Drawing.Point(173, 114);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPkgEndDate.TabIndex = 10;
            this.dtpPkgEndDate.Tag = "Package End Date";
            // 
            // txtPkgName
            // 
            this.txtPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.txtPkgName.Location = new System.Drawing.Point(173, 58);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(200, 20);
            this.txtPkgName.TabIndex = 12;
            this.txtPkgName.Tag = "Package Name";
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Location = new System.Drawing.Point(173, 84);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPkgStartDate.TabIndex = 14;
            this.dtpPkgStartDate.Tag = "Package Start Date";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(173, 247);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(298, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // packages_Products_SuppliersBindingSource
            // 
            this.packages_Products_SuppliersBindingSource.DataSource = typeof(TravelExpertsLibrary.Packages_Products_Suppliers);
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.txtBasePrice.Location = new System.Drawing.Point(173, 170);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(200, 20);
            this.txtBasePrice.TabIndex = 20;
            this.txtBasePrice.Tag = "Package Base Price";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(173, 199);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(200, 20);
            this.txtPkgAgencyCommission.TabIndex = 18;
            this.txtPkgAgencyCommission.Tag = "Package Agency Commission";
            // 
            // AddModifyPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(430, 303);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.txtPkgAgencyCommission);
            this.Controls.Add(packageIdLabel);
            this.Controls.Add(this.dtpPkgStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.dtpPkgEndDate);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.txtPkgDescription);
            this.Controls.Add(pkgEndDateLabel);
            this.Name = "AddModifyPackages";
            this.Text = "AddModifyPackages";
            this.Load += new System.EventHandler(this.AddModifyPackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.TextBox txtPkgDescription;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource packages_Products_SuppliersBindingSource;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
    }
}