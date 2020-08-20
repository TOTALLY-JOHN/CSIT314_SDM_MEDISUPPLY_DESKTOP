namespace CSIT314_project
{
    partial class printInventoryReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printInventoryReportForm));
            this.goBackButton = new System.Windows.Forms.Button();
            this.printInventoryButton2 = new System.Windows.Forms.Button();
            this.printInventoryButton1 = new System.Windows.Forms.Button();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.categoryInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(183, 290);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(115, 35);
            this.goBackButton.TabIndex = 25;
            this.goBackButton.Text = "GO BACK";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // printInventoryButton2
            // 
            this.printInventoryButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInventoryButton2.Location = new System.Drawing.Point(234, 205);
            this.printInventoryButton2.Name = "printInventoryButton2";
            this.printInventoryButton2.Size = new System.Drawing.Size(157, 57);
            this.printInventoryButton2.TabIndex = 24;
            this.printInventoryButton2.Text = "Print Inventory Report By Critical Quantity";
            this.printInventoryButton2.UseVisualStyleBackColor = true;
            this.printInventoryButton2.Click += new System.EventHandler(this.printInventoryButton2_Click);
            // 
            // printInventoryButton1
            // 
            this.printInventoryButton1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInventoryButton1.Location = new System.Drawing.Point(232, 118);
            this.printInventoryButton1.Name = "printInventoryButton1";
            this.printInventoryButton1.Size = new System.Drawing.Size(159, 55);
            this.printInventoryButton1.TabIndex = 23;
            this.printInventoryButton1.Text = "Print Inventory Report By Category";
            this.printInventoryButton1.UseVisualStyleBackColor = true;
            this.printInventoryButton1.Click += new System.EventHandler(this.printInventoryButton1_Click);
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(137, 67);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(215, 24);
            this.titleLabel1.TabIndex = 22;
            this.titleLabel1.Text = "Print Inventory Report";
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
            this.dateTimeLabel.Location = new System.Drawing.Point(171, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 20;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(13, 35);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 48;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(104, 224);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(100, 21);
            this.quantityInput.TabIndex = 52;
            // 
            // categoryInput
            // 
            this.categoryInput.Location = new System.Drawing.Point(104, 136);
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(100, 21);
            this.categoryInput.TabIndex = 51;
            // 
            // printInventoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 337);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.categoryInput);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.printInventoryButton2);
            this.Controls.Add(this.printInventoryButton1);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "printInventoryReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.printInventoryReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button printInventoryButton2;
        private System.Windows.Forms.Button printInventoryButton1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.TextBox categoryInput;
    }
}