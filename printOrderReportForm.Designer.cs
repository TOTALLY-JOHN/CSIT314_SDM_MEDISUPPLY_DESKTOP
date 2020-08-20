namespace CSIT314_project
{
    partial class printOrderReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printOrderReportForm));
            this.printOrderButton1 = new System.Windows.Forms.Button();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.printOrderButton2 = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.monthInput = new System.Windows.Forms.TextBox();
            this.clinicNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // printOrderButton1
            // 
            this.printOrderButton1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printOrderButton1.Location = new System.Drawing.Point(235, 121);
            this.printOrderButton1.Name = "printOrderButton1";
            this.printOrderButton1.Size = new System.Drawing.Size(159, 54);
            this.printOrderButton1.TabIndex = 17;
            this.printOrderButton1.Text = "Print Order Report By Month";
            this.printOrderButton1.UseVisualStyleBackColor = true;
            this.printOrderButton1.Click += new System.EventHandler(this.printOrderButton1_Click);
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(152, 67);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(181, 24);
            this.titleLabel1.TabIndex = 15;
            this.titleLabel1.Text = "Print Order Report";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(29, 17);
            this.currentUserLabel.TabIndex = 14;
            this.currentUserLabel.Text = "Hi, ";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(168, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 13;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // printOrderButton2
            // 
            this.printOrderButton2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printOrderButton2.Location = new System.Drawing.Point(235, 201);
            this.printOrderButton2.Name = "printOrderButton2";
            this.printOrderButton2.Size = new System.Drawing.Size(157, 52);
            this.printOrderButton2.TabIndex = 18;
            this.printOrderButton2.Text = "Print Order Report By Clinic Name";
            this.printOrderButton2.UseVisualStyleBackColor = true;
            this.printOrderButton2.Click += new System.EventHandler(this.printOrderButton2_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(189, 289);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(115, 36);
            this.goBackButton.TabIndex = 19;
            this.goBackButton.Text = "GO BACK";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
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
            // monthInput
            // 
            this.monthInput.Location = new System.Drawing.Point(102, 138);
            this.monthInput.Name = "monthInput";
            this.monthInput.Size = new System.Drawing.Size(100, 21);
            this.monthInput.TabIndex = 49;
            // 
            // clinicNameInput
            // 
            this.clinicNameInput.Location = new System.Drawing.Point(102, 211);
            this.clinicNameInput.Name = "clinicNameInput";
            this.clinicNameInput.Size = new System.Drawing.Size(100, 21);
            this.clinicNameInput.TabIndex = 50;
            // 
            // printOrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 337);
            this.Controls.Add(this.clinicNameInput);
            this.Controls.Add(this.monthInput);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.printOrderButton2);
            this.Controls.Add(this.printOrderButton1);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "printOrderReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "printOrderReportForm";
            this.Load += new System.EventHandler(this.printOrderReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printOrderButton1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Button printOrderButton2;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.TextBox monthInput;
        private System.Windows.Forms.TextBox clinicNameInput;
    }
}