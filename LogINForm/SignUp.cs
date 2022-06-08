using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LogINForm
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        //creating connection with the database
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dipendra\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ClearField()
        {
            signupEmailTextBox.Clear();
            signupPasswordTextBox.Clear();
            conPassTextBox.Clear();
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                string queryOne = "SELECT COUNT(*) FROM Register WHERE Email = '" +signupEmailTextBox.Text+ "' ";
                SqlCommand command = new SqlCommand(queryOne, Conn);
                command.ExecuteNonQuery();
                int rows = (int)command.ExecuteScalar();
                Conn.Close();
                if (rows == 1)
                {
                    MessageBox.Show("Already have account with this email!!", "Signup");
                }
                else if (signupEmailTextBox.Text == "" || signupPasswordTextBox.Text == "" || conPassTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the input field!!", "Signup");
                }
                else if (!(string.IsNullOrEmpty(signupEmailTextBox.Text)) && signupPasswordTextBox.Text == conPassTextBox.Text)
                {
                    Conn.Open();
                    var query = "INSERT INTO Register VALUES('" + signupEmailTextBox.Text + "', '" + signupPasswordTextBox.Text + "', '" + conPassTextBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your account has been created successfully!!", "Signup");
                    ClearField();
                    Conn.Close();
                }
                else if (signupPasswordTextBox.Text != conPassTextBox.Text)
                {
                    MessageBox.Show("Password is not matching!!", "Signup");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Conn.Close();
        }

        private void clearBtnRegister_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            Login loginObj = new Login();
            this.Hide();
            loginObj.Show();
        }
    }
}
