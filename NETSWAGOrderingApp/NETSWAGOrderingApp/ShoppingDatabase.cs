using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETSWAGOrderingApp
{
    public class ShoppingDatabase
    {
        private SQLiteConnection _database;

        public static ShoppingDatabase Instance = new ShoppingDatabase();

        public ShoppingDatabase()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = path + "shopping.db";

            _database = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            _database.CreateTable<ItemDetails>();
        }
        public List<ItemDetails> GetShopping()
        {
            return _database.Table<ItemDetails>().OrderByDescending(x => x.OrderDate).ToList();
        }

        public void SaveShopping(ItemDetails item)
        {
            _database.Insert(item);
        }
    }
}
