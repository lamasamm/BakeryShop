using myBakeryShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myBakeryShop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetails : ContentPage
	{
       
        

		public ItemDetails (String ItemName , String Image , String Calories , String Price, String Dicription)
		{
			InitializeComponent ();



            The_image.Source = Image;

            MyItemName.Text = ItemName;

            MyDiscription.Text = Dicription;

            MyCal.Text = Calories;

            MyPrice.Text = Price;


            
        }

        void Call_ICON_Clicked(object sender, EventArgs e)

        {

                PhoneDialer.Open("0506643422");
           


        }

        private async void MAP_ICON_Clicked(object sender, EventArgs e)
        {
            var location = new Location(21.62186560649057, 39.196021556854255);
            var options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };

            await Map.OpenAsync(location, options);


        }
    }
}