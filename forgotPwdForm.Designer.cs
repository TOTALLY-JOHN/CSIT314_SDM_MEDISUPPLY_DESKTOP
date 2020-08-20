namespace CSIT314_project
{
    partial class forgotPwdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPwdForm));
            this.personalQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.personalAnswerInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.userIdInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personalQuestionComboBox
            // 
            this.personalQuestionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personalQuestionComboBox.DropDownWidth = 220;
            this.personalQuestionComboBox.Font = new System.Drawing.Font("굴림", 7.8F);
            this.personalQuestionComboBox.FormattingEnabled = true;
            this.personalQuestionComboBox.Location = new System.Drawing.Point(228, 158);
            this.personalQuestionComboBox.Name = "personalQuestionComboBox";
            this.personalQuestionComboBox.Size = new System.Drawing.Size(171, 18);
            this.personalQuestionComboBox.TabIndex = 59;
            // 
            // personalAnswerInput
            // 
            this.personalAnswerInput.Location = new System.Drawing.Point(228, 197);
            this.personalAnswerInput.Name = "personalAnswerInput";
            this.personalAnswerInput.Size = new System.Drawing.Size(171, 21);
            this.personalAnswerInput.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 68;
            this.label6.Text = "Personal Answer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 67;
            this.label7.Text = "Personal Question:";
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(122, 246);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 35);
            this.goBackButton.TabIndex = 63;
            this.goBackButton.Text = "GO BACK";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(262, 246);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 35);
            this.submitButton.TabIndex = 62;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // userIdInput
            // 
            this.userIdInput.Location = new System.Drawing.Point(228, 113);
            this.userIdInput.Name = "userIdInput";
            this.userIdInput.Size = new System.Drawing.Size(171, 21);
            this.userIdInput.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "User ID:";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(160, 59);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(165, 24);
            this.titleLabel1.TabIndex = 64;
            this.titleLabel1.Text = "Reset Password";
            // 
            // forgotPwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 298);
            this.Controls.Add(this.personalQuestionComboBox);
            this.Controls.Add(this.personalAnswerInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.userIdInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "forgotPwdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesiSupply System";
            this.Load += new System.EventHandler(this.forgotPwdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox personalQuestionComboBox;
        private System.Windows.Forms.TextBox personalAnswerInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox userIdInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel1;
    }
}