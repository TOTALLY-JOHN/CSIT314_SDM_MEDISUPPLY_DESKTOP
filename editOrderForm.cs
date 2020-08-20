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
    public partial class editOrderForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;
        string userType;

        public editOrderForm()
        {
            InitializeComponent();
        }

        private void editOrderForm_Load(object sender, EventArgs e)
        {
            // RETRIEVE CLINIC NAME IN THE CLINIC NAME'S COMBO BOX
            try
            {
                if (userType == "Admin")
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "SELECT DISTINCT clinicName FROM clinic";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);

                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        string clinicName = MyReader.GetString("clinicName");
                        clinicNameComboBox.Items.Add(clinicName);
                    }
                    MyConn.Close();
                }
                else
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "SELECT DISTINCT clinicName FROM clinic JOIN users ON clinic.clinicOICName = @userName WHERE users.userType = 'OIC'";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@userName", user);

                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        string clinicName = MyReader.GetString("clinicName");
                        clinicNameComboBox.Items.Add(clinicName);
                    }
                    MyConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // RETRIEVE ITEM CATEGORY'S NAME IN THE ITEM CATEGORY'S COMBO BOX
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT DISTINCT itemCategory FROM items";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);

                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();

                while (MyReader.Read())
                {
                    string itemCategory = MyReader.GetString("itemCategory");
                    itemCategoryComboBox.Items.Add(itemCategory);
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            orderStatusComboBox.Items.Add("Pending");
            orderStatusComboBox.Items.Add("Delivering");
            orderStatusComboBox.Items.Add("Received");

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

        public void setUserType(string userType)
        {
            this.userType = userType;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.orderIDInput.Text == "")
            {
                MessageBox.Show("No ID input", "Error Message");
            }
            else
            {
                try
                {
                    string Query = "";
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd; 
                    if (userType=="Admin")
                    {
                        Query = "SELECT * FROM orders JOIN clinic ON orders.clinicName = clinic.clinicName WHERE orderID = @orderID";
                        cmd = new MySqlCommand(Query, MyConn);
                        cmd.Parameters.AddWithValue("@orderID", this.orderIDInput.Text);
                    }
                    else
                    {
                        Query = "SELECT * FROM orders JOIN clinic ON orders.clinicName = clinic.clinicName WHERE orderID = @orderID AND clinicOICName = @clinicOICName";
                        cmd = new MySqlCommand(Query, MyConn);
                        cmd.Parameters.AddWithValue("@orderID", this.orderIDInput.Text);
                        cmd.Parameters.AddWithValue("@clinicOICName", user);
                    }
                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    if (MyReader.Read())
                    {
                        this.orderIDInput.Text = MyReader.GetString("orderID");
                        this.clinicNameComboBox.Text = MyReader.GetString("clinicName");
                        this.itemTypeComboBox.Text = MyReader.GetString("itemType");
                        this.itemQuantityInput.Value = MyReader.GetInt32("itemQuantity");
                        this.deliveryDateInput.Value = MyReader.GetDateTime("deliveryDate");
                        this.orderStatusComboBox.Text = MyReader.GetString("orderStatus");
                        this.orderDetailsInput.Text = MyReader.GetString("orderDetails");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderIDInput.Text == null || orderIDInput.Text == "" ||
                    clinicNameComboBox.SelectedIndex == -1 ||
                    itemTypeComboBox.SelectedIndex == -1 ||
                    deliveryDateInput.Value == null)
                {
                    MessageBox.Show("There is an empty input.", "Error Message");
                }
                else if (deliveryDateInput.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("You cannot input a past date.", "Error Message");
                }
                else
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";

                    string Query1 = "UPDATE orders SET clinicName = @clinicName, itemType = @itemType, itemQuantity = @itemQuantity, orderDate = @orderDate, deliveryDate = @deliveryDate, orderStatus = @orderStatus, orderDetails = @orderDetails WHERE orderID = @orderID";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MyConn.Open();

                    if (this.orderDetailsInput.Text == "")
                    {
                        Query1 = "UPDATE orders SET clinicName = @clinicName, itemType = @itemType, itemQuantity = @itemQuantity, orderDate = @orderDate, deliveryDate = @deliveryDate, orderStatus = @orderStatus WHERE orderID = @orderID";
                        MySqlCommand cmd1 = new MySqlCommand(Query1, MyConn);
                        cmd1.Parameters.AddWithValue("@clinicName", clinicNameComboBox.Items[clinicNameComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemType", itemTypeComboBox.Items[itemTypeComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemQuantity", this.itemQuantityInput.Value);
                        cmd1.Parameters.AddWithValue("@orderDate", DateTime.Now.Date);
                        cmd1.Parameters.AddWithValue("@deliveryDate", this.deliveryDateInput.Value.Date);
                        cmd1.Parameters.AddWithValue("@orderStatus", this.orderStatusComboBox.Items[orderStatusComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@orderID", orderIDInput.Text);
                        MySqlDataReader MyReader1 = cmd1.ExecuteReader();

                        MessageBox.Show("Record Updated", "Records");
                    }
                    else
                    {
                        MySqlCommand cmd1 = new MySqlCommand(Query1, MyConn);
                        cmd1.Parameters.AddWithValue("@clinicName", clinicNameComboBox.Items[clinicNameComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemType", itemTypeComboBox.Items[itemTypeComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemQuantity", this.itemQuantityInput.Value);
                        cmd1.Parameters.AddWithValue("@orderDate", DateTime.Now.Date);
                        cmd1.Parameters.AddWithValue("@deliveryDate", this.deliveryDateInput.Value.Date);
                        cmd1.Parameters.AddWithValue("@orderStatus", this.orderStatusComboBox.Items[orderStatusComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@orderDetails", this.orderDetailsInput.Text);
                        cmd1.Parameters.AddWithValue("@orderID", orderIDInput.Text);
                        MySqlDataReader MyReader1 = cmd1.ExecuteReader();

                        MessageBox.Show("Record Updated", "Records");
                    }
                    MyConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemTypeComboBox.Items.Clear();
            // RETRIEVE ITEM NAME IN THE ITEM TYPE'S COMBO BOX
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM items WHERE itemCategory = @itemCategory";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                cmd.Parameters.AddWithValue("@itemCategory", itemCategoryComboBox.Items[itemCategoryComboBox.SelectedIndex].ToString());
                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();

                while (MyReader.Read())
                {
                    string itemType = MyReader.GetString("itemName");
                    itemTypeComboBox.Items.Add(itemType);
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
