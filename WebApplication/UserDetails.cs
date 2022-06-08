using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisej.Web;
using System.Data.SqlClient;

namespace LogINForm
{
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
        }
        //Creating connection with database
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dipendra\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        //Creating a method to display data into datagridview
        private void PopulateData()
        {
            Conn.Open();
            string query = "SELECT * FROM Employee";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            employeeDataGridView.DataSource = data.Tables[0];
            Conn.Close();
        }
        private void UserDetails_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Clear()
        {
            employeeIDTextBox.Clear();
            employeeNameTextBox.Clear();
            addressTextBox.Clear();
            salaryTextBox.Clear();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            try {

                Conn.Open();
                string queryOne = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = "+employeeIDTextBox.Text+" ";
                SqlCommand command = new SqlCommand(queryOne, Conn);
                command.ExecuteNonQuery();
                int rows = (int)command.ExecuteScalar();
                Conn.Close();
                if (employeeIDTextBox.Text == "" || employeeNameTextBox.Text == "" || addressTextBox.Text == "" || salaryTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the input field!!", "Manage Employee");
                }
                else if (rows == 1)
                {
                    MessageBox.Show("Employee ID already exists", "Manage Employee");
                }
                else
                {
                    Conn.Open();
                    string query = "INSERT INTO Employee VALUES(" + int.Parse(employeeIDTextBox.Text) + ",'" + employeeNameTextBox.Text + "','" + addressTextBox.Text + "'," + int.Parse(salaryTextBox.Text) + ")";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    PopulateData();
                    MessageBox.Show("Data has been successfully added!!", "Manage Employee");
                    Clear();
                }
                }
            catch
            {
                MessageBox.Show("Please fill appropriate value!!", "Manage Employee");
            }

            Conn.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeIDTextBox.Text == "")
                {
                    MessageBox.Show("Please enter employee ID!!", "Manage Employee");
                }
                else
                {
                    Conn.Open();
                    string query = "DELETE FROM Employee WHERE EmployeeID = "+employeeIDTextBox.Text+"";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data deleted successfully", "Manage Employee");
                    Clear();
                    Conn.Close();
                    PopulateData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeIDTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                employeeNameTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                addressTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                salaryTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select rows!!!", "Manage Employee");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeIDTextBox.Text == "" || employeeNameTextBox.Text == "" || addressTextBox.Text == "" || salaryTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the input field", "Manage Employee");
                }
                else
                {
                    Conn.Open();
                    string query = "UPDATE Employee SET Name = '"+employeeNameTextBox.Text+"', Address = '"+addressTextBox.Text+"', Salary = "+salaryTextBox.Text+" WHERE EmployeeID = "+employeeIDTextBox.Text+" ";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully updated", "Manage Employee");
                    Clear();
                    Conn.Close();
                    PopulateData();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
