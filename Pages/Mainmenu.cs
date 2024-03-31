using gym_assignment.Models;
using gym_assignment.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_assignment.Pages
{
    public partial class roleSelect : Form
    {

        bool sideBarExpand = true;
        public roleSelect(User userInfo)
        {
            InitializeComponent();
            logged.Text = userInfo.name;
            loggedName.Text = userInfo.type;

        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(roleSelect));
            sideBar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            Home = new Button();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            sideBarTimer = new Timer(components);
            userTable = new DataGridView();
            users = new Label();
            logged = new Label();
            loggedName = new Label();
            insertUserButton = new Button();
            updateUserBtn = new Button();
            deleteUserBtn = new Button();
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            userName = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            sideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((ISupportInitialize)userTable).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(35, 40, 45);
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel3);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel5);
            sideBar.Controls.Add(panel6);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.MaximumSize = new Size(218, 566);
            sideBar.MinimumSize = new Size(79, 566);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(218, 566);
            sideBar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 88);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(27, 22);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(24, 24);
            menuButton.SizeMode = PictureBoxSizeMode.AutoSize;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Home);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 60);
            panel2.TabIndex = 1;
            // 
            // Home
            // 
            Home.BackColor = Color.FromArgb(35, 40, 45);
            Home.ForeColor = Color.White;
            Home.Image = (Image)resources.GetObject("Home.Image");
            Home.ImageAlign = ContentAlignment.MiddleLeft;
            Home.Location = new Point(-11, -10);
            Home.Name = "Home";
            Home.Padding = new Padding(30, 0, 0, 0);
            Home.Size = new Size(245, 79);
            Home.TabIndex = 2;
            Home.Text = "Gym Classes";
            Home.UseVisualStyleBackColor = false;
            Home.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 40, 45);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 163);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(231, 79);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(176, 64);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 40, 45);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-8, -11);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(220, 85);
            button2.TabIndex = 4;
            button2.Text = "Members";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 233);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 59);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 40, 45);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-8, -10);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(184, 78);
            button3.TabIndex = 5;
            button3.Text = "Users";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 298);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 64);
            panel5.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 40, 45);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-8, -13);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(203, 92);
            button4.TabIndex = 6;
            button4.Text = "Trainers";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 368);
            panel6.Name = "panel6";
            panel6.Size = new Size(182, 61);
            panel6.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(35, 40, 45);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-11, -23);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 0);
            button5.Size = new Size(223, 92);
            button5.TabIndex = 7;
            button5.Text = "Admins";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // userTable
            // 
            userTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Location = new Point(243, 72);
            userTable.Name = "userTable";
            userTable.RowHeadersWidth = 51;
            userTable.Size = new Size(731, 188);
            userTable.TabIndex = 1;
            userTable.CellClick += userCellClick;
            // 
            // users
            // 
            users.AutoSize = true;
            users.Font = new Font("Segoe UI", 20F);
            users.Location = new Point(243, 9);
            users.Name = "users";
            users.Size = new Size(101, 46);
            users.TabIndex = 2;
            users.Text = "Users";
            // 
            // logged
            // 
            logged.AutoSize = true;
            logged.Location = new Point(912, 25);
            logged.Name = "logged";
            logged.Size = new Size(0, 20);
            logged.TabIndex = 3;
            // 
            // loggedName
            // 
            loggedName.AutoSize = true;
            loggedName.Location = new Point(784, 25);
            loggedName.Name = "loggedName";
            loggedName.Size = new Size(0, 20);
            loggedName.TabIndex = 4;
            // 
            // insertUserButton
            // 
            insertUserButton.BackColor = Color.FromArgb(64, 64, 64);
            insertUserButton.FlatStyle = FlatStyle.Flat;
            insertUserButton.ForeColor = Color.White;
            insertUserButton.Location = new Point(849, 298);
            insertUserButton.Name = "insertUserButton";
            insertUserButton.Size = new Size(125, 41);
            insertUserButton.TabIndex = 5;
            insertUserButton.Text = "Insert";
            insertUserButton.UseVisualStyleBackColor = false;
            insertUserButton.Click += insertUserBtn;
            // 
            // updateUserBtn
            // 
            updateUserBtn.BackColor = Color.FromArgb(64, 64, 64);
            updateUserBtn.FlatStyle = FlatStyle.Flat;
            updateUserBtn.ForeColor = Color.White;
            updateUserBtn.Location = new Point(849, 345);
            updateUserBtn.Name = "updateUserBtn";
            updateUserBtn.Size = new Size(125, 41);
            updateUserBtn.TabIndex = 6;
            updateUserBtn.Text = "Update";
            updateUserBtn.UseVisualStyleBackColor = false;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.BackColor = Color.FromArgb(64, 64, 64);
            deleteUserBtn.FlatStyle = FlatStyle.Flat;
            deleteUserBtn.ForeColor = Color.White;
            deleteUserBtn.Location = new Point(849, 396);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(125, 41);
            deleteUserBtn.TabIndex = 7;
            deleteUserBtn.Text = "Delete";
            deleteUserBtn.UseVisualStyleBackColor = false;
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(255, 335);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(304, 27);
            userNameBox.TabIndex = 8;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(254, 415);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(304, 27);
            passwordBox.TabIndex = 9;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(255, 298);
            userName.Name = "userName";
            userName.Size = new Size(49, 20);
            userName.TabIndex = 10;
            userName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 381);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ADMIN", "USER" });
            comboBox1.Location = new Point(255, 491);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 455);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 13;
            label3.Text = "Role";
            label3.Click += label3_Click;
            // 
            // roleSelect
            // 
            ClientSize = new Size(999, 566);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(userName);
            Controls.Add(passwordBox);
            Controls.Add(userNameBox);
            Controls.Add(deleteUserBtn);
            Controls.Add(updateUserBtn);
            Controls.Add(insertUserButton);
            Controls.Add(loggedName);
            Controls.Add(logged);
            Controls.Add(users);
            Controls.Add(userTable);
            Controls.Add(sideBar);
            Name = "roleSelect";
            Text = "MainMenu";
            Load += Mainmenu_Load;
            sideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((ISupportInitialize)userTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(sideBarExpand);

            if (sideBarExpand)
            {
                sideBar.Width -= 60;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }

            }
            else
            {
                sideBar.Width += 60;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("clicked");
            sideBarTimer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private SqlConnection OpenConnection()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            return con;
        }
        public void Mainmenu_Load(object sender, EventArgs e)
        {
            string getAllUsersQuery = "SELECT Id, name, type FROM ACCOUNTS ORDER BY created_at DESC";
            using (SqlConnection con = OpenConnection())
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(getAllUsersQuery, con);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                userTable.DataSource = dt;
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void insertUserBtn(object sender, EventArgs e)
        {
            try
            {
                string name = userNameBox.Text;
                string password = passwordBox.Text;
                string type = comboBox1.Text;
                string hashedPass = SecurePasswordHasher.Hash(password);
                DateTime now = DateTime.Now;
                Debug.WriteLine(now);


                User newUser = new User(name, hashedPass, type);
                var validator = new UserValidator();
                var result = validator.Validate(newUser);

                if (!result.IsValid)
                {
                    foreach (var error in result.Errors)
                    {
                        MessageBox.Show(error.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {



                    string createUserQuery = "INSERT INTO Accounts (Id ,name, password, type, created_at) VALUES (@Id, @name, @hashedPassword, @type, @created_at)";
                    using (SqlConnection con = OpenConnection())
                    {
                        SqlCommand createUserCmd = new SqlCommand(createUserQuery, con);
                        createUserCmd.Parameters.AddWithValue("@Id", newUser.Id);
                        createUserCmd.Parameters.AddWithValue("@name", newUser.name);
                        createUserCmd.Parameters.AddWithValue("@hashedPassword", newUser.password);
                        createUserCmd.Parameters.AddWithValue("@type", newUser.type);
                        createUserCmd.Parameters.AddWithValue("@created_at", now);

                        int rowsAffected = createUserCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User created successfully!");
                            newUser.resetUserForm();
                            userNameBox.Text = null;
                            passwordBox.Text = null;
                            comboBox1.Text = null;
                            this.Mainmenu_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Failed to create user.");
                        }

                        con.Close();
                        // _ = rowsAffected > 0 ? MessageBox.Show("User created Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : MessageBox.Show("User created Fail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding a user: " + ex);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userCellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex != -1)
            {
                DataGridViewRow row = userTable.Rows[e.RowIndex];
                userNameBox.Text = row.Cells[1].Value.ToString();

            }
        }
    }
}
