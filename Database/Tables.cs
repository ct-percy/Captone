using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PA.Database
{

    public class Employees
    {
        [PrimaryKey]
        public int employeeID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string type { get; set; }

        public string createdBy { get; set; }

        public string createdOn { get; set; }

        public string updatedBy { get; set; }

        public string updatedOn { get; set; }

    }
    public class Parts
    {
       
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Type { get; set; }

        public string createdBy { get; set; }

        public string createdOn { get; set; }

        public string updatedBy { get; set; }

        public string updatedOn { get; set; }

    }

    public class Products
    {
       
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public string createdBy { get; set; }

        public string createdOn { get; set; }

        public string updatedBy { get; set; }

        public string updatedOn { get; set; }

    }

    public class AssociatedParts
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public int ProductID { get; set; }
    }

        public class Inhouses : Parts
    {
        public int machineID { get; set; }

    }

    public class Outsource : Parts
    {
        public string companyName { get; set; }

    }

}
