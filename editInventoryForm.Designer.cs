namespace CSIT314_project
{
    partial class editInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editInventoryForm));
            this.searchButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.inventoryIDInput = new System.Windows.Forms.TextBox();
            this.supplierContactNoInput = new System.Windows.Forms.TextBox();
            this.supplierCompanyInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.supplierNameInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.itemPurposeInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemPictureInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.itemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inventoryDetailsInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.itemOrderStatusInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemBrandInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.itemQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.itemSellingPriceInput = new System.Windows.Forms.NumericUpDown();
            this.itemCostPriceInput = new System.Windows.Forms.NumericUpDown();
            this.criticalQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSellingPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCostPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criticalQuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(342, 83);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(67, 28);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(29, 17);
            this.currentUserLabel.TabIndex = 66;
            this.currentUserLabel.Text = "Hi, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Inventory ID:";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(159, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 65;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(176, 36);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(139, 24);
            this.titleLabel1.TabIndex = 68;
            this.titleLabel1.Text = "Edit Inventory";
            // 
            // inventoryIDInput
            // 
            this.inventoryIDInput.Location = new System.Drawing.Point(238, 86);
            this.inventoryIDInput.Name = "inventoryIDInput";
            this.inventoryIDInput.Size = new System.Drawing.Size(98, 21);
            this.inventoryIDInput.TabIndex = 1;
            // 
            // supplierContactNoInput
            // 
            this.supplierContactNoInput.Location = new System.Drawing.Point(237, 416);
            this.supplierContactNoInput.Name = "supplierContactNoInput";
            this.supplierContactNoInput.Size = new System.Drawing.Size(171, 21);
            this.supplierContactNoInput.TabIndex = 15;
            // 
            // supplierCompanyInput
            // 
            this.supplierCompanyInput.Location = new System.Drawing.Point(238, 362);
            this.supplierCompanyInput.Name = "supplierCompanyInput";
            this.supplierCompanyInput.Size = new System.Drawing.Size(171, 21);
            this.supplierCompanyInput.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(76, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 18);
            this.label13.TabIndex = 111;
            this.label13.Text = "Supplier Contact No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 18);
            this.label9.TabIndex = 110;
            this.label9.Text = "Supplier Company:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 18);
            this.label10.TabIndex = 112;
            this.label10.Text = "Item Cost Price: RM";
            // 
            // supplierNameInput
            // 
            this.supplierNameInput.Location = new System.Drawing.Point(237, 389);
            this.supplierNameInput.Name = "supplierNameInput";
            this.supplierNameInput.Size = new System.Drawing.Size(171, 21);
            this.supplierNameInput.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 18);
            this.label12.TabIndex = 109;
            this.label12.Text = "Supplier Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 18);
            this.label11.TabIndex = 108;
            this.label11.Text = "Item Selling Price: RM";
            // 
            // itemPurposeInput
            // 
            this.itemPurposeInput.Location = new System.Drawing.Point(238, 227);
            this.itemPurposeInput.Name = "itemPurposeInput";
            this.itemPurposeInput.Size = new System.Drawing.Size(171, 21);
            this.itemPurposeInput.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 107;
            this.label8.Text = "Item Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 106;
            this.label6.Text = "Item Purpose:";
            // 
            // itemPictureInput
            // 
            this.itemPictureInput.Location = new System.Drawing.Point(238, 172);
            this.itemPictureInput.Name = "itemPictureInput";
            this.itemPictureInput.ReadOnly = true;
            this.itemPictureInput.Size = new System.Drawing.Size(98, 21);
            this.itemPictureInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 105;
            this.label2.Text = "Item Picture File:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(342, 171);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(66, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 104;
            this.label3.Text = "Item Type:";
            // 
            // itemCategoryComboBox
            // 
            this.itemCategoryComboBox.FormattingEnabled = true;
            this.itemCategoryComboBox.Location = new System.Drawing.Point(238, 116);
            this.itemCategoryComboBox.Name = "itemCategoryComboBox";
            this.itemCategoryComboBox.Size = new System.Drawing.Size(171, 20);
            this.itemCategoryComboBox.TabIndex = 3;
            this.itemCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.itemCategoryComboBox_SelectedIndexChanged);
            // 
            // itemTypeComboBox
            // 
            this.itemTypeComboBox.FormattingEnabled = true;
            this.itemTypeComboBox.Location = new System.Drawing.Point(238, 142);
            this.itemTypeComboBox.Name = "itemTypeComboBox";
            this.itemTypeComboBox.Size = new System.Drawing.Size(171, 20);
            this.itemTypeComboBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 103;
            this.label7.Text = "Item Category:";
            // 
            // inventoryDetailsInput
            // 
            this.inventoryDetailsInput.Location = new System.Drawing.Point(237, 443);
            this.inventoryDetailsInput.Name = "inventoryDetailsInput";
            this.inventoryDetailsInput.Size = new System.Drawing.Size(171, 21);
            this.inventoryDetailsInput.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 102;
            this.label5.Text = "Inventory Details:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "GO BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(271, 500);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 35);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // itemOrderStatusInput
            // 
            this.itemOrderStatusInput.Location = new System.Drawing.Point(238, 254);
            this.itemOrderStatusInput.Name = "itemOrderStatusInput";
            this.itemOrderStatusInput.Size = new System.Drawing.Size(171, 21);
            this.itemOrderStatusInput.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 100;
            this.label4.Text = "Item Order Status:";
            // 
            // itemBrandInput
            // 
            this.itemBrandInput.Location = new System.Drawing.Point(238, 200);
            this.itemBrandInput.Name = "itemBrandInput";
            this.itemBrandInput.Size = new System.Drawing.Size(171, 21);
            this.itemBrandInput.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 18);
            this.label14.TabIndex = 101;
            this.label14.Text = "Item Brand:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(13, 35);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 113;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // itemQuantityInput
            // 
            this.itemQuantityInput.Location = new System.Drawing.Point(238, 281);
            this.itemQuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.itemQuantityInput.Name = "itemQuantityInput";
            this.itemQuantityInput.Size = new System.Drawing.Size(171, 21);
            this.itemQuantityInput.TabIndex = 10;
            // 
            // itemSellingPriceInput
            // 
            this.itemSellingPriceInput.DecimalPlaces = 2;
            this.itemSellingPriceInput.Location = new System.Drawing.Point(238, 335);
            this.itemSellingPriceInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.itemSellingPriceInput.Name = "itemSellingPriceInput";
            this.itemSellingPriceInput.Size = new System.Drawing.Size(171, 21);
            this.itemSellingPriceInput.TabIndex = 12;
            // 
            // itemCostPriceInput
            // 
            this.itemCostPriceInput.DecimalPlaces = 2;
            this.itemCostPriceInput.Location = new System.Drawing.Point(238, 308);
            this.itemCostPriceInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.itemCostPriceInput.Name = "itemCostPriceInput";
            this.itemCostPriceInput.Size = new System.Drawing.Size(171, 21);
            this.itemCostPriceInput.TabIndex = 11;
            // 
            // criticalQuantityInput
            // 
            this.criticalQuantityInput.Location = new System.Drawing.Point(237, 470);
            this.criticalQuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.criticalQuantityInput.Name = "criticalQuantityInput";
            this.criticalQuantityInput.Size = new System.Drawing.Size(171, 21);
            this.criticalQuantityInput.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(90, 470);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 18);
            this.label15.TabIndex = 115;
            this.label15.Text = "Critical Quantity:";
            // 
            // editInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 537);
            this.Controls.Add(this.criticalQuantityInput);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.itemSellingPriceInput);
            this.Controls.Add(this.itemCostPriceInput);
            this.Controls.Add(this.itemQuantityInput);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.supplierContactNoInput);
            this.Controls.Add(this.supplierCompanyInput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.supplierNameInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.itemPurposeInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemPictureInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemCategoryComboBox);
            this.Controls.Add(this.itemTypeComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inventoryDetailsInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.itemOrderStatusInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemBrandInput);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.inventoryIDInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "editInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.editInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSellingPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCostPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criticalQuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.TextBox inventoryIDInput;
        private System.Windows.Forms.TextBox supplierContactNoInput;
        private System.Windows.Forms.TextBox supplierCompanyInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox supplierNameInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox itemPurposeInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemPictureInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox itemCategoryComboBox;
        private System.Windows.Forms.ComboBox itemTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inventoryDetailsInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox itemOrderStatusInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemBrandInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.NumericUpDown itemQuantityInput;
        private System.Windows.Forms.NumericUpDown itemSellingPriceInput;
        private System.Windows.Forms.NumericUpDown itemCostPriceInput;
        private System.Windows.Forms.NumericUpDown criticalQuantityInput;
        private System.Windows.Forms.Label label15;
    }
}