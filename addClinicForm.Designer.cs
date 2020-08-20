namespace CSIT314_project
{
    partial class addClinicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addClinicForm));
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.goBackButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.clinicTelephoneInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clinicAddressInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clinicOICPwdInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clinicDetailsInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clinicNameInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clinicAreaInput = new System.Windows.Forms.TextBox();
            this.clinicOIDInputComboBox = new System.Windows.Forms.ComboBox();
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
            this.currentUserLabel.TabIndex = 15;
            this.currentUserLabel.Text = "Hi, ";
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(126, 368);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 35);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "GO BACK";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(271, 368);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 35);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clinicTelephoneInput
            // 
            this.clinicTelephoneInput.Location = new System.Drawing.Point(241, 218);
            this.clinicTelephoneInput.Name = "clinicTelephoneInput";
            this.clinicTelephoneInput.Size = new System.Drawing.Size(171, 21);
            this.clinicTelephoneInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Clinic Telephone:";
            // 
            // clinicAddressInput
            // 
            this.clinicAddressInput.Location = new System.Drawing.Point(241, 141);
            this.clinicAddressInput.Name = "clinicAddressInput";
            this.clinicAddressInput.Size = new System.Drawing.Size(171, 21);
            this.clinicAddressInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Clinic Address:";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(196, 48);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(102, 24);
            this.titleLabel1.TabIndex = 18;
            this.titleLabel1.Text = "Add Clinic";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(156, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 14;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Clinic\'s OIC Name:";
            // 
            // clinicOICPwdInput
            // 
            this.clinicOICPwdInput.Location = new System.Drawing.Point(241, 290);
            this.clinicOICPwdInput.Name = "clinicOICPwdInput";
            this.clinicOICPwdInput.Size = new System.Drawing.Size(171, 21);
            this.clinicOICPwdInput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "OIC Password:";
            // 
            // clinicDetailsInput
            // 
            this.clinicDetailsInput.Location = new System.Drawing.Point(241, 326);
            this.clinicDetailsInput.MaxLength = 250;
            this.clinicDetailsInput.Name = "clinicDetailsInput";
            this.clinicDetailsInput.Size = new System.Drawing.Size(171, 21);
            this.clinicDetailsInput.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Clinic Details:";
            // 
            // clinicNameInput
            // 
            this.clinicNameInput.Location = new System.Drawing.Point(241, 104);
            this.clinicNameInput.Name = "clinicNameInput";
            this.clinicNameInput.Size = new System.Drawing.Size(171, 21);
            this.clinicNameInput.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Clinic Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Clinic Area:";
            // 
            // clinicAreaInput
            // 
            this.clinicAreaInput.Location = new System.Drawing.Point(241, 180);
            this.clinicAreaInput.Name = "clinicAreaInput";
            this.clinicAreaInput.Size = new System.Drawing.Size(171, 21);
            this.clinicAreaInput.TabIndex = 3;
            // 
            // clinicOIDInputComboBox
            // 
            this.clinicOIDInputComboBox.FormattingEnabled = true;
            this.clinicOIDInputComboBox.Location = new System.Drawing.Point(241, 254);
            this.clinicOIDInputComboBox.Name = "clinicOIDInputComboBox";
            this.clinicOIDInputComboBox.Size = new System.Drawing.Size(171, 20);
            this.clinicOIDInputComboBox.TabIndex = 5;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(13, 35);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 47;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // addClinicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 415);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.clinicOIDInputComboBox);
            this.Controls.Add(this.clinicNameInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clinicDetailsInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clinicOICPwdInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clinicTelephoneInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clinicAreaInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clinicAddressInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.dateTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addClinicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.addClinicForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox clinicTelephoneInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clinicAddressInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clinicOICPwdInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clinicDetailsInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clinicNameInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clinicAreaInput;
        private System.Windows.Forms.ComboBox clinicOIDInputComboBox;
        private System.Windows.Forms.LinkLabel logoutLabel;
    }
}