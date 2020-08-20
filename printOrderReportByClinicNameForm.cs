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
    public partial class printOrderReportByClinicNameForm : Form
    {
        Timer t = new Timer();
        string user;
        ReportDataSource rs = new ReportDataSource();
        string searchInput;
        string userID;

        public printOrderReportByClinicNameForm()
        {
            InitializeComponent();
        }

        private void printOrderReportByClinicNameForm_Load(object sender, EventArgs e)
        {
            List<Orders> list = new List<Orders>();
            list.Clear();

            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT orderID, orders.clinicName, clinic.clinicAddress, itemType, orders.itemQuantity, orderDate, itemSellingPrice FROM orders JOIN clinic ON orders.clinicName = clinic.clinicName JOIN inventory ON orders.itemType = inventory.itemName WHERE orders.clinicName = @clinicName";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                cmd.Parameters.AddWithValue("@clinicName", searchInput);
                MyConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                decimal _totalPrice = 0;
                while (reader.Read())
                {
                    string _orderID = reader.GetString("orderID");
                    string _clinicName = reader.GetString("clinicName");
                    string _clinicAddress = reader.GetString("clinicAddress");
                    string _itemType = reader.GetString("itemType");
                    int _itemQuantity = reader.GetInt32("itemQuantity");
                    string _orderDate = reader.GetString("orderDate").Substring(0, 10);
                    decimal _itemSellingPrice = reader.GetDecimal("itemSellingPrice");
                    decimal _rowTotal = _itemQuantity * _itemSellingPrice;
                    _totalPrice += _rowTotal;

                    Orders order = new Orders
                    {
                        OrderID = _orderID,
                        ClinicName = _clinicName,
                        ClinicAddress = _clinicAddress,
                        ItemName = _itemType,
                        ItemQuantity = _itemQuantity,
                        OrderDate = _orderDate,
                        ItemPrice = _itemSellingPrice,
                        Total = _rowTotal
                    };
                    list.Add(order);

                }
                rs.Name = "DataSet_OrderReportByMonth";
                rs.Value = list;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rs);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSIT314_project.orderReport.rdlc";
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
            printOrderReportForm print_order_report_form = new printOrderReportForm();
            this.Hide();
            print_order_report_form.setCurrentUser(user);
            print_order_report_form.setUserID(userID);
            print_order_report_form.ShowDialog();
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
