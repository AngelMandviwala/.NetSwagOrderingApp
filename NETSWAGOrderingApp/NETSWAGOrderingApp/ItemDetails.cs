using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NETSWAGOrderingApp
{
    public class ItemDetails : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Color { get; set; }

        public string ImagePath { get; set; }

        public int Price { get; set; }


        private int _quantity = 1;

        public int Quantity
        {
            get
            { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }

        }

        public int OrderPlacementId { get; set; }


        public int ItemId { get; set; }

        public DateTime OrderDate { get; set; }

        public string FormattedOrderDate 
        { 
            get
            {
                return OrderDate.ToString();
            } 
        }

        public string FormattedPrice 
        {
            get
            {
                return $"R {Price.ToString()}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

    

}
