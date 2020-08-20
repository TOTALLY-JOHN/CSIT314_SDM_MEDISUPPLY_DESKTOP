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
    public partial class editClinicForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public editClinicForm()
        {
            InitializeComponent();
        }

        private void editClinicForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM users WHERE userType = 'OIC'";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);

                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();

                while (MyReader.Read())
                {
                    string oicName = MyReader.GetString("userName");
                    clinicOIDInputComboBox.Items.Add(oicName);
                }
                MyConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.dateTimeLabel.Text = "";
            this.currentUserLabel.Text += user;
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            // Get current date, time
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            // DATE, TIME
            string datetime = year + "-";

            // Padding leading zero
            if (month < 10)
            {
                datetime += "0" + month + "-";
            }
            else
            {
                datetime += month + "-";
            }

            if (day < 10)
            {
                datetime += "0" + day + " ";
            }
            else
            {
                datetime += day + " ";
            }

            if (hour < 10)
            {
                datetime += "0" + hour + ":";
            }
            else
            {
                datetime += hour + ":";
            }

            if (minute < 10)
            {
                datetime += "0" + minute + ":";
            }
            else
            {
                datetime += minute + ":";
            }

            if (second < 10)
            {
                datetime += "0" + second;
            }
            else
            {
                datetime += second + "";
            }
            dateTimeLabel.Text = datetime;
        }

        public void setCurrentUser(string user)
        {
            this.user = user;
        }

        public void setUserID(string userID)
        {
            this.userID = userID;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.clinicIDInput.Text == "")
            {
                MessageBox.Show("No ID input", "Error Message");
            }
            else
            {
                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "SELECT * FROM clinic WHERE clinicID = @clinicID";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@clinicID", this.clinicIDInput.Text);
                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    if (MyReader.Read())
                    {
                        this.clinicIDInput.Text = MyReader.GetString("clinicID");
                        this.clinicNameInput.Text = MyReader.GetString("clinicName");
                        this.clinicAddressInput.Text = MyReader.GetString("clinicAddress");
                        this.clinicAreaInput.Text = MyReader.GetString("clinicArea");
                        this.clinicTelephoneInput.Text = MyReader.GetString("clinicTelephone");
                        this.clinicOIDInputComboBox.Text = MyReader.GetString("clinicOICName");
                        this.clinicOICPwdInput.Text = " ";
                        this.clinicDetailsInput.Text = MyReader.GetString("clinicDetails");
                    }
                    else
                    {
                        MessageBox.Show("No record found", "Records");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            adminForm admin_form = new adminForm();
            this.Hide();
            admin_form.setCurrentUser(user);
            admin_form.setUserID(userID);
            admin_form.ShowDialog();
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (clinicIDInput.Text == null || clinicIDInput.Text == "" ||
                    clinicNameInput.Text == null || clinicNameInput.Text == "" ||
                    clinicAddressInput.Text == null || clinicAddressInput.Text == "" ||
                    clinicAreaInput.Text == null || clinicAreaInput.Text == "" ||
                    clinicTelephoneInput.Text == null || clinicTelephoneInput.Text == "" ||
                    clinicOIDInputComboBox.SelectedIndex == -1 ||
                    clinicOICPwdInput.Text == null || clinicOICPwdInput.Text == "")
                {
                    MessageBox.Show("There is an empty input.", "Error Message");
                }
                else if (clinicOICPwdInput.Text.Length < 8)
                {
                    MessageBox.Show("You have to set your password equal to or greater than 8 digits.", "Error Message");
                }
                else
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query1 = "SELECT * FROM users WHERE userName = @userName";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd1 = new MySqlCommand(Query1, MyConn);
                    string hash_MD5_pwd = MD5Hash(this.clinicOICPwdInput.Text);
                    cmd1.Parameters.AddWithValue("@userName", clinicOIDInputComboBox.Items[clinicOIDInputComboBox.SelectedIndex].ToString());
                    MyConn.Open();
                    MySqlDataReader MyReader1 = cmd1.ExecuteReader();


                    if (MyReader1.Read())
                    {
                        string userRealName = MyReader1.GetString("userName");
                        string userRealPwd = MyReader1.GetString("userPwd");

                        if (clinicOIDInputComboBox.Items[clinicOIDInputComboBox.SelectedIndex].ToString() == userRealName && hash_MD5_pwd == userRealPwd)
                        {
                            MyReader1.Close();
                            string Query2 = "UPDATE clinic SET clinicID = @clinicID, clinicName = @clinicName, clinicAddress = @clinicAddress, clinicArea = @clinicArea, clinicTelephone = @clinicTelephone, clinicOICName = @clinicOICName, clinicOICPwd = @clinicOICPwd, clinicDetails = @clinicDetails WHERE clinicID = @clinicID";
                            if (this.clinicDetailsInput.Text == "")
                            {
                                Query2 = "UPDATE clinic SET clinicID = @clinicID, clinicName = @clinicName, clinicAddress = @clinicAddress, clinicArea = @clinicArea, clinicTelephone = @clinicTelephone, clinicOICName = @clinicOICName, clinicOICPwd = @clinicOICPwd WHERE clinicID = @clinicID";
                                MySqlCommand cmd2 = new MySqlCommand(Query2, MyConn);
                                cmd2.Parameters.AddWithValue("@clinicID", this.clinicIDInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicName", this.clinicNameInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicAddress", this.clinicAddressInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicArea", this.clinicAreaInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicTelephone", this.clinicTelephoneInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicOICName", clinicOIDInputComboBox.Items[clinicOIDInputComboBox.SelectedIndex].ToString());
                                cmd2.Parameters.AddWithValue("@clinicOICPwd", hash_MD5_pwd);
                                MySqlDataReader MyReader2 = cmd2.ExecuteReader();
                            }
                            else
                            {
                                MySqlCommand cmd2 = new MySqlCommand(Query2, MyConn);
                                cmd2.Parameters.AddWithValue("@clinicID", this.clinicIDInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicName", this.clinicNameInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicAddress", this.clinicAddressInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicArea", this.clinicAreaInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicTelephone", this.clinicTelephoneInput.Text);
                                cmd2.Parameters.AddWithValue("@clinicOICName", clinicOIDInputComboBox.Items[clinicOIDInputComboBox.SelectedIndex].ToString());
                                cmd2.Parameters.AddWithValue("@clinicOICPwd", hash_MD5_pwd);
                                cmd2.Parameters.AddWithValue("@clinicDetails", this.clinicDetailsInput.Text);
                                MySqlDataReader MyReader2 = cmd2.ExecuteReader();
                            }

                            MessageBox.Show("Record Updated", "Records");
                            adminForm admin_form = new adminForm();
                            this.Hide();
                            admin_form.setCurrentUser(user);
                            admin_form.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("OIC name or password is not correct!", "Error Message");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is not that OIC name existing", "Error Message");
                    }

                    MyConn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm login_form = new loginForm();
            MessageBox.Show("Successfully logout.\nThank you for using the program.", "Logout Message");
            this.Hide();
            login_form.ShowDialog();
            this.Close();
        }
    }
}
