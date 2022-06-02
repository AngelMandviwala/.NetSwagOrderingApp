using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NETSWAGOrderingApp
{
    public class OrderPlacement : INotifyPropertyChanged
    { 
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; }

        public string FormattedOrderDate
        {
            get
            {
                return OrderDate.ToString();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
