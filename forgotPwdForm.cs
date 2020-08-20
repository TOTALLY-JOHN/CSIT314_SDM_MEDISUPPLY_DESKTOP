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
    public partial class forgotPwdForm : Form
    {
        public forgotPwdForm()
        {
            InitializeComponent();
        }

        private void forgotPwdForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM personal_questions";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);

                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();

                while (MyReader.Read())
                {
                    string question = MyReader.GetString("questionContent");
                    personalQuestionComboBox.Items.Add(question);
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (userIdInput.Text == null || userIdInput.Text == "" ||
                personalQuestionComboBox.SelectedIndex == -1 ||
                personalAnswerInput.Text == null || personalAnswerInput.Text == "")
            {
                MessageBox.Show("No Record to Update", "Records");
            }
            else
            {
                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "SELECT * FROM users WHERE userID = @userID AND personalQuestion = @personalQuestion AND personalAnswer = @personalAnswer";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@userID", this.userIdInput.Text);
                    cmd.Parameters.AddWithValue("@personalQuestion", personalQuestionComboBox.Items[personalQuestionComboBox.SelectedIndex].ToString());
                    cmd.Parameters.AddWithValue("@personalAnswer", this.personalAnswerInput.Text);
                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    if (MyReader.Read())
                    {
                        resetPwdForm reset_pwd_form = new resetPwdForm();
                        this.Hide();
                        reset_pwd_form.setOicId(this.userIdInput.Text);
                        reset_pwd_form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your input is not correct!", "Forgot Password Validation");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
