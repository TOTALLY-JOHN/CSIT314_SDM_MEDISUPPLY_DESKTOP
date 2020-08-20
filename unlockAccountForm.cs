using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIT314_project
{
    public partial class unlockAccountForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public unlockAccountForm()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void unlockAccountForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM users WHERE userType = 'OIC' AND userStatus = 'Locked' AND requestUnlock = 1";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);

                MyConn.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
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

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm login_form = new loginForm();
            MessageBox.Show("Successfully logout.\nThank you for using the program.", "Logout Message");
            this.Hide();
            login_form.ShowDialog();
            this.Close();
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            string oicID = "";
            if(this.oicIDInput.Text == null || this.oicIDInput.Text == "")
            {
                MessageBox.Show("You have to input OIC ID!", "Error Message");
            }
            else
            {
                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "SELECT * FROM users WHERE userID = @userID AND userType = 'OIC' AND requestUnlock = 1";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@userID", this.oicIDInput.Text);
                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    if (MyReader.Read())
                    {
                        oicID = MyReader.GetString("userID");
                    }
                    else
                    {
                        MessageBox.Show("No record found or available account.", "Records");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "UPDATE users SET userStatus = 'Available', requestUnlock = 0 WHERE userID = @userID AND userType = 'OIC' AND requestUnlock = 1";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@userID", oicID);

                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    MessageBox.Show("Successfully unlocked!", "Unlock the account");
                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void unlockAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "UPDATE users SET userStatus = 'Available' WHERE userType = 'OIC' AND requestUnlock = 1";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);

                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();
                MessageBox.Show("Successfully unlocked!", "Unlock all accounts");
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
