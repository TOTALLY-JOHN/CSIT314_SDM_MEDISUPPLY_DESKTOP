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
    public partial class addCPForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public addCPForm()
        {
            InitializeComponent();
        }

        private void addCPForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM clinic";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                
                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();

                while(MyReader.Read())
                {
                    string clinicName = MyReader.GetString("clinicName");
                    clinicNameComboBox.Items.Add(clinicName);
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM personal_questions";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);

                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();

                while (MyReader.Read())
                {
                    string question = MyReader.GetString("questionContent");
                    personalQuestionComboBox.Items.Add(question);
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

        private void goBackButton_Click(object sender, EventArgs e)
        {
            adminForm admin_form = new adminForm();
            this.Hide();
            admin_form.setCurrentUser(user);
            admin_form.setUserID(userID);
            admin_form.ShowDialog();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cpIdInput.Text == null || cpIdInput.Text == "" ||
                    cpPwdInput.Text == null || cpPwdInput.Text == "" ||
                    cpNameInput.Text == null || cpNameInput.Text == "" ||
                    clinicNameComboBox.SelectedIndex == -1 ||
                    contactNoInput.Text == null || contactNoInput.Text == "" ||
                    alternativeContactNoInput.Text == null || alternativeContactNoInput.Text == "" ||
                    personalQuestionComboBox.SelectedIndex == -1 ||
                    personalAnswerInput.Text == null || personalAnswerInput.Text == "")
                {
                    MessageBox.Show("There is an empty input.", "Error Message");
                }
                else if (memberSinceInput.Value.Date > DateTime.Today)
                {
                    MessageBox.Show("You cannot input a future date.", "Error Message");
                }
                else if (cpPwdInput.Text.Length < 8)
                {
                    MessageBox.Show("You have to set your password equal to or greater than 8 digits.", "Error Message");
                }
                else
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query2 = "INSERT INTO contact_person (cpID, cpPwd, cpName, clinicName, contactNo, alternativeContactNo, memberSince, personalQuestion, personalAnswer) VALUES (@cpID, @cpPwd, @cpName, @clinicName, @contactNo, @alternativeContactNo, @memberSince, @personalQuestion, @personalAnswer)";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd2 = new MySqlCommand(Query2, MyConn);
                    string hash_MD5_pwd = MD5Hash(cpPwdInput.Text);
                    cmd2.Parameters.AddWithValue("@cpID", cpIdInput.Text);
                    cmd2.Parameters.AddWithValue("@cpPwd", hash_MD5_pwd);
                    cmd2.Parameters.AddWithValue("@cpName", cpNameInput.Text);
                    cmd2.Parameters.AddWithValue("@clinicName", this.clinicNameComboBox.Items[clinicNameComboBox.SelectedIndex].ToString());
                    cmd2.Parameters.AddWithValue("@contactNo", contactNoInput.Text);
                    cmd2.Parameters.AddWithValue("@alternativeContactNo", alternativeContactNoInput.Text);
                    cmd2.Parameters.AddWithValue("@memberSince", memberSinceInput.Value.Date);
                    cmd2.Parameters.AddWithValue("@personalQuestion", this.personalQuestionComboBox.Items[personalQuestionComboBox.SelectedIndex].ToString());
                    cmd2.Parameters.AddWithValue("@personalAnswer", personalAnswerInput.Text);

                    MyConn.Open();
                    MySqlDataReader MyReader = cmd2.ExecuteReader();
                    MessageBox.Show("Record Saved", "Records");
                    MyConn.Close();

                    adminForm admin_form = new adminForm();
                    this.Hide();
                    admin_form.setCurrentUser(user);
                    admin_form.ShowDialog();
                    this.Close();
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
