using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NETSWAGOrderingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddToYourBag : ContentPage
    {
        public ItemDetails Item { get; set; }

        public AddToYourBag(ItemDetails item)
        {
            InitializeComponent();

            Item = item;

            BindingContext = this;
        }

        private async void AddBagButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert","Your item has been added to your bag","ok");

            var db = ShoppingDatabase.Instance;

            Item.OrderDate = DateTime.Now;  

            db.SaveShopping(Item);

        }
    }
}