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
    public partial class lockedAccountForm : Form
    {
        public lockedAccountForm()
        {
            InitializeComponent();
        }

        private void lockedAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            loginForm login_form = new loginForm();
            this.Hide();
            login_form.ShowDialog();
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (oicIDInput.Text == null || oicIDInput.Text == "")
            {
                MessageBox.Show("You have to input ID!", "Error Message");
            }
            else
            {
                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "UPDATE users SET requestUnlock = 1 WHERE userID = @userID AND userStatus = 'Locked' AND userType = 'OIC' AND requestUnlock = 0";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@userID", this.oicIDInput.Text);

                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Successfully requested!", "Request to unlock the account");
                    loginForm login_form = new loginForm();
                    this.Hide();
                    login_form.ShowDialog();
                    MyConn.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public int unlockAccount(string userID, bool requestUnlock, string userStatus)
        {
            if(requestUnlock == true && userStatus == "Locked")
            {
                requestUnlock = false;
                userStatus = "Available";
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
