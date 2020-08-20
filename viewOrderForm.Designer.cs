namespace CSIT314_project
{
    partial class viewOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewOrderForm));
            this.goBackButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.displayButtonByMonth = new System.Windows.Forms.Button();
            this.displayButtonByClinicName = new System.Windows.Forms.Button();
            this.displayButtonByArea = new System.Windows.Forms.Button();
            this.displayButtonByOrderStatus = new System.Windows.Forms.Button();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.searchInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(392, 446);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 35);
            this.goBackButton.TabIndex = 17;
            this.goBackButton.Text = "GO BACK";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(836, 264);
            this.dataGridView1.TabIndex = 16;
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(388, 62);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(114, 24);
            this.titleLabel1.TabIndex = 15;
            this.titleLabel1.Text = "View Order";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(18, 15);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(29, 17);
            this.currentUserLabel.TabIndex = 14;
            this.currentUserLabel.Text = "Hi, ";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(369, 15);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 13;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // displayButtonByMonth
            // 
            this.displayButtonByMonth.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButtonByMonth.Location = new System.Drawing.Point(153, 113);
            this.displayButtonByMonth.Name = "displayButtonByMonth";
            this.displayButtonByMonth.Size = new System.Drawing.Size(155, 35);
            this.displayButtonByMonth.TabIndex = 18;
            this.displayButtonByMonth.Text = "Search by month";
            this.displayButtonByMonth.UseVisualStyleBackColor = true;
            this.displayButtonByMonth.Click += new System.EventHandler(this.displayButtonByMonth_Click);
            // 
            // displayButtonByClinicName
            // 
            this.displayButtonByClinicName.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButtonByClinicName.Location = new System.Drawing.Point(314, 113);
            this.displayButtonByClinicName.Name = "displayButtonByClinicName";
            this.displayButtonByClinicName.Size = new System.Drawing.Size(177, 35);
            this.displayButtonByClinicName.TabIndex = 19;
            this.displayButtonByClinicName.Text = "Search by clinic name";
            this.displayButtonByClinicName.UseVisualStyleBackColor = true;
            this.displayButtonByClinicName.Click += new System.EventHandler(this.displayButtonByClinicName_Click);
            // 
            // displayButtonByArea
            // 
            this.displayButtonByArea.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButtonByArea.Location = new System.Drawing.Point(497, 113);
            this.displayButtonByArea.Name = "displayButtonByArea";
            this.displayButtonByArea.Size = new System.Drawing.Size(132, 35);
            this.displayButtonByArea.TabIndex = 19;
            this.displayButtonByArea.Text = "Search by area";
            this.displayButtonByArea.UseVisualStyleBackColor = true;
            this.displayButtonByArea.Click += new System.EventHandler(this.displayButtonByArea_Click);
            // 
            // displayButtonByOrderStatus
            // 
            this.displayButtonByOrderStatus.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButtonByOrderStatus.Location = new System.Drawing.Point(635, 113);
            this.displayButtonByOrderStatus.Name = "displayButtonByOrderStatus";
            this.displayButtonByOrderStatus.Size = new System.Drawing.Size(186, 35);
            this.displayButtonByOrderStatus.TabIndex = 19;
            this.displayButtonByOrderStatus.Text = "Search by order status";
            this.displayButtonByOrderStatus.UseVisualStyleBackColor = true;
            this.displayButtonByOrderStatus.Click += new System.EventHandler(this.displayButtonByOrderStatus_Click);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(19, 44);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 48;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(36, 119);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(100, 21);
            this.searchInput.TabIndex = 49;
            // 
            // viewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 507);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.displayButtonByOrderStatus);
            this.Controls.Add(this.displayButtonByArea);
            this.Controls.Add(this.displayButtonByClinicName);
            this.Controls.Add(this.displayButtonByMonth);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "viewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.viewOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Button displayButtonByMonth;
        private System.Windows.Forms.Button displayButtonByClinicName;
        private System.Windows.Forms.Button displayButtonByArea;
        private System.Windows.Forms.Button displayButtonByOrderStatus;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.TextBox searchInput;
    }
}