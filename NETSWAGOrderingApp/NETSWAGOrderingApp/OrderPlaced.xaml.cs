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
    public partial class OrderPlaced : ContentPage
    {
        private int _placementId;

        public OrderPlaced(int placementId)
        {
            InitializeComponent();

            _placementId = placementId;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var db = ShoppingDatabase.Instance;

            var orderPlacement = db.GetOrderPlacementById(_placementId);

            BindingContext = orderPlacement;
        }
    }
}