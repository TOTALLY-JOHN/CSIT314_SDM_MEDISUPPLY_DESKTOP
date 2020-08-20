namespace CSIT314_project
{
    partial class OICForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OICForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.updateOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.viewOrderButton = new System.Windows.Forms.Button();
            this.printOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(29, 17);
            this.currentUserLabel.TabIndex = 26;
            this.currentUserLabel.Text = "Hi, ";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(133, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 25;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addOrderButton.BackgroundImage")));
            this.addOrderButton.Location = new System.Drawing.Point(55, 123);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(65, 85);
            this.addOrderButton.TabIndex = 36;
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // updateOrderButton
            // 
            this.updateOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateOrderButton.BackgroundImage")));
            this.updateOrderButton.Location = new System.Drawing.Point(164, 123);
            this.updateOrderButton.Name = "updateOrderButton";
            this.updateOrderButton.Size = new System.Drawing.Size(65, 85);
            this.updateOrderButton.TabIndex = 37;
            this.updateOrderButton.UseVisualStyleBackColor = true;
            this.updateOrderButton.Click += new System.EventHandler(this.updateOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteOrderButton.BackgroundImage")));
            this.deleteOrderButton.Location = new System.Drawing.Point(272, 123);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(65, 85);
            this.deleteOrderButton.TabIndex = 38;
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // viewOrderButton
            // 
            this.viewOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewOrderButton.BackgroundImage")));
            this.viewOrderButton.Location = new System.Drawing.Point(55, 243);
            this.viewOrderButton.Name = "viewOrderButton";
            this.viewOrderButton.Size = new System.Drawing.Size(65, 85);
            this.viewOrderButton.TabIndex = 39;
            this.viewOrderButton.UseVisualStyleBackColor = true;
            this.viewOrderButton.Click += new System.EventHandler(this.viewOrderButton_Click);
            // 
            // printOrderButton
            // 
            this.printOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printOrderButton.BackgroundImage")));
            this.printOrderButton.Location = new System.Drawing.Point(164, 243);
            this.printOrderButton.Name = "printOrderButton";
            this.printOrderButton.Size = new System.Drawing.Size(65, 85);
            this.printOrderButton.TabIndex = 40;
            this.printOrderButton.UseVisualStyleBackColor = true;
            this.printOrderButton.Click += new System.EventHandler(this.printOrderButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "MediSupply Inventory System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.Location = new System.Drawing.Point(272, 243);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 85);
            this.exitButton.TabIndex = 42;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(13, 35);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 46;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // OICForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 357);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printOrderButton);
            this.Controls.Add(this.viewOrderButton);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.updateOrderButton);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OICForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.OICForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button updateOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button viewOrderButton;
        private System.Windows.Forms.Button printOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.LinkLabel logoutLabel;
    }
}