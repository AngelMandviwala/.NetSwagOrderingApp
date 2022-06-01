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

        private void AddBagButton_Clicked(object sender, EventArgs e)
        {

            var db = ShoppingDatabase.Instance;

            db.SaveShopping(Item);

        }
    }
}