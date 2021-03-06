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
    public partial class Bag : ContentPage
    {
        public List<ItemDetails> BagItems { get; set; }

        public Bag()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var db = ShoppingDatabase.Instance;

            BagItems = db.GetShopping();

            BindingContext = this;
        }

        private async void CheckOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckOutPage());

        }
    }
}