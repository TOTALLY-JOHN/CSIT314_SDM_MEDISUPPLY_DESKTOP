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
    public partial class OICForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public OICForm()
        {
            InitializeComponent();
        }

        private void OICForm_Load(object sender, EventArgs e)
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

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            addOrderForm add_order_form = new addOrderForm();
            this.Hide();
            add_order_form.setCurrentUser(user);
            add_order_form.setUserID(userID);
            add_order_form.setUserType("OIC");
            add_order_form.ShowDialog();
            this.Close();
        }

        private void updateOrderButton_Click(object sender, EventArgs e)
        {
            editOrderForm edit_order_form = new editOrderForm();
            this.Hide();
            edit_order_form.setCurrentUser(user);
            edit_order_form.setUserID(userID);
            edit_order_form.setUserType("OIC");
            edit_order_form.ShowDialog();
            this.Close();
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            deleteOrderForm delete_order_form = new deleteOrderForm();
            this.Hide();
            delete_order_form.setCurrentUser(user);
            delete_order_form.setUserID(userID);
            delete_order_form.setUserType("OIC");
            delete_order_form.ShowDialog();
            this.Close();
        }

        private void viewOrderButton_Click(object sender, EventArgs e)
        {
            viewOrderForm view_order_form = new viewOrderForm();
            this.Hide();
            view_order_form.setCurrentUser(user);
            view_order_form.setUserID(userID);
            view_order_form.ShowDialog();
            this.Close();
        }

        private void printOrderButton_Click(object sender, EventArgs e)
        {
            printOrderReportForm print_order_report_form = new printOrderReportForm();
            this.Hide();
            print_order_report_form.setCurrentUser(user);
            print_order_report_form.setUserID(userID);
            print_order_report_form.ShowDialog();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
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
    }
}
