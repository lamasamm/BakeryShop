﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myBakeryShop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


          
        }

        async void Button_Clicked(object sender, EventArgs e)
        {

            await DisplayAlert("Succsefully Logged", "Enjoy shopping dear "+username.Text , "Ok");

            await Navigation.PushAsync(new DisplayItem());
        }
    }
}
