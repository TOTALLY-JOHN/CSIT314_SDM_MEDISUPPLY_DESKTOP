namespace CSIT314_project
{
    partial class editOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editOrderForm));
            this.goBackButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.orderIDInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.deliveryDateInput = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.orderDetailsInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.clinicNameComboBox = new System.Windows.Forms.ComboBox();
            this.itemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.itemQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.orderStatusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(127, 397);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 35);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "GO BACK";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(336, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(81, 31);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(265, 397);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 35);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // orderIDInput
            // 
            this.orderIDInput.Location = new System.Drawing.Point(246, 76);
            this.orderIDInput.Name = "orderIDInput";
            this.orderIDInput.Size = new System.Drawing.Size(83, 21);
            this.orderIDInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Order ID:";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(197, 37);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(105, 24);
            this.titleLabel1.TabIndex = 22;
            this.titleLabel1.Text = "Edit Order";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(29, 17);
            this.currentUserLabel.TabIndex = 21;
            this.currentUserLabel.Text = "Hi, ";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(173, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 20;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // deliveryDateInput
            // 
            this.deliveryDateInput.Location = new System.Drawing.Point(246, 274);
            this.deliveryDateInput.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.deliveryDateInput.Name = "deliveryDateInput";
            this.deliveryDateInput.Size = new System.Drawing.Size(171, 21);
            this.deliveryDateInput.TabIndex = 7;
            this.deliveryDateInput.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "Clinic Name:";
            // 
            // orderDetailsInput
            // 
            this.orderDetailsInput.Location = new System.Drawing.Point(246, 348);
            this.orderDetailsInput.Name = "orderDetailsInput";
            this.orderDetailsInput.Size = new System.Drawing.Size(171, 21);
            this.orderDetailsInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Order Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Date of Delivery:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Item Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Item Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "Order Status:";
            // 
            // itemTypeComboBox
            // 
            this.itemTypeComboBox.FormattingEnabled = true;
            this.itemTypeComboBox.Location = new System.Drawing.Point(246, 195);
            this.itemTypeComboBox.Name = "itemTypeComboBox";
            this.itemTypeComboBox.Size = new System.Drawing.Size(171, 20);
            this.itemTypeComboBox.TabIndex = 5;
            // 
            // clinicNameComboBox
            // 
            this.clinicNameComboBox.FormattingEnabled = true;
            this.clinicNameComboBox.Location = new System.Drawing.Point(246, 116);
            this.clinicNameComboBox.Name = "clinicNameComboBox";
            this.clinicNameComboBox.Size = new System.Drawing.Size(171, 20);
            this.clinicNameComboBox.TabIndex = 3;
            // 
            // itemCategoryComboBox
            // 
            this.itemCategoryComboBox.FormattingEnabled = true;
            this.itemCategoryComboBox.Location = new System.Drawing.Point(246, 155);
            this.itemCategoryComboBox.Name = "itemCategoryComboBox";
            this.itemCategoryComboBox.Size = new System.Drawing.Size(171, 20);
            this.itemCategoryComboBox.TabIndex = 4;
            this.itemCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.itemCategoryComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "Item Category:";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(13, 35);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 66;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // itemQuantityInput
            // 
            this.itemQuantityInput.Location = new System.Drawing.Point(246, 235);
            this.itemQuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.itemQuantityInput.Name = "itemQuantityInput";
            this.itemQuantityInput.Size = new System.Drawing.Size(171, 21);
            this.itemQuantityInput.TabIndex = 67;
            // 
            // orderStatusComboBox
            // 
            this.orderStatusComboBox.FormattingEnabled = true;
            this.orderStatusComboBox.Location = new System.Drawing.Point(246, 312);
            this.orderStatusComboBox.Name = "orderStatusComboBox";
            this.orderStatusComboBox.Size = new System.Drawing.Size(171, 20);
            this.orderStatusComboBox.TabIndex = 8;
            // 
            // editOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 457);
            this.Controls.Add(this.orderStatusComboBox);
            this.Controls.Add(this.itemQuantityInput);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.itemCategoryComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.itemTypeComboBox);
            this.Controls.Add(this.clinicNameComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deliveryDateInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderDetailsInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.orderIDInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "editOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.editOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox orderIDInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.DateTimePicker deliveryDateInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox orderDetailsInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox itemTypeComboBox;
        private System.Windows.Forms.ComboBox clinicNameComboBox;
        private System.Windows.Forms.ComboBox itemCategoryComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.NumericUpDown itemQuantityInput;
        private System.Windows.Forms.ComboBox orderStatusComboBox;
    }
}