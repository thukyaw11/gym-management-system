using System;
using System.Configuration;
using gym_assignment.Pages;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using gym_assignment.Utils;
using System.Diagnostics;
using gym_assignment.Models;
using System.Security.Policy;

namespace gym_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection OpenConnection()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            return con;
        }

     

        private User GetUserInfo(string userName)
        {
            string accountQuery = "SELECT password, type, name FROM Accounts WHERE name = @UserName";

            using (SqlConnection con = OpenConnection())
            {
                SqlCommand fetchUserInfoCommand = new SqlCommand(accountQuery, con);
                fetchUserInfoCommand.Parameters.AddWithValue("@UserName", userName);

                using (SqlDataReader reader = fetchUserInfoCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader.GetString(reader.GetOrdinal("name"));
                        string password = reader.GetString(reader.GetOrdinal("password"));
                        string type = reader.GetString(reader.GetOrdinal("type"));

                        User user = new User(name, password, type);

                        return user;
                    }
                }
            }

            return null;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = userNameBox.Text;
                string password = passwordBox.Text;

                Debug.WriteLine(SecurePasswordHasher.Hash(password));

                User userInfo = GetUserInfo(name);
              
                if (userInfo != null && SecurePasswordHasher.Verify(password, userInfo.password))
                {
                    string type = userInfo.type;
                    string displayName = userInfo.name;

                    MessageBox.Show($"Login Successful!\nType: {type}\nName: {displayName}");
                    roleSelect mainmenu = new roleSelect(userInfo);
                    mainmenu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
               

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }


}
