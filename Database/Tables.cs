using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLocal.Database
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


        #region Methods and Queries
        public static async Task addEmployee(int employeeId, string firstName, string lastName, string username, string password, string type, string user)
        {
          
            var employee = new Employees()
            {
                employeeID = employeeId,
                firstName = firstName,
                lastName = lastName,
                userName = username,
                password = password,
                type = type,
                createdBy = user,
                createdOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),
                updatedBy = user,
                updatedOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),


            };

            await Connection._db.InsertAsync(employee);

        }

        public static async Task<IList<Employees>> getEmployees()
        {
  

            var employees = await Connection._db.QueryAsync<Employees>("SELECT * FROM Employees");

            return employees;


        }

        public static async Task updateEmployee(int employeeId, string firstName, string lastName, string username, string password, string type, int oldId, string user)
        {
            await Connection._db.QueryAsync<Employees>("UPDATE Employees SET employeeID = '" + employeeId + "', firstName = '" + firstName + "', lastName ='" + lastName + "', userName = '" + username + "', password = '" + password + "', type ='" + type + "', updatedBy ='" + user + "', updatedOn ='" + DateTime.Now.ToUniversalTime().ToLocalTime().ToString() + "' WHERE employeeID =" + oldId);
        }

        public static async Task deleteEmployee(int employeeId)
        {
            await Connection._db.QueryAsync<Employees>("DELETE FROM Employees WHERE employeeID =" + employeeId);
        }


        #endregion

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


        #region Methods and Queries
        public static async Task addPart(int partID, string name, decimal price, int stock, int max, int min, string type, string companyName, Nullable<int> machineId, string user)
        {

            var part = new Parts
            {
                PartID = partID,
                Name = name,
                Price = price,
                Stock = stock,
                Max = max,
                Min = min,
                Type = type,
                createdBy = user,
                createdOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),
                updatedBy = user,
                updatedOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),
            };
            await Connection._db.InsertAsync(part);

            if (companyName == null)
            {
                await Inhouses.addInhouse(partID, name, price, stock, max, min, machineId, user);
            }
            else if (machineId == null)
            {

                await Outsource.addOutsource(partID, name, price, stock, max, min, companyName, user);
            }

        }

        public static async Task updatePart(int partID, string name, decimal price, int stock, int max, int min, string type, string user)
        {
            await Connection._db.QueryAsync<Parts>("UPDATE Parts SET Name ='" + name + "', Price = '" + price + "', Stock = '" + stock + "', Max = '" + max + "', Min = '" + min + "', Type = '" + type + "', updatedBy ='" + user + "', updatedOn ='" + DateTime.Now.ToUniversalTime().ToLocalTime().ToString() + "' WHERE PartID = " + partID);
        }

        public static async Task deletePart(int partId)
        {
            await Connection._db.QueryAsync<Parts>("DELETE FROM Parts WHERE PartID =" + partId);
        }
        public static async Task<IList<Parts>> getAllParts()
        {

 
            var allParts = await Connection._db.QueryAsync<Parts>("SELECT * FROM Parts;");

            return allParts;
        }


        #endregion


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


        #region Method and Queries

        public static async Task addProduct(int productId, string name, decimal price, int stock, int max, int min, string user)
        {

            var product = new Products
            {
                ProductID = productId,
                Name = name,
                Price = price,
                Stock = stock,
                Max = max,
                Min = min,
                createdBy = user,
                createdOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),
                updatedBy = user,
                updatedOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),

            };

            await Connection._db.InsertAsync(product);
        }

        public static async Task updateProduct(int productId, string name, decimal price, int stock, int max, int min, string user)
        {

            await Connection._db.QueryAsync<Products>("UPDATE Products SET Name ='" + name + "', Price ='" + price + "', Stock = '" + stock + "', Max = '" + max + "', Min = '" + min + "', updatedBy = '" + user + "', updatedOn = '" + DateTime.Now.ToUniversalTime().ToLocalTime().ToString() + "' WHERE ProductID =" + productId);


        }
        public static async Task deleteProduct(int productId)
        {
            await Connection._db.QueryAsync<Products>("DELETE FROM Products WHERE ProductID =" + productId);
        }

        public static async Task<IList<Products>> getAllProducts()
        {

            var allProducts = await Connection._db.QueryAsync<Products>("SELECT * FROM Products;");

            return allProducts;
        }
        public static async Task<Products> getProduct(int productId)
        {


            var product = await Connection._db.QueryAsync<Products>("SELECT * FROM Products WHERE ProductID =" + productId);

            return product.ElementAtOrDefault(0) as Products;

        }

      

        #endregion


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


        #region Methods and Queries

        public static async Task addAssociatedPart(int productID, int partID, string partName, decimal price, int stock, int max, int min)
        {

            var associatedPart = new AssociatedParts
            {
                ProductID = productID,
                PartID = partID,
                Name = partName,
                Price = price,
                Stock = stock,
                Max = max,
                Min = min,

            };

            await Connection._db.InsertAsync(associatedPart);

        }
        public static async Task deleteAssociatedParts(int productId)
        {
            await Connection._db.QueryAsync<AssociatedParts>("DELETE FROM AssociatedParts WHERE ProductID =" + productId);
        }


        public static async Task<IList<AssociatedParts>> getAssociatedParts(int productId)
        {
            var associatedParts = await Connection._db.QueryAsync<AssociatedParts>("SELECT * FROM AssociatedParts WHERE ProductID =" + productId);

            return associatedParts;
        }

        public static async Task updateAssociatedParts(int partId, string name, decimal price, int stock, int max, int min)
        {
            await Connection._db.QueryAsync<AssociatedParts>("UPDATE AssociatedParts SET Name = '" + name + "', Price = '" + price + "', Stock = '" + stock + "', Max = '" + max + "', Min = '" + min + "' WHERE PartID = " + partId);
        }

        public static async Task<IList<AssociatedParts>> getAssociatedProduct(int partId)
        {
            var associatedProduct = await Connection._db.QueryAsync<AssociatedParts>("SELECT * FROM AssociatedParts WHERE PartID =" + partId);

            return associatedProduct;
        }

        public static async Task<IList<AssociatedParts>> getAllAssociatedParts()
        {

            await Connection.Init();

            var allParts = await Connection._db.QueryAsync<AssociatedParts>("SELECT * FROM AssociatedParts;");

            return allParts;
        }

        #endregion
    }

    public class Inhouses : Parts
    {
        public int machineID { get; set; }

        #region Methods and Queries

        public static async Task addInhouse(int partID, string name, decimal price, int stock, int max, int min, Nullable<int> machineId, string user)
        {
            var inHouse = new Inhouses
            {
                PartID = partID,
                Name = name,
                Price = price,
                Stock = stock,
                Max = max,
                Min = min,
                machineID = (int)machineId,
                createdBy = user,
                createdOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),
                updatedBy = user,
                updatedOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),
            };

            await Connection._db.InsertAsync(inHouse);
        }

        public static async Task updateInhouse(int partID, string name, decimal price, int stock, int max, int min, int machineId, string user)
        {
            await Connection._db.QueryAsync<Inhouses>("UPDATE Inhouses SET Name ='" + name + "', Price = '" + price + "', Stock = '" + stock + "', Max = '" + max + "', Min = '" + min + "', machineID = '" + machineId + "', updatedBy = '" + user + "', updatedOn = '" + DateTime.Now.ToUniversalTime().ToLocalTime().ToString() + "'WHERE PartID = " + partID);
        }

        public static async Task deleteInhouse(int partId)
        {
            await Connection._db.QueryAsync<Inhouses>("DELETE FROM Inhouses WHERE PartID =" + partId);
        }
        public static async Task<IList<Inhouses>> getInhouse(int partId)
        {

            await Connection.Init();


            var part = await Connection._db.QueryAsync<Inhouses>("SELECT * FROM Inhouses WHERE PartID =" + partId);

            return part;

        }

        public static async Task<IList<Inhouses>> getAllInhouse()
        {
            var allParts = await Connection._db.QueryAsync<Inhouses>("SELECT * FROM Inhouses;");

            return allParts;

        }

        #endregion

    }

    public class Outsource : Parts
    {
        public string companyName { get; set; }

        #region Methods and Queries 
        public static async Task addOutsource(int partID, string name, decimal price, int stock, int max, int min, string companyName, string user)
        {
            var outsource = new Outsource
            {
                PartID = partID,
                Name = name,
                Price = price,
                Stock = stock,
                Max = max,
                Min = min,
                companyName = companyName,
                createdBy = user,
                createdOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),
                updatedBy = user,
                updatedOn = DateTime.Now.ToUniversalTime().ToLocalTime().ToString(),
            };

            await Connection._db.InsertAsync(outsource);
        }



        public static async Task updateOutsource(int partID, string name, decimal price, int stock, int max, int min, string companyName, string user)
        {
            await Connection._db.QueryAsync<Outsource>("UPDATE Outsource SET Name ='" + name + "', Price = '" + price + "', Stock = '" + stock + "', Max = '" + max + "', Min = '" + min + "', companyName = '" + companyName + "', updatedBy = '" + user + "', updatedOn = '" + DateTime.Now.ToUniversalTime().ToLocalTime().ToString() + "'WHERE PartID = " + partID);
        }


        public static async Task deleteOutsource(int partId)
        {
            await Connection._db.QueryAsync<Outsource>("DELETE FROM Outsource WHERE PartID =" + partId);
        }

        public static async Task<IList<Outsource>> getOutsource(int partId)
        {

            var part = await Connection._db.QueryAsync<Outsource>("SELECT * FROM Outsource WHERE PartID =" + partId);

            return part;

        }

        public static async Task<IList<Outsource>> getAllOutsource()
        {
            var allParts = await Connection._db.QueryAsync<Outsource>("SELECT * FROM Outsource;");

            return allParts;

        }
        #endregion

    }

}
