using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CSIT314_project
{
    public partial class viewInventoryForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public viewInventoryForm()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void viewInventoryForm_Load(object sender, EventArgs e)
        {
            this.dateTimeLabel.Text = "";
            this.currentUserLabel.Text += user;

            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM inventory";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                MyConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.ColumnCount = 13;
                dataGridView1.Columns[0].Name = "Inventory ID";
                dataGridView1.Columns[1].Name = "Item Name";
                dataGridView1.Columns[2].Name = "Item Brand";
                dataGridView1.Columns[3].Name = "Item Purpose";
                dataGridView1.Columns[4].Name = "Item Order Status";
                dataGridView1.Columns[5].Name = "Item Quantity";
                dataGridView1.Columns[6].Name = "Item Cost Price";
                dataGridView1.Columns[7].Name = "Item Selling Price";
                dataGridView1.Columns[8].Name = "Supplier Company";
                dataGridView1.Columns[9].Name = "Supplier Name";
                dataGridView1.Columns[10].Name = "Supplier Contact No";
                dataGridView1.Columns[11].Name = "Inventory Details";
                dataGridView1.Columns[12].Name = "Critical Quantity";
                
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 110;
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                img.Name = "img";
                img.HeaderText = "Item Picture";
                dataGridView1.Columns.Add(img);
                int index = 0;
                
                while (reader.Read())
                {
                    dataGridView1.Rows.Add();

                    string inventoryID = reader.GetString("inventoryID");
                    string itemName = reader.GetString("itemName");
                    string itemPicturePath = reader.GetString("itemPicture");
                    string itemBrand = reader.GetString("itemBrand");
                    string itemPurpose = reader.GetString("itemPurpose");
                    string itemOrderStatus = reader.GetString("itemOrderStatus");
                    string itemQuantity = reader.GetString("itemQuantity");
                    string itemCostPrice = reader.GetString("itemCostPrice");
                    string itemSellingPrice = reader.GetString("itemSellingPrice");
                    string supplierCompany = reader.GetString("supplierCompany");
                    string supplierName = reader.GetString("supplierName");
                    string supplierContactNo = reader.GetString("supplierContactNo");
                    string inventoryDetails = reader.GetString("inventoryDetails");
                    string criticalQuantity = reader.GetString("criticalQuantity");
                    
                    Image image = Image.FromFile(itemPicturePath);
                    dataGridView1[0, index].Value = inventoryID;
                    dataGridView1[1, index].Value = itemName;
                    dataGridView1[2, index].Value = itemBrand;
                    dataGridView1[3, index].Value = itemPurpose;
                    dataGridView1[4, index].Value = itemOrderStatus;
                    dataGridView1[5, index].Value = itemQuantity;
                    dataGridView1[6, index].Value = itemCostPrice;
                    dataGridView1[7, index].Value = itemSellingPrice;
                    dataGridView1[8, index].Value = supplierCompany;
                    dataGridView1[9, index].Value = supplierName;
                    dataGridView1[10, index].Value = supplierContactNo;
                    dataGridView1[11, index].Value = inventoryDetails;
                    dataGridView1[12, index].Value = criticalQuantity;
                    dataGridView1[13, index].Value = image;
                    index++;
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
