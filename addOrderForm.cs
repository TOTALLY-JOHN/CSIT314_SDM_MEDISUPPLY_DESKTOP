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
    public partial class addOrderForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;
        string userType;

        public addOrderForm()
        {
            InitializeComponent();
        }

        private void addOrderForm_Load(object sender, EventArgs e)
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

            this.dateTimeLabel.Text = "";
            this.currentUserLabel.Text += user;
            this.deliveryDateInput.Value = DateTime.Today;
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            // Check whether the inventory's quantity is enough or not
            int inventoryQuantity = 0;
            int inventoryCriticalQuantity = 0;
            string inventoryID = "";

            try
            {
                if (clinicNameComboBox.SelectedIndex == -1 ||
                    itemCategoryComboBox.SelectedIndex == -1 ||
                    deliveryDateInput.Value == null)
                {
                    MessageBox.Show("There is an empty input.", "Error Message");
                    return;
                }
                else if (deliveryDateInput.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("You cannot input a past date.", "Error Message");
                    return;
                }
                else
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    int orderQuantity = Convert.ToInt32(this.itemQuantityInput.Text);
                    string Query = "SELECT inventoryID, itemOrderStatus, itemQuantity, criticalQuantity FROM inventory WHERE inventory.itemName = @itemName";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MyConn.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@itemName", itemTypeComboBox.Items[itemTypeComboBox.SelectedIndex].ToString());
                    MySqlDataReader MyReader = cmd.ExecuteReader();


                    if (MyReader.Read())
                    {
                        inventoryQuantity = MyReader.GetInt32("itemQuantity");
                        inventoryCriticalQuantity = MyReader.GetInt32("criticalQuantity");
                        inventoryID = MyReader.GetString("inventoryID");
                        string itemOrderStatus = MyReader.GetString("itemOrderStatus");

                        if (orderQuantity > (inventoryQuantity - inventoryCriticalQuantity) && itemOrderStatus == "Received")
                        {
                            MessageBox.Show("There is not enough quantity of this item in the inventory.", "Error Message");
                            return;
                        }
                        else if (itemOrderStatus == "Delivering" || itemOrderStatus == "Pending")
                        {
                            MessageBox.Show("The inventory's items are not delivered yet.", "Error Message");
                            return;
                        }
                        else
                        {
                            inventoryQuantity -= orderQuantity;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The item's information is not incorrect!", "Error Message");
                        return;
                    }
                    MyConn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                if (clinicNameComboBox.SelectedIndex == -1 ||
                    itemCategoryComboBox.SelectedIndex == -1 ||
                    deliveryDateInput.Value == null)
                {
                    MessageBox.Show("There is an empty input.", "Error Message");
                    return;
                }
                else if(deliveryDateInput.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("You cannot input a past date.", "Error Message");
                    return;
                }
                else
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    
                    string Query1 = "INSERT INTO orders (clinicName, itemType, itemQuantity, orderDate, deliveryDate, orderStatus, orderDetails) VALUES (@clinicName, @itemType, @itemQuantity, @orderDate, @deliveryDate, @orderStatus, @orderDetails)";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MyConn.Open();

                    if (this.orderDetailsInput.Text == "")
                    {
                        Query1 = "INSERT INTO orders (clinicName, itemType, itemQuantity, orderDate, deliveryDate, orderStatus) VALUES (@clinicName, @itemType, @itemQuantity, @orderDate, @deliveryDate, @orderStatus)";
                        MySqlCommand cmd1 = new MySqlCommand(Query1, MyConn);
                        cmd1.Parameters.AddWithValue("@clinicName", clinicNameComboBox.Items[clinicNameComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemType", itemTypeComboBox.Items[itemTypeComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemQuantity",itemQuantityInput.Value);
                        cmd1.Parameters.AddWithValue("@orderDate", DateTime.Now.Date);
                        cmd1.Parameters.AddWithValue("@deliveryDate", this.deliveryDateInput.Value.Date);
                        cmd1.Parameters.AddWithValue("@orderStatus", "Pending");
                        MySqlDataReader MyReader1 = cmd1.ExecuteReader();

                        MessageBox.Show("Record Saved", "Records");
                    }
                    else
                    {
                        MySqlCommand cmd1 = new MySqlCommand(Query1, MyConn);
                        cmd1.Parameters.AddWithValue("@clinicName", clinicNameComboBox.Items[clinicNameComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemType", itemTypeComboBox.Items[itemTypeComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemQuantity", this.itemQuantityInput.Value);
                        cmd1.Parameters.AddWithValue("@orderDate", DateTime.Now.Date);
                        cmd1.Parameters.AddWithValue("@deliveryDate", this.deliveryDateInput.Value.Date);
                        cmd1.Parameters.AddWithValue("@orderStatus", "Pending");
                        cmd1.Parameters.AddWithValue("@orderDetails", this.orderDetailsInput.Text);
                        MySqlDataReader MyReader1 = cmd1.ExecuteReader();

                        MessageBox.Show("Record Saved", "Records");
                    }
                    MyConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";

                string Query1 = "UPDATE inventory SET itemQuantity = @itemQuantity WHERE inventoryID = @inventoryID";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MyConn.Open();
                MySqlCommand cmd1 = new MySqlCommand(Query1, MyConn);
                cmd1.Parameters.AddWithValue("@itemQuantity", inventoryQuantity);
                cmd1.Parameters.AddWithValue("@inventoryID", inventoryID);
                MySqlDataReader MyReader1 = cmd1.ExecuteReader();
                
                MyConn.Close();
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

        public int addOrderItem(string orderID, string orderItem, 
            string inventoryItem, int orderQuantity, int inventoryQuantity, 
            int inventoryCriticalQuantity)
        {
            if(orderItem != inventoryItem)
            {
                return -1;
            }
            else
            {
                if(orderQuantity > (inventoryQuantity - inventoryCriticalQuantity))
                {
                    return -1;
                }
                return 1;
            }
        }
    }
}
