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
    public partial class editInventoryForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public editInventoryForm()
        {
            InitializeComponent();
        }

        private void editInventoryForm_Load(object sender, EventArgs e)
        {
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
            if (this.inventoryIDInput.Text == "")
            {
                MessageBox.Show("No ID input", "Error Message");
            }
            else
            {
                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "SELECT * FROM inventory WHERE inventoryID = @inventoryID";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@inventoryID", this.inventoryIDInput.Text);
                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    if (MyReader.Read())
                    {
                        this.inventoryIDInput.Text = MyReader.GetString("inventoryID");
                        this.itemTypeComboBox.Text = MyReader.GetString("itemName");
                        this.itemPictureInput.Text = MyReader.GetString("itemPicture");
                        this.itemBrandInput.Text = MyReader.GetString("itemBrand");
                        this.itemPurposeInput.Text = MyReader.GetString("itemPurpose");
                        this.itemOrderStatusInput.Text = MyReader.GetString("itemOrderStatus");
                        this.itemQuantityInput.Value = MyReader.GetInt32("itemQuantity");
                        this.itemCostPriceInput.Value = MyReader.GetDecimal("itemCostPrice");
                        this.itemSellingPriceInput.Value = MyReader.GetDecimal("itemSellingPrice");
                        this.supplierCompanyInput.Text = MyReader.GetString("supplierCompany");
                        this.supplierNameInput.Text = MyReader.GetString("supplierName");
                        this.supplierContactNoInput.Text = MyReader.GetString("supplierContactNo");
                        this.inventoryDetailsInput.Text = MyReader.GetString("inventoryDetails");
                        this.criticalQuantityInput.Value = MyReader.GetInt32("criticalQuantity");
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

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select file to be uploaded.";
            openFileDialog1.Filter = "Select Valid picture(*.jpg; *.gif; *.png; *.bmp)|*.jpg; *.gif; *.png; *.bmp";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        itemPictureInput.Text = path;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // GO BACK TO MAIN PAGE
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
                if (inventoryIDInput.Text == null || inventoryIDInput.Text == "" ||
                    itemCategoryComboBox.SelectedIndex == -1 ||
                    itemTypeComboBox.SelectedIndex == -1 ||
                    itemPictureInput.Text == null || itemPictureInput.Text == "" ||
                    itemBrandInput.Text == null || itemBrandInput.Text == "" ||
                    itemPurposeInput.Text == null || itemPurposeInput.Text == "" ||
                    itemOrderStatusInput.Text == null || itemOrderStatusInput.Text == "" ||
                    supplierCompanyInput.Text == null || supplierCompanyInput.Text == "" ||
                    supplierNameInput.Text == null || supplierNameInput.Text == "" ||
                    supplierContactNoInput.Text == null || supplierContactNoInput.Text == "")
                {
                    MessageBox.Show("There is an empty input.", "Error Message");
                }
                else
                {
                    // File Upload
                    string fileName = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\item_images\\" + fileName);

                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query1 = "UPDATE inventory SET itemName = @itemName, itemPicture = @itemPicture, itemBrand = @itemBrand, itemPurpose = @itemPurpose, itemOrderStatus = @itemOrderStatus, itemQuantity = @itemQuantity, itemCostPrice = @itemCostPrice, itemSellingPrice = @itemSellingPrice, supplierCompany = @supplierCompany, supplierName = @supplierName, supplierContactNo = @supplierContactNo, inventoryDetails = @inventoryDetails, criticalQuantity = @criticalQuantity WHERE inventoryID = @inventoryID";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MyConn.Open();

                    if (this.inventoryDetailsInput.Text == "")
                    {
                        MySqlCommand cmd1 = new MySqlCommand(Query1, MyConn);
                        cmd1.Parameters.AddWithValue("@inventoryID", inventoryIDInput.Text);
                        cmd1.Parameters.AddWithValue("@itemName", itemTypeComboBox.Items[itemTypeComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemPicture", path + "\\item_images\\" + fileName);
                        cmd1.Parameters.AddWithValue("@itemBrand", itemBrandInput.Text);
                        cmd1.Parameters.AddWithValue("@itemPurpose", itemPurposeInput.Text);
                        cmd1.Parameters.AddWithValue("@itemOrderStatus", itemOrderStatusInput.Text);
                        cmd1.Parameters.AddWithValue("@itemQuantity", itemQuantityInput.Value);
                        cmd1.Parameters.AddWithValue("@itemCostPrice", itemCostPriceInput.Value);
                        cmd1.Parameters.AddWithValue("@itemSellingPrice", itemSellingPriceInput.Value);
                        cmd1.Parameters.AddWithValue("@supplierCompany", supplierCompanyInput.Text);
                        cmd1.Parameters.AddWithValue("@supplierName", supplierNameInput.Text);
                        cmd1.Parameters.AddWithValue("@supplierContactNo", supplierContactNoInput.Text);
                        cmd1.Parameters.AddWithValue("@inventoryDetails", " ");
                        cmd1.Parameters.AddWithValue("@criticalQuantity", criticalQuantityInput.Value);
                        MySqlDataReader MyReader1 = cmd1.ExecuteReader();

                        MessageBox.Show("Record Saved", "Records");
                        adminForm admin_form = new adminForm();
                        this.Hide();
                        admin_form.setCurrentUser(user);
                        admin_form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MySqlCommand cmd1 = new MySqlCommand(Query1, MyConn);
                        cmd1.Parameters.AddWithValue("@inventoryID", inventoryIDInput.Text);
                        cmd1.Parameters.AddWithValue("@itemName", itemTypeComboBox.Items[itemTypeComboBox.SelectedIndex].ToString());
                        cmd1.Parameters.AddWithValue("@itemPicture", path + "\\item_images\\" + fileName);
                        cmd1.Parameters.AddWithValue("@itemBrand", itemBrandInput.Text);
                        cmd1.Parameters.AddWithValue("@itemPurpose", itemPurposeInput.Text);
                        cmd1.Parameters.AddWithValue("@itemOrderStatus", itemOrderStatusInput.Text);
                        cmd1.Parameters.AddWithValue("@itemQuantity", itemQuantityInput.Value);
                        cmd1.Parameters.AddWithValue("@itemCostPrice", itemCostPriceInput.Value);
                        cmd1.Parameters.AddWithValue("@itemSellingPrice", itemSellingPriceInput.Value);
                        cmd1.Parameters.AddWithValue("@supplierCompany", supplierCompanyInput.Text);
                        cmd1.Parameters.AddWithValue("@supplierName", supplierNameInput.Text);
                        cmd1.Parameters.AddWithValue("@supplierContactNo", supplierContactNoInput.Text);
                        cmd1.Parameters.AddWithValue("@inventoryDetails", inventoryDetailsInput.Text);
                        cmd1.Parameters.AddWithValue("@criticalQuantity", criticalQuantityInput.Value);
                        MySqlDataReader MyReader1 = cmd1.ExecuteReader();

                        MessageBox.Show("Record Saved", "Records");
                        adminForm admin_form = new adminForm();
                        this.Hide();
                        admin_form.setCurrentUser(user);
                        admin_form.ShowDialog();
                        this.Close();
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
