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
    public partial class MaleClothing : ContentPage
    {
        public List<ItemDetails> Items { get; set; }
        public MaleClothing()
        {
            InitializeComponent();

            Items = new List<ItemDetails>
            {
                new ItemDetails
                {
                    Description = "T-Shirt",
                    Price = 250,
                    ImagePath = "maletshirt1.jpg",
                    ItemId = 512896,
                },

                new ItemDetails
                {
                    Description = "T-Shirt",
                    Price = 350,
                    ImagePath = "maletshirt2.jpg",
                    ItemId = 589745,
                },

                new ItemDetails
                {
                    Description = "T-Shirt",
                    Price = 250,
                    ImagePath = "maletshirt3.jpg",
                    ItemId= 548721,
                },

                new ItemDetails
                {
                    Description = "T-Shirt",
                    Price = 250,
                    ImagePath = "maletshirt4.jpg",
                    ItemId = 538962,
                },


            };

            BindingContext = this;
        }

        private async void FemaleClothing_Tapped(object sender, ItemTappedEventArgs e)
        {
            ItemDetails item = e.Item as ItemDetails;
            await Navigation.PushAsync(new AddToYourBag(item));
        }
    }
}