namespace CSIT314_project
{
    partial class addOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrderForm));
            this.label7 = new System.Windows.Forms.Label();
            this.orderDetailsInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.deliveryDateInput = new System.Windows.Forms.DateTimePicker();
            this.clinicNameComboBox = new System.Windows.Forms.ComboBox();
            this.itemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.itemQuantityInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Item Category:";
            // 
            // orderDetailsInput
            // 
            this.orderDetailsInput.Location = new System.Drawing.Point(237, 263);
            this.orderDetailsInput.Name = "orderDetailsInput";
            this.orderDetailsInput.Size = new System.Drawing.Size(171, 21);
            this.orderDetailsInput.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Order Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date of Delivery:";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(29, 17);
            this.currentUserLabel.TabIndex = 41;
            this.currentUserLabel.Text = "Hi, ";
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(118, 318);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 35);
            this.goBackButton.TabIndex = 46;
            this.goBackButton.Text = "GO BACK";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(268, 318);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 35);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Item Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Clinic Name:";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(167, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 40;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(193, 38);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(104, 24);
            this.titleLabel1.TabIndex = 43;
            this.titleLabel1.Text = "Add Order";
            // 
            // deliveryDateInput
            // 
            this.deliveryDateInput.Location = new System.Drawing.Point(237, 227);
            this.deliveryDateInput.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.deliveryDateInput.Name = "deliveryDateInput";
            this.deliveryDateInput.Size = new System.Drawing.Size(171, 21);
            this.deliveryDateInput.TabIndex = 51;
            this.deliveryDateInput.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // clinicNameComboBox
            // 
            this.clinicNameComboBox.FormattingEnabled = true;
            this.clinicNameComboBox.Location = new System.Drawing.Point(237, 79);
            this.clinicNameComboBox.Name = "clinicNameComboBox";
            this.clinicNameComboBox.Size = new System.Drawing.Size(171, 20);
            this.clinicNameComboBox.TabIndex = 52;
            // 
            // itemCategoryComboBox
            // 
            this.itemCategoryComboBox.FormattingEnabled = true;
            this.itemCategoryComboBox.Location = new System.Drawing.Point(237, 117);
            this.itemCategoryComboBox.Name = "itemCategoryComboBox";
            this.itemCategoryComboBox.Size = new System.Drawing.Size(171, 20);
            this.itemCategoryComboBox.TabIndex = 53;
            this.itemCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.itemCategoryComboBox_SelectedIndexChanged);
            // 
            // itemTypeComboBox
            // 
            this.itemTypeComboBox.FormattingEnabled = true;
            this.itemTypeComboBox.Location = new System.Drawing.Point(237, 154);
            this.itemTypeComboBox.Name = "itemTypeComboBox";
            this.itemTypeComboBox.Size = new System.Drawing.Size(171, 20);
            this.itemTypeComboBox.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Item Type:";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(13, 35);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 56;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // itemQuantityInput
            // 
            this.itemQuantityInput.Location = new System.Drawing.Point(237, 190);
            this.itemQuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.itemQuantityInput.Name = "itemQuantityInput";
            this.itemQuantityInput.Size = new System.Drawing.Size(171, 21);
            this.itemQuantityInput.TabIndex = 57;
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 365);
            this.Controls.Add(this.itemQuantityInput);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.itemTypeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemCategoryComboBox);
            this.Controls.Add(this.clinicNameComboBox);
            this.Controls.Add(this.deliveryDateInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderDetailsInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.titleLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.addOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox orderDetailsInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.DateTimePicker deliveryDateInput;
        private System.Windows.Forms.ComboBox clinicNameComboBox;
        private System.Windows.Forms.ComboBox itemCategoryComboBox;
        private System.Windows.Forms.ComboBox itemTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.NumericUpDown itemQuantityInput;
    }
}