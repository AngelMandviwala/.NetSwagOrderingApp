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
            _database.CreateTable<OrderPlacement>();


        }
        public List<ItemDetails> GetShopping()
        {
            return _database.Table<ItemDetails>().OrderByDescending(x => x.OrderDate).ToList();
        }

        public List<ItemDetails> GetShoppingByOrderPlacement(int orderPlacementId)
        {
            return _database.Table<ItemDetails>().Where(x => x.OrderPlacementId == orderPlacementId).ToList();
        }


        public void SaveShopping(ItemDetails item)
        {
            _database.Insert(item);
        }

        public void UpdateShopping(ItemDetails item)
        {
            _database.Update(item);
        }


        public void SaveOrder(OrderPlacement order)
        {
            _database.Insert(order);
        }

        public OrderPlacement GetOrderPlacement()
        {
            return _database.Table<OrderPlacement>().FirstOrDefault();
        }


        public OrderPlacement GetOrderPlacementById(int id)
        {
            return _database.Table<OrderPlacement>().Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
