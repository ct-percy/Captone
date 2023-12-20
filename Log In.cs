using C968_PA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_PA
{
    public partial class Log_In : Form
    {
        BindingList<Employees> employees;
        private async void loadData()
        {
            await Connection.Init();

           employees  = new BindingList<Employees>(await Query.getEmployees());

            if(employees.Count() == 0)
            {
                await Query.addEmployee(0, "Admin", "Admin", "Admin", "Admin", "Admin", "Admin");
            }

        }

        public Log_In()
        {
            InitializeComponent();
            exitButton.Hide();
           loadData();

        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private  void logInButton_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < employees.Count(); i++)
            {
                if (userNameTextbox.Text == employees[i].userName && passwordTextbox.Text == employees[i].password)
                {
                    MainScreen ms = new MainScreen(employees[i].userName);
                    ms.Show();
                    logInButton.Hide();
                    adminButton.Hide();
                    userNameTextbox.Hide();
                    passwordTextbox.Hide();
                    exitButton.Show();
                    label1.Visible = false;
                    label2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Username and Password did not match");
                    return;
                }
            }
            
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}
