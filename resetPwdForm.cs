using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIT314_project
{
    public partial class resetPwdForm : Form
    {
        string oicID;

        public resetPwdForm()
        {
            InitializeComponent();
        }

        public resetPwdForm(string oicID)
        {
            InitializeComponent();
            this.oicID = oicID;
        }

        public void setOicId(string oicID)
        {
            this.oicID = oicID;
        }

        private void resetPwdForm_Load(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            forgotPwdForm forgot_pwd_form = new forgotPwdForm();
            this.Hide();
            forgot_pwd_form.ShowDialog();
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (userPwdInput.Text == null || userPwdInput.Text == "")
            {
                MessageBox.Show("No Record to Update", "Records");
            }
            else if(userPwdInput.Text.Length < 8)
            {
                MessageBox.Show("You have to input at least 8 digits' password.", "Password Error");
            }
            else
            {
                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "UPDATE users SET userPwd = @userPwd WHERE userID = @userID";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    string MD5UserPwd = MD5Hash(userPwdInput.Text);
                    cmd.Parameters.AddWithValue("@userID", oicID);
                    cmd.Parameters.AddWithValue("@userPwd", MD5UserPwd);
                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Successfully updated!", "Password Reset");
                    MyConn.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public String MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        public int changePassword()
        {
            if (oicID != null && oicID != "")
                return 1;
            else
                return 0;
        }
    }
}
