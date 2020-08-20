using Microsoft.Reporting.WinForms;
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
    public partial class printInventoryReportByQuantity : Form
    {
        Timer t = new Timer();
        string user;
        ReportDataSource rs = new ReportDataSource();
        string searchInput;
        string userID;

        public printInventoryReportByQuantity()
        {
            InitializeComponent();
        }

        private void printInventoryReportByQuantity_Load(object sender, EventArgs e)
        {
            List<Inventory> list = new List<Inventory>();
            list.Clear();

            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT inventoryID, items.itemCategory, inventory.itemName, itemBrand, itemQuantity, itemCostPrice, itemSellingPrice, supplierCompany, supplierName, supplierContactNo, inventoryDetails, criticalQuantity FROM inventory JOIN items ON inventory.itemName = items.itemName WHERE criticalQuantity = @criticalQuantity";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                cmd.Parameters.AddWithValue("@criticalQuantity", searchInput);
                MyConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                double _totalPrice = 0.0;
                while (reader.Read())
                {
                    string _inventoryID = reader.GetString("inventoryID");
                    string _itemCategory = reader.GetString("itemCategory");
                    string _itemName = reader.GetString("itemName");
                    string _itemBrand = reader.GetString("itemBrand");
                    int _itemQuantity = reader.GetInt32("itemQuantity");
                    double _itemCostPrice = reader.GetDouble("itemCostPrice");
                    double _itemSellingPrice = reader.GetDouble("itemSellingPrice");
                    string _supplierCompany = reader.GetString("supplierCompany");
                    string _supplierName = reader.GetString("supplierName");
                    string _supplierContactNo = reader.GetString("supplierContactNo");
                    string _inventoryDetails = reader.GetString("inventoryDetails");
                    int _criticalQuantity = reader.GetInt32("criticalQuantity");
                    double _rowTotal = _itemQuantity * _itemSellingPrice;
                    _totalPrice += _rowTotal;

                    Inventory inventory = new Inventory
                    {
                        InventoryID = _inventoryID,
                        ItemCategory = _itemCategory,
                        ItemName = _itemName,
                        ItemBrand = _itemBrand,
                        ItemQuantity = _itemQuantity,
                        ItemCostPrice = _itemCostPrice,
                        ItemSellingPrice = _itemSellingPrice,
                        SupplierCompany = _supplierCompany,
                        SupplierName = _supplierName,
                        SupplierContactNo = _supplierContactNo,
                        InventoryDetails = _inventoryDetails,
                        CriticalQuantity = _criticalQuantity,
                        Total = _rowTotal
                    };
                    list.Add(inventory);

                }
                rs.Name = "DataSet_InventoryReport";
                rs.Value = list;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rs);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSIT314_project.inventoryReport.rdlc";
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

            this.reportViewer1.RefreshReport();
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

        public void setSearchInput(string searchInput)
        {
            this.searchInput = searchInput;
        }

        public void setUserID(string userID)
        {
            this.userID = userID;
        }

        private void goBackButton_Click(object sender, EventArgs e)
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
    }
}
