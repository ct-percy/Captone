using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSLocal.Database
{
    public static class Connection
    {
        public static SQLiteAsyncConnection _db;
        public static SQLiteConnection _dbconnection;



        //USE DATA TABLE TO LOAD DGV

        public static async Task Init()
        {
            if (_db != null)
            {
                return;
            }

            else
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "IMSdata.db");

                _db = new SQLiteAsyncConnection(databasePath);
                _dbconnection = new SQLiteConnection(databasePath);

                await _db.CreateTableAsync<Employees>();
                await _db.CreateTableAsync<Parts>();
                await _db.CreateTableAsync<Inhouses>();
                await _db.CreateTableAsync<Outsource>();
                await _db.CreateTableAsync<Products>();
                await _db.CreateTableAsync<AssociatedParts>();

            }
        }
    }
}
