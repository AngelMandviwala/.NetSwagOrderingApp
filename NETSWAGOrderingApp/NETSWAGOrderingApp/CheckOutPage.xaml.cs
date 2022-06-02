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
    public partial class CheckOutPage : ContentPage
    {
        public CheckOutPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new OrderPlacement();
        }
        private async void OrderPlaced_Clicked(object sender, EventArgs e)
        {
            var item = BindingContext as OrderPlacement;

            var db = ShoppingDatabase.Instance;

            db.SaveOrder(item);

            var bagItems = db.GetShopping();

            foreach(var bagItem in bagItems)
            {
                bagItem.OrderPlacementId = item.Id;

                db.UpdateShopping(bagItem);

            }


            await Navigation.PushAsync(new OrderPlaced(item.Id));
        }
    }
}