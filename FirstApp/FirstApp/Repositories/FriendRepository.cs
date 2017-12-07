using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Models;
using SQLite;
using Xamarin.Forms;
using FirstApp.Interfaces;

namespace FirstApp.Repositories
{
    public class FriendRepository
    {
        SQLiteConnection database;
        public FriendRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISqLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Friend>();
        }
        public IEnumerable<Friend> GetItems()
        {
            return (from i in database.Table<Friend>() select i).ToList();

        }
        public Friend GetItem(int id)
        {
            return database.Get<Friend>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Friend>(id);
        }
        public int SaveItem(Friend item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
