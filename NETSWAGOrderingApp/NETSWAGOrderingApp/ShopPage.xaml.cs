﻿using System;
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


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabPage());
        }
    }
}