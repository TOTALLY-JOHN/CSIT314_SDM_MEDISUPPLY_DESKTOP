namespace CSIT314_project
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addOICButton = new System.Windows.Forms.Button();
            this.editOICButton = new System.Windows.Forms.Button();
            this.deleteOICButton = new System.Windows.Forms.Button();
            this.deleteContactPersonButton = new System.Windows.Forms.Button();
            this.editContactPersonButton = new System.Windows.Forms.Button();
            this.addContactPersonButton = new System.Windows.Forms.Button();
            this.printOrderReportButton = new System.Windows.Forms.Button();
            this.printInventoryReportButton = new System.Windows.Forms.Button();
            this.viewOICButton = new System.Windows.Forms.Button();
            this.viewContactPersonButton = new System.Windows.Forms.Button();
            this.viewClinicButton = new System.Windows.Forms.Button();
            this.deleteClinicButton = new System.Windows.Forms.Button();
            this.editClinicButton = new System.Windows.Forms.Button();
            this.addClinicButton = new System.Windows.Forms.Button();
            this.viewOrderButton = new System.Windows.Forms.Button();
            this.viewInventoryButton = new System.Windows.Forms.Button();
            this.deleteInventoryButton = new System.Windows.Forms.Button();
            this.editInventoryButton = new System.Windows.Forms.Button();
            this.addInventoryButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.unlockButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(29, 17);
            this.currentUserLabel.TabIndex = 1;
            this.currentUserLabel.Text = "Hi, ";
            this.currentUserLabel.Click += new System.EventHandler(this.currentUserLabel_Click);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(165, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 0;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // addOICButton
            // 
            this.addOICButton.BackColor = System.Drawing.SystemColors.Control;
            this.addOICButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addOICButton.BackgroundImage")));
            this.addOICButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOICButton.Location = new System.Drawing.Point(32, 26);
            this.addOICButton.Name = "addOICButton";
            this.addOICButton.Size = new System.Drawing.Size(65, 85);
            this.addOICButton.TabIndex = 2;
            this.addOICButton.UseVisualStyleBackColor = false;
            this.addOICButton.Click += new System.EventHandler(this.addOICButton_Click);
            // 
            // editOICButton
            // 
            this.editOICButton.BackColor = System.Drawing.SystemColors.Control;
            this.editOICButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editOICButton.BackgroundImage")));
            this.editOICButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOICButton.Location = new System.Drawing.Point(140, 26);
            this.editOICButton.Name = "editOICButton";
            this.editOICButton.Size = new System.Drawing.Size(65, 85);
            this.editOICButton.TabIndex = 3;
            this.editOICButton.UseVisualStyleBackColor = false;
            this.editOICButton.Click += new System.EventHandler(this.editOICButton_Click);
            // 
            // deleteOICButton
            // 
            this.deleteOICButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteOICButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteOICButton.BackgroundImage")));
            this.deleteOICButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOICButton.Location = new System.Drawing.Point(248, 26);
            this.deleteOICButton.Name = "deleteOICButton";
            this.deleteOICButton.Size = new System.Drawing.Size(65, 85);
            this.deleteOICButton.TabIndex = 4;
            this.deleteOICButton.UseVisualStyleBackColor = false;
            this.deleteOICButton.Click += new System.EventHandler(this.deleteOICButton_Click);
            // 
            // deleteContactPersonButton
            // 
            this.deleteContactPersonButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteContactPersonButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteContactPersonButton.BackgroundImage")));
            this.deleteContactPersonButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteContactPersonButton.Location = new System.Drawing.Point(248, 26);
            this.deleteContactPersonButton.Name = "deleteContactPersonButton";
            this.deleteContactPersonButton.Size = new System.Drawing.Size(65, 85);
            this.deleteContactPersonButton.TabIndex = 7;
            this.deleteContactPersonButton.UseVisualStyleBackColor = false;
            this.deleteContactPersonButton.Click += new System.EventHandler(this.deleteContactPersonButton_Click);
            // 
            // editContactPersonButton
            // 
            this.editContactPersonButton.BackColor = System.Drawing.SystemColors.Control;
            this.editContactPersonButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editContactPersonButton.BackgroundImage")));
            this.editContactPersonButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editContactPersonButton.Location = new System.Drawing.Point(140, 26);
            this.editContactPersonButton.Name = "editContactPersonButton";
            this.editContactPersonButton.Size = new System.Drawing.Size(65, 85);
            this.editContactPersonButton.TabIndex = 6;
            this.editContactPersonButton.UseVisualStyleBackColor = false;
            this.editContactPersonButton.Click += new System.EventHandler(this.editContactPersonButton_Click);
            // 
            // addContactPersonButton
            // 
            this.addContactPersonButton.BackColor = System.Drawing.SystemColors.Control;
            this.addContactPersonButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addContactPersonButton.BackgroundImage")));
            this.addContactPersonButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContactPersonButton.Location = new System.Drawing.Point(32, 26);
            this.addContactPersonButton.Name = "addContactPersonButton";
            this.addContactPersonButton.Size = new System.Drawing.Size(65, 85);
            this.addContactPersonButton.TabIndex = 5;
            this.addContactPersonButton.UseVisualStyleBackColor = false;
            this.addContactPersonButton.Click += new System.EventHandler(this.addContactPersonButton_Click);
            // 
            // printOrderReportButton
            // 
            this.printOrderReportButton.BackColor = System.Drawing.SystemColors.Control;
            this.printOrderReportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printOrderReportButton.BackgroundImage")));
            this.printOrderReportButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printOrderReportButton.Location = new System.Drawing.Point(128, 26);
            this.printOrderReportButton.Name = "printOrderReportButton";
            this.printOrderReportButton.Size = new System.Drawing.Size(65, 85);
            this.printOrderReportButton.TabIndex = 8;
            this.printOrderReportButton.UseVisualStyleBackColor = false;
            this.printOrderReportButton.Click += new System.EventHandler(this.printOrderReportButton_Click);
            // 
            // printInventoryReportButton
            // 
            this.printInventoryReportButton.BackColor = System.Drawing.SystemColors.Control;
            this.printInventoryReportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printInventoryReportButton.BackgroundImage")));
            this.printInventoryReportButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInventoryReportButton.Location = new System.Drawing.Point(249, 26);
            this.printInventoryReportButton.Name = "printInventoryReportButton";
            this.printInventoryReportButton.Size = new System.Drawing.Size(65, 85);
            this.printInventoryReportButton.TabIndex = 9;
            this.printInventoryReportButton.UseVisualStyleBackColor = false;
            this.printInventoryReportButton.Click += new System.EventHandler(this.printInventoryReportButton_Click);
            // 
            // viewOICButton
            // 
            this.viewOICButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewOICButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewOICButton.BackgroundImage")));
            this.viewOICButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOICButton.Location = new System.Drawing.Point(358, 26);
            this.viewOICButton.Name = "viewOICButton";
            this.viewOICButton.Size = new System.Drawing.Size(65, 85);
            this.viewOICButton.TabIndex = 11;
            this.viewOICButton.UseVisualStyleBackColor = false;
            this.viewOICButton.Click += new System.EventHandler(this.viewOICButton_Click);
            // 
            // viewContactPersonButton
            // 
            this.viewContactPersonButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewContactPersonButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewContactPersonButton.BackgroundImage")));
            this.viewContactPersonButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewContactPersonButton.Location = new System.Drawing.Point(358, 26);
            this.viewContactPersonButton.Name = "viewContactPersonButton";
            this.viewContactPersonButton.Size = new System.Drawing.Size(65, 85);
            this.viewContactPersonButton.TabIndex = 12;
            this.viewContactPersonButton.UseVisualStyleBackColor = false;
            this.viewContactPersonButton.Click += new System.EventHandler(this.viewContactPersonButton_Click);
            // 
            // viewClinicButton
            // 
            this.viewClinicButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewClinicButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewClinicButton.BackgroundImage")));
            this.viewClinicButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewClinicButton.Location = new System.Drawing.Point(358, 26);
            this.viewClinicButton.Name = "viewClinicButton";
            this.viewClinicButton.Size = new System.Drawing.Size(65, 85);
            this.viewClinicButton.TabIndex = 16;
            this.viewClinicButton.UseVisualStyleBackColor = false;
            this.viewClinicButton.Click += new System.EventHandler(this.viewClinicButton_Click);
            // 
            // deleteClinicButton
            // 
            this.deleteClinicButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteClinicButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteClinicButton.BackgroundImage")));
            this.deleteClinicButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClinicButton.Location = new System.Drawing.Point(248, 26);
            this.deleteClinicButton.Name = "deleteClinicButton";
            this.deleteClinicButton.Size = new System.Drawing.Size(65, 85);
            this.deleteClinicButton.TabIndex = 15;
            this.deleteClinicButton.UseVisualStyleBackColor = false;
            this.deleteClinicButton.Click += new System.EventHandler(this.deleteClinicButton_Click);
            // 
            // editClinicButton
            // 
            this.editClinicButton.BackColor = System.Drawing.SystemColors.Control;
            this.editClinicButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editClinicButton.BackgroundImage")));
            this.editClinicButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClinicButton.Location = new System.Drawing.Point(140, 26);
            this.editClinicButton.Name = "editClinicButton";
            this.editClinicButton.Size = new System.Drawing.Size(65, 85);
            this.editClinicButton.TabIndex = 14;
            this.editClinicButton.UseVisualStyleBackColor = false;
            this.editClinicButton.Click += new System.EventHandler(this.editClinicButton_Click);
            // 
            // addClinicButton
            // 
            this.addClinicButton.BackColor = System.Drawing.SystemColors.Control;
            this.addClinicButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addClinicButton.BackgroundImage")));
            this.addClinicButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClinicButton.Location = new System.Drawing.Point(32, 26);
            this.addClinicButton.Name = "addClinicButton";
            this.addClinicButton.Size = new System.Drawing.Size(65, 85);
            this.addClinicButton.TabIndex = 13;
            this.addClinicButton.UseVisualStyleBackColor = false;
            this.addClinicButton.Click += new System.EventHandler(this.addClinicButton_Click);
            // 
            // viewOrderButton
            // 
            this.viewOrderButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewOrderButton.BackgroundImage")));
            this.viewOrderButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderButton.Location = new System.Drawing.Point(358, 27);
            this.viewOrderButton.Name = "viewOrderButton";
            this.viewOrderButton.Size = new System.Drawing.Size(65, 85);
            this.viewOrderButton.TabIndex = 20;
            this.viewOrderButton.UseVisualStyleBackColor = false;
            this.viewOrderButton.Click += new System.EventHandler(this.viewOrderButton_Click);
            // 
            // viewInventoryButton
            // 
            this.viewInventoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewInventoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewInventoryButton.BackgroundImage")));
            this.viewInventoryButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInventoryButton.Location = new System.Drawing.Point(358, 26);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(65, 85);
            this.viewInventoryButton.TabIndex = 24;
            this.viewInventoryButton.UseVisualStyleBackColor = false;
            this.viewInventoryButton.Click += new System.EventHandler(this.viewInventoryButton_Click);
            // 
            // deleteInventoryButton
            // 
            this.deleteInventoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteInventoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteInventoryButton.BackgroundImage")));
            this.deleteInventoryButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInventoryButton.Location = new System.Drawing.Point(248, 26);
            this.deleteInventoryButton.Name = "deleteInventoryButton";
            this.deleteInventoryButton.Size = new System.Drawing.Size(65, 85);
            this.deleteInventoryButton.TabIndex = 23;
            this.deleteInventoryButton.UseVisualStyleBackColor = false;
            this.deleteInventoryButton.Click += new System.EventHandler(this.deleteInventoryButton_Click);
            // 
            // editInventoryButton
            // 
            this.editInventoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.editInventoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editInventoryButton.BackgroundImage")));
            this.editInventoryButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInventoryButton.Location = new System.Drawing.Point(140, 26);
            this.editInventoryButton.Name = "editInventoryButton";
            this.editInventoryButton.Size = new System.Drawing.Size(65, 85);
            this.editInventoryButton.TabIndex = 22;
            this.editInventoryButton.UseVisualStyleBackColor = false;
            this.editInventoryButton.Click += new System.EventHandler(this.editInventoryButton_Click);
            // 
            // addInventoryButton
            // 
            this.addInventoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.addInventoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addInventoryButton.BackgroundImage")));
            this.addInventoryButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryButton.Location = new System.Drawing.Point(32, 26);
            this.addInventoryButton.Name = "addInventoryButton";
            this.addInventoryButton.Size = new System.Drawing.Size(65, 85);
            this.addInventoryButton.TabIndex = 21;
            this.addInventoryButton.UseVisualStyleBackColor = false;
            this.addInventoryButton.Click += new System.EventHandler(this.addInventoryButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(10, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 163);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addOICButton);
            this.tabPage1.Controls.Add(this.editOICButton);
            this.tabPage1.Controls.Add(this.deleteOICButton);
            this.tabPage1.Controls.Add(this.viewOICButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Officer-in-charge";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addContactPersonButton);
            this.tabPage2.Controls.Add(this.editContactPersonButton);
            this.tabPage2.Controls.Add(this.deleteContactPersonButton);
            this.tabPage2.Controls.Add(this.viewContactPersonButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contact Person";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteClinicButton);
            this.tabPage3.Controls.Add(this.addClinicButton);
            this.tabPage3.Controls.Add(this.editClinicButton);
            this.tabPage3.Controls.Add(this.viewClinicButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(454, 137);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clinic";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deleteOrderButton);
            this.tabPage4.Controls.Add(this.editOrderButton);
            this.tabPage4.Controls.Add(this.addOrderButton);
            this.tabPage4.Controls.Add(this.viewOrderButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(454, 137);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Order";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.addInventoryButton);
            this.tabPage5.Controls.Add(this.viewInventoryButton);
            this.tabPage5.Controls.Add(this.editInventoryButton);
            this.tabPage5.Controls.Add(this.deleteInventoryButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(454, 137);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Inventory";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.printOrderReportButton);
            this.tabPage6.Controls.Add(this.printInventoryReportButton);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(454, 137);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Print Report";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.Location = new System.Drawing.Point(403, 310);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 85);
            this.exitButton.TabIndex = 43;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "MediSupply Inventory System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(13, 35);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 45;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // unlockButton
            // 
            this.unlockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unlockButton.BackgroundImage")));
            this.unlockButton.Location = new System.Drawing.Point(310, 310);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(65, 85);
            this.unlockButton.TabIndex = 46;
            this.unlockButton.UseVisualStyleBackColor = true;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.SystemColors.Control;
            this.addOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addOrderButton.BackgroundImage")));
            this.addOrderButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderButton.Location = new System.Drawing.Point(32, 26);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(65, 85);
            this.addOrderButton.TabIndex = 21;
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click_1);
            // 
            // editOrderButton
            // 
            this.editOrderButton.BackColor = System.Drawing.SystemColors.Control;
            this.editOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editOrderButton.BackgroundImage")));
            this.editOrderButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrderButton.Location = new System.Drawing.Point(140, 26);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(65, 85);
            this.editOrderButton.TabIndex = 22;
            this.editOrderButton.UseVisualStyleBackColor = false;
            this.editOrderButton.Click += new System.EventHandler(this.editOrderButton_Click_1);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteOrderButton.BackgroundImage")));
            this.deleteOrderButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderButton.Location = new System.Drawing.Point(248, 27);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(65, 85);
            this.deleteOrderButton.TabIndex = 23;
            this.deleteOrderButton.UseVisualStyleBackColor = false;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click_1);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 407);
            this.Controls.Add(this.unlockButton);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button addOICButton;
        private System.Windows.Forms.Button editOICButton;
        private System.Windows.Forms.Button deleteOICButton;
        private System.Windows.Forms.Button deleteContactPersonButton;
        private System.Windows.Forms.Button editContactPersonButton;
        private System.Windows.Forms.Button addContactPersonButton;
        private System.Windows.Forms.Button printOrderReportButton;
        private System.Windows.Forms.Button printInventoryReportButton;
        private System.Windows.Forms.Button viewOICButton;
        private System.Windows.Forms.Button viewContactPersonButton;
        private System.Windows.Forms.Button viewClinicButton;
        private System.Windows.Forms.Button deleteClinicButton;
        private System.Windows.Forms.Button editClinicButton;
        private System.Windows.Forms.Button addClinicButton;
        private System.Windows.Forms.Button viewOrderButton;
        private System.Windows.Forms.Button viewInventoryButton;
        private System.Windows.Forms.Button deleteInventoryButton;
        private System.Windows.Forms.Button editInventoryButton;
        private System.Windows.Forms.Button addInventoryButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button editOrderButton;
        private System.Windows.Forms.Button addOrderButton;
    }
}