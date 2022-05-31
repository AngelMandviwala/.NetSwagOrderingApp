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
    public partial class Shop : ContentPage
    {
       

        public Shop()
        {
            InitializeComponent();

          
        }


        private async void Female_Clothing(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FemaleClothing());
        }

        private async void Male_Clothing(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaleClothing());
        }
    }
}