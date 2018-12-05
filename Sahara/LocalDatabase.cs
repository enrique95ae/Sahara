using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;

namespace Sahara
{
    public class LocalDatabase
    {
        readonly SQLiteAsyncConnection database;

        public LocalDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<BillingModel>().Wait();
            database.CreateTableAsync<PersonalInfo>().Wait();
        }

        public Task<List<PersonalInfo>>ClearInfo()
        {
            return database.QueryAsync<PersonalInfo>("DELETE FROM [PersonalInfo]");
        }

        public Task<int> SaveBillingAsync(BillingModel bill)
        {
            return database.InsertAsync(bill);
        }

        public Task<int> SavePersonalAsync(PersonalInfo info)
        {
            return database.InsertAsync(info);
        }

        public Task<List<BillingModel>> GetBilling()
        {
            return database.QueryAsync<BillingModel>("SELECT * FROM [BillingModel]"); //never used, was for initial testing
        }

        public Task<List<PersonalInfo>> GetInfo()
        {
            return database.QueryAsync<PersonalInfo>("SELECT * FROM [PersonalInfo]"); //never used, was for initial testing
        }

    }
}
