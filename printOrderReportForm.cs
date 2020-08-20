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
    public partial class printOrderReportForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public printOrderReportForm()
        {
            InitializeComponent();
        }

        private void printOrderReportForm_Load(object sender, EventArgs e)
        {
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
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM users WHERE userID = @userID";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                cmd.Parameters.AddWithValue("@userID", userID);
                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();


                if (MyReader.Read())
                {
                    string userRealID = MyReader.GetString("userID");
                    string userRealName = MyReader.GetString("userName");
                    string userType = MyReader.GetString("userType");

                    if (userRealID == userID && userType == "Admin")
                    {
                        adminForm admin_form = new adminForm();
                        this.Hide();
                        admin_form.setCurrentUser(userRealName);
                        admin_form.setUserID(userRealID);
                        admin_form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        OICForm oic_form = new OICForm();
                        this.Hide();
                        oic_form.setCurrentUser(userRealName);
                        oic_form.setUserID(userRealID);
                        oic_form.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("This ID does not exist!", "Error Message");
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printOrderButton1_Click(object sender, EventArgs e)
        {
            if(monthInput.Text == "" || monthInput.Text == null)
            {
                MessageBox.Show("You have to input the month!", "Error Message");
            }
            else
            {
                printOrderReportByMonthForm print_order_report_by_month_form = new printOrderReportByMonthForm();
                this.Hide();
                print_order_report_by_month_form.setCurrentUser(user);
                print_order_report_by_month_form.setSearchInput(monthInput.Text);
                print_order_report_by_month_form.setUserID(userID);
                print_order_report_by_month_form.ShowDialog();
                this.Close();
            }
        }

        private void printOrderButton2_Click(object sender, EventArgs e)
        {
            if(clinicNameInput.Text == "" || clinicNameInput.Text == null)
            {
                MessageBox.Show("You have to input the clinic name!", "Error Message");
            }
            else
            {
                printOrderReportByClinicNameForm print_order_report_by_clinin_name_form = new printOrderReportByClinicNameForm();
                this.Hide();
                print_order_report_by_clinin_name_form.setCurrentUser(user);
                print_order_report_by_clinin_name_form.setSearchInput(clinicNameInput.Text);
                print_order_report_by_clinin_name_form.setUserID(userID);
                print_order_report_by_clinin_name_form.ShowDialog();
                this.Close();
            }
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
