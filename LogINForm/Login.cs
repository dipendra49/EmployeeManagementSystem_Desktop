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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dipendra\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //creating a method to clear all the input field.
        public void Clear()
        {
            emailTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                string queryOne = "SELECT COUNT(*) FROM Register WHERE Email = '" + emailTextBox.Text + "' AND Password = '"+passwordTextBox.Text+"' ";
                SqlCommand command = new SqlCommand(queryOne, Conn);
                command.ExecuteNonQuery();
                int rows = (int)command.ExecuteScalar();
                Conn.Close();
                if (rows == 1)
                {
                    UserDetails userDetailsObj = new UserDetails();
                    this.Hide();
                    userDetailsObj.Show();
                }
                else if (emailTextBox.Text == "" || passwordTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the input field!!", "Signin");
                }
                else
                {
                    MessageBox.Show("Email or password is wrong!!", "Signin");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            SignUp signupObj = new SignUp();
            this.Hide();
            signupObj.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
