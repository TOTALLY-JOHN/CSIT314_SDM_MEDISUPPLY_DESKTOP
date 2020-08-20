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
    public partial class adminForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public adminForm()
        {
            InitializeComponent();
        }

        public void setCurrentUser(string user)
        {
            this.user = user;
        }

        public void setUserID(string userID)
        {
            this.userID = userID;
        }

        private void currentUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void adminForm_Load(object sender, EventArgs e)
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

        private void addOICButton_Click(object sender, EventArgs e)
        {
            addOICForm add_OIC_form = new addOICForm();
            this.Hide();
            add_OIC_form.setCurrentUser(user);
            add_OIC_form.setUserID(userID);
            add_OIC_form.ShowDialog();
            this.Close();
        }

        private void editOICButton_Click(object sender, EventArgs e)
        {
            editOICForm edit_OIC_form = new editOICForm();
            this.Hide();
            edit_OIC_form.setCurrentUser(user);
            edit_OIC_form.setUserID(userID);
            edit_OIC_form.ShowDialog();
            this.Close();
        }

        private void deleteOICButton_Click(object sender, EventArgs e)
        {
            deleteOICForm delete_OIC_form = new deleteOICForm();
            this.Hide();
            delete_OIC_form.setCurrentUser(user);
            delete_OIC_form.setUserID(userID);
            delete_OIC_form.ShowDialog();
            this.Close();
        }

        private void viewOICButton_Click(object sender, EventArgs e)
        {
            viewOICForm view_OIC_form = new viewOICForm();
            this.Hide();
            view_OIC_form.setCurrentUser(user);
            view_OIC_form.setUserID(userID);
            view_OIC_form.ShowDialog();
            this.Close();
        }

        private void addContactPersonButton_Click(object sender, EventArgs e)
        {
            addCPForm add_CP_form = new addCPForm();
            this.Hide();
            add_CP_form.setCurrentUser(user);
            add_CP_form.setUserID(userID);
            add_CP_form.ShowDialog();
            this.Close();
        }

        private void editContactPersonButton_Click(object sender, EventArgs e)
        {
            editCPForm edit_CP_form = new editCPForm();
            this.Hide();
            edit_CP_form.setCurrentUser(user);
            edit_CP_form.setUserID(userID);
            edit_CP_form.ShowDialog();
            this.Close();
        }

        private void deleteContactPersonButton_Click(object sender, EventArgs e)
        {
            deleteCPForm delete_CP_form = new deleteCPForm();
            this.Hide();
            delete_CP_form.setCurrentUser(user);
            delete_CP_form.setUserID(userID);
            delete_CP_form.ShowDialog();
            this.Close();
        }

        private void viewContactPersonButton_Click(object sender, EventArgs e)
        {
            viewCPForm view_CP_form = new viewCPForm();
            this.Hide();
            view_CP_form.setCurrentUser(user);
            view_CP_form.setUserID(userID);
            view_CP_form.ShowDialog();
            this.Close();
        }

        private void addClinicButton_Click(object sender, EventArgs e)
        {
            addClinicForm add_clinic_form = new addClinicForm();
            this.Hide();
            add_clinic_form.setCurrentUser(user);
            add_clinic_form.setUserID(userID);
            add_clinic_form.ShowDialog();
            this.Close();
        }

        private void editClinicButton_Click(object sender, EventArgs e)
        {
            editClinicForm edit_clinic_form = new editClinicForm();
            this.Hide();
            edit_clinic_form.setCurrentUser(user);
            edit_clinic_form.setUserID(userID);
            edit_clinic_form.ShowDialog();
            this.Close();
        }

        private void deleteClinicButton_Click(object sender, EventArgs e)
        {
            deleteClinicForm delete_clinic_form = new deleteClinicForm();
            this.Hide();
            delete_clinic_form.setCurrentUser(user);
            delete_clinic_form.setUserID(userID);
            delete_clinic_form.ShowDialog();
            this.Close();
        }

        private void viewClinicButton_Click(object sender, EventArgs e)
        {
            viewClinicForm view_clinic_form = new viewClinicForm();
            this.Hide();
            view_clinic_form.setCurrentUser(user);
            view_clinic_form.setUserID(userID);
            view_clinic_form.ShowDialog();
            this.Close();
        }

        private void addOrderButton_Click_1(object sender, EventArgs e)
        {
            addOrderForm add_order_form = new addOrderForm();
            this.Hide();
            add_order_form.setCurrentUser(user);
            add_order_form.setUserID(userID);
            add_order_form.setUserType("Admin");
            add_order_form.ShowDialog();
            this.Close();
        }

        private void editOrderButton_Click_1(object sender, EventArgs e)
        {
            editOrderForm edit_order_form = new editOrderForm();
            this.Hide();
            edit_order_form.setCurrentUser(user);
            edit_order_form.setUserID(userID);
            edit_order_form.setUserType("Admin");
            edit_order_form.ShowDialog();
            this.Close();
        }

        private void deleteOrderButton_Click_1(object sender, EventArgs e)
        {
            deleteOrderForm delete_order_form = new deleteOrderForm();
            this.Hide();
            delete_order_form.setCurrentUser(user);
            delete_order_form.setUserID(userID);
            delete_order_form.setUserType("Admin");
            delete_order_form.ShowDialog();
            this.Close();
        }

        private void viewOrderButton_Click(object sender, EventArgs e)
        {
            viewOrderForm2 view_order_form2 = new viewOrderForm2();
            this.Hide();
            view_order_form2.setCurrentUser(user);
            view_order_form2.setUserID(userID);
            view_order_form2.ShowDialog();
            this.Close();
        }
        private void addInventoryButton_Click(object sender, EventArgs e)
        {
            addInventoryForm add_inventory_form = new addInventoryForm();
            this.Hide();
            add_inventory_form.setCurrentUser(user);
            add_inventory_form.setUserID(userID);
            add_inventory_form.ShowDialog();
            this.Close();
        }

        private void editInventoryButton_Click(object sender, EventArgs e)
        {
            editInventoryForm edit_inventory_form = new editInventoryForm();
            this.Hide();
            edit_inventory_form.setCurrentUser(user);
            edit_inventory_form.setUserID(userID);
            edit_inventory_form.ShowDialog();
            this.Close();
        }

        private void deleteInventoryButton_Click(object sender, EventArgs e)
        {
            deleteInventoryForm delete_inventory_form = new deleteInventoryForm();
            this.Hide();
            delete_inventory_form.setCurrentUser(user);
            delete_inventory_form.setUserID(userID);
            delete_inventory_form.ShowDialog();
            this.Close();
        }

        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            viewInventoryForm view_inventory_form = new viewInventoryForm();
            this.Hide();
            view_inventory_form.setCurrentUser(user); 
            view_inventory_form.setUserID(userID);
            view_inventory_form.ShowDialog();
            this.Close();
        }

        private void printOrderReportButton_Click(object sender, EventArgs e)
        {
            printOrderReportForm print_order_report_form = new printOrderReportForm();
            this.Hide();
            print_order_report_form.setCurrentUser(user);
            print_order_report_form.setUserID(userID);
            print_order_report_form.ShowDialog();
            this.Close();
        }

        private void printInventoryReportButton_Click(object sender, EventArgs e)
        {
            printInventoryReportForm print_inventory_report_form = new printInventoryReportForm();
            this.Hide();
            print_inventory_report_form.setCurrentUser(user);
            print_inventory_report_form.setUserID(userID);
            print_inventory_report_form.ShowDialog();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            unlockAccountForm unlock_account_form = new unlockAccountForm();
            this.Hide();
            unlock_account_form.setCurrentUser(user);
            unlock_account_form.setUserID(userID);
            unlock_account_form.ShowDialog();
            this.Close();
        }

        
    }
}
