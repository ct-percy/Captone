using IMSLocal.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMSLocal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static async void loadData()
        {
            await Connection.Init();
            BindingList<Employees> employees;
            employees = new BindingList<Employees>(await Employees.getEmployees());
            if (employees.Count() == 0)
            {
                await Employees.addEmployee(0, "Admin", "Admin", "Admin", "Admin", "Admin", "Admin");
            }
            else
            {
                for (int i = 0; i < employees.Count(); i++)
                {
                    if (employees.ElementAt(i).type != "Admin")
                    {
                        await Employees.addEmployee(0, "Admin", "Admin", "Admin", "Admin", "Admin", "Admin");
                    }
                }
            }
        }
        static void Main()
        {
        
              loadData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Log_In());



            



        }
    }
}
