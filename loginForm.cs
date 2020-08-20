using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIT314_project
{
    public partial class loginForm : Form
    {
        int loginAttemptCount = 0;

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String id = this.idInput.Text;
            String pwd = this.pwdInput.Text;

            if (this.idInput.Text == "" || this.pwdInput.Text == "")
            {
                MessageBox.Show("There is a blank input", "Login Error");
            }
            else
            {
                loginAttemptCount++;

                if (loginAttemptCount > 3)
                {
                    try
                    {
                        string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                        string Query = "UPDATE users SET userStatus = @userStatus WHERE userID = @userID AND userType = 'OIC'";
                        MySqlConnection MyConn = new MySqlConnection(Conn);
                        MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                        cmd.Parameters.AddWithValue("@userStatus", "Locked");
                        cmd.Parameters.AddWithValue("@userID", this.idInput.Text);

                        MyConn.Open();
                        MySqlDataReader MyReader = cmd.ExecuteReader();
                        MessageBox.Show("You failed to login three times, so this ID is locked now. \nPlease, contact the system administrator.", "Login Error");
                        lockedAccountForm locked_account_form = new lockedAccountForm();
                        this.Hide();
                        locked_account_form.ShowDialog();
                        MyConn.Close();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                        string Query = "SELECT * FROM users WHERE userID = @userID";
                        MySqlConnection MyConn = new MySqlConnection(Conn);
                        MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                        string hash_MD5_pwd = MD5Hash(this.pwdInput.Text);
                        cmd.Parameters.AddWithValue("@userID", this.idInput.Text);
                        MyConn.Open();
                        MySqlDataReader MyReader = cmd.ExecuteReader();


                        if (MyReader.Read())
                        {
                            string userRealID = MyReader.GetString("userID");
                            string userRealPwd = MyReader.GetString("userPwd");
                            string userRealName = MyReader.GetString("userName");
                            string userStatus = MyReader.GetString("userStatus");
                            string userType = MyReader.GetString("userType");

                            if (userStatus == "Locked" || userStatus == "locked")
                            {
                                MessageBox.Show("Your account is locked! Contact the system administrator, please.", "Login Error");
                            }
                            else
                            {
                                if (this.idInput.Text == userRealID && hash_MD5_pwd == userRealPwd && userType == "Admin")
                                {
                                    adminForm admin_form = new adminForm();
                                    this.Hide();
                                    admin_form.setCurrentUser(userRealName);
                                    admin_form.setUserID(userRealID);
                                    admin_form.ShowDialog();
                                    this.Close();
                                }
                                else if (this.idInput.Text == userRealID && hash_MD5_pwd == userRealPwd && userType == "OIC")
                                {
                                    OICForm oic_form = new OICForm();
                                    this.Hide();
                                    oic_form.setCurrentUser(userRealName);
                                    oic_form.setUserID(userRealID);
                                    oic_form.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Your ID or password is incorrect!", "Login Error");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("This ID does not exist!", "Login Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

        private void forgotPwdLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPwdForm forgot_pwd_form = new forgotPwdForm();
            forgot_pwd_form.ShowDialog();
        }
    }
}
