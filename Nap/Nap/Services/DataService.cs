using Nap.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Nap.Services
{
    public static class DataService
    {
        private static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
            {
                return;
            }
            var dbPath = Path.Combine(FileSystem.AppDataDirectory ,"NapAppData.db");
            db = new SQLiteAsyncConnection(dbPath);

            await db.CreateTableAsync<Data>();
        }
        public static async Task AddData(string info, string desc)
        {
            await Init();
            var data = new Data
            {
                Info = info,
                Desc = desc
            };

            await db.InsertAsync(data);
        }
        public static async Task RemoveData(int key)
        {
            await Init();

            await db.DeleteAsync<Data>(key);
        }
        public static async Task<IEnumerable<Data>> GetData()
        {
            await Init();
            return await db.Table<Data>().ToListAsync();
        }
    }
}
