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
    public partial class printInventoryReportForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public printInventoryReportForm()
        {
            InitializeComponent();
        }

        private void printInventoryReportForm_Load(object sender, EventArgs e)
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

                    if(userRealID == userID && userType == "Admin")
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printInventoryButton1_Click(object sender, EventArgs e)
        {
            if(categoryInput.Text == "" || categoryInput.Text == null)
            {
                MessageBox.Show("You have to input the category!", "Error Message");
            }
            else
            {
                printInventoryReportByCategory print_inventory_report_by_category = new printInventoryReportByCategory();
                this.Hide();
                print_inventory_report_by_category.setCurrentUser(user);
                print_inventory_report_by_category.setSearchInput(categoryInput.Text);
                print_inventory_report_by_category.setUserID(userID);
                print_inventory_report_by_category.ShowDialog();
                this.Close();
            }
        }

        private void printInventoryButton2_Click(object sender, EventArgs e)
        {
            if(quantityInput.Text == "" || quantityInput.Text == null)
            {
                MessageBox.Show("You have to input the quantity!", "Error Message");
            }
            else
            {
                printInventoryReportByQuantity print_inventory_report_by_quantity = new printInventoryReportByQuantity();
                this.Hide();
                print_inventory_report_by_quantity.setCurrentUser(user);
                print_inventory_report_by_quantity.setSearchInput(quantityInput.Text);
                print_inventory_report_by_quantity.setUserID(userID);
                print_inventory_report_by_quantity.ShowDialog();
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
