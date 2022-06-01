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
    public partial class FemaleClothing : ContentPage
    {
        public List<ItemDetails> Items { get; set; }

        public FemaleClothing()
        {
            InitializeComponent();

            Items = new List<ItemDetails>
            {
                new ItemDetails
                {
                    Description = "T-Shirt",
                    Price = 250,
                    ImagePath = "tshirt1.jpg",  
                    ItemId = 549678,
                },

                new ItemDetails
                {
                    Description = "T-Shirt",
                    Price = 350,
                    ImagePath = "tshirt2.jpg",
                    ItemId = 521547,

                },

                new ItemDetails
                {
                    Description = "T-Shirt",
                    Price = 250,
                    ImagePath = "tshirt3.jpg",
                    ItemId= 531657
                },

                new ItemDetails
                {
                    Description = "T-Shirt",
                    Price = 250,
                    ImagePath = "tshirt4.jpg",
                    ItemId = 547961,
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