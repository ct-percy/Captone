using IMSLocal.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IMSLocal
{
    public partial class Admin : Form
    {

        BindingList<Employees> employees;

        public async void loadData()
        {
            employees = new BindingList<Employees>(await Employees.getEmployees());
            employeesDGV.DataSource = employees;
        }
        public Admin()
        {
            InitializeComponent();
            saveButton.Enabled = false;
            newUserButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            searchButton.Enabled = false;


        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void userRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void adminRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void saveButton_Click(object sender, EventArgs e)
        {

            string user = adminUsername.Text;


            if (string.IsNullOrWhiteSpace(employeeIDTextbox.Text) || (string.IsNullOrWhiteSpace(firstNameTextbox.Text) || (string.IsNullOrWhiteSpace(lastNameTextbox.Text) ||
                string.IsNullOrWhiteSpace(usernameTextbox.Text) || string.IsNullOrWhiteSpace(passwordTextbox.Text) || (adminRB.Checked == false && userRB.Checked == false))))
            {
                MessageBox.Show("All fields are required");
                return;
            }




            try
            {
                int oldId = int.Parse(employeesDGV.SelectedCells[0].Value.ToString());
                string oldUser = employeesDGV.SelectedCells[3].Value.ToString();

                for (int i = 0; i < employees.Count(); i++)
                {

                    if (usernameTextbox.Text == employees[i].userName.ToString() && usernameTextbox.Text != oldUser)
                    {
                        MessageBox.Show("There is already an active employee with this username");
                        return;
                    }
                }


                if (adminRB.Checked == true)
                {
                    await Employees.updateEmployee(int.Parse(employeeIDTextbox.Text), firstNameTextbox.Text, lastNameTextbox.Text, usernameTextbox.Text, passwordTextbox.Text, "Admin", oldId, user);

                }
                else if (userRB.Checked == true)
                {
                    await Employees.updateEmployee(int.Parse(employeeIDTextbox.Text), firstNameTextbox.Text, lastNameTextbox.Text, usernameTextbox.Text, passwordTextbox.Text, "User", oldId, user);

                }
            }
            catch
            {


                for (int i = 0; i < employees.Count(); i++)
                {
                    if (employeeIDTextbox.Text == employees[i].employeeID.ToString())
                    {
                        MessageBox.Show("There is already an active employee with this employee ID");
                        return;
                    }
                    if (usernameTextbox.Text == employees[i].userName.ToString())
                    {
                        MessageBox.Show("There is already an active employee with this username");
                        return;
                    }
                }


                if (adminRB.Checked == true)
                {
                    await Employees.addEmployee(int.Parse(employeeIDTextbox.Text), firstNameTextbox.Text, lastNameTextbox.Text, usernameTextbox.Text, passwordTextbox.Text, "Admin", user);

                }
                else if (userRB.Checked == true)
                {
                    await Employees.addEmployee(int.Parse(employeeIDTextbox.Text), firstNameTextbox.Text, lastNameTextbox.Text, usernameTextbox.Text, passwordTextbox.Text, "User", user);

                }
            }

            MessageBox.Show("Employee Record Updated");
            this.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            employeesDGV.ClearSelection();
            employeesDGV.DefaultCellStyle.SelectionBackColor = Color.Blue;
            bool found = false;
            if (searchTextbox.Text != "")
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].firstName.Contains(searchTextbox.Text) || employees[i].lastName.Contains(searchTextbox.Text))
                    {
                        employeesDGV.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            else
            {
                return;
            }

            if (!found) { MessageBox.Show("Employee Not Found"); return; }

        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                    int employeeId = int.Parse(employeesDGV.SelectedCells[0].Value.ToString());
                    await Employees.deleteEmployee(employeeId);


                    loadData();
                
            }
            catch
            {
           
                MessageBox.Show("No Employee Selected");
                return;
            }
        }

        private void adminUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private  async void logInButton_Click(object sender, EventArgs e)
        {

            employees = new BindingList<Employees>(await Employees.getEmployees());

            for (int i = 0; i < employees.Count; i++)
            {
                if (adminUsername.Text == employees[i].userName && adminPassword.Text == employees[i].password && employees[i].type == "Admin")
                {
                    loadData();
                    saveButton.Enabled = true;
                    newUserButton.Enabled = true;
                    editButton.Enabled = true;
                    deleteButton.Enabled = true;
                    searchButton.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Only an Administrator can access this form");
                    employeesDGV.DataSource = null;
                    saveButton.Enabled = false;
                    newUserButton.Enabled = false;
                    editButton.Enabled = false;
                    deleteButton.Enabled = false;
                    searchButton.Enabled = false;
                    return;
                }

            }
           
        }

        private void employeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

       

        private void editButton_Click(object sender, EventArgs e)
        {
            try 
            {
                employeeIDTextbox.Text = employeesDGV.SelectedCells[0].Value.ToString();
                employeeIDTextbox.Enabled = false;
                firstNameTextbox.Text = employeesDGV.SelectedCells[1].Value.ToString();
                lastNameTextbox.Text = employeesDGV.SelectedCells[2].Value.ToString();
                usernameTextbox.Text = employeesDGV.SelectedCells[3].Value.ToString();
                passwordTextbox.Text = employeesDGV.SelectedCells[4].Value.ToString();
                if (employeesDGV.SelectedCells[5].Value.ToString() == "Admin")
                {
                    adminRB.Checked = true;
                }
                else
                {
                    userRB.Checked = true;
                }

            }
            catch
            {
                MessageBox.Show("Select an employee to edit");
                return;
            }

            
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            employeesDGV.ClearSelection();
            employeeIDTextbox.Enabled = true;
            employeeIDTextbox.Clear();
            firstNameTextbox.Clear();
            lastNameTextbox.Clear();
            usernameTextbox.Clear();
            passwordTextbox.Clear();
            adminRB.Checked = false;
            userRB.Checked = false;


        }
    }
}
